// 
//  Image.cs
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
	public class Image : Impl.ImageImpl
	{

		public Image(Evas.EvasObject parent)
		{
			this.Raw.Pointer = elm_image_add(parent.Raw.Pointer);
		}

		public void SetImageFile(string fileName, string edjeGroup)
		{
			elm_image_file_set(this.Raw.Pointer, fileName, edjeGroup);
		}

		public void GetImageFile(out string fileName, out string edjeGroup)
		{
			IntPtr filePtr;
			IntPtr edjeGroupPtr;
			
			elm_image_file_get(this.Raw.Pointer, filePtr, edjeGroupPtr);
			
			fileName = Marshal.PtrToStringAuto(filePtr);
			edjeGroup = Marshal.PtrToStringAuto(edjeGroupPtr);
		}


		public bool FillOutside {
			get { return elm_image_fill_outside_get(this.Raw.Pointer); }
			set { elm_image_fill_outside_set(this.Raw.Pointer, value); }
		}

		public bool NoScale {
			get { return elm_image_no_scale_get(this.Raw.Pointer); }
			set { elm_image_no_scale_set(this.Raw.Pointer, value); }
		}

		public ImageOrientation Orientation {
			get { return elm_image_orient_get(this.Raw.Pointer); }
			set { elm_image_orient_set(this.Raw.Pointer, value); }
		}

		public int Prescale {
			get { return elm_image_prescale_get(this.Raw.Pointer); }
			set { elm_image_prescale_set(this.Raw.Pointer, value); }
		}

		public bool ScaleUp {
			get {
				IntPtr scaleUpPtr;
				IntPtr scaleDownPtr;
				
				elm_image_scale_get(this.Raw.Pointer, scaleUpPtr, scaleDownPtr);
				
				var scaleup = Marshal.ReadByte(scaleUpPtr);
				
				return scaleup == Efl.Eina.Constants.True;
			}
			set { elm_image_scale_set(this.Raw.Pointer, value, ScaleDown); }
		}

		public bool ScaleDown {
			get {
				IntPtr scaleUpPtr;
				IntPtr scaleDownPtr;
				
				elm_image_scale_get(this.Raw.Pointer, scaleUpPtr, scaleDownPtr);
				
				var scaleDown = Marshal.ReadByte(scaleDownPtr);
				
				return scaleDown == Efl.Eina.Constants.True;
			}
			set { elm_image_scale_set(this.Raw.Pointer, ScaleUp, value); }
		}

		public bool Smooth {
			get { return elm_image_smooth_get(this.Raw.Pointer); }
			set { elm_image_smooth_set(this.Raw.Pointer, value); }
		}

		public event EventHandler ClickedEvent {
			add { this.SmartCallbackAdd(Efl.Common.EventNames.Clicked, value, new IntPtr()); }
			remove { this.SmartCallbackRemove(Efl.Common.EventNames.Clicked, value); }
		}

		public event EventHandler DropEvent {
			add { this.SmartCallbackAdd(Efl.Common.EventNames.Drop, value, new IntPtr()); }
			remove { this.SmartCallbackRemove(Efl.Common.EventNames.Drop, value); }
		}
	}
}

