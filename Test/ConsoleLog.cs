﻿using System;
using Misakai.Kafka;

namespace Test
{
    /// <summary>
    /// This class simply logs all information out to the Trace log provided by windows.  
    /// The reason Trace is being used as the default it to remove extenal references from
    /// the base kafka-net package.  A proper logging framework like log4net is recommended.
    /// </summary>
    public class ConsoleLog : IKafkaLog
    {
        public void DebugFormat(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        public void InfoFormat(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        public void WarnFormat(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        public void FatalFormat(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }
    }
}
