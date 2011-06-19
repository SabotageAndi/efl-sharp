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
		protected static extern Evas.EvasObjectPtr elm_win_add (ref Efl.Evas.EvasObject parent, string name, int type);

		[DllImport(Library.Name)]
		protected static extern void elm_win_activate (Evas.EvasObjectPtr obj);
		
		[DllImport(Library.Name)]
		protected static extern void elm_win_title_set (Evas.EvasObjectPtr obj, string title);
		
		[DllImport(Library.Name)]
		protected static extern void elm_win_resize_object_add(Evas.EvasObjectPtr obj, Evas.EvasObjectPtr subobj);
		
	}
}

