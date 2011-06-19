// 
//  EdjeObject.cs
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
namespace Efl.Edje
{
	public class EdjeObject : Impl.EdjeObjectImpl
	{
		public static TEvasObject GetPart<TEvasObject>(EvasObject edje, string part) where TEvasObject : EvasObject, new()
		{
			var evasObject = new TEvasObject();
			
			evasObject.Raw = edje_object_part_external_object_get(edje.Raw, part);
			
			return evasObject;
		}
	}
}

