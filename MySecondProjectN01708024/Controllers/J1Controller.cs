using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Optimization;

namespace MySecondProjectN01708024.Controllers
{
	public class DefaultController : ApiController
	{
		/// <summary>
		/// Write a program that will compute the total Calories of the meal.
		/// {burger} - Integer representing the index burger choice
		/// {drink} - Integer representing the index drink choice
		/// {side} - Integer representing the index side choice
		/// {dessert} - Integer representing the index dessert choice
		/// </summary>
		/// <returns>
		/// return "your Total calorie  is" + totalcalorise;
		/// if (burger),(drink),(side),(dessert)< 1 || >4 -->return "no burger","no drink","no side order","No Dessert";
		/// </returns>
		/// <example>
		/// localhost/api/J1/Menu/{burger}/{drink}/{side}/{dessert}
		/// localhost/api/J1/Menu/4/4/4/4-->Your total calorie count is 0
		/// localhost/api/J1/Menu/1/2/3/4-->Your total calorie count is 691
		/// </example>

		[HttpGet]
		[Route("api/J1/{burger}/{drink}/{side}/{dessert}")]
		public string J1(int burger, int drink, int side, int dessert)
		{
			int[] burgerchoices = {0,461,431,420,0}; //[Cheeseburger, Fish Burger, Veggie Burger, No burger]
			int[] drinkchoices = {0,130,160,118,0};//[Soft Drink, Orange Juice, Milk, No drink]
			int[] sidechoices = {0,100,57,70,0}; //[Fries, Baked Potato, Chef Salad, No side order]
			int[] dessertchoices = {0,167,266,420,0}; //[Apple Pie, Sundae, Fruit Cup, No dessert]

			if (burger < 1 || burger > 4)
			{
				return "no burger";
			}
			if (drink < 1 || burger > 4)
			{
				return "no drink";
			}
			if (side < 1 || burger > 4)
			{
				return "no side order";
			}
			if (dessert < 1 || burger > 4)
			{
				return "No Dessert";
			}

			int totalcalorise = burgerchoices[burger] + drinkchoices[drink] + sidechoices[side] + dessertchoices[dessert];

			return "your Total calorie  is " + totalcalorise;
		}
	}
}