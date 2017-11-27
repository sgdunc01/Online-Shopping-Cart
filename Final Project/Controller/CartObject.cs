using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Controller
{
    public class CartObject
    {
        private int _quantity;
        private Product _obj;

        public CartObject(int quantity, Product obj)
        {
            _quantity = quantity;
            _obj = obj;
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        public Product Obj
        {
            get
            {
                return _obj;
            }
            set
            {
                _obj = value;
            }
        }
    }
}