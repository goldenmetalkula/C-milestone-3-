namespace PizzaMaker
{
    partial class FrmPizzaMaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();

            this.lblDeliveryTime = new System.Windows.Forms.Label();
            this.dtpDeliveryTime = new System.Windows.Forms.DateTimePicker();

            this.grpIngredients = new System.Windows.Forms.GroupBox();
            this.chbPepperoni = new System.Windows.Forms.CheckBox();
            this.chbPineapple = new System.Windows.Forms.CheckBox();
            this.chbBacon = new System.Windows.Forms.CheckBox();
            this.chbSausage = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbPeppers = new System.Windows.Forms.CheckBox();
            this.chbMushrooms = new System.Windows.Forms.CheckBox();
            this.chbTomatoes = new System.Windows.Forms.CheckBox();

            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.rdoThinCrust = new System.Windows.Forms.RadioButton();
            this.rdoDeepDish = new System.Windows.Forms.RadioButton();
            this.rdoStuffedCrust = new System.Windows.Forms.RadioButton();
            this.rdoGlutenFree = new System.Windows.Forms.RadioButton();

            this.lblStrangeAddOns = new System.Windows.Forms.Label();
            this.lsbStrangeAddOns = new System.Windows.Forms.ListBox();

            this.grpExtraGoodies = new System.Windows.Forms.GroupBox();
            this.lblSauceTitle = new System.Windows.Forms.Label();
            this.lblSauce = new System.Windows.Forms.Label();
            this.hsbSauce = new System.Windows.Forms.HScrollBar();
            this.lblCheeseTitle = new System.Windows.Forms.Label();
            this.lblCheese = new System.Windows.Forms.Label();
            this.hsbCheese = new System.Windows.Forms.HScrollBar();

            this.lblPizzaBoxColor = new System.Windows.Forms.Label();
            this.picPizzaBoxColor = new System.Windows.Forms.PictureBox();

            this.lblPizzaPriceTitle = new System.Windows.Forms.Label();
            this.lblPizzaPrice = new System.Windows.Forms.Label();

            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnCreatePizza = new System.Windows.Forms.Button();
            this.btnSeeFullOrder = new System.Windows.Forms.Button();

            this.grpIngredients.SuspendLayout();
            this.grpCrust.SuspendLayout();
            this.grpExtraGoodies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaBoxColor)).BeginInit();
            this.SuspendLayout();

            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 20);
            this.lblName.Text = "Name:";

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 27);

            // 
            // lblDeliveryTime
            // 
            this.lblDeliveryTime.AutoSize = true;
            this.lblDeliveryTime.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Bold);
            this.lblDeliveryTime.Location = new System.Drawing.Point(400, 15);
            this.lblDeliveryTime.Name = "lblDeliveryTime";
            this.lblDeliveryTime.Size = new System.Drawing.Size(120, 20);
            this.lblDeliveryTime.Text = "Delivery Time";

            // 
            // dtpDeliveryTime
            // 
            this.dtpDeliveryTime.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dtpDeliveryTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryTime.Location = new System.Drawing.Point(400, 38);
            this.dtpDeliveryTime.Name = "dtpDeliveryTime";
            this.dtpDeliveryTime.Size = new System.Drawing.Size(200, 27);

            // 
            // grpIngredients
            // 
            this.grpIngredients.Controls.Add(this.chbPepperoni);
            this.grpIngredients.Controls.Add(this.chbPineapple);
            this.grpIngredients.Controls.Add(this.chbBacon);
            this.grpIngredients.Controls.Add(this.chbSausage);
            this.grpIngredients.Controls.Add(this.chbOlives);
            this.grpIngredients.Controls.Add(this.chbPeppers);
            this.grpIngredients.Controls.Add(this.chbMushrooms);
            this.grpIngredients.Controls.Add(this.chbTomatoes);
            this.grpIngredients.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Bold);
            this.grpIngredients.Location = new System.Drawing.Point(12, 60);
            this.grpIngredients.Name = "grpIngredients";
            this.grpIngredients.Size = new System.Drawing.Size(270, 150);
            this.grpIngredients.TabStop = false;
            this.grpIngredients.Text = "Ingredients";

            // 
            // chbPepperoni / chbPineapple / chbBacon / chbSausage / chbOlives / chbPeppers / chbMushrooms / chbTomatoes
            // (checkbox font reset to Regular so they don't inherit the bold group box font)
            // 
            this.chbPepperoni.AutoSize = true;
            this.chbPepperoni.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.chbPepperoni.Location = new System.Drawing.Point(15, 30);
            this.chbPepperoni.Name = "chbPepperoni";
            this.chbPepperoni.Text = "Pepperoni";

            this.chbPineapple.AutoSize = true;
            this.chbPineapple.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.chbPineapple.Location = new System.Drawing.Point(150, 30);
            this.chbPineapple.Name = "chbPineapple";
            this.chbPineapple.Text = "Pineapple";

            this.chbBacon.AutoSize = true;
            this.chbBacon.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.chbBacon.Location = new System.Drawing.Point(15, 60);
            this.chbBacon.Name = "chbBacon";
            this.chbBacon.Text = "Bacon";

            this.chbSausage.AutoSize = true;
            this.chbSausage.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.chbSausage.Location = new System.Drawing.Point(150, 60);
            this.chbSausage.Name = "chbSausage";
            this.chbSausage.Text = "Sausage";

            this.chbOlives.AutoSize = true;
            this.chbOlives.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.chbOlives.Location = new System.Drawing.Point(15, 90);
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.Text = "Olives";

            this.chbPeppers.AutoSize = true;
            this.chbPeppers.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.chbPeppers.Location = new System.Drawing.Point(150, 90);
            this.chbPeppers.Name = "chbPeppers";
            this.chbPeppers.Text = "Peppers";

            this.chbMushrooms.AutoSize = true;
            this.chbMushrooms.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.chbMushrooms.Location = new System.Drawing.Point(15, 120);
            this.chbMushrooms.Name = "chbMushrooms";
            this.chbMushrooms.Text = "Mushrooms";

            this.chbTomatoes.AutoSize = true;
            this.chbTomatoes.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.chbTomatoes.Location = new System.Drawing.Point(150, 120);
            this.chbTomatoes.Name = "chbTomatoes";
            this.chbTomatoes.Text = "Tomatoes";

            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.rdoThinCrust);
            this.grpCrust.Controls.Add(this.rdoDeepDish);
            this.grpCrust.Controls.Add(this.rdoStuffedCrust);
            this.grpCrust.Controls.Add(this.rdoGlutenFree);
            this.grpCrust.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Bold);
            this.grpCrust.Location = new System.Drawing.Point(300, 60);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(160, 150);
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust";

            this.rdoThinCrust.AutoSize = true;
            this.rdoThinCrust.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.rdoThinCrust.Location = new System.Drawing.Point(15, 30);
            this.rdoThinCrust.Name = "rdoThinCrust";
            this.rdoThinCrust.Text = "Thin Crust";

            this.rdoDeepDish.AutoSize = true;
            this.rdoDeepDish.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.rdoDeepDish.Location = new System.Drawing.Point(15, 60);
            this.rdoDeepDish.Name = "rdoDeepDish";
            this.rdoDeepDish.Text = "Deep Dish";

            this.rdoStuffedCrust.AutoSize = true;
            this.rdoStuffedCrust.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.rdoStuffedCrust.Location = new System.Drawing.Point(15, 90);
            this.rdoStuffedCrust.Name = "rdoStuffedCrust";
            this.rdoStuffedCrust.Text = "Stuffed Crust";

            this.rdoGlutenFree.AutoSize = true;
            this.rdoGlutenFree.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.rdoGlutenFree.Location = new System.Drawing.Point(15, 120);
            this.rdoGlutenFree.Name = "rdoGlutenFree";
            this.rdoGlutenFree.Text = "Gluten Free";

            // 
            // lblStrangeAddOns
            // 
            this.lblStrangeAddOns.AutoSize = true;
            this.lblStrangeAddOns.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Bold);
            this.lblStrangeAddOns.Location = new System.Drawing.Point(12, 225);
            this.lblStrangeAddOns.Name = "lblStrangeAddOns";
            this.lblStrangeAddOns.Text = "Strange Add Ons";

            // 
            // lsbStrangeAddOns
            // 
            this.lsbStrangeAddOns.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.lsbStrangeAddOns.FormattingEnabled = true;
            this.lsbStrangeAddOns.ItemHeight = 20;
            this.lsbStrangeAddOns.Items.AddRange(new object[] {
            "Hotdogs",
            "Eggplant",
            "Artichoke Hearts",
            "Eggs",
            "Peanut Butter",
            "Prosciutto",
            "Honey",
            "Chili Thread",
            "Olive Oil",
            "Arugula",
            "Garlic",
            "Chicken",
            "Anchovies",
            "BBQ Sauce",
            "Green Onion",
            "Red Onion",
            "Carrots",
            "Peanuts"});
            this.lsbStrangeAddOns.Location = new System.Drawing.Point(12, 250);
            this.lsbStrangeAddOns.Name = "lsbStrangeAddOns";
            this.lsbStrangeAddOns.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbStrangeAddOns.Size = new System.Drawing.Size(270, 150);

            // 
            // grpExtraGoodies
            // 
            this.grpExtraGoodies.Controls.Add(this.lblSauceTitle);
            this.grpExtraGoodies.Controls.Add(this.lblSauce);
            this.grpExtraGoodies.Controls.Add(this.hsbSauce);
            this.grpExtraGoodies.Controls.Add(this.lblCheeseTitle);
            this.grpExtraGoodies.Controls.Add(this.lblCheese);
            this.grpExtraGoodies.Controls.Add(this.hsbCheese);
            this.grpExtraGoodies.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Bold);
            this.grpExtraGoodies.Location = new System.Drawing.Point(300, 225);
            this.grpExtraGoodies.Name = "grpExtraGoodies";
            this.grpExtraGoodies.Size = new System.Drawing.Size(300, 175);
            this.grpExtraGoodies.TabStop = false;
            this.grpExtraGoodies.Text = "Extra Goodies";

            this.lblSauceTitle.AutoSize = true;
            this.lblSauceTitle.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.lblSauceTitle.Location = new System.Drawing.Point(15, 30);
            this.lblSauceTitle.Name = "lblSauceTitle";
            this.lblSauceTitle.Text = "Amount of Sauce";

            this.lblSauce.AutoSize = true;
            this.lblSauce.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.lblSauce.Location = new System.Drawing.Point(230, 30);
            this.lblSauce.Name = "lblSauce";
            this.lblSauce.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSauce.Text = "00";

            this.hsbSauce.Location = new System.Drawing.Point(15, 55);
            this.hsbSauce.Name = "hsbSauce";
            this.hsbSauce.Size = new System.Drawing.Size(270, 20);
            this.hsbSauce.Minimum = 0;
            this.hsbSauce.Maximum = 100;
            this.hsbSauce.SmallChange = 1;

            this.lblCheeseTitle.AutoSize = true;
            this.lblCheeseTitle.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.lblCheeseTitle.Location = new System.Drawing.Point(15, 95);
            this.lblCheeseTitle.Name = "lblCheeseTitle";
            this.lblCheeseTitle.Text = "Amount of Cheese";

            this.lblCheese.AutoSize = true;
            this.lblCheese.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.lblCheese.Location = new System.Drawing.Point(230, 95);
            this.lblCheese.Name = "lblCheese";
            this.lblCheese.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCheese.Text = "00";

            this.hsbCheese.Location = new System.Drawing.Point(15, 120);
            this.hsbCheese.Name = "hsbCheese";
            this.hsbCheese.Size = new System.Drawing.Size(270, 20);
            this.hsbCheese.Minimum = 0;
            this.hsbCheese.Maximum = 100;
            this.hsbCheese.SmallChange = 1;

            // 
            // lblPizzaBoxColor
            // 
            this.lblPizzaBoxColor.AutoSize = true;
            this.lblPizzaBoxColor.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Bold);
            this.lblPizzaBoxColor.Location = new System.Drawing.Point(12, 415);
            this.lblPizzaBoxColor.Name = "lblPizzaBoxColor";
            this.lblPizzaBoxColor.Text = "Pizza Box Color";

            // 
            // picPizzaBoxColor
            // 
            this.picPizzaBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPizzaBoxColor.Location = new System.Drawing.Point(12, 440);
            this.picPizzaBoxColor.Name = "picPizzaBoxColor";
            this.picPizzaBoxColor.Size = new System.Drawing.Size(120, 60);
            this.picPizzaBoxColor.TabStop = false;

            // 
            // lblPizzaPriceTitle
            // 
            this.lblPizzaPriceTitle.AutoSize = true;
            this.lblPizzaPriceTitle.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Bold);
            this.lblPizzaPriceTitle.Location = new System.Drawing.Point(300, 415);
            this.lblPizzaPriceTitle.Name = "lblPizzaPriceTitle";
            this.lblPizzaPriceTitle.Text = "Pizza Price:";

            // 
            // lblPizzaPrice
            // 
            this.lblPizzaPrice.AutoSize = true;
            this.lblPizzaPrice.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Regular);
            this.lblPizzaPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPizzaPrice.Location = new System.Drawing.Point(400, 415);
            this.lblPizzaPrice.Name = "lblPizzaPrice";
            this.lblPizzaPrice.Text = "$0";

            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(12, 515);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(110, 35);
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;

            // 
            // btnCreatePizza
            // 
            this.btnCreatePizza.Location = new System.Drawing.Point(130, 515);
            this.btnCreatePizza.Name = "btnCreatePizza";
            this.btnCreatePizza.Size = new System.Drawing.Size(110, 35);
            this.btnCreatePizza.Text = "Create Pizza";
            this.btnCreatePizza.UseVisualStyleBackColor = true;

            // 
            // btnSeeFullOrder
            // 
            this.btnSeeFullOrder.Location = new System.Drawing.Point(12, 555);
            this.btnSeeFullOrder.Name = "btnSeeFullOrder";
            this.btnSeeFullOrder.Size = new System.Drawing.Size(228, 35);
            this.btnSeeFullOrder.Text = "See Full Order";
            this.btnSeeFullOrder.UseVisualStyleBackColor = true;

            // 
            // FrmPizzaMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 610);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDeliveryTime);
            this.Controls.Add(this.dtpDeliveryTime);
            this.Controls.Add(this.grpIngredients);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.lblStrangeAddOns);
            this.Controls.Add(this.lsbStrangeAddOns);
            this.Controls.Add(this.grpExtraGoodies);
            this.Controls.Add(this.lblPizzaBoxColor);
            this.Controls.Add(this.picPizzaBoxColor);
            this.Controls.Add(this.lblPizzaPriceTitle);
            this.Controls.Add(this.lblPizzaPrice);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnCreatePizza);
            this.Controls.Add(this.btnSeeFullOrder);
            this.Name = "FrmPizzaMaker";
            this.Text = "Pizza Maker";

            this.grpIngredients.ResumeLayout(false);
            this.grpIngredients.PerformLayout();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.grpExtraGoodies.ResumeLayout(false);
            this.grpExtraGoodies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaBoxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDeliveryTime;
        private System.Windows.Forms.DateTimePicker dtpDeliveryTime;

        private System.Windows.Forms.GroupBox grpIngredients;
        private System.Windows.Forms.CheckBox chbPepperoni;
        private System.Windows.Forms.CheckBox chbPineapple;
        private System.Windows.Forms.CheckBox chbBacon;
        private System.Windows.Forms.CheckBox chbSausage;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbPeppers;
        private System.Windows.Forms.CheckBox chbMushrooms;
        private System.Windows.Forms.CheckBox chbTomatoes;

        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.RadioButton rdoThinCrust;
        private System.Windows.Forms.RadioButton rdoDeepDish;
        private System.Windows.Forms.RadioButton rdoStuffedCrust;
        private System.Windows.Forms.RadioButton rdoGlutenFree;

        private System.Windows.Forms.Label lblStrangeAddOns;
        private System.Windows.Forms.ListBox lsbStrangeAddOns;

        private System.Windows.Forms.GroupBox grpExtraGoodies;
        private System.Windows.Forms.Label lblSauceTitle;
        private System.Windows.Forms.Label lblSauce;
        private System.Windows.Forms.HScrollBar hsbSauce;
        private System.Windows.Forms.Label lblCheeseTitle;
        private System.Windows.Forms.Label lblCheese;
        private System.Windows.Forms.HScrollBar hsbCheese;

        private System.Windows.Forms.Label lblPizzaBoxColor;
        private System.Windows.Forms.PictureBox picPizzaBoxColor;

        private System.Windows.Forms.Label lblPizzaPriceTitle;
        private System.Windows.Forms.Label lblPizzaPrice;

        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnCreatePizza;
        private System.Windows.Forms.Button btnSeeFullOrder;
    }
}