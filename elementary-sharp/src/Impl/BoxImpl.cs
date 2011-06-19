// 
//  BoxImpl.cs
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
	public class BoxImpl : Evas.EvasObject
	{
		public BoxImpl()
		{
		}

		[DllImport(Library.Name)]
		protected static extern Evas.EvasObjectPtr elm_box_add(Evas.EvasObjectPtr parent);

		[DllImport(Library.Name)]
		protected static extern Evas.EvasObjectPtr elm_box_pack_end(Evas.EvasObjectPtr parent, Evas.EvasObjectPtr child);

		[DllImport(Library.Name)]
		protected static extern Evas.EvasObjectPtr elm_box_pack_start(Evas.EvasObjectPtr parent, Evas.EvasObjectPtr child);

		[DllImport(Library.Name)]
		protected static extern void elm_box_horizontal_set(Evas.EvasObjectPtr obj, bool isHorizontal);

		[DllImport(Library.Name)]
		protected static extern bool elm_box_horizontal_get(Evas.EvasObjectPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_box_homogenous_set(Evas.EvasObjectPtr obj, bool isHomogenous);

		[DllImport(Library.Name)]
		protected static extern bool elm_box_homogenous_get(Evas.EvasObjectPtr obj);
	}
}

