// 
//  Frame.cs
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
	public class Frame : Impl.FrameImpl
	{
		public Frame (Evas.EvasObject parent)
		{
			Raw.Pointer = elm_frame_add (parent.Raw.Pointer);
		}
		
		public FrameStyle Style
		{
			set
			{
				string frameStyle = "default";
				
				switch (value)
				{
				case FrameStyle.Default:
					frameStyle = "default";
					break;
				case FrameStyle.OutdentBottom:
					frameStyle = "outdent_bottom";
					break;
				case FrameStyle.OutdentTop:
					frameStyle = "outdent_top";
					break;
				case FrameStyle.PadHuge:
					frameStyle = "pad_huge";
					break;
				case FrameStyle.PadLarge:
					frameStyle = "pad_large";
					break;
				case FrameStyle.PadMedium:
					frameStyle = "pad_medium";
					break;
				case FrameStyle.PadSmall:
					frameStyle = "pad_small";
					break;
				}
				
                elm_object_style_set(this.Raw.Pointer, frameStyle);
			}
		}
		
		
		private Type _contentType;
		public Evas.EvasObject Content
		{
			set{
				_contentType = value.GetType();
				
				elm_frame_content_set(this.Raw.Pointer, value.Raw.Pointer);
			}
			get{
				
				var content = (Evas.EvasObject)Activator.CreateInstance(_contentType);
				content.Raw.Pointer = elm_frame_content_get(this.Raw.Pointer);				
				
				return content;
			}
		}
	}
}

