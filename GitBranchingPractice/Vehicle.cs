﻿using System;
namespace GitBranchingPractice
{
	public abstract class Vehicle
	{
		public Vehicle()
		{
		}

        public string Name { get; set; }


		public virtual void Go() // giving inheritors option to override
        {
            Console.WriteLine("Go");
        }
    }
}
