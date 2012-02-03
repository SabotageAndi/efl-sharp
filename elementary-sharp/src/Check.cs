// 
//  Check.cs
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
	public class Check : Impl.CheckImpl
	{
		public Check (Evas.EvasObject parent)
		{
			Raw.Pointer = elm_check_add (parent.Raw.Pointer);
		}

		public event EventHandler OnChangedEvent {
			add { this.SmartCallbackAdd ("changed", value, new IntPtr ()); }
			remove { this.SmartCallbackRemove ("changed", value); }
		}

		public string Label {
			get { return elm_check_label_get (this.Raw.Pointer); }
			set { elm_check_label_set (this.Raw.Pointer, value); }
		}


		public bool State {
			get { return elm_check_state_get (this.Raw.Pointer); }
			set { elm_check_state_set (this.Raw.Pointer, value); }
		}

		private Type _contentType;
		public Evas.EvasObject Icon {

			get {
				var content = (Evas.EvasObject)Activator.CreateInstance (_contentType);
				content.Raw.Pointer = elm_check_icon_get (this.Raw.Pointer);
				
				return content;
			}
			set {
				_contentType = value.GetType ();
				elm_check_icon_set (this.Raw.Pointer, value.Raw.Pointer);
			}
		}

		public Evas.EvasObject UnsetIcon ()
		{
			if (_contentType == null)
				return null;
			
			var content = (Evas.EvasObject)Activator.CreateInstance (_contentType);
			content.Raw.Pointer = elm_check_icon_unset (this.Raw.Pointer);
			
			return content;
		}
	}
}

