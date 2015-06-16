namespace BitArray64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = ConvertToBitArray();
            for (int i = 0; i < bits.Length; i++)
            {
                yield return bits[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private int[] ConvertToBitArray()
        {
            int[] bits = new int[64];
            for (int i = 0; i < bits.Length; i++)
            {
                int bit = (int)((this.Number>> i) & 1);
                bits[63 - i] = bit;
            }
            return bits;
        }

        //equals
        public override bool Equals(object obj)
        {
            if(!(obj is BitArray))
            {
                return false;
            }
            BitArray64 temp = obj as BitArray64;
            if (ReferenceEquals(temp, null))
            {
                return false;
            }
            if (ReferenceEquals(this, temp))
            {
                return true;
            }
            return this.Number == temp.Number;
        }

        //== operator
        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

        //!= operator
        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals(first, second);
        }

        //hash code
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + this.Number.GetHashCode();
                return result;
            }
        }

        //indexator
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new System.ArgumentOutOfRangeException();
                }

                int[] bits = ConvertToBitArray();
                return bits[index];
            }
        }

    }
}
