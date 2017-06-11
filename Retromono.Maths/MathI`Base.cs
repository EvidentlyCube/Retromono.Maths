using System.Runtime.CompilerServices;

namespace Retromono.Maths {
    public static partial class MathI {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ApproachStep(int currentValue, int targetValue, int step) => (int) MathCommon.ApproachStep(currentValue, targetValue, step);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(int value, int min, int max) => (int) MathCommon.Clamp(value, min, max);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int DistanceSquared(int x1, int y1, int x2, int y2) => (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int DistanceManhattan(int x1, int y1, int x2, int y2) => Max(Abs(x2 - x1), Abs(y2 - y1));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int DistanceChess(int x1, int y1, int x2, int y2) => Abs(x2 - x1) + Abs(y2 - y1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Wrap(int value, int min, int max) => (int) MathCommon.Wrap(value, min, max);
    }
}