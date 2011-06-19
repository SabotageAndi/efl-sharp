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
		{
			
		}

		public Window (Efl.Evas.EvasObject parent, string title, Elm_Win_Type type)
		{
			Raw = elm_win_add (ref parent, title, (int)type);
			
			this.Show ();
		}

		public void Activate ()
		{
			elm_win_activate (this.Raw);
		}

		public string Title {
			set { elm_win_title_set (this.Raw, value); }
		}

		public event EventHandler DeleteRequestEvent {
			add { this.SmartCallbackAdd ("delete-request", value, new Evas.EvasObjectPtr ()); }
			remove { this.SmartCallbackRemove ("delete-request", value); }
		}

		public void ResizeObjectAdd (Evas.EvasObject subobj)
		{
			elm_win_resize_object_add (this.Raw, subobj.Raw);
		}
	}
}
