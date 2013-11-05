using System;
using System.Net;
using System.IO;
using System.Collections;
using System.Threading;
using Tamir.Streams;

namespace Tamir.SharpSsh.jsch
{
/* -*-mode:java; c-basic-offset:2; -*- */
/*
Copyright (c) 2002,2003,2004 ymnk, JCraft,Inc. All rights reserved.

Redistribution and use ins source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

  1. Redistributions of source code must retain the above copyright notice,
     this list of conditions and the following disclaimer.

  2. Redistributions ins binary form must reproduce the above copyright 
     notice, this list of conditions and the following disclaimer ins 
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

	public class ChannelSftp : ChannelSession
	{

		private const byte SSH_FXP_INIT=               1;
		private const byte SSH_FXP_VERSION=            2;
		private const byte SSH_FXP_OPEN=               3;
		private const byte SSH_FXP_CLOSE=              4;
		private const byte SSH_FXP_READ=               5;
		private const byte SSH_FXP_WRITE=              6;
		private const byte SSH_FXP_LSTAT=              7;
		private const byte SSH_FXP_FSTAT=              8;
		private const byte SSH_FXP_SETSTAT=            9;
		private const byte SSH_FXP_FSETSTAT=          10;
		private const byte SSH_FXP_OPENDIR=           11;
		private const byte SSH_FXP_READDIR=           12;
		private const byte SSH_FXP_REMOVE=            13;
		private const byte SSH_FXP_MKDIR=             14;
		private const byte SSH_FXP_RMDIR=             15;
		private const byte SSH_FXP_REALPATH=          16;
		private const byte SSH_FXP_STAT=              17;
		private const byte SSH_FXP_RENAME=            18;
		private const byte SSH_FXP_READLINK=          19;
		private const byte SSH_FXP_SYMLINK=           20;
		private const byte SSH_FXP_STATUS=           101;
		private const byte SSH_FXP_HANDLE=           102;
		private const byte SSH_FXP_DATA=             103;
		private const byte SSH_FXP_NAME=             104;
		private const byte SSH_FXP_ATTRS=            105;
		private const byte SSH_FXP_EXTENDED=         (byte)200;
		private const byte SSH_FXP_EXTENDED_REPLY=   (byte)201;

		// pflags
		private const int SSH_FXF_READ=           0x00000001;
		private const int SSH_FXF_WRITE=          0x00000002;
		private const int SSH_FXF_APPEND=         0x00000004;
		private const int SSH_FXF_CREAT=          0x00000008;
		private const int SSH_FXF_TRUNC=          0x00000010;
		private const int SSH_FXF_EXCL=           0x00000020;

		private const int SSH_FILEXFER_ATTR_SIZE=         0x00000001;
		private const int SSH_FILEXFER_ATTR_UIDGID=       0x00000002;
		private const int SSH_FILEXFER_ATTR_PERMISSIONS=  0x00000004;
		private const int SSH_FILEXFER_ATTR_ACMODTIME=    0x00000008;
		private const uint SSH_FILEXFER_ATTR_EXTENDED=     0x80000000;

		public const int SSH_FX_OK=                            0;
		public const int SSH_FX_EOF=                           1;
		public const int SSH_FX_NO_SUCH_FILE=                  2;
		public const int SSH_FX_PERMISSION_DENIED=             3;
		public const int SSH_FX_FAILURE=                       4;
		public const int SSH_FX_BAD_MESSAGE=                   5;
		public const int SSH_FX_NO_CONNECTION=                 6;
		public const int SSH_FX_CONNECTION_LOST=               7;
		public const int SSH_FX_OP_UNSUPPORTED=                8;
		/*
		   SSH_FX_OK
			  Indicates successful completion of the operation.
		   SSH_FX_EOF
			 indicates end-of-file condition; for SSH_FX_READ it means that no
			   more data is available ins the file, and for SSH_FX_READDIR it
			  indicates that no more files are contained ins the directory.
		   SSH_FX_NO_SUCH_FILE
			  is returned when a reference is made to a file which should exist
			  but doesn't.
		   SSH_FX_PERMISSION_DENIED
			  is returned when the authenticated user does not have sufficient
			  permissions to perform the operation.
		   SSH_FX_FAILURE
			  is a generic catch-all error message; it should be returned if an
			  error occurs for which there is no more specific error code
			  defined.
		   SSH_FX_BAD_MESSAGE
			  may be returned if a badly formatted packet or protocol
			  incompatibility is detected.
		   SSH_FX_NO_CONNECTION
			  is a pseudo-error which indicates that the client has no
			  connection to the server (it can only be generated locally by the
			  client, and MUST NOT be returned by servers).
		   SSH_FX_CONNECTION_LOST
			  is a pseudo-error which indicates that the connection to the
			  server has been lost (it can only be generated locally by the
			  client, and MUST NOT be returned by servers).
		   SSH_FX_OP_UNSUPPORTED
			  indicates that an attempt was made to perform an operation which
			  is not supported for the server (it may be generated locally by
			  the client if e.g.  the version number exchange indicates that a
			  required feature is not supported by the server, or it may be
			  returned by the server if the server does not implement an
			  operation).
		*/

		public const int OVERWRITE=0;
		public const int RESUME=1;
		public const int APPEND=2;

		//  private bool interactive=true;
		//private bool interactive=false;
		private int count=1;
		private Buffer buf;
		private Packet packet;

		public ChannelSftp()
		{
			packet=new Packet(buf);
		}

		private Thread currentThread=null;

		private String _version="3";
		private int server_version=3;
		/*
		10. Changes from previous protocol versions
		  The SSH File Transfer Protocol has changed over time, before it's
		   standardization.  The following is a description of the incompatible
		   changes between different versions.
		10.1 Changes between versions 3 and 2
		   o  The SSH_FXP_READLINK and SSH_FXP_SYMLINK messages were added.
		   o  The SSH_FXP_EXTENDED and SSH_FXP_EXTENDED_REPLY messages were added.
		   o  The SSH_FXP_STATUS message was changed to include fields `error
			  message' and `language tag'.
		10.2 Changes between versions 2 and 1
		   o  The SSH_FXP_RENAME message was added.
		10.3 Changes between versions 1 and 0
		   o  Implementation changes, no actual protocol changes.
		*/

