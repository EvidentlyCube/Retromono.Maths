using System;
using System.Runtime.CompilerServices;

namespace Retromono.Maths {
    public static partial class MathI {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(sbyte value) => Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(short value) => Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(int value) => Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(long value) => (int) Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(byte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(char value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(ushort value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(uint value) => (int) value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(ulong value) => (int) value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(byte left, byte right) => left > right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(char left, char right) => left > right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(ushort left, ushort right) => left > right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(uint left, uint right) => (int) (left > right ? left : right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(ulong left, ulong right) => (int) (left > right ? left : right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(sbyte left, sbyte right) => left > right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(short left, short right) => left > right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(int left, int right) => left > right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(long left, long right) => (int) (left > right ? left : right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Min(byte left, byte right) => left < right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Min(char left, char right) => left < right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Min(ushort left, ushort right) => left < right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Min(uint left, uint right) => (int) (left < right ? left : right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Min(ulong left, ulong right) => (int) (left < right ? left : right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Min(sbyte left, sbyte right) => left < right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Min(short left, short right) => left < right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Min(int left, int right) => left < right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Min(long left, long right) => (int) (left < right ? left : right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(byte value) => value > 0 ? 1 : 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(char value) => value > 0 ? 1 : 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(ushort value) => value > 0 ? 1 : 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(uint value) => value > 0 ? 1 : 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(ulong value) => value > 0 ? 1 : 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(sbyte value) => Math.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(short value) => Math.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(int value) => Math.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(long value) => Math.Sign(value);
        
        // Rounding
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Ceiling(decimal value) => (int) Math.Ceiling(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Ceiling(double value) => (int) Math.Ceiling(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Ceiling(float value) => (int) Math.Ceiling(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Ceiling(byte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Ceiling(char value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Ceiling(ushort value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Ceiling(uint value) => (int)value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Ceiling(sbyte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Ceiling(short value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Ceiling(int value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Floor(decimal value) => (int) Math.Floor(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Floor(double value) => (int) Math.Floor(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Floor(float value) => (int) Math.Floor(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Floor(byte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Floor(char value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Floor(ushort value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Floor(sbyte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Floor(short value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Floor(int value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Round(decimal value) => (int) Math.Round(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Round(double value) => (int) Math.Round(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Round(float value) => (int) Math.Round(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Round(byte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Round(char value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Round(ushort value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Round(sbyte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Round(short value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Round(int value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Round(decimal value, MidpointRounding mode) => (int) Math.Round(value, mode);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Round(double value, MidpointRounding mode) => (int) Math.Round(value, mode);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Round(float value, MidpointRounding mode) => (int) Math.Round(value, mode);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Truncate(decimal value) => (int) Math.Truncate(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Truncate(double value) => (int) Math.Truncate(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Truncate(float value) => (int) Math.Truncate(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Truncate(byte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Truncate(char value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Truncate(ushort value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Truncate(sbyte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Truncate(short value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Truncate(int value) => value;
    }
}