﻿using PS_PreslavDrakov.Model;
using PS_PreslavDrakov.Services.ProductService;

namespace PS_PreslavDrakov
{
    public partial class App : Application
    {
        public static UserInfo UserInfo;
        public static ProductService _productService;
        public static ProductService ProductService
        {
            get
            {
                if(_productService == null)
                {
                    _productService = new ProductService(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProductDB.db3"));
                }
                return _productService;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
