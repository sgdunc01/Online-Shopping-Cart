using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_Project.Controller;

namespace Final_Project.WebForms
{
    public partial class Checkout : System.Web.UI.Page
    {
        List<CartObject> cartObj;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack )
            {
                cartObj = (List<CartObject>)Session["CartObjs"];

                foreach (var i in cartObj)
                {
                    ProductLstBx.Items.Add(string.Format("{0}-{1}", i.Obj.Title, i.Obj.Price.ToString("C")));
                }
                QuantityTxt.Enabled = false;
            }

        }

        protected void QtyEditBtn_Click(object sender, EventArgs e)
        {
            cartObj = (List<CartObject>)Session["CartObjs"];
            QuantityTxt.Enabled = true;
            int selectedItem = ProductLstBx.SelectedIndex;
            if (QuantityTxt.Text == "0")
            {

                var removedItem = ProductLstBx.SelectedItem;
                ProductLstBx.Items.Remove(removedItem.ToString());
                cartObj.Remove(cartObj[selectedItem]);
                HttpContext.Current.Session["CartObjs"] = cartObj;
            }
            else
            {
                try
                {
                    cartObj[selectedItem].Quantity = int.Parse(QuantityTxt.Text);
                }
                catch 
                {

                    cartObj[selectedItem].Quantity = 0;
                }
               

                HttpContext.Current.Session["CartObjs"] = cartObj;
            }
        }

        protected void ExitButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExitPage.aspx");
        }

        protected void PayButton_Click(object sender, EventArgs e)
        {
            cartObj = (List<CartObject>)Session["CartObjs"];
            Product prod = new Product();
            double Price = 0;
            int count = 0;
            double totalPrice;

            foreach (var i in cartObj)
            {
                Price += i.Obj.Price * i.Quantity;
                count += i.Quantity;
            }

            var discount = prod.discountPercentage(count);
            totalPrice = Price - (Price * discount);

            TotalLbl.Text = "Total amount to pay is " + totalPrice.ToString("c") + ". You got a discount of " + discount.ToString("c");

        }

        protected void ProductLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartObj = (List<CartObject>)Session["CartObjs"];
            QuantityTxt.Enabled = true;

            QuantityTxt.Text = cartObj[ProductLstBx.SelectedIndex].Quantity.ToString();

        }
    }
}