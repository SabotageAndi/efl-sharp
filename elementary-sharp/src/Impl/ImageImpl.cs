// 
//  ImageImpl.cs
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
	public class ImageImpl : Evas.EvasObject
	{
		public ImageImpl()
		{
		}

		[DllImport(Library.Name)]
		protected static extern IntPtr elm_image_add(IntPtr parent);

		[DllImport(Library.Name)]
		protected static extern void elm_image_file_get(IntPtr obj, IntPtr file, IntPtr edjeGroup);

		[DllImport(Library.Name)]
		protected static extern bool elm_image_file_set(IntPtr obj, string file, string edjeGroup);

		[DllImport(Library.Name)]
		protected static extern bool elm_image_fill_outside_get(IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_image_fill_outside_set(IntPtr obj, bool fill_outside);

		[DllImport(Library.Name)]
		protected static extern bool elm_image_no_scale_get(IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_image_no_scale_set(IntPtr obj, bool no_scale);

		[DllImport(Library.Name)]
		protected static extern ImageOrientation elm_image_orient_get(IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_image_orient_set(IntPtr obj, ImageOrientation orientation);

		[DllImport(Library.Name)]
		protected static extern int elm_image_prescale_get(IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_image_prescale_set(IntPtr obj, int size);

		[DllImport(Library.Name)]
		protected static extern void elm_image_scale_get(IntPtr obj, IntPtr scale_up, IntPtr scale_down);

		[DllImport(Library.Name)]
		protected static extern void elm_image_scale_set(IntPtr obj, bool scale_up, bool scale_down);

		[DllImport(Library.Name)]
		protected static extern bool elm_image_smooth_get(IntPtr obj);

		[DllImport(Library.Name)]
		protected static extern void elm_image_smooth_set(IntPtr obj, bool smooth);
	}
}

