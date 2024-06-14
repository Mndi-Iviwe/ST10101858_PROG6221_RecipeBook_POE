using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Model
{
    public class RecipeManager
    {
        public static ObservableCollection<Recipe> _SavedRecipes = new ObservableCollection<Recipe>() { new Recipe() { recipeName = "Large Deep Dish Pizza", recipeCalorieTotal = 3000 } };


        public static ObservableCollection<Recipe> GetRecipe()
        {
            return _SavedRecipes;
        }

        public static void AddRecipe(Recipe recipe)
        {
            _SavedRecipes.Add(recipe);
        }
    }
}
