// 
//  Box.cs
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
namespace Efl.Elementary
{
	public class Box : Impl.BoxImpl
	{
		public Box (Evas.EvasObject parent)
		{
			Raw = elm_box_add (parent.Raw);
		}
		
		public void PackStart(Evas.EvasObject child)
		{
			elm_box_pack_start(this.Raw, child.Raw);
		}
		
		public void PackEnd(Evas.EvasObject child)
		{
			elm_box_pack_end(this.Raw, child.Raw);
		}
		
		public bool IsHorizontal
		{
			get{return elm_box_horizontal_get(Raw);}
			set{elm_box_horizontal_set(Raw, value);}
		}
		
		public bool IsHomogenous
		{
			get { return elm_box_homogenous_get(this.Raw);}
			set { elm_box_homogenous_set(this.Raw, value);}
		}
	}
}

