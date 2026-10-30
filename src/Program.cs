// Build: eb6a9322c79df0f9c766b4f4173e9c1d
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
