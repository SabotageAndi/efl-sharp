// 
//  HoverselImpl.cs
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
namespace Efl.Elementary.Impl
{
	public class HoverselImpl : Evas.EvasObject
	{
		public HoverselImpl()
		{
		}

		[DllImport(Library.Name)]
		protected static extern IntPtr elm_hoversel_add(IntPtr parent);

		[DllImport(Library.Name)]
		protected static extern void elm_hoversel_horizontal_set(IntPtr obj, bool horizontal);

		[DllImport(Library.Name)]
		protected static extern bool elm_hoversel_horizontal_get(IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_hoversel_hover_begin(IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_hoversel_hover_end(IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern bool elm_hoversel_expanded_get(IntPtr obj);
		
	}
}

