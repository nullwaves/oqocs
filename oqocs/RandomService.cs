using System;

namespace oqocs
{
    public static class RandomService
    {
        private static readonly Random random = new Random();
        public static Random Instance => random;
    }
}