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
		protected static extern void evas_object_del (EvasObjectPtr objectPtr);
		[DllImport(Evas.Name)]
		protected static extern void evas_object_show (EvasObjectPtr obj);

		[DllImport(Evas.Name)]
		protected static extern void evas_object_hide (EvasObjectPtr obj);

		[DllImport(Evas.Name)]
		protected static extern bool evas_object_visible_get (EvasObjectPtr obj);
		[DllImport(Evas.Name)]
		protected static extern void evas_object_smart_callback_add (EvasObjectPtr obj, string eventName, EvasSmartCallback seh, EvasObjectPtr data);
		[DllImport(Evas.Name)]
		protected static extern void evas_object_smart_callback_del (EvasObjectPtr obj, string eventName, EvasSmartCallback seh);


		[DllImport(Evas.Name)]
		protected static extern void evas_object_size_hint_weight_set (EvasObjectPtr obj, double x, double y);
		[DllImport(Evas.Name)]
		protected static extern void evas_object_size_hint_align_set (EvasObjectPtr obj, double x, double y);
		[DllImport(Evas.Name)]
		protected static extern void evas_object_move (EvasObjectPtr obj, int x, int y);

		[DllImport(Evas.Name)]
		protected static extern void evas_object_resize (EvasObjectPtr obj, int w, int h);
		
	}
}

