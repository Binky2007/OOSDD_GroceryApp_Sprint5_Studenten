using Grocery.App.ViewModels;
using Microsoft.Maui.Controls;

namespace Grocery.App.Views
{
    public partial class ProductCategoriesView : ContentPage
    {
        public ProductCategoriesView(ProductCategoriesViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}