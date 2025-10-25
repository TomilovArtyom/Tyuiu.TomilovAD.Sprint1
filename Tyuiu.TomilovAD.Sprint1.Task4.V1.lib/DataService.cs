﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TomilovAD.Sprint1.Task4.V1.lib
{
    public class DataService : ISprint1Task4V1
    {
        public double Calculate(double x)
        {
            return Math.Round(1 / ((x + 2)*(x + 2)), 3);
        }
    }
}
