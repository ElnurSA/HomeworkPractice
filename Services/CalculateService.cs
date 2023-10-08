using System;
using System.Data;
using HomeworkPractice.Helpers.Constants;

namespace HomeworkPractice.Services
{
	internal class CalculateService
	{
		public string Calculate(double num1, double num2, string operation)
		{
            string result;
            switch (operation)
			{
				case "+":
					result = (num1 + num2).ToString();

                    return result;
				case "-":
					result = (num1 - num2).ToString();

                    return result;
				case "*":
					result = (num1 * num2).ToString();

                    return result;
				case "/":
					result = (num1 / num2).ToString();

                    return result;
				default:
					result = CalculateNotifications.InvalidOperation;

					return result;
						
					
			}
		}
	}
}

