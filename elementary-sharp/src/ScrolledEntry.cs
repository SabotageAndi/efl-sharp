// 
//  ScrolledEntry.cs
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
	public class ScrolledEntry : Impl.ScrolledEntryImpl
	{
		public ScrolledEntry(){}
		
		public ScrolledEntry (Evas.EvasObject parent)
		{
			Raw.Pointer = elm_scrolled_entry_add (parent.Raw.Pointer);
		}

		public bool IsSingleLine {
			get { return elm_scrolled_entry_single_line_get (this.Raw.Pointer); }
			set { elm_scrolled_entry_single_line_set (this.Raw.Pointer, value); }
		}

		public bool IsMultiline {
			get { return !IsSingleLine; }
			set { IsSingleLine = !value; }
		}

		private string GetStringFromObjectPtr (IntPtr objectPtr)
		{
			string result = Marshal.PtrToStringAnsi (objectPtr);
			if (IsSingleLine)
				result = result.Trim ();
			return result;
		}

		public string Text {
			get { return GetStringFromObjectPtr (elm_scrolled_entry_entry_get (this.Raw.Pointer)); }
			set { elm_scrolled_entry_entry_set (this.Raw.Pointer, value); }
		}

		public bool IsEditable {
			get { return elm_scrolled_entry_editable_get (this.Raw.Pointer); }
			set { elm_scrolled_entry_editable_set (this.Raw.Pointer, value); }
		}

		public bool PasswordMode {
			get { return elm_scrolled_entry_password_get (this.Raw.Pointer); }
			set { elm_scrolled_entry_password_set (this.Raw.Pointer, value); }
		}

		public string SelectedText {
			get { return GetStringFromObjectPtr (elm_scrolled_entry_selection_get (this.Raw.Pointer)); }
		}

		public event EventHandler OnChangedEvent {
			add { this.SmartCallbackAdd ("changed", value, new IntPtr ()); }
			remove { this.SmartCallbackRemove ("changed", value); }
		}
	}
}

