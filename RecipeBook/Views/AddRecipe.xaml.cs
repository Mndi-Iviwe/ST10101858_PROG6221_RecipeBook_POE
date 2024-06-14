using RecipeBook.ViewModel;
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
using System.Windows.Shapes;

namespace RecipeBook.Views
{
    /// <summary>
    /// Interaction logic for AddRecipe.xaml
    /// </summary>
    public partial class AddRecipe : Window
    {
        private int clickIngCount = 0;
        private int clickSteCount = 0;

        public AddRecipe()
        {
            InitializeComponent();
            AddRecipeViewModel addRecipeViewModel = new AddRecipeViewModel();
            this.DataContext = addRecipeViewModel;
        
        }

        private void btn_1_addIngredient_Click(object sender, RoutedEventArgs e)
        {
  
            txt_2_ingredName.Clear();
            txt_3_ingredMeasure.Clear();
            txt_4_Quant.Clear();
        }

        private void btn_2_addStep_Click(object sender, RoutedEventArgs e)
        {
            txt_5_Description.Clear();
        }

        private void numIngred_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (numIngred.Text == null)
            {
                MessageBox.Show("Recipe must contain atleast 1 Ingredient");
            }
            clickIngCount++;
            if (numIngred.Text.Equals(clickIngCount))
            {
                MessageBox.Show("Ingredient limit reached");
            }
        }

        private void txt_numStep_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_numStep.Text == null)
            {
                MessageBox.Show("Recipe must contain atleast 1 instruction");
            }

            clickSteCount++;
            if (txt_numStep.Text.Equals(clickSteCount))
            {
                MessageBox.Show("Instruction limit reached");
            }
        }

        private void btn_3_Save_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }
    }
}
