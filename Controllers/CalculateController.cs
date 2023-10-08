using System;
using HomeworkPractice.Helpers.Constants;
using HomeworkPractice.Services;

namespace HomeworkPractice.Controllers
{
	internal class CalculateController
	{

		private readonly CalculateService _calculateService;


		public CalculateController()
		{
			_calculateService = new CalculateService();
		}

		public void Calculate()
		{

			Console.WriteLine("Add first number:");

			

			Num1: string num1 = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(num1))
			{
                Console.WriteLine(CalculateNotifications.InputEmptyMessage);
                goto Num1;
            }

            double number1;

            bool IsTrueNum1 = double.TryParse(num1, out number1);

            if (!IsTrueNum1)
            {
                Console.WriteLine(CalculateNotifications.CorrectInputMessage);
                goto Num1;
            }


			Console.WriteLine("Please select one operator: +, -, /, *");

			string operation = Console.ReadLine();



			Console.WriteLine("Add second number: ");

            Num2: string num2 = Console.ReadLine();

            double number2;

            bool IsTrueNum2 = double.TryParse(num2, out number2);

			if (!IsTrueNum2)
			{
				Console.WriteLine(CalculateNotifications.CorrectInputMessage);
				goto Num2;
			}

			if(operation == "/" && number2 == 0)
			{
				Console.WriteLine("Cant divide by 0, please start again");
				goto Num1;
			}


			string result = _calculateService.Calculate(number1, number2, operation);

			Console.WriteLine(result);


        }
	}
}

