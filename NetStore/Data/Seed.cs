using Microsoft.EntityFrameworkCore;
using NetStore.Models.Store;

namespace NetStore.Data;

public static class Seed
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        var electronicsCategoryId = Guid.NewGuid();
        var booksCategoryId = Guid.NewGuid();
        var clothingCategoryId = Guid.NewGuid();
        var homeKitchenCategoryId = Guid.NewGuid();

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = electronicsCategoryId, Name = "Electronics", Description = "Electronic devices and gadgets" },
            new Category { Id = booksCategoryId, Name = "Books", Description = "Various genres of books" },
            new Category { Id = clothingCategoryId, Name = "Clothing", Description = "Apparel and clothing items" },
            new Category { Id = homeKitchenCategoryId, Name = "Home & Kitchen", Description = "Home and kitchen appliances" }
        );
        
        var smartphoneProductId = Guid.NewGuid();
        var laptopProductId = Guid.NewGuid();
        var headphonesProductId = Guid.NewGuid();
        var smartwatchProductId = Guid.NewGuid();
        var novelProductId = Guid.NewGuid();
        var scifiBookProductId = Guid.NewGuid();
        var cookbookProductId = Guid.NewGuid();
        var biographyProductId = Guid.NewGuid();
        var tshirtProductId = Guid.NewGuid();
        var jeansProductId = Guid.NewGuid();
        var jacketProductId = Guid.NewGuid();
        var sneakersProductId = Guid.NewGuid();
        var blenderProductId = Guid.NewGuid();
        var coffeeMakerProductId = Guid.NewGuid();
        var vacuumCleanerProductId = Guid.NewGuid();
        var airFryerProductId = Guid.NewGuid();
        var microwaveOvenProductId = Guid.NewGuid();
        var toasterProductId = Guid.NewGuid();
        var cutlerySetProductId = Guid.NewGuid();
        var cookwareSetProductId = Guid.NewGuid();

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = smartphoneProductId, Title = "Smartphone", Description = "Latest model smartphone",
                BasePrice = 699.99m, Stock = 50, CategoryId = electronicsCategoryId
            },
            new Product
            {
                Id = laptopProductId, Title = "Laptop", Description = "High performance laptop", BasePrice = 999.99m,
                Stock = 30, CategoryId = electronicsCategoryId
            },
            new Product
            {
                Id = headphonesProductId, Title = "Headphones", Description = "Noise-cancelling headphones",
                BasePrice = 199.99m, Stock = 100, CategoryId = electronicsCategoryId
            },
            new Product
            {
                Id = smartwatchProductId, Title = "Smartwatch", Description = "Feature-rich smartwatch",
                BasePrice = 299.99m, Stock = 70, CategoryId = electronicsCategoryId
            },
            new Product
            {
                Id = novelProductId, Title = "Novel", Description = "Bestselling novel", BasePrice = 14.99m,
                Stock = 200, CategoryId = booksCategoryId
            },
            new Product
            {
                Id = scifiBookProductId, Title = "Science Fiction Book", Description = "Popular science fiction book",
                BasePrice = 19.99m, Stock = 150, CategoryId = booksCategoryId
            },
            new Product
            {
                Id = cookbookProductId, Title = "Cookbook", Description = "Comprehensive cookbook", BasePrice = 24.99m,
                Stock = 80, CategoryId = booksCategoryId
            },
            new Product
            {
                Id = biographyProductId, Title = "Biography", Description = "Inspiring biography", BasePrice = 29.99m,
                Stock = 60, CategoryId = booksCategoryId
            },
            new Product
            {
                Id = tshirtProductId, Title = "T-Shirt", Description = "Comfortable cotton t-shirt", BasePrice = 9.99m,
                Stock = 300, CategoryId = clothingCategoryId
            },
            new Product
            {
                Id = jeansProductId, Title = "Jeans", Description = "Stylish denim jeans", BasePrice = 49.99m,
                Stock = 120, CategoryId = clothingCategoryId
            },
            new Product
            {
                Id = jacketProductId, Title = "Jacket", Description = "Warm winter jacket", BasePrice = 89.99m,
                Stock = 60, CategoryId = clothingCategoryId
            },
            new Product
            {
                Id = sneakersProductId, Title = "Sneakers", Description = "Comfortable sneakers", BasePrice = 59.99m,
                Stock = 150, CategoryId = clothingCategoryId
            },
            new Product
            {
                Id = blenderProductId, Title = "Blender", Description = "High-speed blender", BasePrice = 49.99m,
                Stock = 80, CategoryId = homeKitchenCategoryId
            },
            new Product
            {
                Id = coffeeMakerProductId, Title = "Coffee Maker", Description = "Automatic coffee maker",
                BasePrice = 79.99m, Stock = 50, CategoryId = homeKitchenCategoryId
            },
            new Product
            {
                Id = vacuumCleanerProductId, Title = "Vacuum Cleaner", Description = "Powerful vacuum cleaner",
                BasePrice = 129.99m, Stock = 40, CategoryId = homeKitchenCategoryId
            },
            new Product
            {
                Id = airFryerProductId, Title = "Air Fryer", Description = "Healthy air fryer", BasePrice = 99.99m,
                Stock = 70, CategoryId = homeKitchenCategoryId
            },
            new Product
            {
                Id = microwaveOvenProductId, Title = "Microwave Oven", Description = "Compact microwave oven",
                BasePrice = 89.99m, Stock = 60, CategoryId = homeKitchenCategoryId
            },
            new Product
            {
                Id = toasterProductId, Title = "Toaster", Description = "2-slice toaster", BasePrice = 29.99m,
                Stock = 100, CategoryId = homeKitchenCategoryId
            },
            new Product
            {
                Id = cutlerySetProductId, Title = "Cutlery Set", Description = "Stainless steel cutlery set",
                BasePrice = 39.99m, Stock = 90, CategoryId = homeKitchenCategoryId
            },
            new Product
            {
                Id = cookwareSetProductId, Title = "Cookware Set", Description = "Non-stick cookware set",
                BasePrice = 149.99m, Stock = 30, CategoryId = homeKitchenCategoryId
            }
        );

        modelBuilder.Entity<ProductImage>().HasData(
            new ProductImage { Id = Guid.NewGuid(), ProductId = smartphoneProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = laptopProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = headphonesProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = smartwatchProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = novelProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = scifiBookProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = cookbookProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = biographyProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = tshirtProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = jeansProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = jacketProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = sneakersProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = blenderProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = coffeeMakerProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = vacuumCleanerProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = airFryerProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = microwaveOvenProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = toasterProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = cutlerySetProductId, ImageUrl =  string.Empty },
            new ProductImage { Id = Guid.NewGuid(), ProductId = cookwareSetProductId, ImageUrl =  string.Empty }
        );
    }
}