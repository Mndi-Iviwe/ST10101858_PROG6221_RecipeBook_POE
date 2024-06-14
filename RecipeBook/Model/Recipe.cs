using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Model
{
    public class Recipe
    {
        public string recipeName {  get; set; }
        public double recipeCalorieTotal;

        //Ingredient Details
        public int numIngred {  get; set; }
        public List<string> ingredName { get; set; }
        public List<string> ingredUnit { get; set; }
        public List<double> ingredQuant { get; set; }
        public List<double> ingredCalories { get; set; }
        public List<string> ingredFoodgrp { get; set; }

        //Step Details
        public int numSteps { get; set; }
        public List<string> stepDescr { get; set; }

        


        public Recipe()
        {
            
        }

    }
}
