﻿using System;

namespace Legacy_solution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ecs = new ECS(28);

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate(); //test
        }
    }
}
