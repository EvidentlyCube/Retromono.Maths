using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Retromono.Maths {
    internal static class MathCommon {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static double Clamp(double value, double min, double max) {
            if (double.IsNaN(value) || double.IsNaN(min) || double.IsNaN(max))
                return value;
            else if (value > max)
                return max;
            else if (value < min)
                return min;
            else
                return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static double ApproachStep(double currentValue, double targetValue, double step) {
            Contract.Requires(step > float.Epsilon);
            
            if (currentValue.Equals(targetValue) || Math.Abs(targetValue - currentValue) <= step) {
                return targetValue;
            } else if (currentValue < targetValue) {
                return currentValue + step;
            } else {
                return currentValue - step;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static double ApproachFactor(double currentValue, double targetValue, double factor, double roundWhen) {
            Contract.Requires(factor > float.Epsilon);
            Contract.Requires(roundWhen > float.Epsilon);
            
            if (double.IsNaN(currentValue) || double.IsNaN(targetValue) || double.IsNaN(factor) || double.IsNaN(roundWhen))
                return currentValue;
            
            if (currentValue.Equals(targetValue) || Math.Abs(targetValue - currentValue) <= roundWhen) {
                return targetValue;
            } else {
                return currentValue + (targetValue - currentValue) * factor;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static double Wrap(double value, double min, double max) {
            Contract.Requires(min < max);

            if (double.IsNaN(value) || double.IsNaN(min) || double.IsNaN(max))
                return value;
            
            var delta = max - min;
            while (value < min) {
                value += delta;
            }
            
            while (value >= max) {
                value -= delta;
            }

            return value;
        }

    }
}