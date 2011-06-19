// 
//  EcoreEvas.cs
//  
//  Author:
//       Andreas Willich <sabotageandi@gmail.com>
// 
//  Copyright (c) 2011 Andreas Willich
// 
//  This library is free software; you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as
//  published by the Free Software Foundation; either version 2.1 of the
//  License, or (at your option) any later version.
// 
//  This library is distributed in the hope that it will be useful, but
//  WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
//  Lesser General Public License for more details.
// 
//  You should have received a copy of the GNU Lesser General Public
//  License along with this library; if not, write to the Free Software
//  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System;
using System.Runtime.InteropServices;
using Efl.Evas;

namespace Efl.EcoreEvas
{
	[StructLayout(LayoutKind.Sequential)]
	public struct EcoreEvasPtr
	{
		public EcoreEvasPtr (IntPtr pointer)
		{
			this.Pointer = pointer;
		}

		public IntPtr Pointer;
	}

	public class EcoreEvas : Impl.EcoreEvasImpl
	{
		public const string Name = Efl.Common.Library.Prefix + "ecore_evas" + Efl.Common.Library.Postfix;
		
		private EcoreEvasPtr _pointer;
		
		public EcoreEvasPtr Raw {
			get {
				return this._pointer;
			}
		}		
		
		public EcoreEvas (EcoreEvasPtr pointer)
		{
			_pointer = pointer;
		}

		public static void Init ()
		{
			ecore_evas_init ();
		}
		
		public static EcoreEvas New (string engine_name, int x, int y, int w, int h, string extra_options)
		{
			var ptr = ecore_evas_new (engine_name, x, y, w, h, extra_options);
			
			return new EcoreEvas (ptr);
		}
		
		public static void Free(EcoreEvas ecore_evas)
		{
			ecore_evas_free(ecore_evas.Raw);
		}
		
		public Evas.Evas Evas {
			get { return new Evas.Evas(ecore_evas_get (_pointer)); }
		}
		
		public void Show()
		{
			ecore_evas_show(_pointer);
		}
	}
}

