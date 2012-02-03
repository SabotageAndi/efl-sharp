// 
//  Edje_Evas.cs
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

namespace Efl.Edje
{
	public static class Edje_Evas
	{
		[DllImport(Edje.Name)]
		private static extern bool edje_object_file_set (IntPtr obj, string file, string group);
		
		public static bool SetEdjeFile(this Evas.EvasObject evasObject, string file, string group)
		{
			return edje_object_file_set(
				evasObject.Raw.Pointer, file, group);
		}
		
		[DllImport(Edje.Name)]
		private static extern bool edje_object_part_text_set(IntPtr obj, string part, string text);
		
		public static bool SetPartText(this Evas.EvasObject evasObject, string part, string text)
		{
			return edje_object_part_text_set(evasObject.Raw.Pointer, part, text);
		}
		
		[DllImport(Edje.Name)]
		private static extern IntPtr edje_object_add(Evas.EvasPtr evasPtr);
		
		public static Evas.EvasObject AddEvas(Evas.Evas evas)
		{
			return new Evas.EvasObject( new Evas.EvasObjectPtr( edje_object_add(evas.Raw)));
		}
	}
}

