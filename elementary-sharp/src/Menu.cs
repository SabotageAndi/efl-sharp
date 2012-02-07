// 
//  Menu.cs
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
using Efl.Evas;
using System.Runtime.InteropServices;


namespace Efl.Elementary
{
	public class Menu : Impl.MenuImpl
	{
		
		public Menu ()
		{
			this.Raw.Pointer = elm_menu_add(IntPtr.Zero);
		}
		
		public Menu (EvasObject parent)
		{
			this.Raw.Pointer = elm_menu_add(parent.Raw.Pointer);
		}
		
		public EvasObjectPtr Parent
		{
			get { return new EvasObjectPtr(elm_menu_parent_get(this.Raw.Pointer));}
          	set { elm_menu_parent_set(this.Raw.Pointer, value.Pointer); }
		}
		
		public void Close()
		{
			elm_menu_close(this.Raw.Pointer);
		}
		
		public MenuItem AddItem(MenuItem parent, string icon, string label, EvasSmartCallback onClick, object data)
		{
			return new MenuItem(elm_menu_item_add(this.Raw.Pointer, parent.Raw, icon, label, onClick, IntPtr.Zero));
		}
		
		public MenuItem AddItem(MenuItem parent, EvasObject obj, EvasSmartCallback onClick, object data)
		{
			return new MenuItem(elm_menu_item_add_object(this.Raw.Pointer, parent.Raw, obj.Raw.Pointer, onClick, IntPtr.Zero));
		}
		
		public MenuItem AddSeperator(MenuItem parent)
		{
			return new MenuItem(elm_menu_item_separator_add(this.Raw.Pointer, parent.Raw));
		}
		
		public MenuItem SelectedItem
		{
			get { return new MenuItem(elm_menu_selected_item_get(this.Raw.Pointer));}
		}
		
		public MenuItem LastItem
		{
			get { return new MenuItem(elm_menu_last_item_get(this.Raw.Pointer));}
		}	
		
		public MenuItem FirstItem
		{
			get { return new MenuItem(elm_menu_first_item_get(this.Raw.Pointer));}
		}
	}	
}

