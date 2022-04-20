using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.DataStructures
{
	public class MyStack<T> where T : IComparable<T>
	{
		private List<T> _data;

		public MyStack()
		{
			_data = new List<T>();
		}

		public void Push(T item)
		{
			_data.Add(item);
		}

		//O(1)
		public void PopAsync()
		{
			if (_data.Count > 0)
			{
				T item = Peek();
				_data.RemoveAt(_data.Count - 1);
			}
		}

		//O(1)
		public T Peek()
		{
			if (_data.Count > 0)
				return _data[_data.Count - 1];
			return default(T);
		}

		//O(1)
		public T Min()
		{
			if (_data.Count > 0)
			{
				//return FindMin();
				return _data.Min();
			}
			return default(T);
		}

		private T FindMin()
		{
			if (_data.Count == 0)
				return default(T);

			T low = _data[0];
			foreach (var item in _data)
			{
				if (item.CompareTo(low) < 0)
					low = item;
			}

			return low;

		}

		private T GetMaxValue()
		{
			object maxValue = default(T);
			TypeCode typeCode = Type.GetTypeCode(typeof(T));
			switch (typeCode)
			{
				case TypeCode.Byte:
					maxValue = byte.MaxValue;
					break;
				case TypeCode.Char:
					maxValue = char.MaxValue;
					break;
				case TypeCode.DateTime:
					maxValue = DateTime.MaxValue;
					break;
				case TypeCode.Decimal:
					maxValue = decimal.MaxValue;
					break;
				case TypeCode.Double:
					maxValue = decimal.MaxValue;
					break;
				case TypeCode.Int16:
					maxValue = short.MaxValue;
					break;
				case TypeCode.Int32:
					maxValue = int.MaxValue;
					break;
				case TypeCode.Int64:
					maxValue = long.MaxValue;
					break;
				case TypeCode.SByte:
					maxValue = sbyte.MaxValue;
					break;
				case TypeCode.Single:
					maxValue = float.MaxValue;
					break;
				case TypeCode.UInt16:
					maxValue = ushort.MaxValue;
					break;
				case TypeCode.UInt32:
					maxValue = uint.MaxValue;
					break;
				case TypeCode.UInt64:
					maxValue = ulong.MaxValue;
					break;
				default:
					maxValue = default(T);//set default value
					break;
			}

			return (T)maxValue;
		}

	}
}
