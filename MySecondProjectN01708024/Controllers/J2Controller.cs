using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MySecondProjectN01708024.Controllers
{
    public class J2Controller : ApiController
    {
		/// <summary>
		/// Write a program which determines how many ways she can roll the value of 10.
		/// For example, when the first die has 6 sides (m=6) and the second die has 8 sides (n=8), there
		///are 5 ways to get the sum 10.
		///(m=6),(n=8)=sum
		///2,8=10
		///3,7=10
		///4,6=10
		///5,5=10
		///6,4=10
		/// </summary>
		/// <returns>
		/// (int i = 1;i <= m;i++) if this condition is true than check (int j = 1;j <= n;j++)than if (i + j == 10) than sum++
		/// if (sum == 0)--->"There are 0 ways to get the sum 10."
		/// if (sum == 1)--->"There is 1 way to get the sum 10."
		/// else "There are {sum} total ways to get the sum 10."
		/// </returns>
		/// <param>
		/// m,n,sum
		/// </param>
		/// <example>
		/// localhost/api/J1/Menu/{burger}/{drink}/{side}/{dessert}
		/// localhost/api/J1/Menu/4/4/4/4-->Your total calorie count is 0
		/// localhost/api/J1/Menu/1/2/3/4-->Your total calorie count is 691
		/// </example>
		[HttpGet]
		[Route("api/J2/{m}/{n}")]
		public string J2(int m, int n)
		{
			int sum = 0;
			for (int i = 1;i <= m;i++)
			{
				for (int j = 1;j <= n;j++)
				{
					if (i + j == 10)
					{
						sum++;
					}
				}
			}

			
			string output;
			if (sum == 0)
			{
				output = $"There are 0 ways to get the sum 10.";
			}
			else if (sum == 1)
			{
				output = $"There is 1 way to get the sum 10.";
			}
			else
			{
				output = $"There are {sum} total ways to get the sum 10.";
			}
			return (output);
		}
	}
}