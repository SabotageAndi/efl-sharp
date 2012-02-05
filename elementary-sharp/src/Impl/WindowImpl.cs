// 
//  WindowImpl.cs
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
namespace Efl.Elementary.Impl
{
	public class WindowImpl : Evas.EvasObject
	{
		[DllImport(Library.Name)]
		protected static extern IntPtr elm_win_add (IntPtr parent, string name, int type);
		
		[DllImport(Library.Name)]
		protected static extern IntPtr elm_win_util_standard_add(string name, string title);
		
		[DllImport(Library.Name)]
		protected static extern void elm_win_activate (IntPtr obj);
		
		[DllImport(Library.Name)]
		protected static extern void elm_win_title_set (IntPtr obj, string title);
		
		[DllImport(Library.Name)]
		protected static extern string elm_win_title_get (IntPtr obj);
		
		[DllImport(Library.Name)]
		protected static extern void elm_win_resize_object_add(IntPtr obj, IntPtr subobj);
		
	}
}

