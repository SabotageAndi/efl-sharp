// 
//  Window.cs
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

namespace Efl.Elementary
{
	public class Window : Impl.WindowImpl
	{
		public Window ()
			:this("Window", "")
		{
			
		}

		public Window (Efl.Evas.EvasObject parent, string name, Elm_Win_Type type)
		{
			Raw.Pointer = elm_win_add (parent == null ? IntPtr.Zero : parent.Raw.Pointer, name, (int)type);
				
			this.Show ();
		}
		
		public Window (string name, string title)
		{
			Raw.Pointer = elm_win_util_standard_add (name, title);
			
			this.Show ();
		}

		public void Activate ()
		{
			elm_win_activate (this.Raw.Pointer);
		}

		public string Title {
			get { return elm_win_title_get(this.Raw.Pointer); }
			set { elm_win_title_set (this.Raw.Pointer, value); }
			
		}

		public event EventHandler DeleteRequestEvent {
			add { this.SmartCallbackAdd ("delete,request", value, new IntPtr ()); }
			remove { this.SmartCallbackRemove ("delete,request", value); }
		}

		public void ResizeObjectAdd (Evas.EvasObject subobj)
		{
			elm_win_resize_object_add (this.Raw.Pointer, subobj.Raw.Pointer);
		}
		
		public void GetGeometry(out int x, out int y, out int w, out int h)
		{
			//IntPtr xPtr, yPtr, wPtr, hPtr;
			
			//evas_object_geometry_get(this.Raw.Pointer, xPtr, yPtr, wPtr, hPtr);
			
			/*x = Marshal.ReadInt32 (xPtr);
			y = Marshal.ReadInt32 (yPtr);
			w = Marshal.ReadInt32 (wPtr);
			h = Marshal.ReadInt32 (hPtr);*/
			
			evas_object_geometry_get(this.Raw.Pointer, out x, out y, out w, out h);
		} 
	}
}
