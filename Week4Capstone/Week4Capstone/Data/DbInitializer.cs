using System;
using System.Linq;
using Week4Capstone.Models;

namespace Week4Capstone.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Products.Any())
            {
                context.Products.Add(new Product() { Name = "iPhone 11 Pro", Price = 999 , URL = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/iphone-11-pro-select-2019-family?wid=882&amp;hei=1058&amp;fmt=jpeg&amp;qlt=80&amp;op_usm=0.5,0.5&amp;.v=1586586488946" });
                context.Products.Add(new Product() { Name = "Air58 Ninja - Cherry Blossom Red", Price = 89.99 , URL = "https://cdn.shopify.com/s/files/1/2377/4861/products/red1_2048x2048.png?v=1543685257" });
                context.Products.Add(new Product() { Name = "RK61 60% Wireless Mechanical Keyboard - Blue Switches", Price = 77.99 , URL = "https://images-na.ssl-images-amazon.com/images/I/613mXx-eezL._AC_SL1500_.jpg" });
                context.Products.Add(new Product() { Name = "Blue Yeti Professional USB Microphone - Black", Price = 129.99, URL = "https://s3.amazonaws.com/cd.bluemic.com/img/yeti/yeti-header-yetiblackout-desktop@2x.png"});
                context.Products.Add(new Product() { Name = "Google Home Mini - Chalk", Price = 29, URL = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcQX5KOmrFRx16PO2FTU6y1EJrq2O-955AWhdoN-vCitPvKdT-LucjE&usqp=CAc" });
                context.Products.Add(new Product() { Name = "Surface Book 3 - 13.5 inch, 16GB, Intel Core I7, 256GB", Price = 1799.99, URL = "https://i.ebayimg.com/images/g/moMAAOSw0IFex~Fh/s-l600.jpg" });
                context.Products.Add(new Product() { Name = "Amazon Eero Mesh Wifi System - Router Home Coverage", Price = 249, URL = "https://d2vw57jh8139vw.cloudfront.net/282682168b97687fbd60dfdb418df5a7.jpg" });
                context.Products.Add(new Product() { Name = "Sony Noise Cancelling Headphones WH1000XM3 - Black", Price = 348, URL = "https://images.crutchfieldonline.com/ImageHandler/trim/620/378/products/2018/35/158/g158100XM3B-F-1.jpg" });

                context.SaveChanges();
            }
        }
       
    }
}
