// 
//  MenuImpl.cs
//  
//  Author:
//       Andreas Willich <sabotageandi@gmail.com>
// 
//  Copyright (c) 2012 Andreas Willich
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

namespace Efl.Elementary.Impl
{
	public class MenuImpl : Evas.EvasObject
	{
		[DllImport(Library.Name)]
		protected static extern IntPtr elm_menu_add (IntPtr parent);
		
		[DllImport(Library.Name)]
		protected static extern void elm_menu_parent_set (IntPtr obj, IntPtr parent);
		
		[DllImport(Library.Name)]
		protected static extern IntPtr elm_menu_parent_get (IntPtr obj);
		
		[DllImport(Library.Name)]
		protected static extern void elm_menu_move (IntPtr obj, int x, int y);
		
		[DllImport(Library.Name)]
		protected static extern void elm_menu_close (IntPtr obj);
		
		[DllImport(Library.Name)]
		protected static extern IntPtr 	elm_menu_items_get (IntPtr obj);
		
		[DllImport(Library.Name)]
		protected static extern IntPtr 	elm_menu_item_object_get (IntPtr it);
		
		[DllImport(Library.Name)]
		protected static extern IntPtr 	elm_menu_item_add (IntPtr obj, IntPtr parent, string icon, string label, EvasSmartCallback func, IntPtr data);
		
		[DllImport(Library.Name)]
		protected static extern IntPtr 	elm_menu_item_add_object (IntPtr obj, IntPtr parent, IntPtr subobj, EvasSmartCallback func, IntPtr data);
		
		[DllImport(Library.Name)]
		protected static extern IntPtr 	elm_menu_item_separator_add (IntPtr obj, IntPtr parent);
		
		[DllImport(Library.Name)]
		protected static extern IntPtr 	elm_menu_selected_item_get (IntPtr obj);
		
		[DllImport(Library.Name)]
		protected static extern IntPtr	elm_menu_last_item_get (IntPtr obj);
		
		[DllImport(Library.Name)]
		protected static extern IntPtr 	elm_menu_first_item_get (IntPtr obj);
		
	}
}

