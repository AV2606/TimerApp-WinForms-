using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Timer
{
    public class ClockDoesNotCountingException : Exception
    {
        public ClockDoesNotCountingException(string message) : base(message)
        {

        }
    }
    class Watch
    {
        private static DateTime Default = new DateTime(DateTime.MinValue.Ticks);
        private static DateTime Zero = new DateTime(0);

        private DateTime StartTime;
        private DateTime AddTime;

        /// <summary>
        /// Indicates wether the clock is currently ticking
        /// </summary>
        public bool IsTicking
        {
            get
            {
                return StartTime != Default;
            }
        }
        /// <summary>
        /// Shows wether this clock is paused or not.
        /// </summary>
        public bool IsPaused { get; private set; } = true;

        public Watch()
        {
            StartTime = Default;
            AddTime = Zero;
        }
        /// <summary>
        /// Starts to tick the clock. or continues if it was paused.
        /// </summary>
        public void StartCon()
        {
            StartTime = DateTime.Now;
            IsPaused = false;
        }
        /// <summary>
        /// Get the total milliseconds the clock "counted".
        /// </summary>
        /// <returns></returns>
        public long GetMillisecondsPast()
        {
            var stime = StartTime;
            var now = DateTime.Now;
            if (StartTime == Default)
                stime = now;
                //throw new ClockDoesNotCountingException("The clock is not ticking!");
            return (long)((now - stime).TotalMilliseconds + (AddTime-Zero).TotalMilliseconds);
        }
        /// <summary>
        /// Get the total Seconds the clock "counted".
        /// </summary>
        /// <returns></returns>
        public long GetSecondsPast()
        {
            if (StartTime == Default)
                throw new ClockDoesNotCountingException("The clock is not ticking!");
            return (long)((DateTime.Now - StartTime).TotalSeconds + (AddTime - Zero).TotalSeconds);
        }
        /// <summary>
        /// Get the total Minutes the clock "counted".
        /// </summary>
        /// <returns></returns>
        public long GetMinutesPast()
        {
            if (StartTime == Default)
                throw new ClockDoesNotCountingException("The clock is not ticking!");
            return (long)((DateTime.Now - StartTime).TotalMinutes + (AddTime - Zero).TotalMinutes);
        }
        /// <summary>
        /// Get the total Hours the clock "counted".
        /// </summary>
        /// <returns></returns>
        public long GetHoursPast()
        {
            if (StartTime == Default)
                throw new ClockDoesNotCountingException("The clock is not ticking!");
            return (long)((DateTime.Now - StartTime).TotalHours + (AddTime - Zero).TotalHours);
        }
        /// <summary>
        /// Stops the clock from ticking.
        /// </summary>
        public void Pause()
        {
            AddTime = new DateTime(GetMillisecondsPast()*10000);
            StartTime = Default;
            IsPaused = true;
        }
        /// <summary>
        /// Stops counting and resets the clock.
        /// </summary>
        public void Stop()
        {
            StartTime = Default;
            AddTime = Zero;

        }
        /// <summary>
        /// Resets the clock.
        /// </summary>
        public void Reset()
        {
            AddTime = Zero;
            StartTime = IsPaused? Default:DateTime.Now;
        }
    }
}
