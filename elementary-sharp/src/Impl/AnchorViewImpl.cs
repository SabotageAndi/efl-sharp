// 
//  AnchorViewImpl.cs
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
using System.Runtime.InteropServices;
namespace Efl.Elementary.Impl
{
	public class AnchorViewImpl : Evas.EvasObject
	{
		[DllImport(Library.Name)]
		protected static extern IntPtr elm_anchorview_add(IntPtr parent);

		[DllImport(Library.Name)]
		protected static extern void elm_anchorview_text_set(IntPtr obj, string text);

		[DllImport(Library.Name)]
		protected static extern IntPtr elm_anchorview_text_get(IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_anchorview_hover_parent_set(IntPtr obj, IntPtr parent);

		[DllImport(Library.Name)]
		protected static extern IntPtr elm_anchorview_hover_parent_get(IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_anchorview_hover_style_set(IntPtr obj, string style);

		[DllImport(Library.Name)]
		protected static extern IntPtr elm_anchorview_hover_style_get(IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_anchorview_hover_end(IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_anchorview_bounce_set(IntPtr obj, bool h_bounce, bool v_bounce);
		
		[DllImport(Library.Name)]
		protected static extern void elm_anchorview_bounce_get(IntPtr obj, IntPtr h_bounce, IntPtr v_bounce);
		
	}
}

