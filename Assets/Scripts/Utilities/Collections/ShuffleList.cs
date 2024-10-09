using System;
using System.Collections.Generic;
using Unity.Mathematics;

namespace OSGames.Utilities {

    public static class ListFunctions {

        // private static Random rng = new Random();  

        public static void ShuffleList<T>(this IList<T> list)  
        {  
            uint seed = (uint) DateTime.Now.Millisecond;
            if (seed == 0) seed = 1;
            Unity.Mathematics.Random rng = new Unity.Mathematics.Random(seed);
            int n = list.Count;  
            while (n > 1) {  
                n--;  
                int k = rng.NextInt(n + 1);  
                T value = list[k];  
                list[k] = list[n];  
                list[n] = value;  
            }  
        }
    }

}