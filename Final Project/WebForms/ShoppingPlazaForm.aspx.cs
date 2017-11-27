using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_Project.Controller;
using Final_Project.Model;

namespace Final_Project.WebForms
{
    public partial class ShoppingPlazaForm : System.Web.UI.Page
    {
        List<CartObject> cart = new List<CartObject>();
        List<Product> allProducts = new List<Product>();
        List<Product> bookList = new List<Product>();
        List<Product> dvdList = new List<Product>();
        protected void Page_Load(object sender, EventArgs e)
        {
            BuildProducts bp = new BuildProducts();
            allProducts = (List<Product>)Session["AllProducts"];

            if (!IsPostBack)
            {
                foreach (var i in allProducts)
                {
                    if (i.ProductType == "Book")
                    {
                        BooksDropDown.Items.Add(i.Title);
                        BooksDropDown.SelectedIndex = 0;
                        bookList.Add(i);
                        int selectedBook = BooksDropDown.SelectedIndex;
                        BookPriceValueLabel.Text = bookList[selectedBook].Price.ToString("c");
                    }
                    else
                    {
                        DvdDropDown.Items.Add(i.Title);
                        DvdDropDown.SelectedIndex = 0;
                        dvdList.Add(i);
                        int selectedDvd = DvdDropDown.SelectedIndex;
                        DVDPriceValueLabel.Text = dvdList[selectedDvd].Price.ToString("c");
                    }
                }
            }
        }


        protected void ExitBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExitPage.aspx");
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            string bookQuantity = BookQuantityTB.Text;
            string dvdQuantity = DvdQuantityTB.Text;
            Product selectedBook = allProducts[BooksDropDown.SelectedIndex];
            Product selectedDvd = allProducts[DvdDropDown.SelectedIndex + 5];

            MessageLabel.Text = "";

            if (Session["CartObjs"] == null)
            {
                if (bookQuantity != "" && dvdQuantity == "")
                {
                    CartObject book = new CartObject(int.Parse(bookQuantity), selectedBook);
                    cart.Add(book);
                    HttpContext.Current.Session["CartObjs"] = cart;
                }
                else if (dvdQuantity != "" && bookQuantity == "")
                {
                    CartObject dvd = new CartObject(int.Parse(dvdQuantity), selectedDvd);
                    cart.Add(dvd);
                    HttpContext.Current.Session["CartObjs"] = cart;
                }
                else if (dvdQuantity != "" && bookQuantity != "")
                {
                    CartObject book = new CartObject(int.Parse(bookQuantity), selectedBook);
                    CartObject dvd = new CartObject(int.Parse(dvdQuantity), selectedDvd);
                    cart.Add(book);
                    cart.Add(dvd);
                    HttpContext.Current.Session["CartObjs"] = cart;
                }
                else
                {
                    MessageLabel.Text = "One of the quantities must be more than 0. Otherwise Please Click Exit.";
                }
            }
            else
            {
                if (bookQuantity != "" && dvdQuantity == "")
                {
                    ChangeCart(int.Parse(bookQuantity), selectedBook);
                }
                else if (dvdQuantity != "" && bookQuantity == "")
                {
                    ChangeCart(int.Parse(dvdQuantity), selectedDvd);
                }
                else if (dvdQuantity != "" && bookQuantity != "")
                {
                    ChangeCart(int.Parse(bookQuantity), selectedBook);
                    ChangeCart(int.Parse(dvdQuantity), selectedDvd);
                }
                else
                {
                    MessageLabel.Text = "One of the quantities must be more than 0. Otherwise Please Click Exit.";
                }
            }

        }
       

        public void ChangeCart(int quant, Product prod)
        {
            CartObject newItem = new CartObject(quant, prod);
            List<CartObject> newList = new List<CartObject>();
            newList = (List<CartObject>)Session["CartObjs"];
            newList.Add(newItem);
            HttpContext.Current.Session["CartObjs"] = newList;
        }

        
        protected void BooksDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int book = BooksDropDown.SelectedIndex;
            BookPriceValueLabel.Text = allProducts[book].Price.ToString("C");
        }

        
        protected void DvdDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dvd = DvdDropDown.SelectedIndex;
            DVDPriceValueLabel.Text = allProducts[dvd + 5].Price.ToString("C");
        }

       
        protected void CheckoutBtn_Click(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["CartObjs"] == null)
            {
                MessageLabel.Text = "One of the quantities must be more than 0. Otherwise Please Click Exit.";
            }
            else
                Response.Redirect("Checkout.aspx");
        }

    }
}