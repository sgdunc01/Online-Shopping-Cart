using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Controller
{
    public class Product
    {
        private string _productType;
        private int _productId;
        private string _title;
        private double _price;

        public string ProductType
        {
            get
            {
                return _productType;
            }
            set
            {
                _productType = value;
            }
        }
        public int ProductId
        {
            get
            {
                return _productId;
            }
            set
            {
                _productId = value;
            }
        }
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public double discountPercentage(int quantity)
        {
            double discount = 0.00;

            if (quantity < 2)
            {
                discount = 0.00;

            }
            else if (quantity < 5)
            {
                discount = 0.02;

            }
            else
            {
                discount = 0.05;

            }

            return discount;
        }
    }
}