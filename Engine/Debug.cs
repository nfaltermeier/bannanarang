﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Engine
{
    static class Debug
    {
        public static void Log(string output)
        {
            System.Diagnostics.Debug.WriteLine(output);
        }
    }
}