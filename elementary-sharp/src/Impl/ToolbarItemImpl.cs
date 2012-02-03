// 
//  ToolbarItemImpl.cs
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
using Efl.Elementary;

namespace Efl.Elementary.Impl
{
	public class ToolbarItemImpl : WidgetItem
	{		
		[DllImport(Library.Name)]
		protected static extern IntPtr elm_toolbar_item_toolbar_get(ToolbarItemPtr item);
		
		[DllImport(Library.Name)]
		protected static extern string elm_toolbar_item_icon_get(ToolbarItemPtr item);
		
		[DllImport(Library.Name)]
		protected static extern void elm_toolbar_item_icon_set(ToolbarItemPtr item, string icon);
		
		
		[DllImport(Library.Name)]
		protected static extern string elm_toolbar_item_label_get(ToolbarItemPtr item);
		
		[DllImport(Library.Name)]
		protected static extern string elm_toolbar_item_label_set(ToolbarItemPtr item, string label);
		
		[DllImport(Library.Name)]
		protected static extern bool elm_toolbar_item_selected_get(ToolbarItemPtr item);
		
		[DllImport(Library.Name)]
		protected static extern void elm_toolbar_item_selected_set(ToolbarItemPtr item, bool selected);
	}
}

