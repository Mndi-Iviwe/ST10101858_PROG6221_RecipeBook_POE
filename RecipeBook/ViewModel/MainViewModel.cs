using RecipeBook.Commands;
using RecipeBook.Model;
using RecipeBook.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RecipeBook.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<Recipe> Recipes { get; set; }

        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel()
        {
            Recipes = RecipeManager.GetRecipe();

            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            AddRecipe addRecipeWindow = new AddRecipe();
            addRecipeWindow.Show();
        }

    }
}
