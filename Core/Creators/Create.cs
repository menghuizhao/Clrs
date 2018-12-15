namespace Core.Creators
{
    using System;
    public static class Create
    {
        public static int NewInt(int max)
        {
            var seed = new Random();
            return seed.Next(max);
        }

        public static int[] NewIntArray(int length)
        {
            if (length <= 0) return null;
            var arr = new int[length];
            for(int i = 0; i < length; i++)
            {
                arr[i] = Create.NewInt(100);
            }
            return arr;
        }
    }
}
