﻿namespace DateTimeTest
{
    using System;

    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime DateTimeNow
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}