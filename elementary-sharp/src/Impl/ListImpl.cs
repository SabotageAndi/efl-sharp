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
		protected static extern Evas.EvasObjectPtr elm_list_add (Evas.EvasObjectPtr parent);

		[DllImport(Library.Name)]
		protected static extern ListItemPtr elm_list_item_append (Evas.EvasObjectPtr obj, string label, Evas.EvasObjectPtr icon, Evas.EvasObjectPtr end, Evas.EvasSmartCallback func, IntPtr data);

		[DllImport(Library.Name)]
		protected static extern ListItemPtr elm_list_item_sorted_insert (Evas.EvasObjectPtr obj, string label, Evas.EvasObjectPtr icon, Evas.EvasObjectPtr end, Evas.EvasSmartCallback func, IntPtr data);

		[DllImport(Library.Name)]
		protected static extern ListItemPtr elm_list_item_prepend (Evas.EvasObjectPtr obj, string label, Evas.EvasObjectPtr icon, Evas.EvasObjectPtr end, Evas.EvasSmartCallback func, IntPtr data);

		[DllImport(Library.Name)]
		protected static extern ListItemPtr elm_list_item_insert_before (Evas.EvasObjectPtr obj, ListItemPtr before, string label, Evas.EvasObjectPtr icon, Evas.EvasObjectPtr end, Evas.EvasSmartCallback func, IntPtr data);

		[DllImport(Library.Name)]
		protected static extern ListItemPtr elm_list_item_insert_after (Evas.EvasObjectPtr obj, ListItemPtr after, string label, Evas.EvasObjectPtr icon, Evas.EvasObjectPtr end, Evas.EvasSmartCallback func, IntPtr data);

		[DllImport(Library.Name)]
		protected static extern void elm_list_clear (Evas.EvasObjectPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_list_go (Evas.EvasObjectPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_list_multi_select_set (Evas.EvasObjectPtr obj, bool multiSelect);

		[DllImport(Library.Name)]
		protected static extern bool elm_list_multi_select_get (Evas.EvasObjectPtr obj);

		[DllImport(Library.Name)]
		protected static extern ListMode elm_list_mode_get (Evas.EvasObjectPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_list_mode_set (Evas.EvasObjectPtr obj, ListMode listMode);

		[DllImport(Library.Name)]
		protected static extern void elm_list_horizontal_set (Evas.EvasObjectPtr obj, bool horizontal);

		[DllImport(Library.Name)]
		protected static extern bool elm_list_horizontal_get (Evas.EvasObjectPtr obj);
		
		[DllImport(Library.Name)]
		protected static extern void elm_list_always_select_mode_set(Evas.EvasObjectPtr obj, bool alwaysSelectMode);
		
		[DllImport(Library.Name)]
		protected static extern bool elm_list_always_select_mode_get(Evas.EvasObjectPtr obj);
	
		[DllImport(Library.Name)]
		protected static extern Efl.Eina.EinaListPtr  elm_list_items_get(Evas.EvasObjectPtr obj);
		
		[DllImport(Library.Name)]
		protected static extern ListItemPtr elm_list_selected_item_get(Evas.EvasObjectPtr obj);
	}
}

