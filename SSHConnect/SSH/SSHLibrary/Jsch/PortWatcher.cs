using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Tamir.SharpSsh.jsch
{
	/* -*-mode:java; c-basic-offset:2; -*- */
	/*
	Copyright (c) 2002,2003,2004 ymnk, JCraft,Inc. All rights reserved.

	Redistribution and use in source and binary forms, with or without
	modification, are permitted provided that the following conditions are met:

	  1. Redistributions of source code must retain the above copyright notice,
		 this list of conditions and the following disclaimer.

	  2. Redistributions in binary form must reproduce the above copyright 
		 notice, this list of conditions and the following disclaimer in 
		 the documentation and/or other materials provided with the distribution.

	  3. The names of the authors may not be used to endorse or promote products
		 derived from this software without specific prior written permission.

	THIS SOFTWARE IS PROVIDED ``AS IS'' AND ANY EXPRESSED OR IMPLIED WARRANTIES,
	INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
	FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL JCRAFT,
	INC. OR ANY CONTRIBUTORS TO THIS SOFTWARE BE LIABLE FOR ANY DIRECT, INDIRECT,
	INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
	LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA,
	OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
	LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
	NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE,
	EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
	*/

	class PortWatcher
	{
		private static System.Collections.ArrayList pool=new System.Collections.ArrayList();

		internal Session session;
		internal int lport;
		internal int rport;
		internal String host;
		internal String boundaddress;
		internal System.Net.Sockets.TcpListener ss;
		internal object thread;

		internal static String[] getPortForwarding(Session session)
		{
			System.Collections.ArrayList foo=new System.Collections.ArrayList();
			lock(pool)
			{
				for(int i=0; i<pool.Count; i++)
				{
					PortWatcher p=(PortWatcher)(pool[i]);
					if(p.session==session)
					{
						foo.Add(p.lport+":"+p.host+":"+p.rport);
					}
				}
			}
			String[] bar=new String[foo.Count];
			for(int i=0; i<foo.Count; i++)
			{
				bar[i]=(String)(foo[i]);
			}
			return bar;
		}
		internal static PortWatcher getPort(Session session, int lport)
		{
			lock(pool)
			{
				for(int i=0; i<pool.Count; i++)
				{
					PortWatcher p=(PortWatcher)(pool[i]);
					if(p.session==session && p.lport==lport) return p;
				}
				return null;
			}
		}
		internal static PortWatcher addPort(Session session, String address, int lport, String host, int rport)
		{
			if(getPort(session, lport)!=null)
			{
				throw new JSchException("PortForwardingL: local port "+lport+" is already registered.");
			}
			PortWatcher pw=new PortWatcher(session, address, lport, host, rport);
			pool.Add(pw);
			return pw;
		}
		internal static void delPort(Session session, int lport)
		{
			PortWatcher pw=getPort(session, lport);
			if(pw==null)
			{
				throw new JSchException("PortForwardingL: local port "+lport+" is not registered.");
			}
			pw.delete();
			pool.Remove(pw);
		}
		internal static void delPort(Session session)
		{
			PortWatcher[] foo=new PortWatcher[pool.Count];
			int count=0;
			lock(pool)
			{
				for(int i=0; i<pool.Count; i++)
				{
					PortWatcher p=(PortWatcher)(pool[i]);
					if(p.session==session) 
					{
						p.delete();
						foo[count++]=p;
					}
				}
				for(int i=0; i<count; i++)
				{
					PortWatcher p=foo[i];
					pool.Remove(p);
				}
			}
		}
		internal PortWatcher(Session session, 
			String boundaddress, int lport, 
			String host, int rport)
		{
			this.session=session;
			this.boundaddress=boundaddress;
			this.lport=lport;
			this.host=host;
			this.rport=rport;
			try
			{
				//    ss=new ServerSocket(port);
				ss=new TcpListener(Dns.GetHostByName(this.boundaddress).AddressList[0], lport);	
				
			}
			catch(Exception e)
			{ 
				Console.WriteLine(e);
				throw new JSchException("PortForwardingL: local port "+lport+" cannot be bound.");
			}
		}
	
	

		public void run()
		{
			Buffer buf=new Buffer(300); // ??
			Packet packet=new Packet(buf);
			thread=this;
			try
			{
				ss.Start();
				while(thread!=null)
				{
					Socket socket=ss.AcceptSocket();
					socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.NoDelay, 1);
					NetworkStream ns = new NetworkStream(socket);
					Stream ins= ns;
					Stream outs=ns;
					ChannelDirectTCPIP channel=new ChannelDirectTCPIP();
					channel.init();
					channel.setInputStream(ins);
					channel.setOutputStream(outs);
						session.addChannel(channel);
					((ChannelDirectTCPIP)channel).setHost(host);
					((ChannelDirectTCPIP)channel).setPort(rport);
					((ChannelDirectTCPIP)channel).setOrgIPAddress( ((IPEndPoint)socket.RemoteEndPoint).Address.ToString() );
					((ChannelDirectTCPIP)channel).setOrgPort(((IPEndPoint)socket.RemoteEndPoint).Port);
					channel.connect();
					if(channel.exitstatus!=-1)
					{
					}
				}
			}
			catch
			{
				//System.out.println("! "+e);
			}
		}

		void delete()
		{
			thread=null;
			try
			{ 
				if(ss!=null)ss.Stop();
				ss=null;
			}
			catch
			{
			}
		}
	}

}
