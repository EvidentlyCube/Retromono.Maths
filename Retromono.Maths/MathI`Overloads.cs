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
    }
}