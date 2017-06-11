using System;
using System.Runtime.CompilerServices;

namespace Retromono.Maths {
    public static partial class MathF {
        public const float PI = (float) Math.PI;
        public const float E = (float) Math.E;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ApproachStep(float currentValue, float targetValue, float step) => (float)MathCommon.ApproachStep(currentValue, targetValue, step);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ApproachFactor(float currentValue, float targetValue, float factor, float roundWhen) => (float) MathCommon.ApproachFactor(currentValue, targetValue, factor, roundWhen);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp(float value, float min, float max) => (float)MathCommon.Clamp(value, min, max);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(float x1, float y1, float x2, float y2) => Sqrt(DistanceSquared(x1, y1, x2, y2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float DistanceSquared(float x1, float y1, float x2, float y2) => (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float DistanceManhattan(float x1, float y1, float x2, float y2) => Max(Abs(x2 - x1), Abs(y2 - y1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float DistanceChess(float x1, float y1, float x2, float y2) => Abs(x2 - x1) + Abs(y2 - y1);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float FloorToFraction(double value, double toFraction) => (float)(Floor(value / toFraction) * toFraction);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float FloorToFraction(float value, float toFraction) => Floor(value / toFraction) * toFraction;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Wrap(float value, float min, float max) => (float)MathCommon.Wrap(value, min, max);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Wrap(int value, int min, int max) => (float)MathCommon.Wrap(value, min, max);
    }
}