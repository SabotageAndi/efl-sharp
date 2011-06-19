// 
//  Button.cs
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
using System.Collections.Generic;
namespace Efl.Elementary
{
	public class Button : Impl.ButtonImpl
	{
		public Button()
		{}
		
		public Button (Evas.EvasObject parent)
		{
			Raw = elm_button_add (parent.Raw);
		}

		public Button (Evas.EvasObject parent, string label) : this(parent)
		{
			Text = label;
		}

		public string Text {
			set { elm_button_label_set (Raw, value); }
		}
		
		
		public event EventHandler ClickedEvent
		{
			add{
				this.SmartCallbackAdd(Efl.Common.EventNames.Clicked, value, new Evas.EvasObjectPtr());
			}
			remove{
				this.SmartCallbackRemove(Efl.Common.EventNames.Clicked, value);
			}
		}
	}
}

