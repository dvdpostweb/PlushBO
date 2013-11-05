using System;
using System.IO;

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

	public class IO
	{
		internal Stream ins;
		internal Stream outs;
		internal Stream out_ext;

		internal void setOutputStream(Stream outs)
		{
			this.outs=outs;
		}
		internal void setExtOutputStream(Stream outs)
		{
			this.out_ext=outs;
		}
		internal void setInputStream(Stream ins)
		{
			this.ins=ins;
		}
		public void put(Packet p)
		{
			outs.Write(p.buffer.buffer, 0, p.buffer.index);
			outs.Flush();
		}
		internal void put(byte[] array, int begin, int length)
		{
			outs.Write(array, begin, length);
			outs.Flush();
		}
		internal void put_ext(byte[] array, int begin, int length)
		{
			out_ext.Write(array, begin, length);
			out_ext.Flush();
		}

		internal int getByte()
		{
			int res = ins.ReadByte()&0xff;
			return res; 
		}

		internal void getByte(byte[] array)
		{
			getByte(array, 0, array.Length);
		}

		internal void getByte(byte[] array, int begin, int length)
		{
			do
			{
				int completed = ins.Read(array, begin, length);
				if(completed<=0)
				{
					throw new IOException("");
				}
				begin+=completed;
				length-=completed;
			}
			while (length>0);
		}

		public void finalize()
		{
			try
			{
				if(ins!=null) ins.Close();
			}
			catch{}
			try
			{
				if(outs!=null) outs.Close();
			}
			catch{}
		}
	}

}