		private String file_separator=Path.DirectorySeparatorChar.ToString();
		private char file_separatorc=Path.DirectorySeparatorChar;

		private String cwd;
		private String home;
		private String lcwd;

		//ChannelSftp(){}

		public override void init()
		{
			/*
			io.setStream(session.ins);
			io.setStream(session.outs);
			*/
		}

		public override void start() 
		{
			try
			{

				PipedOutputStream pos=new PipedOutputStream();
				io.setOutputStream(pos);
				PipedInputStream pis=new PipedInputStream(pos);
				io.setInputStream(pis);

				Request request=new RequestSftp();
				request.request(session, this);

				//      thread=Thread.currentThread();

				buf=new Buffer();
				packet=new Packet(buf);
				int i=0;
				//int j=0;
				int Length;
				int type;
				byte[] str;

				// send SSH_FXP_INIT
				sendINIT();

				// receive SSH_FXP_VERSION
				buf.rewind();
				i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				//System.outs.println(io+" "+io.ins+" "+io.outs);
				Length=buf.getInt();
				type=buf.getByte();           // 2 -> SSH_FXP_VERSION
				server_version=buf.getInt();
				//System.outs.println("SFTP protocol server-version="+server_version);

				// send SSH_FXP_REALPATH
				sendREALPATH(Util.getBytes("."));

				// receive SSH_FXP_NAME
				buf.rewind();
				i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				Length=buf.getInt();
				type=buf.getByte();          // 104 -> SSH_FXP_NAME
				buf.getInt();                //
				i=buf.getInt();              // count
				str=buf.getString();         // filename
				home=cwd=Util.getString(str);
				str=buf.getString();         // logname
				//    SftpATTRS.getATTR(buf);           // attrs

				//lcwd=new File(".").getAbsolutePath();
				//lcwd=new File(".").getCanonicalPath();
				lcwd=Path.GetFullPath(".");

			}
			catch(Exception e)
			{
				//System.outs.println(e);
				if(e is JSchException) throw (JSchException)e;
				throw new JSchException(e.ToString());
			}
		}

		public void quit(){ disconnect();}
		public void exit(){ disconnect();}
		public void lcd(String path)
		{
			//    if(!path.StartsWith("/")){ path=lcwd+file_separator+path; }
			if(!isLocalAbsolutePath(path)){ path=lcwd+file_separator+path; }
			if(Directory.Exists(path))
			{
				try
				{
					//path=(new File(path)).getAbsolutePath();
					path=Path.GetFullPath(path);
				}
				catch{}//(Exception e){}
				lcwd=path;
				return;
			}
			throw new SftpException(SSH_FX_NO_SUCH_FILE, "No such directory");
		}

