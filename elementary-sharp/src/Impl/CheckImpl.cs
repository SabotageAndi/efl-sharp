// 
//  CheckImpl.cs
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
	public class CheckImpl : Evas.EvasObject
	{
		public CheckImpl()
		{
		}

		[DllImport(Library.Name)]
		protected static extern IntPtr elm_check_add(IntPtr parent);

		[DllImport(Library.Name)]
		protected static extern void elm_check_label_set(IntPtr obj, string label);
		[DllImport(Library.Name)]
		protected static extern string elm_check_label_get(IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_check_state_set(IntPtr obj, bool state);
		[DllImport(Library.Name)]
		protected static extern bool elm_check_state_get(IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_check_icon_set(IntPtr obj, IntPtr icon);
		[DllImport(Library.Name)]
		protected static extern IntPtr elm_check_icon_get(IntPtr obj);
		[DllImport(Library.Name)]
		protected static extern IntPtr elm_check_icon_unset(IntPtr obj);
		
		
	}
}

