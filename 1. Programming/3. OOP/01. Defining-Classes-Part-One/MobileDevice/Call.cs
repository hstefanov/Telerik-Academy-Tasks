namespace MobileDevice
{
    using System;

    public class Call
    {
        private string dialedNumber;
        private int callDuration;

        public Call():this(new DateTime(),null,0)
        {
        }

        public Call(DateTime date, string number, int duration)
        {
            this.CallDate = date;
            this.dialedNumber = number;
            this.callDuration = duration;
        }

        public DateTime CallDate { get; set; }

        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
            set
            {
                if (value.Substring(0, 4) != "+359")
                {
                    throw new ArgumentException("Numbers must begint with +359!");
                }
                this.dialedNumber = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.callDuration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Duration cannot be negative!");
                }
                this.callDuration = value;
            }
        }

    }
}
