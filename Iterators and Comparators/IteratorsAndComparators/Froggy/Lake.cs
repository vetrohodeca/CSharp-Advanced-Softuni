using System;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake
    {
        private readonly int[] stones;
        public Lake(params int[] stones)
        {
            this.stones = stones;
        }
        public IEnumerator <int> GetEnumerator()
        {
            for (int i = 0; i < stones.Length; i++)
            {
                yield return this.stones[i];
            }
            for (int i = stones.Length; i >=0; i--)
            {
                if(i%2!=0)
                {
                    yield return this.stones[i];
                }
            }
        }
    }
}
