﻿using System.Data.Common;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TomilovAD.Sprint1.Task2.V25.Lib
{
    public class DataService : ISprint1Task2V25
    {
        public double ConvertRadsToDegrees(int value)
        {
            return Math.Round( value * 180 / Math.PI, 3);
        }
    }
}
