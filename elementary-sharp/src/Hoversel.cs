// 
//  Hoversel.cs
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
	public class Hoversel : Impl.HoverselImpl
	{
		public Hoversel (Evas.EvasObject parent)
		{
			Raw = elm_hoversel_add (parent.Raw);
		}

		public bool IsHorizontal {
			get { return elm_hoversel_horizontal_get (this.Raw); }
			set { elm_hoversel_horizontal_set (this.Raw, value); }
		}

		public void BeginHover ()
		{
			elm_hoversel_hover_begin (this.Raw);
		}

		public void EndHover ()
		{
			elm_hoversel_hover_end (this.Raw);
		}

		public bool IsExpanded {
			get { return elm_hoversel_expanded_get (this.Raw); }
		}
		
	}
}

