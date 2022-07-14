using System;
namespace Classes
{
	public class Car
	{
		//Constructors
		public Car()
		{

		}

        public Car(string makeInput, string modelInput, int yearInput)
        {
			Make = makeInput;
			Model = modelInput;
			Year = yearInput;
        }

		//Properties
		public string Make { get; set; } // get = read   set = write
		public string Model { get; set; }
		public int Year { get; set; }
	}
}

