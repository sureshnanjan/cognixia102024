using System;

namespace GettingStarted
{
    [Flags] // This attribute enables the use of bitwise operations on enum values.
    public enum weeks
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64
    }
}
