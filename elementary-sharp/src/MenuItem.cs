// 
//  MenuItem.cs
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
using Efl.Eina;

namespace Efl.Elementary
{
	public class MenuItem : ObjectItem
	{
		[DllImport(Library.Name)]
		protected static extern IntPtr 	elm_menu_item_menu_get (IntPtr it);

		[DllImport(Library.Name)]
		protected static extern void 	elm_menu_item_object_icon_name_set (IntPtr it, string icon);
		
		[DllImport(Library.Name)]
		protected static extern string 	elm_menu_item_object_icon_name_get (IntPtr  it);
		
		[DllImport(Library.Name)]
		protected static extern void 	elm_menu_item_selected_set (IntPtr it, bool selected);
		
		[DllImport(Library.Name)]
		protected static extern bool 	elm_menu_item_selected_get (IntPtr it);
		
		[DllImport(Library.Name)]
		protected static extern bool 	elm_menu_item_is_separator (IntPtr it);
		
		[DllImport(Library.Name)]
		protected static extern IntPtr 	elm_menu_item_subitems_get (IntPtr it);
		
		[DllImport(Library.Name)]
		protected static extern int 	elm_menu_item_index_get (IntPtr it);
		
		[DllImport(Library.Name)]
		protected static extern IntPtr 	elm_menu_item_next_get (IntPtr it);
		
		[DllImport(Library.Name)]
		protected static extern IntPtr	elm_menu_item_prev_get (IntPtr it);

		
		public MenuItem(IntPtr raw)
			:base(raw)
		{}
		
		public string Icon
		{
			get{ return elm_menu_item_object_icon_name_get(this.Raw);}
			set{ elm_menu_item_object_icon_name_set(this.Raw, value);}
		}
		
		public Menu ParentMenu
		{
			get { return new Menu(new EvasObject(elm_menu_item_menu_get(this.Raw)));}
		}	
		
		public bool IsSelected
		{
			get { return elm_menu_item_selected_get(this.Raw); }
			set { elm_menu_item_selected_set(this.Raw, value); }
		}
		
		public bool IsSeperator
		{
			get { return elm_menu_item_is_separator(this.Raw); }
		}
		
		public MenuItem Next
		{
			get { return new MenuItem(elm_menu_item_next_get(this.Raw));}
		}
		
		public MenuItem Previous
		{
			get { return new MenuItem(elm_menu_item_prev_get(this.Raw));}
		}
		
		public EinaList SubItems
		{
			get { return new EinaList(elm_menu_item_subitems_get(this.Raw));}
		}
	}
}

