// 
//  EvasObject.cs
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
using System.Linq;

namespace Efl.Evas
{
	public class EvasObjectPtr
	{
		public EvasObjectPtr()
			:this(IntPtr.Zero)
		{
		}
		
		public EvasObjectPtr (IntPtr pointer)
		{
			this.Pointer = pointer;
		}

		public IntPtr Pointer;
	}	


	public class EvasObject : Impl.EvasObjectImpl
	{
		public EvasObject ()
		{
			Raw = new EvasObjectPtr(IntPtr.Zero);
		}
		
		public EvasObject(IntPtr ptr)
		{
			Raw = new EvasObjectPtr(ptr);
		}	
		
		public EvasObject(EvasObjectPtr ptr)
		{
			Raw = ptr;
		}
		
		public delegate void EventHandler (EvasObject w, System.Object event_info);

		private List<EventHandlers> _internalEventHandlers = new List<EventHandlers> ();

		private class EventHandlers
		{
			public EvasSmartCallback internalEventHandler;
			public EventHandler eventHandler;
		}

		protected EvasSmartCallback GetInternalEventHandler (EventHandler externalEventHandler)
		{
			return new EvasSmartCallback ((d, o, e) => { externalEventHandler (this, e); });
		}

//		private HandleRef _objRaw;
//
//		public virtual IntPtr Raw {
//			get { return new IntPtr (_objRaw.Handle); }
//			set { _objRaw = new HandleRef (this, value.Pointer); }
//		}
		
		private EvasObjectPtr _objRaw;

		public virtual EvasObjectPtr Raw {
			get { return _objRaw; }
			set { _objRaw = value; }
		}
		
		
		public static void Delete(EvasObject evasObject)
		{
			evas_object_del(evasObject.Raw.Pointer);
		}	

		public virtual void Show ()
		{
			evas_object_show (Raw.Pointer);
		}

		public virtual void Hide ()
		{
			evas_object_hide (Raw.Pointer);
		}
		
		public virtual bool Visible {
			get { return evas_object_visible_get (Raw.Pointer); }
			set {
				if (value)
					evas_object_show (Raw.Pointer);
				else
					evas_object_hide (Raw.Pointer);
			}
		}

		public void SmartCallbackAdd (string eventName, EventHandler seh, IntPtr data)
		{
			SmartCallbackAdd (this.Raw.Pointer, eventName, seh, data);
		}

		public void SmartCallbackAdd (IntPtr obj, string eventName, EventHandler seh, IntPtr data)
		{
			var handler = GetInternalEventHandler (seh);
			_internalEventHandlers.Add (new EventHandlers { internalEventHandler = handler, eventHandler = seh });
			int itemNum = _internalEventHandlers.Count - 1;
			
			evas_object_smart_callback_add (obj, eventName, _internalEventHandlers[itemNum].internalEventHandler, data);
		}

		public void SmartCallbackRemove (string eventName, EventHandler seh)
		{
			SmartCallbackRemove (this.Raw.Pointer, eventName, seh);
		}

		public void SmartCallbackRemove (IntPtr obj, string eventName, EventHandler seh)
		{
			var eventHandlers = _internalEventHandlers.Where (eh => eh.eventHandler == seh);
			
			foreach (var eventHandler in eventHandlers) {
				evas_object_smart_callback_del (obj, eventName, eventHandler.internalEventHandler);
			}
		}
		
		public void SizeHintWeight (double x, double y)
		{
			evas_object_size_hint_weight_set (this.Raw.Pointer, x, y);
		}

		
		public void SizeHintAlign (double x, double y)
		{
			evas_object_size_hint_align_set (this.Raw.Pointer, x, y);
		}
		
		public void Move(int x, int y)
		{
			evas_object_move(Raw.Pointer, x, y);
		}	
		
		public void Resize(int w, int h)
		{
			evas_object_resize(Raw.Pointer, w, h);
		}	
	}
}

