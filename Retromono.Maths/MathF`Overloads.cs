using System;
using System.Runtime.CompilerServices;

namespace Retromono.Maths {
    public static partial class MathF {
        // Simple numeric
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(decimal value) => (float) Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(double value) => (float) Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(float value) => Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(sbyte value) => Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(short value) => Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(int value) => Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(long value) => Math.Abs(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(byte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(char value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(ushort value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(uint value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(ulong value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float IEEERemainder(double dividend, double divisor) => (float) Math.IEEERemainder(dividend, divisor);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(byte left, byte right) => left > right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(char left, char right) => left > right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(ushort left, ushort right) => left > right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(uint left, uint right) => left > right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(ulong left, ulong right) => left > right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(sbyte left, sbyte right) => left > right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(short left, short right) => left > right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(int left, int right) => left > right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(long left, long right) => left > right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(decimal left, decimal right) => left > right ? (float) left : (float) right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(float left, float right) => left > right || float.IsNaN(left) ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(double left, double right) => left > right || double.IsNaN(left) ? (float) left : (float) right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(byte left, byte right) => left < right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(char left, char right) => left < right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(ushort left, ushort right) => left < right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(uint left, uint right) => left < right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(ulong left, ulong right) => left < right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(sbyte left, sbyte right) => left < right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(short left, short right) => left < right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(int left, int right) => left < right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(long left, long right) => left < right ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(decimal left, decimal right) => left < right ? (float) left : (float) right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(float left, float right) => (double) left < (double) right || float.IsNaN(left) ? left : right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(double left, double right) => left < right || double.IsNaN(left) ? (float) left : (float) right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sign(byte value) => value > 0 ? 1 : 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sign(char value) => value > 0 ? 1 : 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sign(ushort value) => value > 0 ? 1 : 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sign(uint value) => value > 0 ? 1 : 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sign(ulong value) => value > 0 ? 1 : 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sign(sbyte value) => Math.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sign(short value) => Math.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sign(int value) => Math.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sign(long value) => Math.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sign(decimal value) => Math.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sign(float value) => Math.Sign(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sign(double value) => Math.Sign(value);

        // Rounding
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceiling(decimal value) => (float) Math.Ceiling(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceiling(double value) => (float) Math.Ceiling(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceiling(float value) => (float) Math.Ceiling(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceiling(byte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceiling(char value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceiling(ushort value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceiling(uint value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceiling(ulong value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceiling(sbyte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceiling(short value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceiling(int value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceiling(long value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(decimal value) => (float) Math.Floor(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(double value) => (float) Math.Floor(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(float value) => (float) Math.Floor(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(byte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(char value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(ushort value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(uint value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(ulong value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(sbyte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(short value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(int value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(long value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(decimal value) => (float) Math.Round(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(double value) => (float) Math.Round(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(float value) => (float) Math.Round(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(byte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(char value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(ushort value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(uint value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(ulong value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(sbyte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(short value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(int value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(long value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(decimal value, MidpointRounding mode) => (float) Math.Round(value, mode);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(double value, MidpointRounding mode) => (float) Math.Round(value, mode);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(float value, MidpointRounding mode) => (float) Math.Round(value, mode);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(decimal value) => (float) Math.Truncate(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(double value) => (float) Math.Truncate(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(float value) => (float) Math.Truncate(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(byte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(char value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(ushort value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(uint value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(ulong value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(sbyte value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(short value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(int value) => value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(long value) => value;

        // Exponentials
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Exp(double value) => (float) Math.Exp(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Log(double value) => (float) Math.Log(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Log(double value, double newBase) => (float) Math.Log(value, newBase);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Log10(double value) => (float) Math.Log10(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Pow(double left, double right) => (float) Math.Pow(left, right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sqrt(double value) => (float) Math.Sqrt(value);

        // Trigonometry
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Acos(double value) => (float) Math.Acos(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Acos(float value) => (float) Math.Acos(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Asin(double value) => (float) Math.Asin(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Atan(double value) => (float) Math.Atan(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Atan2(double left, double right) => (float) Math.Atan2(left, right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Atan2(float left, float right) => (float) Math.Atan2(left, right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Cos(double value) => (float) Math.Cos(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Cosh(double value) => (float) Math.Cosh(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sinh(double value) => (float) Math.Sinh(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Tan(double value) => (float) Math.Tan(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Tanh(double value) => (float) Math.Tanh(value);
    }
}