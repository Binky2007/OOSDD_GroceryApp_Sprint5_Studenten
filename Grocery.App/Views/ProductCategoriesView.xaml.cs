using Grocery.App.ViewModels;

namespace Grocery.App.Views
{
    [QueryProperty(nameof(CategoryId), "categoryId")]
    public partial class ProductCategoriesView : ContentPage
    {
        public int CategoryId { get; set; }

        public ProductCategoriesView(ProductCategoriesViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            ViewModel = viewModel;
        }

        public ProductCategoriesViewModel ViewModel { get; }

        protected override async void OnNavigatedTo(NavigatedToEventArgs args)
        {
            await ViewModel.Load(CategoryId);
        }
    }

}