		/*
			cd /tmp
			c->s REALPATH
			s->c NAME
			c->s STAT
			s->c ATTR 
		*/
		public void cd(String path) 
		{
			try
			{
				if(!path.StartsWith("/")){ path=cwd+"/"+path; }

				ArrayList v=glob_remote(path);
				if(v.Count!=1)
				{
					throw new SftpException(SSH_FX_FAILURE, v.ToString());
				}
				path=(String)(v[0]);

				sendREALPATH(Util.getBytes(path));

				buf.rewind();
				int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				int Length=buf.getInt();
				int type=buf.getByte();
				if(type!=101 && type!=104)
				{
					throw new SftpException(SSH_FX_FAILURE, "");
				}
				if(type==101)
				{
					buf.getInt();
					i=buf.getInt();
					throwStatusError(buf, i);
					//	byte[] str=buf.getString();
					//	throw new SftpException(i, Util.getString(str));
				}
				buf.getInt();
				i=buf.getInt();
				byte[] str=buf.getString();
				if(str!=null && str[0]!='/')
				{
					str=Util.getBytes(cwd+"/"+Util.getString(str));
				}
				cwd=Util.getString(str);
				str=buf.getString();         // logname
				i=buf.getInt();              // attrs
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}

		/*
			put foo
			c->s OPEN
			s->c HANDLE
			c->s WRITE
			s->c STATUS
			c->s CLOSE 
			s->c STATUS 
		*/
		public void put(String src, String dst) 
		{
			put(src, dst, null, OVERWRITE);
		}
		public void put(String src, String dst, int mode) 
		{
			put(src, dst, null, mode);
		}
		public void put(String src, String dst, 
			SftpProgressMonitor monitor) 
		{
			put(src, dst, monitor, OVERWRITE);
		}
		public void put(String src, String dst, 
			SftpProgressMonitor monitor, int mode) 
		{
			//    if(!src.StartsWith("/")){ src=lcwd+file_separator+src; } 
			if(!isLocalAbsolutePath(src)){ src=lcwd+file_separator+src; } 
			if(!dst.StartsWith("/")){ dst=cwd+"/"+dst; }
			//System.outs.println("src: "+src+", "+dst);
			try
			{
				ArrayList v=glob_remote(dst);
				if(v.Count!=1)
				{
					throw new SftpException(SSH_FX_FAILURE, v.ToString());
				}
				dst=(String)(v[0]);

				bool _isRemoteDir=isRemoteDir(dst);

				v=glob_local(src);
				//System.outs.println("glob_local: "+v+" dst="+dst);
				for(int j=0; j<v.Count; j++)
				{
					String _src=(String)(v[j]);
					String _dst=dst;
					if(_isRemoteDir)
					{
						if(!_dst.EndsWith("/"))
						{
							_dst+="/";
						}
						int i=_src.LastIndexOf(file_separatorc);
						if(i==-1) _dst+=_src;
						else _dst+=_src.Substring(i+1);
					}

					//System.outs.println("_dst "+_dst);

					long size_of_dst=0;
					if(mode==RESUME)
					{
						try
						{
							SftpATTRS attr=stat(_dst);
							size_of_dst=attr.getSize();
						}
						catch
						{//(Exception eee){
							//System.outs.println(eee);
						}
						long size_of_src=new FileInfo(_src).Length;
						if(size_of_src<size_of_dst)
						{
							throw new SftpException(SSH_FX_FAILURE, "failed to resume for "+_dst);
						}
						if(size_of_src==size_of_dst)
						{
							return;
						}
					}

					if(monitor!=null)
					{
						monitor.init(SftpProgressMonitor.PUT, _src, _dst,
							(new FileInfo(_src)).Length);
						if(mode==RESUME)
						{
							monitor.count(size_of_dst);
						}
					}
					FileStream fis=null;
					try
					{
						fis=File.OpenRead(_src);
						put(fis, _dst, monitor, mode);
					}
					finally
					{
						if(fis!=null) 
						{
							//	    try{
							fis.Close();
							//	    }catch(Exception ee){};
						}
					}
				}
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}
		public void put(Stream src, String dst) 
		{
			put(src, dst, null, OVERWRITE);
		}
		public void put(Stream src, String dst, int mode) 
		{
			put(src, dst, null, mode);
		}
		public void put(Stream src, String dst, 
			SftpProgressMonitor monitor) 
		{
			put(src, dst, monitor, OVERWRITE);
		}
		public void put(Stream src, String dst, 
			SftpProgressMonitor monitor, int mode) 
		{
			try
			{
				if(!dst.StartsWith("/")){ dst=cwd+"/"+dst; } 
				ArrayList v=glob_remote(dst);
				if(v.Count!=1)
				{
					throw new SftpException(SSH_FX_FAILURE, v.ToString());
				}
				dst=(String)(v[0]);
				if(isRemoteDir(dst))
				{
					throw new SftpException(SSH_FX_FAILURE, dst+" is a directory");
				}

				long skip=0;
				if(mode==RESUME || mode==APPEND)
				{
					try
					{
						SftpATTRS attr=stat(dst);
						skip=attr.getSize();
					}
					catch
					{//(Exception eee){
						//System.outs.println(eee);
					}
				}

				if(mode==RESUME && skip>0)
				{
					long skipped=src.Seek(skip, SeekOrigin.Current);
					if(skipped<skip)
					{
						throw new SftpException(SSH_FX_FAILURE, "failed to resume for "+dst);
					}
				}

				if(mode==OVERWRITE)
				{
					sendOPENW(Util.getBytes(dst));
				}
				else
				{
					sendOPENA(Util.getBytes(dst));
				}

				buf.rewind();
				int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				int Length=buf.getInt();
				int type=buf.getByte();
				if(type!=SSH_FXP_STATUS && type!=SSH_FXP_HANDLE)
				{
					throw new SftpException(SSH_FX_FAILURE, "");
				}
				if(type==SSH_FXP_STATUS)
				{
					buf.getInt();
					i=buf.getInt();
					throwStatusError(buf, i);
				}
				buf.getInt();
				byte[] handle=buf.getString();         // filename
				byte[] data=new byte[1024];

				long offset=0;
				if(mode==RESUME || mode==APPEND)
				{
					offset+=skip;
				}
				while(true)
				{
					i=src.Read(data, 0, 1024);
					if(i<=0)break;
					sendWRITE(handle, offset, data, 0, i);
					offset+=i;

					buf.rewind();
					io.ins.Read(buf.buffer, 0, buf.buffer.Length);
					Length=buf.getInt();
					type=buf.getByte();
					if(type!=SSH_FXP_STATUS){ break;}
					buf.getInt();
					if(buf.getInt()!=SSH_FX_OK)
					{
						//System.outs.println("getInt="+buf.getInt());
						break;
					}

					if(monitor!=null)
					{
						if(!monitor.count(i))
						{
							break;
						}
					}

				}

				sendCLOSE(handle);
				//System.outs.println("done");
				if(monitor!=null)monitor.end();

				buf.rewind();
				i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				Length=buf.getInt();
				type=buf.getByte();
				if(type!=SSH_FXP_STATUS)
				{
					throw new SftpException(SSH_FX_FAILURE, "");
				}
				buf.getInt();
				i=buf.getInt();
				if(i==SSH_FX_OK) return;
				throwStatusError(buf, i);
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}
		/**/
		public Stream put(String dst) 
		{
			return put(dst, (SftpProgressMonitor)null, OVERWRITE);
		}
		public Stream put(String dst, int mode) 
		{
			return put(dst, (SftpProgressMonitor)null, mode);
		}
		public Stream put(String dst, SftpProgressMonitor monitor, int mode) 
		{
			if(!dst.StartsWith("/")){ dst=cwd+"/"+dst; } 
			try
			{
				ArrayList v=glob_remote(dst);
				if(v.Count!=1)
				{
					throw new SftpException(SSH_FX_FAILURE, v.ToString());
				}
				dst=(String)(v[0]);
				if(isRemoteDir(dst))
				{
					throw new SftpException(SSH_FX_FAILURE, dst+" is a directory");
				}
				Tamir.Streams.PipedOutputStream pos=new Tamir.Streams.PipedOutputStream();

				Tamir.Streams.PipedInputStream pis=new Tamir.Streams.PipedInputStream(pos);
				ChannelSftp channel=this;
				String _dst=dst;
				runnable1 runnable = new runnable1(channel, pis, _dst, monitor, mode);
				currentThread=new Thread(new ThreadStart(runnable.run));
				currentThread.Start();
				return pos;
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}

		public class runnable1
		{
			ChannelSftp channel;
			PipedInputStream pis;
			String _dst;
			SftpProgressMonitor monitor;
			int mode;
			public runnable1(ChannelSftp channel, PipedInputStream pis, String _dst, SftpProgressMonitor monitor, int mode)
			{
				this.channel= channel;
				this.pis=pis;
				this._dst=_dst;
				this.monitor=monitor;
				this.mode=mode;

			}
			public void run()
			{
				try{ channel.put(pis, _dst, monitor, mode); }
				catch(Exception ee)
				{
					Console.WriteLine("!!"+ee);
				}
				try{ pis.close(); }
				catch{}//(Exception ee){}
			}
		}
		/**/
		public void get(String src, String dst) 
		{
			get(src, dst, null, OVERWRITE);
		}
		public void get(String src, String dst,
			SftpProgressMonitor monitor) 
		{
			get(src, dst, monitor, OVERWRITE);
		}
		public void get(String src, String dst,
			SftpProgressMonitor monitor, int mode) 
		{
			if(!src.StartsWith("/")){ src=cwd+"/"+src; } 
			//    if(!dst.StartsWith("/")){ dst=lcwd+file_separator+dst; } 
			if(!isLocalAbsolutePath(dst)){ dst=lcwd+file_separator+dst; } 
			try
			{
				ArrayList v=glob_remote(src);
				for(int j=0; j<v.Count; j++)
				{
					String _dst=dst;
					String _src=(String)(v[j]);
					if(Directory.Exists(_dst))
					{
						if(!_dst.EndsWith(file_separator))
						{
							_dst+=file_separator;
						}
						int i=_src.LastIndexOf('/');
						if(i==-1) _dst+=src;
						else _dst+=_src.Substring(i+1);
					}

					SftpATTRS attr=stat(_src);
					if(mode==RESUME)
					{
						long size_of_src=attr.getSize();
						long size_of_dst=new FileInfo(_dst).Length;
						if(size_of_dst>size_of_src)
						{
							throw new SftpException(SSH_FX_FAILURE, "failed to resume for "+_dst);
						}
						if(size_of_dst==size_of_src)
						{
							return;
						}
					}

					if(monitor!=null)
					{
						monitor.init(SftpProgressMonitor.GET, _src, _dst, attr.getSize());
						if(mode==RESUME)
						{
							monitor.count(new FileInfo(_dst).Length);
						}
					}
					FileStream fos=null;
					if(mode==OVERWRITE)
					{
						fos=File.OpenWrite(_dst);
					}
					else
					{
						fos=new FileStream(_dst, FileMode.Append); // append
					}
					get(_src, fos, monitor, mode, new FileInfo(_dst).Length);
					fos.Close();
				}
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}
		public void get(String src, Stream dst) 
		{
			get(src, dst, null, OVERWRITE, 0);
		}
		public void get(String src, Stream dst,
			SftpProgressMonitor monitor) 
		{
			get(src, dst, monitor, OVERWRITE, 0);
		}
		private void get(String src, Stream dst,
			SftpProgressMonitor monitor, int mode, long skip) 
		{
			//System.outs.println("get: "+src+", "+dst);
			try
			{
				if(!src.StartsWith("/")){ src=cwd+"/"+src; } 
				ArrayList v=glob_remote(src);
				if(v.Count!=1)
				{
					throw new SftpException(SSH_FX_FAILURE, v.ToString());
				}
				src=(String)(v[0]);

				sendOPENR(Util.getBytes(src));
				buf.rewind();
				int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				int Length=buf.getInt();
				int type=buf.getByte();
				if(type!=SSH_FXP_STATUS && type!=SSH_FXP_HANDLE)
				{
					throw new SftpException(SSH_FX_FAILURE, "");
				}
				if(type==SSH_FXP_STATUS)
				{
					buf.getInt();
					i=buf.getInt();
					throwStatusError(buf, i);
				}
				buf.getInt();
				byte[] handle=buf.getString();         // filename

				byte[] data=null;
				int[] data_start=new int[1];
				int[] data_len=new int[1];

				long offset=0;
				if(mode==RESUME)
				{
					offset+=skip;
				}
				while(true)
				{
					sendREAD(handle, offset, 1000);
					buf.rewind();
					i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
					Length=buf.getInt();
					type=buf.getByte();
					buf.getInt();
					if(type!=SSH_FXP_STATUS && type!=SSH_FXP_DATA){ break;}
					if(type==SSH_FXP_STATUS)
					{
						i=buf.getInt();
						if(i==SSH_FX_EOF)
						{
							break;
						}
						throwStatusError(buf, i);
					}
					data=buf.getString(data_start, data_len);
					dst.Write(data, data_start[0], data_len[0]);
					dst.Flush();
					if(monitor!=null)
					{
						if(!monitor.count(data_len[0]))
						{
							break;
						}
					}
					offset+=data_len[0];
				}
				sendCLOSE(handle);

				if(monitor!=null)
				{
					monitor.end();
				}

				buf.rewind();
				i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				Length=buf.getInt();
				type=buf.getByte();
				if(type!=SSH_FXP_STATUS)
				{
					throw new SftpException(SSH_FX_FAILURE, "");
				}
				buf.getInt();
				i=buf.getInt();
				if(i==SSH_FX_OK) return;
				throwStatusError(buf, i);
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}
		/**/
		public Stream get(String src) 
		{
			return get(src, null, OVERWRITE);
		}
		public Stream get(String src, int mode) 
		{
			return get(src, null, mode);
		}
		public Stream get(String src, SftpProgressMonitor monitor, int mode) 
		{
			if(mode==RESUME)
			{
				throw new SftpException(SSH_FX_FAILURE, "faile to resume from "+src);
			}
			if(!src.StartsWith("/")){ src=cwd+"/"+src; } 
			try
			{
				ArrayList v=glob_remote(src);
				if(v.Count!=1)
				{
					throw new SftpException(SSH_FX_FAILURE, v.ToString());
				}
				src=(String)(v[0]);

				SftpATTRS attr=stat(src);

				PipedInputStream pis=new PipedInputStream();
				PipedOutputStream pos=new PipedOutputStream(pis);
				ChannelSftp channel=this;
				String _src=src;

				if(attr.getSize()<=0)
				{
					try{ pos.Close(); }
					catch{}//(Exception ee){}
					return pis;
				}

				Exception[] closed=new Exception[1];
				closed[0]=null;
				runnable2 runnable2 = new runnable2(channel, pos, _src, monitor, mode, closed);
				(new Thread(new ThreadStart(runnable2.run))).Start();
				while(true)
				{
					if(pis.available()!=0)break;
					if(closed[0]!=null)
					{
						throw closed[0];
					}
					//	System.outs.println("pis wait");
					Thread.Sleep(1000);
				}
				return pis;
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}

		public class runnable2
		{
			ChannelSftp channel;
			PipedOutputStream pos;
			String _src;
			SftpProgressMonitor monitor;
			int mode;
			Exception[] closed;
			public runnable2(ChannelSftp channel, PipedOutputStream pos, String _src, SftpProgressMonitor monitor, int mode, Exception[] closed)
			{
				this.channel= channel;
				this.pos=pos;
				this._src=_src;
				this.monitor=monitor;
				this.mode=mode;
				this.closed=closed;

			}
			public void run()
			{
				try{ channel.get(_src, pos, monitor, mode, (long)0); }
				catch(Exception ee)
				{
					//System.outs.println("!!"+ee);
					closed[0]=ee;
					//	      try{ pis.close(); }catch(Exception eee){}
				}
				//System.outs.println("channel.get end");
				try{ pos.close(); }
				catch{}//(Exception ee){}
				//System.outs.println("pos.close end");
			}
		}
		/**/
		public ArrayList ls(String path) 
		{
			try
			{
				if(!path.StartsWith("/")){ path=cwd+"/"+path; }

				String dir=path;
				byte[] pattern=null;
				if(!isRemoteDir(dir))
				{
					int foo=path.LastIndexOf('/');
					dir=path.Substring(0, foo);
					pattern=Util.getBytes(path.Substring(foo+1));
				}

				sendOPENDIR(Util.getBytes(dir));

				buf.rewind();
				int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				int Length=buf.getInt();
				int type=buf.getByte();
				if(type!=SSH_FXP_STATUS && type!=SSH_FXP_HANDLE)
				{
					throw new SftpException(SSH_FX_FAILURE, "");
				}
				if(type==SSH_FXP_STATUS)
				{
					buf.getInt();
					i=buf.getInt();
					throwStatusError(buf, i);
				}
				buf.getInt();
				byte[] handle=buf.getString();         // filename

				ArrayList v=new ArrayList();
				while(true)
				{
					sendREADDIR(handle);
					buf.rewind();
					i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
					buf.index=i;
					Length=buf.getInt();
					Length=Length-(i-4);
					type=buf.getByte();

					if(type!=SSH_FXP_STATUS && type!=SSH_FXP_NAME)
					{
						throw new SftpException(SSH_FX_FAILURE, "");
					}
					if(type==SSH_FXP_STATUS)
					{ 
						/*
						buf.getInt();
						i=buf.getInt();
						System.outs.println("i="+i);
						if(i==SSH_FX_EOF) break;
						byte[] str=buf.getString();
						throw new SftpException(i, Util.getString(str));
						*/
						break;
					}

					buf.getInt();
					int count=buf.getInt();

					byte[] str;
					//int flags;

					while(count>0)
					{
						if(Length>0)
						{
							buf.shift();
							i=io.ins.Read(buf.buffer, buf.index, buf.buffer.Length-buf.index);
							if(i<=0)break;
							buf.index+=i;
							Length-=i;
						}

						byte[] filename=buf.getString();
						// System.outs.println("filename: "+Util.getString(filename));
						str=buf.getString();
						String longname=Util.getString(str);
						// System.outs.println("longname: "+longname);

						SftpATTRS attrs=SftpATTRS.getATTR(buf);
						if(pattern==null || Util.glob(pattern, filename))
						{
							v.Add(longname);
							//	    v.Add(new Ssh_exp_name(Util.getString(filename), longname, attrs));
						}

						count--; 
					}
				}

				sendCLOSE(handle);
				buf.rewind();
				i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				Length=buf.getInt();
				type=buf.getByte();
				if(type!=SSH_FXP_STATUS)
				{
					throw new SftpException(SSH_FX_FAILURE, "");
				}
				buf.getInt();
				i=buf.getInt();
				if(i==SSH_FX_OK) return v;
				throwStatusError(buf, i);
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
			return null;
		}
		public void symlink(String oldpath, String newpath) 
		{
			if(server_version<3)
			{
				throw new SftpException(SSH_FX_FAILURE, 
					"The remote sshd is too old to support symlink operation.");
			}

			try
			{
				if(!oldpath.StartsWith("/")){ oldpath=cwd+"/"+oldpath; } 
				if(!newpath.StartsWith("/")){ newpath=cwd+"/"+newpath; } 

				ArrayList v=glob_remote(oldpath);
				if(v.Count!=1)
				{
					throw new SftpException(SSH_FX_FAILURE, v.ToString());
				}
				oldpath=(String)(v[0]);

				sendSYMLINK(Util.getBytes(oldpath),Util.getBytes( newpath));
				buf.rewind();
				int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				int Length=buf.getInt();
				int type=buf.getByte();
				if(type!=SSH_FXP_STATUS)
				{
					throw new SftpException(SSH_FX_FAILURE, "");
				}
				buf.getInt();
				i=buf.getInt();
				if(i==SSH_FX_OK) return;
				throwStatusError(buf, i);
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}
		public void rename(String oldpath, String newpath) 
		{
			if(server_version<2)
			{
				throw new SftpException(SSH_FX_FAILURE, 
					"The remote sshd is too old to support rename operation.");
			}
			try
			{
				if(!oldpath.StartsWith("/")){ oldpath=cwd+"/"+oldpath; } 
				if(!newpath.StartsWith("/")){ newpath=cwd+"/"+newpath; } 

				ArrayList v=glob_remote(oldpath);
				if(v.Count!=1)
				{
					throw new SftpException(SSH_FX_FAILURE, v.ToString());
				}
				oldpath=(String)(v[0]);

				v=glob_remote(newpath);
				if(v.Count>=2)
				{
					throw new SftpException(SSH_FX_FAILURE, v.ToString());
				}
				if(v.Count==1)
				{
					newpath=(String)(v[0]);
				}

				sendRENAME(Util.getBytes(oldpath), Util.getBytes(newpath));
				buf.rewind();
				int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				int Length=buf.getInt();
				int type=buf.getByte();
				if(type!=SSH_FXP_STATUS)
				{
					throw new SftpException(SSH_FX_FAILURE, "");
				}
				buf.getInt();
				i=buf.getInt();
				if(i==SSH_FX_OK) return;
				throwStatusError(buf, i);
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}
		public void rm(String path) 
		{
			try
			{
				if(!path.StartsWith("/")){ path=cwd+"/"+path; }
				ArrayList v=glob_remote(path);
				for(int j=0; j<v.Count; j++)
				{
					path=(String)(v[j]);
					sendREMOVE(Util.getBytes(path));
					buf.rewind();
					int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
					int Length=buf.getInt();
					int type=buf.getByte();
					if(type!=SSH_FXP_STATUS)
					{
						throw new SftpException(SSH_FX_FAILURE, "");
					}
					buf.getInt();
					i=buf.getInt();
					if(i!=SSH_FX_OK)
					{
						throwStatusError(buf, i);
					}
				}
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}
		bool isRemoteDir(String path)
		{
			try
			{
				sendSTAT(Util.getBytes(path));
				buf.rewind();
				int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				int Length=buf.getInt();
				int type=buf.getByte();
				if(type!=SSH_FXP_ATTRS){ return false; }
				buf.getInt();
				SftpATTRS attr=SftpATTRS.getATTR(buf);
				return attr.isDir();
			}
			catch{}//(Exception e){}
			return false;
		}
		public void chgrp(int gid, String path) 
		{
			try
			{
				if(!path.StartsWith("/")){ path=cwd+"/"+path; }

				ArrayList v=glob_remote(path);
				for(int j=0; j<v.Count; j++)
				{
					path=(String)(v[j]);
					sendSTAT(Util.getBytes(path));
 
					buf.rewind();
					int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
					int Length=buf.getInt();
					int type=buf.getByte();
					if(type!=SSH_FXP_ATTRS)
					{
						throw new SftpException(SSH_FX_FAILURE, "");
					}
					buf.getInt();
					SftpATTRS attr=SftpATTRS.getATTR(buf);
					attr.setUIDGID(attr.uid, gid); 
					_setStat(path, attr);
				}
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}
		public void chown(int uid, String path) 
		{
			try
			{
				if(!path.StartsWith("/")){ path=cwd+"/"+path; }

				ArrayList v=glob_remote(path);
				for(int j=0; j<v.Count; j++)
				{
					path=(String)(v[j]);

					sendSTAT(Util.getBytes(path));
 
					buf.rewind();
					int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
					int Length=buf.getInt();
					int type=buf.getByte();
					if(type!=SSH_FXP_ATTRS)
					{
						throw new SftpException(SSH_FX_FAILURE, "");
					}
					buf.getInt();
					SftpATTRS attr=SftpATTRS.getATTR(buf);
					attr.setUIDGID(uid, attr.gid); 
					_setStat(path, attr);
				}
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}
		public void chmod(int permissions, String path) 
		{
			try
			{
				if(!path.StartsWith("/")){ path=cwd+"/"+path; }

				ArrayList v=glob_remote(path);
				for(int j=0; j<v.Count; j++)
				{
					path=(String)(v[j]);

					sendSTAT(Util.getBytes(path));
 
					buf.rewind();
					int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
					int Length=buf.getInt();
					int type=buf.getByte();
					if(type!=SSH_FXP_ATTRS)
					{
						throw new SftpException(SSH_FX_FAILURE, "");
					}
					buf.getInt();
					SftpATTRS attr=SftpATTRS.getATTR(buf);
					attr.setPERMISSIONS(permissions); 
					_setStat(path, attr);
				}
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}
		public void setMtime(String path, int mtime) 
		{
			try
			{
				if(!path.StartsWith("/")){ path=cwd+"/"+path; }

				ArrayList v=glob_remote(path);
				for(int j=0; j<v.Count; j++)
				{
					path=(String)(v[j]);
					sendSTAT(Util.getBytes(path));
					buf.rewind();
					int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
					int Length=buf.getInt();
					int type=buf.getByte();
					if(type!=SSH_FXP_ATTRS)
					{
						throw new SftpException(SSH_FX_FAILURE, "");
					}
					buf.getInt();
					SftpATTRS attr=SftpATTRS.getATTR(buf);
					attr.setACMODTIME(attr.getATime(), mtime);
					_setStat(path, attr);
				}
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}
		public void rmdir(String path) 
		{
			try
			{
				if(!path.StartsWith("/")){ path=cwd+"/"+path; }
				ArrayList v=glob_remote(path);
				for(int j=0; j<v.Count; j++)
				{
					path=(String)(v[j]);

					sendRMDIR(Util.getBytes(path));
					buf.rewind();
					int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
					int Length=buf.getInt();
					int type=buf.getByte();
					if(type!=SSH_FXP_STATUS)
					{
						throw new SftpException(SSH_FX_FAILURE, "");
					}
					buf.getInt();
					i=buf.getInt();
					if(i!=SSH_FX_OK)
					{
						throwStatusError(buf, i);
					}
				}
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}

		public void mkdir(String path) 
		{
			try
			{
				if(!path.StartsWith("/")){ path=cwd+"/"+path; }
				sendMKDIR(Util.getBytes(path), null);
				buf.rewind();
				int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				int Length=buf.getInt();
				int type=buf.getByte();
				if(type!=SSH_FXP_STATUS)
				{
					throw new SftpException(SSH_FX_FAILURE, "");
				}
				buf.getInt();
				i=buf.getInt();
				if(i==SSH_FX_OK) return;
				throwStatusError(buf, i);
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}

		public SftpATTRS stat(String path) 
		{
			try
			{
				if(!path.StartsWith("/")){ path=cwd+"/"+path; }
				sendSTAT(Util.getBytes(path));
				buf.rewind();
				int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				int Length=buf.getInt();
				int type=buf.getByte();
				if(type!=SSH_FXP_ATTRS)
				{
					if(type==SSH_FXP_STATUS)
					{
						buf.getInt();
						i=buf.getInt();
						throwStatusError(buf, i);
					}
					throw new SftpException(SSH_FX_FAILURE, "");
				}
				buf.getInt();
				SftpATTRS attr=SftpATTRS.getATTR(buf);
				return attr;
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
			//return null;
		}
		public SftpATTRS lstat(String path) 
		{
			try
			{
				if(!path.StartsWith("/")){ path=cwd+"/"+path; }
				sendLSTAT(Util.getBytes(path));
				buf.rewind();
				int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				int Length=buf.getInt();
				int type=buf.getByte();
				if(type!=SSH_FXP_ATTRS)
				{
					if(type==SSH_FXP_STATUS)
					{
						buf.getInt();
						i=buf.getInt();
						throwStatusError(buf, i);
					}
					throw new SftpException(SSH_FX_FAILURE, "");
				}
				buf.getInt();
				SftpATTRS attr=SftpATTRS.getATTR(buf);
				return attr;
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}
		public void setStat(String path, SftpATTRS attr) 
		{
			try
			{
				if(!path.StartsWith("/")){ path=cwd+"/"+path; }
				ArrayList v=glob_remote(path);
				for(int j=0; j<v.Count; j++)
				{
					path=(String)(v[j]);
					_setStat(path, attr);
				}
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}
		private void _setStat(String path, SftpATTRS attr) 
		{
			try
			{
				sendSETSTAT(Util.getBytes(path), attr);

				buf.rewind();
				int i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				int Length=buf.getInt();
				int type=buf.getByte();
				if(type!=SSH_FXP_STATUS)
				{
					throw new SftpException(SSH_FX_FAILURE, "");
				}
				buf.getInt();
				i=buf.getInt();
				if(i!=SSH_FX_OK)
				{
					throwStatusError(buf, i);
				}
			}
			catch(Exception e)
			{
				if(e is SftpException) throw (SftpException)e;
				throw new SftpException(SSH_FX_FAILURE, "");
			}
		}

		public String pwd(){ return cwd; }
		public String lpwd(){ return lcwd; }
		public String version(){ return _version; }

		private void sendINIT()
		{
			packet.reset();
			putHEAD(SSH_FXP_INIT, 5);
			buf.putInt(3);                // version 3
			session.write(packet, this, 5+4);
		}

		private void sendREALPATH(byte[] path) 
		{
			sendPacketPath(SSH_FXP_REALPATH, path);
		}
		private void sendSTAT(byte[] path) 
		{
			sendPacketPath(SSH_FXP_STAT, path);
		}
		private void sendLSTAT(byte[] path) 
		{
			sendPacketPath(SSH_FXP_LSTAT, path);
		}
		private void sendFSTAT(byte[] handle) 
		{
			sendPacketPath(SSH_FXP_FSTAT, handle);
		}
		private void sendSETSTAT(byte[] path, SftpATTRS attr) 
		{
			packet.reset();
			putHEAD(SSH_FXP_SETSTAT, 9+path.Length+attr.length());
			buf.putInt(count++);
			buf.putString(path);             // path
			attr.dump(buf);
			session.write(packet, this, 9+path.Length+attr.length()+4);
		}
		private void sendREMOVE(byte[] path) 
		{
			sendPacketPath(SSH_FXP_REMOVE, path);
		}
		private void sendMKDIR(byte[] path, SftpATTRS attr) 
		{
			packet.reset();
			putHEAD(SSH_FXP_MKDIR, 9+path.Length+(attr!=null?attr.length():4));
			buf.putInt(count++);
			buf.putString(path);             // path
			if(attr!=null) attr.dump(buf);
			else buf.putInt(0);
			session.write(packet, this, 9+path.Length+(attr!=null?attr.length():4)+4);
		}
		private void sendRMDIR(byte[] path) 
		{
			sendPacketPath(SSH_FXP_RMDIR, path);
		}
		private void sendSYMLINK(byte[] p1, byte[] p2) 
		{
			sendPacketPath(SSH_FXP_SYMLINK, p1, p2);
		}
		private void sendREADLINK(byte[] path) 
		{
			sendPacketPath(SSH_FXP_READLINK, path);
		}
		private void sendOPENDIR(byte[] path) 
		{
			sendPacketPath(SSH_FXP_OPENDIR, path);
		}
		private void sendREADDIR(byte[] path) 
		{
			sendPacketPath(SSH_FXP_READDIR, path);
		}
		private void sendRENAME(byte[] p1, byte[] p2) 
		{
			sendPacketPath(SSH_FXP_RENAME, p1, p2);
		}
		private void sendCLOSE(byte[] path) 
		{
			sendPacketPath(SSH_FXP_CLOSE, path);
		}
		private void sendOPENR(byte[] path) 
		{
			sendOPEN(path, SSH_FXF_READ);
		}
		private void sendOPENW(byte[] path) 
		{
			sendOPEN(path, SSH_FXF_WRITE|SSH_FXF_CREAT|SSH_FXF_TRUNC);
		}
		private void sendOPENA(byte[] path) 
		{
			sendOPEN(path, SSH_FXF_WRITE|/*SSH_FXF_APPEND|*/SSH_FXF_CREAT);
		}
		private void sendOPEN(byte[] path, int mode) 
		{
			packet.reset();
			putHEAD(SSH_FXP_OPEN, 17+path.Length);
			buf.putInt(count++);
			buf.putString(path);
			buf.putInt(mode);
			buf.putInt(0);           // attrs
			session.write(packet, this, 17+path.Length+4);
		}
		private void sendPacketPath(byte fxp, byte[] path) 
		{
			packet.reset();
			putHEAD(fxp, 9+path.Length);
			buf.putInt(count++);
			buf.putString(path);             // path
			session.write(packet, this, 9+path.Length+4);
		}
		private void sendPacketPath(byte fxp, byte[] p1, byte[] p2) 
		{
			packet.reset();
			putHEAD(fxp, 13+p1.Length+p2.Length);
			buf.putInt(count++);
			buf.putString(p1);
			buf.putString(p2);
			session.write(packet, this, 13+p1.Length+p2.Length+4);
		}

		private void sendWRITE(byte[] handle, long offset, 
			byte[] data, int start, int Length) 
		{
			packet.reset();
			putHEAD(SSH_FXP_WRITE, 21+handle.Length+Length);
			buf.putInt(count++);
			buf.putString(handle);
			buf.putLong(offset);
			buf.putString(data, start, Length);
			session.write(packet, this, 21+handle.Length+Length+4);
		}

		private void sendREAD(byte[] handle, long offset, int Length) 
		{
			packet.reset();
			putHEAD(SSH_FXP_READ, 21+handle.Length);
			buf.putInt(count++);
			buf.putString(handle);
			buf.putLong(offset);
			buf.putInt(Length);
			session.write(packet, this, 21+handle.Length+4);
		}

		private void putHEAD(byte type, int Length) 
		{
			buf.putByte((byte)Session.SSH_MSG_CHANNEL_DATA);
			buf.putInt(recipient);
			buf.putInt(Length+4);
			buf.putInt(Length);
			buf.putByte(type);
		}
		private ArrayList glob_remote(String _path) 
		{
			//System.outs.println("glob_remote: "+_path);
			ArrayList v=new ArrayList();
			byte[] path=Util.getBytes(_path);
			int i=path.Length-1;
			while(i>=0){if(path[i]=='*' || path[i]=='?')break;i--;}
			if(i<0){ v.Add(_path); return v;}
			while(i>=0){if(path[i]=='/')break;i--;}
			if(i<0){ v.Add(_path); return v;}
			byte[] dir;
			if(i==0){dir=new byte[]{(byte)'/'};}
			else
			{ 
				dir=new byte[i];
				Array.Copy(path, 0, dir, 0, i);
			}
			//System.outs.println("dir: "+Util.getString(dir));
			byte[] pattern=new byte[path.Length-i-1];
			Array.Copy(path, i+1, pattern, 0, pattern.Length);
			//System.outs.println("file: "+Util.getString(pattern));

			sendOPENDIR(dir);

			buf.rewind();
			i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
			int Length=buf.getInt();
			int type=buf.getByte();
			if(type!=SSH_FXP_STATUS && type!=SSH_FXP_HANDLE)
			{
				throw new SftpException(SSH_FX_FAILURE, "");
			}
			if(type==SSH_FXP_STATUS)
			{
				buf.getInt();
				i=buf.getInt();
				throwStatusError(buf, i);
			}
			buf.getInt();
			byte[] handle=buf.getString();         // filename

			while(true)
			{
				sendREADDIR(handle);
				buf.rewind();
				i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
				buf.index=i;
				Length=buf.getInt();
				Length=Length-(i-4);
				type=buf.getByte();

				if(type!=SSH_FXP_STATUS && type!=SSH_FXP_NAME)
				{
					throw new SftpException(SSH_FX_FAILURE, "");
				}
				if(type==SSH_FXP_STATUS)
				{ 
					break;
				}

				buf.getInt();
				int count=buf.getInt();

				byte[] str;
				//int flags;

				while(count>0)
				{
					if(Length>0)
					{
						buf.shift();
						i=io.ins.Read(buf.buffer, buf.index, buf.buffer.Length-buf.index);
						if(i<=0)break;
						buf.index+=i;
						Length-=i;
					}

					byte[] filename=buf.getString();
					//System.outs.println("filename: "+Util.getString(filename));
					str=buf.getString();
					SftpATTRS attrs=SftpATTRS.getATTR(buf);

					if(Util.glob(pattern, filename))
					{
						v.Add(Util.getString(dir)+"/"+Util.getString(filename));
					}

					count--; 
				}
			}

			sendCLOSE(handle);
			buf.rewind();
			i=io.ins.Read(buf.buffer, 0, buf.buffer.Length);
			Length=buf.getInt();
			type=buf.getByte();
			if(type!=SSH_FXP_STATUS)
			{
				throw new SftpException(SSH_FX_FAILURE, "");
			}
			buf.getInt();
			i=buf.getInt();
			if(i==SSH_FX_OK) return v;

			return null;
		}

		private ArrayList glob_local(String _path) 
		{
			//System.outs.println("glob_local: "+_path);
			ArrayList v=new ArrayList();
			byte[] path=Util.getBytes(_path);
			int i=path.Length-1;
			while(i>=0){if(path[i]=='*' || path[i]=='?')break;i--;}
			if(i<0){ v.Add(_path); return v;}
			while(i>=0){if(path[i]==file_separatorc)break;i--;}
			if(i<0){ v.Add(_path); return v;}
			byte[] dir;
			if(i==0){dir=new byte[]{(byte)file_separatorc};}
			else
			{ 
				dir=new byte[i];
				Array.Copy(path, 0, dir, 0, i);
			}
			byte[] pattern=new byte[path.Length-i-1];
			Array.Copy(path, i+1, pattern, 0, pattern.Length);
			//System.outs.println("dir: "+dir+" pattern: "+pattern);
			try
			{
				String[] children=(Directory.GetDirectories(Util.getString(dir)));
				for(int j=0; j<children.Length; j++)
				{
					//System.outs.println("children: "+children[j]);
					if(Util.glob(pattern, Util.getBytes(children[j])))
					{
						v.Add(Util.getString(dir)+file_separator+children[j]);
					}
				}
			}
			catch{}//(Exception e){		
			return v;
		}

  private void throwStatusError(Buffer buf, int i) {
    if(server_version>=3){
      byte[] str=buf.getString();
      //byte[] tag=buf.getString();
      throw new SftpException(i, Util.getString(str));
    }
    else{
      throw new SftpException(i, "Failure");
    }
  }

  private static bool isLocalAbsolutePath(String path){
    return Path.IsPathRooted(path);
  }

  public override void finalize(){
    if(currentThread!=null &&
       currentThread.IsAlive){
      currentThread.Interrupt();
      currentThread=null;
    }
    base.finalize();
  }

  /*
   * Class: Ssh_exp_name
   *
   * Represents the result of a query about filenames (e.g. FXP_OPENDIR+ FXP_READDIR )
   */
  public class Ssh_exp_name {
    private  String filename;
    private  String longname;
    private  SftpATTRS attrs;
    Ssh_exp_name(String filename,
		 String longname,
		 SftpATTRS attrs){
      setFilename(filename);
      setLongname(longname);
      setAttrs(attrs);
    }
    public String getFilename(){return filename;}
    public void setFilename(String filename){this.filename = filename;}
    public String getLongname(){return longname;}
    public void setLongname(String longname){this.longname = longname;}
    public SftpATTRS getAttrs(){return attrs;}
    public void setAttrs(SftpATTRS attrs) {this.attrs = attrs;}
    public override String ToString(){
      return (attrs.ToString()+" "+filename);
    }
  }
}

}
