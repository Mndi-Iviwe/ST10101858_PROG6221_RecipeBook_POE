using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RecipeBook.Model;
using RecipeBook.ViewModel;

namespace RecipeBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
        }

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            RecipeList.Items.Filter = FilterName;
            RecipeList.Items.Filter = FilterIngredient;

        }

        private bool FilterName(object obj)
        {
            var recipe = (Recipe)obj;

    
            return recipe.recipeName.Contains(searchBar.Text);
        }

        private bool FilterIngredient(object obj)
        {
            var recipe = (Recipe)obj;

            return recipe.ingredName.Contains(searchBar.Text);
        }
        private void listItem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
