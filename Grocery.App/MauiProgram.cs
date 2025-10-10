using Grocery.Core.Services;
using Grocery.App.ViewModels;
using Grocery.App.Views;
using Microsoft.Extensions.Logging;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Data.Repositories;
using CommunityToolkit.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using Grocery.Core.Repositories;

namespace Grocery.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            // 🔧 Repositories
            builder.Services.AddSingleton<IGroceryListRepository, GroceryListRepository>();
            builder.Services.AddSingleton<IGroceryListItemsRepository, GroceryListItemsRepository>();
            builder.Services.AddSingleton<IProductRepository, ProductRepository>();
            builder.Services.AddSingleton<IClientRepository, ClientRepository>();
            builder.Services.AddSingleton<ICategoryRepository, CategoryRepository>();
            builder.Services.AddSingleton<IProductCategoryRepository, ProductCategoryRepository>();

            // 🔧 Services
            builder.Services.AddSingleton<IGroceryListService, GroceryListService>();
            builder.Services.AddSingleton<IGroceryListItemsService, GroceryListItemsService>();
            builder.Services.AddSingleton<IProductService, ProductService>();
            builder.Services.AddSingleton<IAuthService, AuthService>();
            builder.Services.AddSingleton<IClientService, ClientService>();
            builder.Services.AddSingleton<IFileSaverService, FileSaverService>();
            builder.Services.AddSingleton<IBoughtProductsService, BoughtProductsService>();
            builder.Services.AddSingleton<ICategoryService, CategoryService>();
            builder.Services.AddSingleton<IProductCategoryService, ProductCategoryService>();

            // 🔧 ViewModels
            builder.Services.AddSingleton<GlobalViewModel>();
            builder.Services.AddSingleton<CategoriesViewModel>();
            builder.Services.AddSingleton<ProductCategoriesViewModel>();
            builder.Services.AddTransient<GroceryListViewModel>();
            builder.Services.AddTransient<GroceryListItemsViewModel>();
            builder.Services.AddTransient<ProductViewModel>();
            builder.Services.AddTransient<ChangeColorViewModel>();
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<BestSellingProductsViewModel>();
            builder.Services.AddTransient<BoughtProductsViewModel>();

            // 🔧 Views
            builder.Services.AddTransient<GroceryListsView>();
            builder.Services.AddTransient<GroceryListItemsView>();
            builder.Services.AddTransient<ProductView>();
            builder.Services.AddTransient<ChangeColorView>();
            builder.Services.AddTransient<LoginView>();
            builder.Services.AddTransient<BestSellingProductsView>();
            builder.Services.AddTransient<BoughtProductsView>();
            builder.Services.AddTransient<CategoriesView>();
            builder.Services.AddTransient<ProductCategoriesView>();

            return builder.Build();
        }
    }
}
