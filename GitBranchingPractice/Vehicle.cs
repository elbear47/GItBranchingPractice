using System;
namespace GitBranchingPractice
{
	public abstract class Vehicle
	{
		public Vehicle()
		{
		}

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }

        public virtual void Go() // giving inheritors option to override
        {
            Console.WriteLine($"{Name} is going");
        }
    }
}

