using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MySecondProjectN01708024.Controllers
{
	public class J3Controller : ApiController
	{
		/// <summary>
		/// *x* xx * * Write a program that accepts a positive integer scaling factor and outputs the scaled icon.
		/// A scaling factor of k means that each character is replaced by a k × k grid consisting only of that character.
		/// The input will be a positive integer k such that k < 25.
		/// </summary>
		/// <returns>
		/// The output will be 3k lines, which represent each individual line scaled by a factor of k and repeated k times.
		/// A line is scaled by a factor of k by replacing each character in the line with k copies of the character.
		/// </returns>
		/// <param>
		/// k,j3
		/// </param>
		/// <example>
		///localhostXX/api/J3/num?k=3-->***xxx*** ***xxx*** ***xxx*** xxxxxx xxxxxx xxxxxx *** *** *** *** *** ***
		///localhostXX/api/J3/num?k=2-->**xx** **xx** xxxx xxxx ** ** ** **
		/// </example>
		[HttpGet]
		[Route("api/J3/num")]
		public IHttpActionResult J3(int k)
		{
			string[] originalIcon = {
			"*x*",
			"xx",
			"* *"
		};

			string J3 = "";

			foreach (string line in originalIcon)
			{
				
				for (int i = 0; i < k; i++)
				{
					foreach (char c in line)
					{
				
						for (int j = 0; j < k; j++)
						{
							J3 += c;
						}
					}
					J3 += $"\n"; 
				}
			}

			return Ok(J3.TrimEnd()); 
		}
	}
}
