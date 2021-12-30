using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EmTekno.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {Name="Bilgisayar", Description="Bilgisayar Ürünleri"},
                new Category() {Name="Telefon", Description="Telefon Ürünleri"},
                new Category() {Name="Televizyon", Description="Televizyon Ürünleri"},
                new Category() {Name="Kamera", Description="Kamera Ürünleri"},
                new Category() {Name="Konsol", Description="Konsol Ürünleri"}
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);

            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product() {Name="Casper", Description="Bilgisayar ürünleri", Price=3000, Stock=50,IsHome=true,IsApproved=true,IsFeatured=false,Slider=true, CategoryId=1,ImageUrl="1.jpg"},
                new Product() {Name="Asus", Description="Bilgisayar ürünleri", Price=2000, Stock=50,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true, CategoryId=1,ImageUrl="2.jpg"},
                new Product() {Name="Canon", Description="Kamera ürünleri", Price=1000, Stock=50,IsHome=true,IsApproved=true,IsFeatured=false,Slider=false, CategoryId=4,ImageUrl="3.jpg"},
                new Product() {Name="iphone 12 pro", Description="Telefon ürünleri", Price=12000, Stock=50,IsHome=true,IsApproved=true,IsFeatured=false,Slider=false, CategoryId=2,ImageUrl="4.jpg"},
                new Product() {Name="LG 43UP323", Description="Televizyon ürünleri", Price=5000, Stock=50,IsHome=false,IsApproved=true,IsFeatured=true,Slider=false, CategoryId=3,ImageUrl="5.jpg"},
                new Product() {Name="Plastation 5", Description="Konsol ürünleri", Price=8000, Stock=50,IsHome=false,IsApproved=true,IsFeatured=false,Slider=false, CategoryId=5,ImageUrl="6.jpg"},
                new Product() {Name="Plastation 4", Description="Konsol ürünleri", Price=8000, Stock=50,IsHome=false,IsApproved=true,IsFeatured=false,Slider=false, CategoryId=5,ImageUrl="7.jpg"}

            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
             context.SaveChanges();
            base.Seed(context);
        }
    }
}