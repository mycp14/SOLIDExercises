﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    interface IErrorLogger
    {
        void NewErrorlogger();
        void Log(string errorMessage);
    }
}
