using Grocery.App.Views;

namespace Grocery.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registratie van routes voor navigatie via GoToAsync
            Routing.RegisterRoute(nameof(GroceryListItemsView), typeof(GroceryListItemsView));
            Routing.RegisterRoute(nameof(ProductView), typeof(ProductView));
            Routing.RegisterRoute(nameof(ChangeColorView), typeof(ChangeColorView));
            Routing.RegisterRoute("Login", typeof(LoginView)); // Login route
            Routing.RegisterRoute(nameof(BestSellingProductsView), typeof(BestSellingProductsView));
            Routing.RegisterRoute(nameof(BoughtProductsView), typeof(BoughtProductsView));
            Routing.RegisterRoute(nameof(CategoriesView), typeof(CategoriesView));
            Routing.RegisterRoute(nameof(ProductCategoriesView), typeof(ProductCategoriesView));
            Routing.RegisterRoute("productcategories", typeof(ProductCategoriesView));

        }
    }
}