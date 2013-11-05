using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Tamir.SharpSsh.jsch
{
	/// <summary>
	/// Summary description for Session.
	/// </summary>
	public class Session 
	{
		private const String version="sharpSsh-0.1.20-experimental";

		// http://ietf.org/internet-drafts/draft-ietf-secsh-assignednumbers-01.txt
		internal const int SSH_MSG_DISCONNECT=                      1;
		internal const int SSH_MSG_IGNORE=                          2;
		internal const int SSH_MSG_UNIMPLEMENTED=                   3;
		internal const int SSH_MSG_DEBUG=                           4;
		internal const int SSH_MSG_SERVICE_REQUEST=                 5;
		internal const int SSH_MSG_SERVICE_ACCEPT=                  6;
		internal const int SSH_MSG_KEXINIT=                        20;
		internal const int SSH_MSG_NEWKEYS=                        21;
		internal const int SSH_MSG_KEXDH_INIT=                     30;
		internal const int SSH_MSG_KEXDH_REPLY=                    31;
		internal const int SSH_MSG_USERAUTH_REQUEST=               50;
		internal const int SSH_MSG_USERAUTH_FAILURE=               51;
		internal const int SSH_MSG_USERAUTH_SUCCESS=               52;
		internal const int SSH_MSG_USERAUTH_BANNER=                53;
		internal const int SSH_MSG_USERAUTH_INFO_REQUEST=          60;
		internal const int SSH_MSG_USERAUTH_INFO_RESPONSE=         61;
		internal const int SSH_MSG_USERAUTH_PK_OK=                 60;
		internal const int SSH_MSG_GLOBAL_REQUEST=                 80;
		internal const int SSH_MSG_REQUEST_SUCCESS=                81;
		internal const int SSH_MSG_REQUEST_FAILURE=                82;
		internal const int SSH_MSG_CHANNEL_OPEN=                   90;
		internal const int SSH_MSG_CHANNEL_OPEN_CONFIRMATION=      91;
		internal const int SSH_MSG_CHANNEL_OPEN_FAILURE=           92;
		internal const int SSH_MSG_CHANNEL_WINDOW_ADJUST=          93;
		internal const int SSH_MSG_CHANNEL_DATA=                   94;
		internal const int SSH_MSG_CHANNEL_EXTENDED_DATA=          95;
		internal const int SSH_MSG_CHANNEL_EOF=                    96;
		internal const int SSH_MSG_CHANNEL_CLOSE=                  97;
		internal const int SSH_MSG_CHANNEL_REQUEST=                98;
		internal const int SSH_MSG_CHANNEL_SUCCESS=                99;
		internal const int SSH_MSG_CHANNEL_FAILURE=               100;

		private byte[] V_S;                                 // server version
		private byte[] V_C=Util.getBytes("SSH-2.0-"+version); // client version

		private byte[] I_C; // the payload of the client's SSH_MSG_KEXINIT
		private byte[] I_S; // the payload of the server's SSH_MSG_KEXINIT
		private byte[] K_S; // the host key

		private byte[] session_id;

		private byte[] IVc2s;
		private byte[] IVs2c;
		private byte[] Ec2s;
		private byte[] Es2c;
		private byte[] MACc2s;
		private byte[] MACs2c;

		private int seqi=0;
		private int seqo=0;

		private Cipher s2ccipher;
		private Cipher c2scipher;
		private MAC s2cmac;
		private MAC c2smac;
		private byte[] mac_buf;

		private Compression deflater;
		private Compression inflater;

		private IO io;
		private Socket socket;
		private int timeout=0;

		private bool isConnected=false;

		private System.Threading.Thread connectThread=null;

		internal Stream ins=null;
		internal Stream outs=null;

		internal static Random random;

		internal Buffer buf;
		internal Packet packet;

		internal SocketFactory socket_factory=null;

		private System.Collections.Hashtable config=null;

		private Proxy proxy=null;
		private UserInfo userinfo;

		internal String host="127.0.0.1";
		internal int port=22;

		internal String username=null;
		internal String password=null;

		internal JSch jsch;

		internal Session(JSch jsch)
		{
		
			this.jsch=jsch;
			buf=new Buffer();
            packet=new Packet(buf);
			io=new IO();
		}

		public void connect()
		{
            
			connect(timeout);
		}

		public void connect(int connectTimeout) 
		{
			if(random==null)
			{
				try
				{
					Type t=Type.GetType(getConfig("random"));
					random=(Random)(Activator.CreateInstance(t));
				}
				catch(Exception e){ Console.Error.WriteLine("connect: random "+e); }
			}
			Packet.setRandom(random);

			try	
			{
				int i, j;
				//int pad=0;

				if(proxy==null)
				{
					proxy=jsch.getProxy(host);
					if(proxy!=null)
					{
						lock(proxy)
						{
							proxy.close();
						}
					}
				}
				IPEndPoint ipe=null;
				if(proxy==null)
				{
					Stream ins;
					Stream outs;
					if(socket_factory==null)
					{
						if(connectTimeout==0)
						{
							ipe = new IPEndPoint(Dns.GetHostByName(host).AddressList[0], port);
							socket=new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
						}
						//			String message="";
						//			Thread tmp=new Thread(new Runnable(){
						//			public void run(){
						//			try{
						//				sockp[0]=new Socket(host, port);
						//				if(done[0]){ 
						//				if(sockp[0]!=null){
						//				sockp[0].close();
						//				sockp[0]=null;
						//				}
						//				}
						//				else thread.interrupt();
						//			}
						//			catch(Exception e){
						//				ee[0]=e;
						//				thread.interrupt();
						//				if(sockp[0]!=null){
						//				try{
						//				sockp[0].close();
						//				sockp[0]=null;
						//				}catch(Exception eee){}
						//				}
						//			}
						//			}
						//			});
						//			tmp.start();
						//			try{ 
						//			Thread.sleep(connectTimeout); 
						//			message="timeout: ";
						//			}
						//			catch(java.lang.InterruptedException eee){
						//			tmp.interrupt();
						//			tmp=null;
						//			System.gc();
						//			}
						//			done[0]=true;
						//			if(sockp[0]!=null){
						//			socket=sockp[0];
						//			}
						//			else{
						//			message+="socket is not established";
						//			if(ee[0]!=null){
						//			message=ee[0].toString();
						//			}
						//			throw new JSchException(message);
						//			}
						//		}
						socket.Connect(ipe);
						NetworkStream ns = new NetworkStream( socket );			
						ins=ns;
						outs=ns;
					}
					else
					{
						socket=socket_factory.createSocket(host, port);
						ins=socket_factory.getInputStream(socket);
						outs=socket_factory.getOutputStream(socket);
					}
					if(timeout>0)
					{
						socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, timeout);
					}
					socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.NoDelay, 1);
					io.setInputStream(ins);
					io.setOutputStream(outs);
				}
				else
				{
					lock(proxy)
					{
						proxy.connect(this, host, port);
						io.setInputStream(proxy.getInputStream());
						io.setOutputStream(proxy.getOutputStream());
					}
				}

				isConnected=true;

				i=0;
				while(i<buf.buffer.Length)
				{
					j=io.getByte();
					buf.buffer[i]=(byte)j; i++; 
					if(j==10)break;
				}

				if(buf.buffer[i-1]==10)
				{    // 0x0a
					i--;
					if(buf.buffer[i-1]==13)
					{  // 0x0d
						i--;
					}
				}

				if(i==buf.buffer.Length ||
					i<7 ||                                      // SSH-1.99 or SSH-2.0
					(buf.buffer[4]=='1' && buf.buffer[6]!='9')  // SSH-1.5
					)
				{
					throw new JSchException("invalid server's version string");
				}

				V_S=new byte[i]; Array.Copy(buf.buffer, 0, V_S, 0, i);
				//Console.WritLine("V_S: ("+i+") ["+new String(V_S)+"]");

				//io.put(V_C, 0, V_C.length); io.put("\n".getBytes(), 0, 1);
			{
				// Some Cisco devices will miss to read '\n' if it is sent separately.
				byte[] foo=new byte[V_C.Length+1];
				Array.Copy(V_C, 0, foo, 0, V_C.Length);
				foo[foo.Length-1]=(byte)'\n';
				io.put(foo, 0, foo.Length);
			}

				buf=read(buf);
				//Console.WritLine("read: 20 ? "+buf.buffer[5]);
				if(buf.buffer[5]!=SSH_MSG_KEXINIT)
				{
					throw new JSchException("invalid protocol: "+buf.buffer[5]);
				}
				KeyExchange kex=receive_kexinit(buf);

				bool result;
                while (true)
                {
                    buf = read(buf);
                    if (kex.getState() == buf.buffer[5])
                    {
                        result = kex.next(buf);
                        if (!result)
                        {
                            //Console.WritLine("verify: "+result);
                            //throw new JSchException("verify: " + result);
                        }
                    }
                    else
                    {
                      //  throw new JSchException("invalid protocol(kex): " + buf.buffer[5]);
                    }
                    if (kex.getState() == KeyExchange.STATE_END)
                    {
                        break;
                    }
                }

				checkHost(host, kex);

				send_newkeys();

				// receive SSH_MSG_NEWKEYS(21)
				buf=read(buf);
				//Console.WritLine("read: 21 ? "+buf.buffer[5]);
				if(buf.buffer[5]==SSH_MSG_NEWKEYS)
				{
					receive_newkeys(buf, kex);
				}
				else
				{
					throw new JSchException("invalid protocol(newkyes): "+buf.buffer[5]);
				}

				bool auth=false;
				bool auth_cancel=false;

				UserAuthNone usn=new UserAuthNone(userinfo);
				auth=usn.start(this);

				String methods=usn.getMethods();
				// methods: publickey,password,keyboard-interactive
				if(methods==null)
				{
					methods="publickey,password,keyboard-interactive";
				}

				//loop:
				while(true)
				{

					//Console.WritLine("methods: "+methods);

					while(!auth && 
						methods!=null && methods.Length>0)
					{

						//Console.WritLine("  methods: "+methods);

						UserAuth us=null;
						if(methods.StartsWith("publickey"))
						{
							//Console.WritLine("   jsch.identities.size()="+jsch.identities.size());
							lock(jsch.identities)
							{
								if(jsch.identities.Count>0)
								{
									us=new UserAuthPublicKey(userinfo);
								}
							}
						}
						else if(methods.StartsWith("keyboard-interactive"))
						{
							if(userinfo is UIKeyboardInteractive)
							{
								us=new UserAuthKeyboardInteractive(userinfo);
							}
						}
						else if(methods.StartsWith("password"))
						{
							us=new UserAuthPassword(userinfo);
						}
						if(us!=null)
						{
							try
							{ 
								auth=us.start(this); 
								auth_cancel=false;
							}
							catch(JSchAuthCancelException ee)
							{
								Console.WriteLine(ee);
								auth_cancel=true;
							}
							catch(JSchPartialAuthException ee)
							{
								methods=ee.getMethods();
								//Console.WritLine("PartialAuth: "+methods);
								auth_cancel=false;
								continue /*loop*/;
							}
							catch(Exception ee)
							{
								throw ee;
							}
						}
						if(!auth)
						{
							int comma=methods.IndexOf(",");
							if(comma==-1) break;
							methods=methods.Substring(comma+1);
						}
					}
					break;
				}

				if(auth)
				{
					connectThread=new System.Threading.Thread(new System.Threading.ThreadStart(run));
					connectThread.Start();
					return;
				}
				if(auth_cancel)
					throw new JSchException("Auth cancel");
				throw new JSchException("Auth fail");
			}
			catch(Exception e) 
			{
				if(isConnected)
				{
					try
					{
						packet.reset();
						buf.putByte((byte)SSH_MSG_DISCONNECT);
						buf.putInt(3);
						buf.putString(Util.getBytes(e.ToString()));
						buf.putString(Util.getBytes( "en" ));
						write(packet);
						disconnect();
					}
					catch
					{
					}
				}
				isConnected=false;
				//e.printStackTrace();		
				//if(e is JSchException) throw (JSchException)e;
				//throw new JSchException("Session.connect: "+e);
				throw e;
			}
		}

		private KeyExchange receive_kexinit(Buffer buf)  
		{
			int j=buf.getInt();
			if(j!=buf.getLength())
			{    // packet was compressed and
				buf.getByte();           // j is the size of deflated packet.
				I_S=new byte[buf.index-5];
			}
			else
			{
				I_S=new byte[j-1-buf.getByte()];
			}
			Array.Copy(buf.buffer, buf.s, I_S, 0, I_S.Length);
			/*
			try{
			byte[] tmp=new byte[I_S.length];
			System.arraycopy(I_S, 0, tmp, 0, I_S.length);
			Buffer tmpb=new Buffer(tmp);
			Console.WritLine("I_S: len="+I_S.length);
			tmpb.setOffSet(17);
			Console.WritLine("kex: "+new String(tmpb.getString()));
			Console.WritLine("server_host_key: "+new String(tmpb.getString()));
			Console.WritLine("cipher.c2s: "+new String(tmpb.getString()));
			Console.WritLine("cipher.s2c: "+new String(tmpb.getString()));
			Console.WritLine("mac.c2s: "+new String(tmpb.getString()));
			Console.WritLine("mac.s2c: "+new String(tmpb.getString()));
			Console.WritLine("compression.c2s: "+new String(tmpb.getString()));
			Console.WritLine("compression.s2c: "+new String(tmpb.getString()));
			Console.WritLine("lang.c2s: "+new String(tmpb.getString()));
			Console.WritLine("lang.s2c: "+new String(tmpb.getString()));
			Console.WritLine("?: "+(tmpb.getByte()&0xff));
			Console.WritLine("??: "+tmpb.getInt());
			}
			catch(Exception e){
			Console.WritLine(e);
			}
			*/

			send_kexinit();
			String[] guess=KeyExchange.Guess(I_S, I_C);
			if(guess==null)
			{
				throw new JSchException("Algorithm negotiation fail");
			}

			KeyExchange kex=null;
			try
			{
				Type t=Type.GetType(getConfig(guess[KeyExchange.PROPOSAL_KEX_ALGS]));
				kex=(KeyExchange)(Activator.CreateInstance(t));
				kex.guess=guess;
				kex.init(this, V_S, V_C, I_S, I_C);
			}
			catch(Exception e){Console.WriteLine("kex: "+e); }

			return kex;
		}

		private bool in_kex=false;
		public void rekey()  
		{
			send_kexinit();
		}
		private void send_kexinit()  
		{
			if(in_kex) return;
			in_kex=true;

			// byte      SSH_MSG_KEXINIT(20)
			// byte[16]  cookie (random bytes)
			// string    kex_algorithms
			// string    server_host_key_algorithms
			// string    encryption_algorithms_client_to_server
			// string    encryption_algorithms_server_to_client
			// string    mac_algorithms_client_to_server
			// string    mac_algorithms_server_to_client
			// string    compression_algorithms_client_to_server
			// string    compression_algorithms_server_to_client
			// string    languages_client_to_server
			// string    languages_server_to_client
			packet.reset();
			buf.putByte((byte) SSH_MSG_KEXINIT);
			lock(random)
			{
				random.fill(buf.buffer, buf.index, 16); buf.skip(16);
			}
			buf.putString(Util.getBytes( getConfig("kex")));
			buf.putString(Util.getBytes(getConfig("server_host_key")));
			buf.putString(Util.getBytes(getConfig("cipher.c2s")));
			buf.putString(Util.getBytes(getConfig("cipher.s2c")));
			buf.putString(Util.getBytes(getConfig("mac.c2s")));
			buf.putString(Util.getBytes(getConfig("mac.s2c")));
			buf.putString(Util.getBytes(getConfig("compression.c2s")));
			buf.putString(Util.getBytes(getConfig("compression.s2c")));
			buf.putString(Util.getBytes(getConfig("lang.c2s")));
			buf.putString(Util.getBytes(getConfig("lang.s2c")));
			buf.putByte((byte)0);
			buf.putInt(0);

			buf.setOffSet(5);
			I_C=new byte[buf.getLength()];
			buf.getByte(I_C);

			write(packet);
		}

		private void send_newkeys()  
		{
			// send SSH_MSG_NEWKEYS(21)
			packet.reset();
			buf.putByte((byte)SSH_MSG_NEWKEYS);
			write(packet);
		}

		private void checkHost(String host, KeyExchange kex)  
		{
			String shkc=getConfig("StrictHostKeyChecking");

			//Console.WritLine("shkc: "+shkc);

			byte[] K_S=kex.getHostKey();
			String key_type=kex.getKeyType();
			String key_fprint=kex.getFingerPrint();

			hostkey=new HostKey(host, K_S);

			HostKeyRepository hkr=jsch.getHostKeyRepository();
			int i=0;
			lock(hkr)
			{
				i=hkr.check(host, K_S);
			}
			if((shkc.Equals("ask") || shkc.Equals("yes")) &&
				i==HostKeyRepository.CHANGED)
			{
				String file=null;
				lock(hkr)
				{
					file=hkr.getKnownHostsRepositoryID();
				}
				if(file==null){file="known_hosts";}
				String message=
					"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n"+
					"@    WARNING: REMOTE HOST IDENTIFICATION HAS CHANGED!     @\n"+
					"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n"+
					"IT IS POSSIBLE THAT SOMEONE IS DOING SOMETHING NASTY!      \n"+
					"Someone could be eavesdropping on you right now (man-in-the-middle attack)!\n"+
					"It is also possible that the "+key_type+" host key has just been changed.\n"+
					"The fingerprint for the "+key_type+" key sent by the remote host is\n"+
					key_fprint+".\n"+
					"Please contact your system administrator.\n"+
					"Add correct host key in "+file+" to get rid of this message.";
				if(userinfo!=null)
				{
					userinfo.showMessage(message);
				}
				throw new JSchException("HostKey has been changed");
			}

			bool insert=false;
	 
			if((shkc.Equals("ask") || shkc.Equals("yes")) &&
				i!=HostKeyRepository.OK)
			{
				if(shkc.Equals("yes"))
				{
					throw new JSchException("reject HostKey");
				}
				//Console.WritLine("finger-print: "+key_fprint);
				if(userinfo!=null)
				{
					bool foo=userinfo.promptYesNo(
						"The authenticity of host '"+host+"' can't be established.\n"+
						key_type+" key fingerprint is "+key_fprint+".\n"+
						"Are you sure you want to continue connecting?"
						);
					if(!foo)
					{
						throw new JSchException("reject HostKey");
					}
					insert=true;
				}
				else
				{
					if(i==HostKeyRepository.NOT_INCLUDED) 
						throw new JSchException("UnknownHostKey");
					else throw new JSchException("HostKey has been changed.");
				}
			}

			if(shkc.Equals("no") && 
				HostKeyRepository.NOT_INCLUDED==i)
			{
				insert=true;
			}

			if(insert)
			{
				lock(hkr)
				{
					hkr.add(host, K_S, userinfo);
				}
			}

		}

		//public void start(){ (new Thread(this)).start();  }

		public Channel openChannel(String type) 
		{
			if(!isConnected)
			{
				throw new JSchException("session is down");
			}
			try
			{
				Channel channel=Channel.getChannel(type);
				addChannel(channel);
				channel.init();
				return channel;
			}
			catch
			{
				//e.printStackTrace();
			}
			return null;
		}

		// encode will bin invoked in write with synchronization.
		public void encode(Packet packet) 
		{
			//Console.WritLine("encode: "+packet.buffer.buffer[5]);
			//if(packet.buffer.buffer[5]==96){
			//Thread.dumpStack();
			//}
			if(deflater!=null)
			{
				packet.buffer.index=deflater.compress(packet.buffer.buffer, 
					5, packet.buffer.index);
			}
			packet.padding();
			byte[] mac=null;
			if(c2scipher!=null)
			{
				int pad=packet.buffer.buffer[4];
				lock(random)
				{
					random.fill(packet.buffer.buffer, packet.buffer.index-pad, pad);
				}
			}
			if(c2smac!=null)
			{
				c2smac.update(seqo);
				c2smac.update(packet.buffer.buffer, 0, packet.buffer.index);
				mac=c2smac.doFinal();
			}
			if(c2scipher!=null)
			{
				byte[] buf=packet.buffer.buffer;
				c2scipher.update(buf, 0, packet.buffer.index, buf, 0);
			}
			if(mac!=null)
			{
				packet.buffer.putByte(mac);
			}
		}

		int[] uncompress_len=new int[1];

		public Buffer read(Buffer buf) 
		{
			int j=0;
			while(true)
			{
				buf.reset();
				io.getByte(buf.buffer, buf.index, 8); buf.index+=8;
				if(s2ccipher!=null)
				{
					s2ccipher.update(buf.buffer, 0, 8, buf.buffer, 0);
				}
//				j=(uint)(((buf.buffer[0]<<24)&0xff000000)|(uint)
//					((buf.buffer[1]<<16)&0x00ff0000)|(uint)
//					((buf.buffer[2]<< 8)&0x0000ff00)|(uint)
//					((buf.buffer[3]    )&0x000000ff));
				j=Util.ToInt32( buf.buffer, 0 );
				io.getByte(buf.buffer, buf.index, j-4); buf.index+=(j-4);
				if(s2ccipher!=null)
				{
					s2ccipher.update(buf.buffer, 8, j-4, buf.buffer, 8);
				}
				if(s2cmac!=null)
				{
					s2cmac.update(seqi);
					s2cmac.update(buf.buffer, 0, buf.index);
					byte[] result=s2cmac.doFinal();
					io.getByte(mac_buf, 0, mac_buf.Length);
					if(!Util.array_equals(result, mac_buf))
					{
						Console.WriteLine("mac error");
						throw new IOException("MAC Error");
					}
				}
				seqi++;

				if(inflater!=null)
				{
					//inflater.uncompress(buf);
					int pad=buf.buffer[4];
					uncompress_len[0]=buf.index-5-pad;
					byte[] foo=inflater.uncompress(buf.buffer, 5, uncompress_len);
					if(foo!=null)
					{
						buf.buffer=foo;
						buf.index=5+uncompress_len[0];
					}
					else
					{
						Console.Error.WriteLine("fail in inflater");
						break;
					}
				}

				int type=buf.buffer[5]&0xff;
				//Console.WritLine("read: "+type);
				if(type==SSH_MSG_DISCONNECT)
				{
					buf.rewind();
					buf.getInt();buf.getShort();
					int reason_code=buf.getInt();
					byte[] description=buf.getString();
					byte[] language_tag=buf.getString();
					/*
						System.err.println("SSH_MSG_DISCONNECT:"+
											" "+reason_code+
								" "+new String(description)+
								" "+new String(language_tag));
					*/
					throw new JSchException("SSH_MSG_DISCONNECT:"+
						" "+reason_code+
						" "+Util.getString(description)+
						" "+Util.getString(language_tag));
					//break;
				}
				else if(type==SSH_MSG_IGNORE)
				{
				}
				else if(type==SSH_MSG_DEBUG)
				{
					buf.rewind();
					buf.getInt();buf.getShort();
					/*
						byte always_display=(byte)buf.getByte();
						byte[] message=buf.getString();
						byte[] language_tag=buf.getString();
						System.err.println("SSH_MSG_DEBUG:"+
								" "+new String(message)+
								" "+new String(language_tag));
					*/
				}
				else if(type==SSH_MSG_CHANNEL_WINDOW_ADJUST)
				{
					buf.rewind();
					buf.getInt();buf.getShort();
					Channel c=Channel.getChannel(buf.getInt(), this);
					if(c==null)
					{
					}
					else
					{
						c.addRemoteWindowSize(buf.getInt()); 
					}
				}
				else
				{
					break;
				}
			}
			buf.rewind();
			return buf;
		}

		internal byte[] getSessionId()
		{
			return session_id;
		}

		private void receive_newkeys(Buffer buf, KeyExchange kex)  
		{
			//    send_newkeys();
			in_kex=false;
			updateKeys(kex);
		}
		private void updateKeys(KeyExchange kex) 
		{
			byte[] K=kex.getK();
			byte[] H=kex.getH();
			HASH hash=kex.getHash();

			String[] guess=kex.guess;

			if(session_id==null)
			{
				session_id=new byte[H.Length];
				Array.Copy(H, 0, session_id, 0, H.Length);
			}

			/*
			Initial IV client to server:     HASH (K || H || "A" || session_id)
			Initial IV server to client:     HASH (K || H || "B" || session_id)
			Encryption key client to server: HASH (K || H || "C" || session_id)
			Encryption key server to client: HASH (K || H || "D" || session_id)
			Integrity key client to server:  HASH (K || H || "E" || session_id)
			Integrity key server to client:  HASH (K || H || "F" || session_id)
			*/

			buf.reset();
			buf.putMPInt(K);
			buf.putByte(H);
			buf.putByte((byte)0x41);
			buf.putByte(session_id);
			hash.update(buf.buffer, 0, buf.index);
			IVc2s=hash.digest();

			int j=buf.index-session_id.Length-1;

			buf.buffer[j]++;
			hash.update(buf.buffer, 0, buf.index);
			IVs2c=hash.digest();

			buf.buffer[j]++;
			hash.update(buf.buffer, 0, buf.index);
			Ec2s=hash.digest();

			buf.buffer[j]++;
			hash.update(buf.buffer, 0, buf.index);
			Es2c=hash.digest();

			buf.buffer[j]++;
			hash.update(buf.buffer, 0, buf.index);
			MACc2s=hash.digest();

			buf.buffer[j]++;
			hash.update(buf.buffer, 0, buf.index);
			MACs2c=hash.digest();

			try
			{
				Type t;
	  
				t=Type.GetType(getConfig(guess[KeyExchange.PROPOSAL_ENC_ALGS_STOC]));
				s2ccipher=(Cipher)(Activator.CreateInstance(t));
				while(s2ccipher.getBlockSize()>Es2c.Length)
				{
					buf.reset();
					buf.putMPInt(K);
					buf.putByte(H);
					buf.putByte(Es2c);
					hash.update(buf.buffer, 0, buf.index);
					byte[] foo=hash.digest();
					byte[] bar=new byte[Es2c.Length+foo.Length];
					Array.Copy(Es2c, 0, bar, 0, Es2c.Length);
					Array.Copy(foo, 0, bar, Es2c.Length, foo.Length);
					Es2c=bar;
				}
				s2ccipher.init(Cipher.DECRYPT_MODE, Es2c, IVs2c);
				t=Type.GetType(getConfig(guess[KeyExchange.PROPOSAL_MAC_ALGS_STOC]));
				s2cmac=(MAC)(Activator.CreateInstance(t));
				s2cmac.init(MACs2c);
				mac_buf=new byte[s2cmac.getBlockSize()];

				t=Type.GetType(getConfig(guess[KeyExchange.PROPOSAL_ENC_ALGS_CTOS]));
				c2scipher=(Cipher)(Activator.CreateInstance(t));
				while(c2scipher.getBlockSize()>Ec2s.Length)
				{
					buf.reset();
					buf.putMPInt(K);
					buf.putByte(H);
					buf.putByte(Ec2s);
					hash.update(buf.buffer, 0, buf.index);
					byte[] foo=hash.digest();
					byte[] bar=new byte[Ec2s.Length+foo.Length];
					Array.Copy(Ec2s, 0, bar, 0, Ec2s.Length);
					Array.Copy(foo, 0, bar, Ec2s.Length, foo.Length);
					Ec2s=bar;
				}
				c2scipher.init(Cipher.ENCRYPT_MODE, Ec2s, IVc2s);

				t=Type.GetType(getConfig(guess[KeyExchange.PROPOSAL_MAC_ALGS_CTOS]));
				c2smac=(MAC)(Activator.CreateInstance(t));
				c2smac.init(MACc2s);

				if(!guess[KeyExchange.PROPOSAL_COMP_ALGS_CTOS].Equals("none"))
				{
					String foo=getConfig(guess[KeyExchange.PROPOSAL_COMP_ALGS_CTOS]);
					if(foo!=null)
					{
						try
						{
							t=Type.GetType(foo);
							deflater=(Compression)(Activator.CreateInstance(t));
							deflater.init(Compression.DEFLATER, 6);
						}
						catch
						{
							Console.Error.WriteLine(foo+" isn't accessible.");
						}
					}
				}
				else
				{
					if(deflater!=null)
					{
						deflater=null;
					}
				}
				if(!guess[KeyExchange.PROPOSAL_COMP_ALGS_STOC].Equals("none"))
				{
					String foo=getConfig(guess[KeyExchange.PROPOSAL_COMP_ALGS_STOC]);
					if(foo!=null)
					{
						try
						{
							t=Type.GetType(foo);
							inflater=(Compression)(Activator.CreateInstance(t));
							inflater.init(Compression.INFLATER, 0);
						}
						catch
						{
							Console.Error.WriteLine(foo+" isn't accessible.");
						}
					}
				}
				else
				{
					if(inflater!=null)
					{
						inflater=null;
					}
				}
			}
			catch(Exception e){ Console.Error.WriteLine("updatekeys: "+e); }
		}

		public /*lock*/ void write(Packet packet, Channel c, int length) 
		{
			while(true)
			{
				if(c.rwsize>=length)
				{
					c.rwsize-=length;
					break;
				}
				if(c._close || !IsConnected())
				{
					throw new IOException("channel is broken");
				}
				if(c.rwsize>0)
				{
					int len=c.rwsize;
					int s=packet.shift(len, (c2smac!=null ? c2smac.getBlockSize() : 0));
					byte command=packet.buffer.buffer[5];
					int recipient=c.getRecipient();
					length-=len;
					c.rwsize=0;
					write(packet);
					packet.unshift(command, recipient, s, length);
				}
				try{System.Threading.Thread.Sleep(10);}
				catch{};
			}
			write(packet);
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		public void write(Packet packet) 
		{
			encode(packet);
			if(io!=null)
			{
				io.put(packet);
				seqo++;
			}
		}

		//System.Threading.Thread thread;
		object thread;
		public void run()
		{
			thread=this;

			byte[] foo;
			Buffer buf=new Buffer();
			Packet packet=new Packet(buf);
			int i=0;
			Channel channel;
			int[] start=new int[1];
			int[] length=new int[1];
			KeyExchange kex=null;

			try
			{
				while(isConnected &&
					thread!=null)
				{
					buf=read(buf);
					int msgType=buf.buffer[5]&0xff;
					//      if(msgType!=94)
					//Console.WritLine("read: 94 ? "+msgType);

					if(kex!=null && kex.getState()==msgType)
					{
						bool result=kex.next(buf);
						if(!result)
						{
							throw new JSchException("verify: "+result);
						}
						continue;
					}

					switch(msgType)
					{
						case SSH_MSG_KEXINIT:
							Console.WriteLine("KEXINIT");
							kex=receive_kexinit(buf);
							break;

						case SSH_MSG_NEWKEYS:
							Console.WriteLine("NEWKEYS");
							send_newkeys();
							receive_newkeys(buf, kex);
							kex=null;
							break;

						case SSH_MSG_CHANNEL_DATA:
							buf.getInt(); 
							buf.getByte(); 
							buf.getByte(); 
							i=buf.getInt(); 
							channel=Channel.getChannel(i, this);
							foo=buf.getString(start, length);
							if(channel==null)
							{
								break;
							}
							try
							{
								channel.write(foo, start[0], length[0]);
							}
							catch(Exception e)
							{
								Console.Error.WriteLine(e);
								try{channel.disconnect();}
								catch(Exception ee){Console.Error.WriteLine(ee);}
								break;
							}
							int len=length[0];
							channel.setLocalWindowSize(channel.lwsize-len);
							if(channel.lwsize<channel.lwsize_max/2)
							{
								packet.reset();
								buf.putByte((byte)SSH_MSG_CHANNEL_WINDOW_ADJUST);
								buf.putInt(channel.getRecipient());
								buf.putInt(channel.lwsize_max-channel.lwsize);
								write(packet);
								channel.setLocalWindowSize(channel.lwsize_max);
							}
							break;

						case SSH_MSG_CHANNEL_EXTENDED_DATA:
							buf.getInt();
							buf.getShort();
							i=buf.getInt();
							channel=Channel.getChannel(i, this);
							buf.getInt();                   // data_type_code == 1
							foo=buf.getString(start, length);
							//Console.WritLine("stderr: "+new String(foo,start[0],length[0]));
							if(channel==null)
							{
								break;
							}
							//channel.write(foo, start[0], length[0]);
							channel.write_ext(foo, start[0], length[0]);

							len=length[0];
							channel.setLocalWindowSize(channel.lwsize-len);
							if(channel.lwsize<channel.lwsize_max/2)
							{
								packet.reset();
								buf.putByte((byte)SSH_MSG_CHANNEL_WINDOW_ADJUST);
								buf.putInt(channel.getRecipient());
								buf.putInt(channel.lwsize_max-channel.lwsize);
								write(packet);
								channel.setLocalWindowSize(channel.lwsize_max);
							}
							break;

						case SSH_MSG_CHANNEL_WINDOW_ADJUST:
							buf.getInt(); 
							buf.getShort(); 
							i=buf.getInt(); 
							channel=Channel.getChannel(i, this);
							if(channel==null)
							{
								break;
							}
							channel.addRemoteWindowSize(buf.getInt()); 
							break;

						case SSH_MSG_CHANNEL_EOF:
							buf.getInt(); 
							buf.getShort(); 
							i=buf.getInt(); 
							channel=Channel.getChannel(i, this);
							if(channel!=null)
							{
								channel.eof_remote=true;
								channel.eof();
							}
							/*
							packet.reset();
							buf.putByte((byte)SSH_MSG_CHANNEL_EOF);
							buf.putInt(channel.getRecipient());
							write(packet);
							*/
							break;
						case SSH_MSG_CHANNEL_CLOSE:
							buf.getInt(); 
							buf.getShort(); 
							i=buf.getInt(); 
							channel=Channel.getChannel(i, this);
							if(channel!=null)
							{
								//	      channel.close();
								channel.disconnect();
							}
							/*
								if(Channel.pool.size()==0){
								thread=null;
							}
							*/
							break;
						case SSH_MSG_CHANNEL_OPEN_CONFIRMATION:
							buf.getInt(); 
							buf.getShort(); 
							i=buf.getInt(); 
							channel=Channel.getChannel(i, this);
							if(channel==null)
							{
								//break;
							}
							channel.setRecipient(buf.getInt());
							channel.setRemoteWindowSize(buf.getInt());
							channel.setRemotePacketSize(buf.getInt());
							break;
						case SSH_MSG_CHANNEL_OPEN_FAILURE:
							buf.getInt(); 
							buf.getShort(); 
							i=buf.getInt(); 
							channel=Channel.getChannel(i, this);
							if(channel==null)
							{
								//break;
							}
							int reason_code=buf.getInt(); 
							//foo=buf.getString();  // additional textual information
							//foo=buf.getString();  // language tag 
							channel.exitstatus=reason_code;
							channel._close=true;
							channel.eof_remote=true;
							channel.setRecipient(0);
							break;
						case SSH_MSG_CHANNEL_REQUEST:
							buf.getInt(); 
							buf.getShort(); 
							i=buf.getInt(); 
							foo=buf.getString(); 
							bool reply=(buf.getByte()!=0);
							channel=Channel.getChannel(i, this);
							if(channel!=null)
							{
								byte reply_type=(byte)SSH_MSG_CHANNEL_FAILURE;
								if((Util.getString(foo)).Equals("exit-status"))
								{
									i=buf.getInt();             // exit-status
									channel.setExitStatus(i);
									//	    Console.WritLine("exit-stauts: "+i);
									//          channel.close();
									reply_type=(byte)SSH_MSG_CHANNEL_SUCCESS;
								}
								if(reply)
								{
									packet.reset();
									buf.putByte(reply_type);
									buf.putInt(channel.getRecipient());
									write(packet);
								}
							}
							else
							{
							}
							break;
						case SSH_MSG_CHANNEL_OPEN:
							buf.getInt(); 
							buf.getShort(); 
							foo=buf.getString(); 
							String ctyp=Util.getString(foo);
							//Console.WritLine("type="+ctyp);
							if(!"forwarded-tcpip".Equals(ctyp) &&
								!"x11".Equals(ctyp))
							{
								Console.WriteLine("Session.run: CHANNEL OPEN "+ctyp); 
								throw new IOException("Session.run: CHANNEL OPEN "+ctyp);
							}
							else
							{
								channel=Channel.getChannel(ctyp);
								addChannel(channel);
								channel.getData(buf);
								channel.init();

								packet.reset();
								buf.putByte((byte)SSH_MSG_CHANNEL_OPEN_CONFIRMATION);
								buf.putInt(channel.getRecipient());
								buf.putInt(channel.id);
								buf.putInt(channel.lwsize);
								buf.putInt(channel.lmpsize);
								write(packet);
								(new Thread(new ThreadStart( channel.run ))).Start();
								break;
							}
						case SSH_MSG_CHANNEL_SUCCESS:
							buf.getInt(); 
							buf.getShort(); 
							i=buf.getInt(); 
							channel=Channel.getChannel(i, this);
							if(channel==null)
							{
								break;
							}
							channel.reply=1;
							break;
						case SSH_MSG_CHANNEL_FAILURE:
							buf.getInt(); 
							buf.getShort(); 
							i=buf.getInt(); 
							channel=Channel.getChannel(i, this);
							if(channel==null)
							{
								break;
							}
							channel.reply=0;
							break;
						case SSH_MSG_GLOBAL_REQUEST:
							buf.getInt(); 
							buf.getShort(); 
							foo=buf.getString();       // request name
							reply=(buf.getByte()!=0);
							if(reply)
							{
								packet.reset();
								buf.putByte((byte)SSH_MSG_REQUEST_FAILURE);
								write(packet);
							}
							break;
						case SSH_MSG_REQUEST_SUCCESS:
						case SSH_MSG_REQUEST_FAILURE:
							break;
						default:
							Console.WriteLine("Session.run: unsupported type "+msgType); 
							throw new IOException("Unknown SSH message type "+msgType);
					}
				}
			}
			catch{}
//			{
//				Console.Error.WriteLine(e);
//				Console.WritLine("# Session.run");
//				e.printStackTrace();
//			}
			try
			{
				disconnect();
			}
			catch(NullReferenceException e)
			{
				Console.Error.WriteLine(e);
				//Console.WritLine("@1");
				//e.printStackTrace();
			}
			catch(Exception e)
			{
				Console.Error.WriteLine(e);
				//Console.WritLine("@2");
				//e.printStackTrace();
			}
			isConnected=false;
		}

		public void constize() 
		{
			disconnect();
			jsch=null;
		}

		public void disconnect()
		{
			if(!isConnected) return;
			isConnected=false;
			try
			{
				//socket.close();
			}
			catch
			{
	    
			}
			//Console.WritLine(this+": disconnect");
			//Thread.dumpStack();
			/*
			for(int i=0; i<Channel.pool.size(); i++){
			try{
				Channel c=((Channel)(Channel.pool.elementAt(i)));
			if(c.session==this) c.eof();
			}
			catch(Exception e){
			}
			} 
			*/

			Channel.eof(this);

			PortWatcher.delPort(this);
			ChannelForwardedTCPIP.delPort(this);

			connectThread.Interrupt();
			//connectThread.yield();
			connectThread=null;

			thread=null;
			try
			{
				if(io!=null)
				{
					if(io.ins!=null) io.ins.Close();
					if(io.outs!=null) io.outs.Close();
				}
				if(proxy==null)
				{
					if(socket!=null)
						socket.Close();
				}
				else
				{
					lock(proxy)
					{
						proxy.close();	  
					}
					proxy=null;
				}
			}
			catch
			{
				//      e.printStackTrace();
			}
			io=null;
			socket=null;
			lock(jsch.pool)
			{
				jsch.pool.Remove(this);
			}
			System.GC.Collect();
		}

		public void setPortForwardingL(int lport, String host, int rport) 
		{
			setPortForwardingL("127.0.0.1", lport, host,rport);
		}
		public void setPortForwardingL(String boundaddress, int lport, String host, int rport) 
		{
			PortWatcher pw=PortWatcher.addPort(this, boundaddress, lport, host, rport);
			Thread th = new Thread(new ThreadStart(pw.run));
			th.Start();
		}
		public void delPortForwardingL(int lport) 
		{
			PortWatcher.delPort(this, lport);
		}
		public String[] getPortForwardingL() 
		{
			return PortWatcher.getPortForwarding(this);
		}

		public void setPortForwardingR(int rport, String host, int lport) 
		{
			ChannelForwardedTCPIP.addPort(this, rport, host, lport);

			Buffer buf=new Buffer(100); // ??
			Packet packet=new Packet(buf);

			try
			{
				// byte SSH_MSG_GLOBAL_REQUEST 80
				// string "tcpip-forward"
				// bool want_reply
				// string  address_to_bind
				// uint32  port number to bind
				packet.reset();
				buf.putByte((byte) SSH_MSG_GLOBAL_REQUEST);
				buf.putString(Util.getBytes("tcpip-forward"));
				buf.putByte((byte)0);
				buf.putString(Util.getBytes("0.0.0.0"));
				buf.putInt(rport);
				write(packet);
			}
			catch(Exception e)
			{
				throw new JSchException(e.ToString());
			}
		}
		public void delPortForwardingR(int rport) 
		{
			ChannelForwardedTCPIP.delPort(this, rport);
		}

		internal void addChannel(Channel channel)
		{
			channel.session=this;
		}
		public String getConfig(String name)
		{
			Object foo=null;
			if(config!=null)
			{
				foo=config[name];
				if(foo is String) return (String)foo;
			}
			foo=jsch.getConfig(name);
			if(foo is String) return (String)foo;
			return null;
		}
		//  public Channel getChannel(){ return channel; }
		public void setProxy(Proxy proxy){ this.proxy=proxy; }
		public void setHost(String host){ this.host=host; }
		public void setPort(int port){ this.port=port; }
		internal void setUserName(String foo){ this.username=foo; }
		public void setPassword(String foo){ this.password=foo; }
		public void setUserInfo(UserInfo userinfo){ this.userinfo=userinfo; }
		public void setInputStream(Stream ins){ this.ins=ins; }
		public void setOutputStream(Stream outs){ this.outs=outs; }
		public void setX11Host(String host){ ChannelX11.setHost(host); }
		public void setX11Port(int port){ ChannelX11.setPort(port); }
		public void setX11Cookie(String cookie){ ChannelX11.setCookie(cookie); }

		//	public void setConfig(System.Collections.Hashtable foo){
		//	setConfig((java.util.Hashtable)foo);
		//	}
	 
		public void setConfig(System.Collections.Hashtable foo)
		{
			if(config==null) config=new System.Collections.Hashtable();
			for(System.Collections.IEnumerator e=foo.Keys.GetEnumerator() ; e.MoveNext();) 
			{
				String key=(String)(e.Current);
				config.Add(key, (String)(foo[key]));
			}
		}
		public void setSocketFactory(SocketFactory foo){ socket_factory=foo;}
		public bool IsConnected(){ return isConnected; }
		public int getTimeout(){ return timeout; }
		public void setTimeout(int foo)  
		{
			if(socket==null)
			{
				if(foo<0)
				{
					throw new JSchException("invalid timeout value");
				}
				this.timeout=foo;
				return;
			}
			try
			{
				socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, foo);
				timeout=foo;
			}
			catch(Exception e)
			{
				throw new JSchException(e.ToString());
			}
		}
		public String getServerVersion()
		{
			return Util.getString(V_S);
		}
		public String getClientVersion()
		{
			return Util.getString(V_C);
		}
		public void setClientVersion(String cv)
		{
			V_C=Util.getBytes(cv);
		}

		public void sendIgnore() 
		{
			Buffer buf=new Buffer();
			Packet packet=new Packet(buf);
			packet.reset();
			buf.putByte((byte)SSH_MSG_IGNORE);
			write(packet);
		}
	  
		private HostKey hostkey=null;
		public HostKey getHostKey(){ return hostkey; }
		public String getMac()
		{
			string mac="";
			if(s2cmac!=null)
				mac = s2cmac.getName();
			return mac;

		}
		public String getCipher()
		{
			string cipher="";
			if(s2ccipher!=null)
				cipher= s2ccipher.ToString();
			return cipher;
		}
	}

}
