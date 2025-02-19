﻿using System;
using System.Buffers.Binary;

namespace LegendaryExplorerCore.Gammtek.Extensions
{
	/// <summary>
	/// </summary>
	public static class DoubleExtensions
	{
		public static double BigEndian(this double value)
		{
			if (!BitConverter.IsLittleEndian)
			{
				return value;
			}

			var data = BitConverter.GetBytes(value);
			var junk = BitConverter.ToUInt64(data, 0).Swap();

			return BitConverter.ToDouble(BitConverter.GetBytes(junk), 0);
		}

		public static double LittleEndian(this double value)
		{
			if (!BitConverter.IsLittleEndian)
			{
				return value;
			}

			var data = BitConverter.GetBytes(value);
			var junk = BitConverter.ToUInt64(data, 0).Swap();

			return BitConverter.ToDouble(BitConverter.GetBytes(junk), 0);
		}

        public static double Swap(this double value)
        {
            return BitConverter.Int64BitsToDouble(BinaryPrimitives.ReverseEndianness(BitConverter.DoubleToInt64Bits(value)));
        }

		public static bool ToBoolean(this double value)
		{
			return Convert.ToBoolean(value);
		}

		public static byte ToByte(this double value)
		{
			return Convert.ToByte(value);
		}

		public static char ToChar(this double value)
		{
			return Convert.ToChar(value);
		}

		public static DateTime ToDateTime(this double value)
		{
			return Convert.ToDateTime(value);
		}

		public static decimal ToDecimal(this double value)
		{
			return Convert.ToDecimal(value);
		}

		public static short ToInt16(this double value)
		{
			return Convert.ToInt16(value);
		}

		public static int ToInt32(this double value)
		{
			return Convert.ToInt32(value);
		}

		public static long ToInt64(this double value)
		{
			return Convert.ToInt64(value);
		}

		public static sbyte ToSByte(this double value)
		{
			return Convert.ToSByte(value);
		}

		public static float ToSingle(this double value)
		{
			return Convert.ToSingle(value);
		}

		public static ushort ToUInt16(this double value)
		{
			return Convert.ToUInt16(value);
		}

		public static uint ToUInt32(this double value)
		{
			return Convert.ToUInt32(value);
		}

		public static ulong ToUInt64(this double value)
		{
			return Convert.ToUInt64(value);
		}
	}
}
