// 
//  EvasObjectImpl.cs
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
namespace Efl.Evas.Impl
{
	public class EvasObjectImpl
	{
		public EvasObjectImpl ()
		{
		}

		[DllImport(Evas.Name)]
		protected static extern void evas_object_del (IntPtr objectPtr);
		[DllImport(Evas.Name)]
		protected static extern void evas_object_show (IntPtr obj);

		[DllImport(Evas.Name)]
		protected static extern void evas_object_hide (IntPtr obj);

		[DllImport(Evas.Name)]
		protected static extern bool evas_object_visible_get (IntPtr obj);
		[DllImport(Evas.Name)]
		protected static extern void evas_object_smart_callback_add (IntPtr obj, string eventName, EvasSmartCallback seh, IntPtr data);
		[DllImport(Evas.Name)]
		protected static extern void evas_object_smart_callback_del (IntPtr obj, string eventName, EvasSmartCallback seh);


		[DllImport(Evas.Name)]
		protected static extern void evas_object_size_hint_weight_set (IntPtr obj, double x, double y);
		[DllImport(Evas.Name)]
		protected static extern void evas_object_size_hint_align_set (IntPtr obj, double x, double y);
		[DllImport(Evas.Name)]
		protected static extern void evas_object_move (IntPtr obj, int x, int y);

		[DllImport(Evas.Name)]
		protected static extern void evas_object_resize (IntPtr obj, int w, int h);
		
		[DllImport(Evas.Name)]
		//protected static extern void evas_object_geometry_get(IntPtr obj, IntPtr x, IntPtr y, IntPtr w, IntPtr h);
		protected static extern void evas_object_geometry_get(IntPtr obj, out int x, out int y, out int w, out int h);
	}	
}

