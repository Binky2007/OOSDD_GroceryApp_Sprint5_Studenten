using Grocery.App.ViewModels;
using Grocery.Core.Models;
using Microsoft.Maui.Controls;

namespace Grocery.App.Views
{
    public partial class CategoriesView : ContentPage
    {
        public CategoriesView(CategoriesViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
        private async void OnCategoryTapped(object sender, ItemTappedEventArgs e)
        {
            var category = e.Item as Category;
            if (category != null)
            {
                await Shell.Current.GoToAsync($"productcategories?categoryId={category.Id}");
            }
        }

    }
}