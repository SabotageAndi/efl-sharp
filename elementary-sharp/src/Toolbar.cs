// 
//  Toolbar.cs
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
using Efl.Evas;

namespace Efl.Elementary
{
	public class Toolbar : Impl.ToolbarImpl
	{
		public Toolbar()
		{
			
		}
		
		public Toolbar(Evas.EvasObject parent)
		{
			Raw.Pointer = elm_toolbar_add(parent.Raw.Pointer);
		}
		
		public ToolbarItemPtr Append(string icon, string label, EvasSmartCallback clickDelegate)
		{
			return elm_toolbar_item_append(this.Raw.Pointer, icon, label, clickDelegate, IntPtr.Zero);
		}
		
		public ToolbarItemPtr Prepend(string icon, string label, EvasSmartCallback clickDelegate)
		{
			return elm_toolbar_item_prepend(this.Raw.Pointer, icon, label, clickDelegate, IntPtr.Zero);
		}
		
		public ToolbarItemPtr InsertAfter(ToolbarItem after, string icon, string label, EvasSmartCallback clickDelegate)
		{
			return elm_toolbar_item_insert_after(this.Raw.Pointer, after.Raw, icon, label, clickDelegate, IntPtr.Zero);
		}
		
		public ToolbarItemPtr InsertBefore(ToolbarItem before, string icon, string label, EvasSmartCallback clickDelegate)
		{
			return elm_toolbar_item_insert_before(this.Raw.Pointer, before.Raw, icon, label, clickDelegate, IntPtr.Zero);
		}
	}
}

