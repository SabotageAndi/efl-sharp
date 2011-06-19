// 
//  ListItem.cs
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
	[StructLayout(LayoutKind.Sequential)]
	public struct ListItemPtr
	{
		public IntPtr Pointer;
		
		public ListItem Item
		{
			get{
				var listItem = (ListItem)Marshal.PtrToStructure(Pointer, typeof(ListItem));
				listItem.Raw = this;
				
				return listItem;
			}
		}
	}
	
	[StructLayout(LayoutKind.Sequential)]
	public class ListItem : WidgetItem
	{
		public ListItemPtr Raw
		{
			get;
			set;
		}
		
		public ListItem (ListItemPtr ptr)
		{
			Raw = ptr;
		}
		
		public override int GetHashCode ()
		{
			return Raw.Pointer.ToInt32();
		}
		
		public override bool Equals (object obj)
		{
			var listItem = obj as ListItem;
			if (listItem == null)
				return false;
			
			return GetHashCode() == listItem.GetHashCode();
		}
	}
}

