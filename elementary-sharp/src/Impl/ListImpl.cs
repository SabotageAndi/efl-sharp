// 
//  ListImpl.cs
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
using Efl.Eina;
namespace Efl.Elementary.Impl
{
	public class ListImpl : Evas.EvasObject
	{
		public ListImpl ()
		{
		}
		
		[DllImport(Library.Name)]
		protected static extern IntPtr elm_list_add (IntPtr parent);

		[DllImport(Library.Name)]
		protected static extern ListItemPtr elm_list_item_append (IntPtr obj, string label, IntPtr icon, IntPtr end, Evas.EvasSmartCallback func, IntPtr data);

		[DllImport(Library.Name)]
		protected static extern ListItemPtr elm_list_item_sorted_insert (IntPtr obj, string label, IntPtr icon, IntPtr end, Evas.EvasSmartCallback func, IntPtr data);

		[DllImport(Library.Name)]
		protected static extern ListItemPtr elm_list_item_prepend (IntPtr obj, string label, IntPtr icon, IntPtr end, Evas.EvasSmartCallback func, IntPtr data);

		[DllImport(Library.Name)]
		protected static extern ListItemPtr elm_list_item_insert_before (IntPtr obj, ListItemPtr before, string label, IntPtr icon, IntPtr end, Evas.EvasSmartCallback func, IntPtr data);

		[DllImport(Library.Name)]
		protected static extern ListItemPtr elm_list_item_insert_after (IntPtr obj, ListItemPtr after, string label, IntPtr icon, IntPtr end, Evas.EvasSmartCallback func, IntPtr data);

		[DllImport(Library.Name)]
		protected static extern void elm_list_clear (IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_list_go (IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_list_multi_select_set (IntPtr obj, bool multiSelect);

		[DllImport(Library.Name)]
		protected static extern bool elm_list_multi_select_get (IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern ListMode elm_list_mode_get (IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_list_mode_set (IntPtr obj, ListMode listMode);

		[DllImport(Library.Name)]
		protected static extern void elm_list_horizontal_set (IntPtr obj, bool horizontal);

		[DllImport(Library.Name)]
		protected static extern bool elm_list_horizontal_get (IntPtr obj);
		
		[DllImport(Library.Name)]
		protected static extern void elm_list_always_select_mode_set(IntPtr obj, bool alwaysSelectMode);
		
		[DllImport(Library.Name)]
		protected static extern bool elm_list_always_select_mode_get(IntPtr obj);
	
		[DllImport(Library.Name)]
		protected static extern Efl.Eina.EinaListPtr  elm_list_items_get(IntPtr obj);
		
		[DllImport(Library.Name)]
		protected static extern ListItemPtr elm_list_selected_item_get(IntPtr obj);
	}
}

