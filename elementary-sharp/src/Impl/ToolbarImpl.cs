// 
//  ToolbarImpl.cs
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
using Efl.Evas;

namespace Efl.Elementary.Impl
{
	public class ToolbarImpl : Efl.Evas.EvasObject
	{
		[DllImport(Library.Name)]
		protected static extern EvasObjectPtr elm_toolbar_add(EvasObjectPtr parent);
		
		[DllImport(Library.Name)]
		protected static extern void elm_toolbar_icon_size_set(EvasObjectPtr obj, int icon_size);
		
		[DllImport(Library.Name)]
		protected static extern int elm_toolbar_icon_size_get(EvasObjectPtr obj);
		
		[DllImport(Library.Name)]
		protected static extern ToolbarItemPtr elm_toolbar_item_append(EvasObjectPtr obj, string icon, string label, EvasSmartCallback func, IntPtr data);
		
		[DllImport(Library.Name)]
		protected static extern ToolbarItemPtr elm_toolbar_item_prepend(EvasObjectPtr obj, string icon, string label, EvasSmartCallback func, IntPtr data);

		[DllImport(Library.Name)]
		protected static extern ToolbarItemPtr elm_toolbar_item_insert_before(EvasObjectPtr obj, ToolbarItemPtr before,  string icon, string label, EvasSmartCallback func, IntPtr data);
		
		[DllImport(Library.Name)]
		protected static extern ToolbarItemPtr elm_toolbar_item_insert_after(EvasObjectPtr obj, ToolbarItemPtr after,  string icon, string label, EvasSmartCallback func, IntPtr data);
		
		
		
	}
}

