namespace RangeExxception
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(T start, T end)
            : base("[" + start + "..." + end + "]")
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; set; }
        public T End { get; set; }
    }
}
