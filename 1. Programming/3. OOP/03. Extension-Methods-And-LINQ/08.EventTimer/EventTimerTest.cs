﻿/*
*8.Read in MSDN about the keyword event in C# and how to publish events. 
Re-implement the above using .NET events and following the best practices.
*/

namespace EventTimer
{
    using System;
    using System.Threading;
    
    public delegate void TimeElapsedEventHandler(object publisher,TimeElapsedEventArgs e);

    public class TimeElapsedEventArgs : EventArgs //inherits EventArgs and adds some more funcionality
    {
        public int Ticks { get; set; }
 
        public TimeElapsedEventArgs(int ticks)
        {
            this.Ticks = ticks;
        }
    }

    public class Timer
    {
        public int Interval { get; set; }
        public int Ticks { get; set; }

        public event TimeElapsedEventHandler TimeElapsed;//declare event

        public Timer(int interval, int ticks)
        {
            this.Interval = interval;
            this.Ticks = ticks;
        }

        public void Subscribe(int ticks)
        {
            TimeElapsedEventArgs e = new TimeElapsedEventArgs(ticks);
            TimeElapsed(this, e);
        }

        public void Run()
        {
            while (Ticks > 0)
            {
                Thread.Sleep(this.Interval);
                this.Ticks--;
                Subscribe(this.Ticks);
            }
        }
    }

    class EventTimerTest
    {
        static void Message(object publisher, TimeElapsedEventArgs e)
        {
            Console.WriteLine("{0} ticks left...", e.Ticks);
        }

        static void Main()
        {
            Timer testTimer = new Timer(3000, 5);

            testTimer.TimeElapsed += new TimeElapsedEventHandler(Message);

            Thread th = new Thread(new ThreadStart(testTimer.Run));

            th.Start();
        }
    }
}
