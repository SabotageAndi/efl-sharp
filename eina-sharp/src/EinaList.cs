// 
//  EinaList.cs
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
using System.Collections;
using System.Runtime.InteropServices;
namespace Efl.Eina
{
	[StructLayout(LayoutKind.Sequential)]
	public struct EinaListPtr
	{
		public EinaListPtr (IntPtr pointer)
		{
			this.Pointer = pointer;
		}

		public IntPtr Pointer;
	}
	
	public class EinaList : Impl.EinaListImpl, IList, IEnumerable, ICollection
	{
		public EinaList()
		{
		}

		public EinaList(EinaListPtr lastItem)
		{
			_lastItem = lastItem;
		}

		private EinaListPtr _lastItem;

		public int Count
		{
			get { return Convert.ToInt32(eina_list_count(_lastItem)); }
		}

		#region IList implementation
		public int Add(object value)
		{
			_lastItem = eina_list_append(_lastItem, new EinaListPtr(IntPtr.Zero));
			return 1;
		}

		public void Clear()
		{
			_lastItem = eina_list_free(_lastItem);
		}

		public bool Contains(object value)
		{
			throw new NotImplementedException();
		}

		public int IndexOf(object value)
		{
			throw new NotImplementedException();
		}

		public void Insert(int index, object value)
		{
			throw new NotImplementedException();
		}

		public void Remove(object value)
		{
			throw new NotImplementedException();
		}

		public void RemoveAt(int index)
		{
			throw new NotImplementedException();
		}

		public bool IsFixedSize
		{
			get {
				throw new NotImplementedException();
			}
		}

		public bool IsReadOnly
		{
			get {
				throw new NotImplementedException();
			}
		}

		public object this[int index]
		{
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}
		#endregion

		#region IEnumerable implementation
		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}
		#endregion

		#region ICollection implementation
		public void CopyTo(Array array, int index)
		{
			throw new NotImplementedException();
		}

		public bool IsSynchronized
		{
			get {
				throw new NotImplementedException();
			}
		}

		public object SyncRoot
		{
			get {
				throw new NotImplementedException();
			}
		}
		#endregion
	}
}

