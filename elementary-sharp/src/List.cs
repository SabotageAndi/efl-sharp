// 
//  List.cs
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
namespace Efl.Elementary
{
	public class List : Impl.ListImpl
	{
		public List(){}
		
		public List (Evas.EvasObject parent)
		{
			this.Raw.Pointer = elm_list_add (parent.Raw.Pointer);
		}

		private static IntPtr GetPtrToObject (object data)
		{
			IntPtr dataPtr = IntPtr.Zero;
			
			if (data != null)
				Marshal.StructureToPtr (data, dataPtr, true);
			
			return dataPtr;
		}

		public ListItemPtr Append (string label, IntPtr iconLeft, IntPtr iconRight, Evas.EvasSmartCallback onClicked, object data)
		{
			return elm_list_item_append (this.Raw.Pointer, label, iconLeft, iconRight, onClicked, GetPtrToObject (data));
		}

		public ListItemPtr SortedInsert (string label, IntPtr iconLeft, IntPtr iconRight, Evas.EvasSmartCallback onClicked, object data)
		{
			return elm_list_item_sorted_insert (this.Raw.Pointer, label, iconLeft, iconRight, onClicked, GetPtrToObject (data));
		}

		public ListItemPtr Prepend (string label, IntPtr iconLeft, IntPtr iconRight, Evas.EvasSmartCallback onClicked, object data)
		{
			return elm_list_item_prepend (this.Raw.Pointer, label, iconLeft, iconRight, onClicked, GetPtrToObject (data));
		}

		public ListItemPtr InsertBefore (string label, ListItemPtr before, IntPtr iconLeft, IntPtr iconRight, Evas.EvasSmartCallback onClicked, object data)
		{
			return elm_list_item_insert_before (this.Raw.Pointer, before, label, iconLeft, iconRight, onClicked, GetPtrToObject (data));
		}

		public ListItemPtr InsertAfter (string label, ListItemPtr before, IntPtr iconLeft, IntPtr iconRight, Evas.EvasSmartCallback onClicked, object data)
		{
			return elm_list_item_insert_after (this.Raw.Pointer, before, label, iconLeft, iconRight, onClicked, GetPtrToObject (data));
		}

		public void Clear ()
		{
			elm_list_clear (this.Raw.Pointer);
		}

		public void Go ()
		{
			elm_list_go (this.Raw.Pointer);
		}

		public bool MultiSelect {
			get { return elm_list_multi_select_get (this.Raw.Pointer); }
			set { elm_list_multi_select_set (this.Raw.Pointer, value); }
		}

		public ListMode Mode {
			get { return elm_list_mode_get (this.Raw.Pointer); }
			set { elm_list_mode_set (this.Raw.Pointer, value); }
		}

		public bool Horizontal {
			get { return elm_list_horizontal_get (this.Raw.Pointer); }
			set { elm_list_horizontal_set (this.Raw.Pointer, value); }
		}
		
		public bool AlwaysSelectMode
		{
			get{ return elm_list_always_select_mode_get(this.Raw.Pointer);}
			set{ elm_list_always_select_mode_set(this.Raw.Pointer, value);}
		}
		
		public Efl.Eina.EinaList Items
		{
			get {
				var list = elm_list_items_get(this.Raw.Pointer);
				return new EinaList(list);
			}
		}
		
		public ListItem SelectedItem
		{
			get {
				var selectedItemPtr = elm_list_selected_item_get(this.Raw.Pointer);
				return new ListItem(selectedItemPtr);
			}
		}
		    
		public event EventHandler SelectedEvent
		{
			add{
				this.SmartCallbackAdd(Efl.Common.EventNames.Selected, value, new IntPtr());
			}
			remove{
				this.SmartCallbackRemove(Efl.Common.EventNames.Selected, value);
			}
		}
	}
}

