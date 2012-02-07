// 
//  main.cs
//  
//  Author:
//       Andreas Willich <sabotageandi@gmail.com>
// 
//  Copyright (c) 2012 Andreas Willich
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
using Efl;
using Efl.Eina;
using Efl.Evas;
using Efl.Ecore;
using Efl.EcoreEvas;
using Efl.Edje;
using Efl.Elementary;

namespace eflsharptest
{
	public class App
	{
		public static int Main ()
		{
			Efl.Elementary.Elementary.Init ();
				
			//var window = new Efl.Elementary.Window (null, "window", Elm_Win_Type.);
			var window = new Efl.Elementary.Window("window", "Efl- Sharp- Test");
			
//			var bg = new Efl.Elementary.BackGround(window);
//			bg.SetBackgroundFile("/home/andreas/Pictures/7978.png", null);
//			bg.Show();
//			string file = string.Empty;
//			string edje = string.Empty;
//			
//			bg.GetBackgroundFile(out file, out edje);
//			
//			window.ResizeObjectAdd(bg); 
			
			var box = new Box (window);
			box.IsHorizontal = true;
			
			window.ResizeObjectAdd (box);
			
			var label = new Label (box, "Label");
			box.PackEnd (label);			
			
			var button = new Button (box, "Click Me");
			button.ClickedEvent += delegate {
				Efl.Elementary.Elementary.Exit();
			};
			box.PackEnd(button);
//			
			
//		
			label.Show ();
			button.Show();
			box.Show ();			
			window.Show ();
			
			window.DeleteRequestEvent += delegate {
				Efl.Elementary.Elementary.Exit ();
			};
			
			
			
			
			window.Resize (800, 600);
			window.Move (100, 100);
			
			int x,y,w,h;
			window.GetGeometry(out x, out y, out w, out h);
			
			Efl.Elementary.Elementary.Run ();
			Efl.Elementary.Elementary.Shutdown ();
				
			return 0;
		}
	}
}

