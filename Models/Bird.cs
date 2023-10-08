using System;
namespace HomeworkPractice.Models
{
	internal class Bird : Animal
	{
        public virtual void Sound()
        {
            Console.WriteLine("Bird sound");
        }
    }
}

