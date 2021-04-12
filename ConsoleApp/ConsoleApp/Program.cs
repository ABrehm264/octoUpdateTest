﻿using System;
using ConsoleApp.Libraries;

namespace ConsoleApp
{
    class Program
    {
        public static ILogger MyLogger { get; set; }

        static Program()
        {
            MyLogger = new ConsoleLogger(LogLevels.Verbose);
        }

        static void Main(string[] args)
        { 
            MyLogger.Log(LogLevels.Verbose, "Hello World!");
            MyLogger.Log(LogLevels.Warn, "This is a warning");
            MyLogger.Log(LogLevels.Error, "This is an error");
        }
    }
}
