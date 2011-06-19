// 
//  Background.cs
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
using Efl.Evas;

namespace Efl.Elementary
{
	public class BackGround : Impl.BackgroundImpl
	{
		public BackGround (Evas.EvasObject parent)
		{
			Raw = elm_bg_add (parent.Raw);
		}

		public void SetBackgroundFile (string fileName, string edjeGroup)
		{
			elm_bg_file_set (this.Raw, fileName, edjeGroup);
		}

		public void GetBackgroundFile (out string fileName, out string edjeGroup)
		{
			EvasObjectPtr filePtr;
			EvasObjectPtr edjeGroupPtr;
			
			elm_bg_file_get (this.Raw, filePtr, edjeGroupPtr);
			
			fileName = Marshal.PtrToStringAuto (filePtr.Pointer);
			edjeGroup = Marshal.PtrToStringAuto (edjeGroupPtr.Pointer);
		}
	}
}

