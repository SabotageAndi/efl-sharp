// 
//  AnchorView.cs
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

namespace Efl.Elementary
{
	public class AnchorView : Impl.AnchorViewImpl
	{
		public AnchorView()
		{
		}

		public AnchorView(EvasObject parent)
		{
			Raw = elm_anchorview_add(parent.Raw);
		}

		public string Text
		{
			get {
				var ptr = elm_anchorview_text_get(this.Raw);
				return Marshal.PtrToStringUni(ptr);
			}
			set { elm_anchorview_text_set(this.Raw, value); }
		}

		public string Style
		{
			get { 
				var ptr = elm_anchorview_hover_style_get(this.Raw);
				return Marshal.PtrToStringUni(ptr);
			}
			set {
				elm_anchorview_hover_style_set(this.Raw, value);
			}
		}
		
		public void EndHover()
		{
			elm_anchorview_hover_end(this.Raw);
		}
	}
}

