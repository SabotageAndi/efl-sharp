// 
//  ToolbarItem.cs
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
	[StructLayout(LayoutKind.Sequential)]
	public struct ToolbarItemPtr
	{
		public IntPtr Pointer;

		public ToolbarItem Item
		{
			get {
				var toolbarItem = (ToolbarItem)Marshal.PtrToStructure(Pointer, typeof(ToolbarItem));
				toolbarItem.Raw = this;
				
				return toolbarItem;
			}
		}
	}

	public class ToolbarItem : Impl.ToolbarItemImpl
	{
		public ToolbarItemPtr Raw
		{
			get;
			set;
		}

		public ToolbarItem()
		{
		}
		
		public string Icon
		{
			get { return elm_toolbar_item_icon_get(this.Raw); }
			set { elm_toolbar_item_icon_set(this.Raw, value); }
		}
			
		public string Label
		{
			get { return elm_toolbar_item_label_get(this.Raw); }
			set { elm_toolbar_item_label_set(this.Raw, value); }
		}
	}
}

