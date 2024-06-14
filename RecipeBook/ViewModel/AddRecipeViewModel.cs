using RecipeBook.Commands;
using RecipeBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Xml.Linq;

namespace RecipeBook.ViewModel
{
    public class AddRecipeViewModel
    {
        public ICommand AddRecipeCommand { get; set; }
        public ICommand AddIngredients {  get; set; }
        public ICommand AddSteps { get; set; }

        public ICommand DisplayRecipes {  get; set; }

        
        public string recipeName { get; set; }
        public double recipeCalorieTotal;

        //Ingredient Details
        public int numIngred { get; set; }
        public List<string> ingredName { get; set; }
        public List<string> ingredUnit { get; set; }
        public List<double> ingredQuant { get; set; }
        public List<double> ingredCalories { get; set; }
        public List<string> ingredFoodgrp { get; set; }

        
        //Step Details
        public int numSteps { get; set; }
        public List<string> stepDescr { get; set; }







        //Methods to Calculate and cycle through loops

        //Add Recipe Details to the object context of the class



        public double CalcTotalCalories()
        {
            double totalCalories = 0;
            for (int i = 0; i < numIngred; i++)
            {
                totalCalories += ingredCalories[i] * ingredQuant[i];
            }
            recipeCalorieTotal = totalCalories;
            return recipeCalorieTotal;
        }

        //Add Recipe to list
        public AddRecipeViewModel()
        {
            AddRecipeCommand = new RelayCommand(AddRecipe, CanAddRecipe);
            DisplayRecipes = new RelayCommand(DisplayRecipe, CanDisplayRecipe);
        }

        private void DisplayRecipe(object obj)
        {

            Console.WriteLine("\n Ingredients: ");
            for (int x = 0; x < numIngred; x++)
            {
                Console.WriteLine(ingredQuant[x] + " " + ingredUnit[x] + " of " + ingredName[x] + " (" + ingredFoodgrp[x] +")");
            }

            int count = 0;

            Console.WriteLine("\n Instructions:");
            for (int x = 0; x < numSteps; x++)
            {
                Console.WriteLine("\nStep #{0}: {1}", count + 1, stepDescr[x]);
                count++;
            }
        }

        private bool CanDisplayRecipe(object obj)
        {
            return true;
        }

        
        private bool CanAddRecipe(object obj)
        {
            return true;
        }

        private void AddRecipe(object obj)
        {
            RecipeManager.AddRecipe(new Recipe() {recipeName = recipeName, numIngred = numIngred, ingredName = ingredName, ingredUnit = ingredUnit, ingredQuant = ingredQuant, ingredCalories = ingredCalories, ingredFoodgrp = ingredFoodgrp, numSteps = numSteps, stepDescr = stepDescr, recipeCalorieTotal = CalcTotalCalories() });
        }
    }
}
