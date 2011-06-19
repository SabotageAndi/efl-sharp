// 
//  Constants.cs
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
namespace Efl.Elementary
{
	public enum Elm_Win_Type
    {
        ELM_WIN_BASIC,
        ELM_WIN_DIALOG_BASIC,
        ELM_WIN_DESKTOP,
        ELM_WIN_DOCK,
        ELM_WIN_TOOLBAR,
        ELM_WIN_MENU,
        ELM_WIN_UTILITY,
        ELM_WIN_SPLASH
    }
	
	public enum FrameStyle
	{
		Default,
	    PadSmall,
	    PadMedium,
	    PadLarge,
	    PadHuge,
	    OutdentTop,
	    OutdentBottom,
	}
	
	public enum ImageOrientation
	{
		ELM_IMAGE_ORIENT_NONE, 
		ELM_IMAGE_ROTATE_90_CW, 
		ELM_IMAGE_ROTATE_180_CW, 
		ELM_IMAGE_ROTATE_90_CCW, 
		ELM_IMAGE_FLIP_HORIZONTAL,
		ELM_IMAGE_FLIP_VERTICAL, 
		ELM_IMAGE_FLIP_TRANSPOSE, 
		ELM_IMAGE_FLIP_TRANSVERSE
	}
	
	public enum ListMode
	{
		ELM_LIST_COMPRESS, 
		ELM_LIST_SCROLL, 
		ELM_LIST_LIMIT,
		ELM_LIST_EXPAND
	}
	

}

