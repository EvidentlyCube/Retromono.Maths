# Retromono.Maths

A set of two classes which allow handy and fast casted (to `float` and `int`) versions of all `System.Math` methods with some additional functionalities.

## How to use
MathF.Floor(15.0);
MathI.Max(7, 50);

## API

### Classes

 - `MathF` contains equivalents to majority `System.Math` methods that return `float` instead
 - `MathI` contains equivalents to a couple of `System.Math` methods that return `int` instead

### New methods
 - `float/int ApproachStep(currentValue, targetValue, step)`  - Returns a value which is `currentValue` increased or decreased by `step` in the direction of `targetValue`. If the difference between `currentValue` and `targetValue` is smaller than `step` then `targetValue` is returned. It can be used to create a linear easing towards `targetValue`.
 - `float ApproachFactor(currentValue, targetValue, factor, roundWhen)` - Returns a value which is `currentValue` increased or decreased by `factor` of the difference between `currentValue` and `targetValue`. If the difference is smaller than `roundWhen` then `targetValue` is returned. It can be used to create a non-linear, slowing-down easing towards `targetValue`.
 - `float/int Clamp(value, min, max)` - Clamps `value` to be between `min` and `max`.
 - `float Distance(x1, y1, x2, y2)` - Returns the euclidean distance between points `(x1, y1)` and `(x2, y2)`. Also known as **L2 distance**.
 - `float/int DistanceSquared(x1, y1, x2, y2)` - Returns the square euclidean distance between points `(x1, y1)` and `(x2, y2)`. This method skips the expensive square root that happens in `Distance()` and is useful when you only need to compare distances.
 - `float/int DistanceManhattan(x1, y1, x2, y2)` - Returns the manhattan distance between points `(x1, y1)` and `(x2, y2)`, which is a grid distance in non-diagonal moves. Also known as **L1 distance** or **snake distance**. More information - https://en.wikipedia.org/wiki/Taxicab_geometry.
 - `float/int DistanceChess(x1, y1, x2, y2)` - Returns the chess distance between points `(x1, y1)` and `(x2, y2)`, which is a grid distance where diagonal moves are as expensive as non-diagonal ones. Also known as **L-infinity distance** or **Chebyshev distance**. More information - https://en.wikipedia.org/wiki/Chebyshev_distance.
 - `float FloorToFraction(value, toFraction)` - Floors `value` to the multiplication of `toFraction`. Eg, `FloorToFraction(1.7, 0.5)` will return `1.5` because it's the closest multiplication of `0.5` that is smaller than `1.7`.
 - `float/int Wrap(value, min, max)` - Wraps `value` so that it sits between `min` (inclusive) and `max` (exclusive).