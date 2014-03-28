namespace CoffeeMachineProject
{
    partial class CoffeeMachineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.labelChooseDrink = new System.Windows.Forms.Label();
            this.buttonBrew = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.comboBoxDrinkList = new System.Windows.Forms.ComboBox();
            this.buttonRefillSugar = new System.Windows.Forms.Button();
            this.buttonRefillMilk = new System.Windows.Forms.Button();
            this.buttonRefillCoffee = new System.Windows.Forms.Button();
            this.labelBackground = new System.Windows.Forms.Label();
            this.radioButtonWaterOn = new System.Windows.Forms.RadioButton();
            this.radioButtonWaterOff = new System.Windows.Forms.RadioButton();
            this.labelPayment = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.labelReturn = new System.Windows.Forms.Label();
            this.labelReturnAmount = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalPaymentAmount = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPriceAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxPaymentAmount = new System.Windows.Forms.MaskedTextBox();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChooseDrink
            // 
            this.labelChooseDrink.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.labelChooseDrink.BackColor = System.Drawing.SystemColors.Control;
            this.labelChooseDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelChooseDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseDrink.Location = new System.Drawing.Point(12, 40);
            this.labelChooseDrink.Name = "labelChooseDrink";
            this.labelChooseDrink.Size = new System.Drawing.Size(121, 23);
            this.labelChooseDrink.TabIndex = 0;
            this.labelChooseDrink.Text = "Choose Drink:";
            // 
            // buttonBrew
            // 
            this.buttonBrew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrew.Location = new System.Drawing.Point(146, 40);
            this.buttonBrew.Name = "buttonBrew";
            this.buttonBrew.Size = new System.Drawing.Size(75, 63);
            this.buttonBrew.TabIndex = 2;
            this.buttonBrew.Text = "Brew!";
            this.buttonBrew.UseVisualStyleBackColor = true;
            this.buttonBrew.Click += new System.EventHandler(this.buttonBrew_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelInfo.BackColor = System.Drawing.SystemColors.Control;
            this.labelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelInfo.Location = new System.Drawing.Point(4, 345);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(386, 62);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "Information: ";
            // 
            // comboBoxDrinkList
            // 
            this.comboBoxDrinkList.FormattingEnabled = true;
            this.comboBoxDrinkList.Location = new System.Drawing.Point(12, 66);
            this.comboBoxDrinkList.Name = "comboBoxDrinkList";
            this.comboBoxDrinkList.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDrinkList.TabIndex = 5;
            this.comboBoxDrinkList.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrinkList_SelectedIndexChanged);
            // 
            // buttonRefillSugar
            // 
            this.buttonRefillSugar.Location = new System.Drawing.Point(4, 284);
            this.buttonRefillSugar.Name = "buttonRefillSugar";
            this.buttonRefillSugar.Size = new System.Drawing.Size(65, 58);
            this.buttonRefillSugar.TabIndex = 6;
            this.buttonRefillSugar.Text = "Refill Sugar";
            this.buttonRefillSugar.UseVisualStyleBackColor = true;
            this.buttonRefillSugar.Click += new System.EventHandler(this.buttonRefillSugar_Click);
            // 
            // buttonRefillMilk
            // 
            this.buttonRefillMilk.Location = new System.Drawing.Point(75, 284);
            this.buttonRefillMilk.Name = "buttonRefillMilk";
            this.buttonRefillMilk.Size = new System.Drawing.Size(65, 58);
            this.buttonRefillMilk.TabIndex = 7;
            this.buttonRefillMilk.Text = "Refill Milk";
            this.buttonRefillMilk.UseVisualStyleBackColor = true;
            this.buttonRefillMilk.Click += new System.EventHandler(this.buttonRefillMilk_Click);
            // 
            // buttonRefillCoffee
            // 
            this.buttonRefillCoffee.Location = new System.Drawing.Point(146, 284);
            this.buttonRefillCoffee.Name = "buttonRefillCoffee";
            this.buttonRefillCoffee.Size = new System.Drawing.Size(65, 58);
            this.buttonRefillCoffee.TabIndex = 8;
            this.buttonRefillCoffee.Text = "Refill Coffee";
            this.buttonRefillCoffee.UseVisualStyleBackColor = true;
            this.buttonRefillCoffee.Click += new System.EventHandler(this.buttonRefillCoffee_Click);
            // 
            // labelBackground
            // 
            this.labelBackground.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelBackground.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBackground.Location = new System.Drawing.Point(4, 3);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(386, 278);
            this.labelBackground.TabIndex = 9;
            // 
            // radioButtonWaterOn
            // 
            this.radioButtonWaterOn.AutoSize = true;
            this.radioButtonWaterOn.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonWaterOn.Location = new System.Drawing.Point(265, 302);
            this.radioButtonWaterOn.Name = "radioButtonWaterOn";
            this.radioButtonWaterOn.Size = new System.Drawing.Size(71, 17);
            this.radioButtonWaterOn.TabIndex = 10;
            this.radioButtonWaterOn.TabStop = true;
            this.radioButtonWaterOn.Text = "Water On";
            this.radioButtonWaterOn.UseVisualStyleBackColor = false;
            this.radioButtonWaterOn.CheckedChanged += new System.EventHandler(this.radioButtonWaterOn_CheckedChanged);
            // 
            // radioButtonWaterOff
            // 
            this.radioButtonWaterOff.AutoSize = true;
            this.radioButtonWaterOff.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonWaterOff.Checked = true;
            this.radioButtonWaterOff.Location = new System.Drawing.Point(265, 325);
            this.radioButtonWaterOff.Name = "radioButtonWaterOff";
            this.radioButtonWaterOff.Size = new System.Drawing.Size(71, 17);
            this.radioButtonWaterOff.TabIndex = 11;
            this.radioButtonWaterOff.TabStop = true;
            this.radioButtonWaterOff.Text = "Water Off";
            this.radioButtonWaterOff.UseVisualStyleBackColor = false;
            this.radioButtonWaterOff.CheckedChanged += new System.EventHandler(this.radioButtonWaterOff_CheckedChanged);
            // 
            // labelPayment
            // 
            this.labelPayment.BackColor = System.Drawing.SystemColors.Control;
            this.labelPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayment.Location = new System.Drawing.Point(265, 37);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(109, 23);
            this.labelPayment.TabIndex = 0;
            this.labelPayment.Text = "Enter Payment:";
            // 
            // buttonPay
            // 
            this.buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.Location = new System.Drawing.Point(265, 89);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(109, 23);
            this.buttonPay.TabIndex = 13;
            this.buttonPay.Text = "Pay!";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // labelReturn
            // 
            this.labelReturn.BackColor = System.Drawing.SystemColors.Control;
            this.labelReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturn.Location = new System.Drawing.Point(265, 208);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(109, 23);
            this.labelReturn.TabIndex = 14;
            this.labelReturn.Text = "Return change:";
            // 
            // labelReturnAmount
            // 
            this.labelReturnAmount.BackColor = System.Drawing.SystemColors.Control;
            this.labelReturnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnAmount.Location = new System.Drawing.Point(265, 231);
            this.labelReturnAmount.Name = "labelReturnAmount";
            this.labelReturnAmount.Size = new System.Drawing.Size(109, 23);
            this.labelReturnAmount.TabIndex = 15;
            this.labelReturnAmount.Text = "00.00";
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.SystemColors.Control;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(265, 155);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(109, 23);
            this.labelTotal.TabIndex = 16;
            this.labelTotal.Text = "Total Payment:";
            // 
            // labelTotalPaymentAmount
            // 
            this.labelTotalPaymentAmount.BackColor = System.Drawing.SystemColors.Control;
            this.labelTotalPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPaymentAmount.Location = new System.Drawing.Point(265, 178);
            this.labelTotalPaymentAmount.Name = "labelTotalPaymentAmount";
            this.labelTotalPaymentAmount.Size = new System.Drawing.Size(109, 23);
            this.labelTotalPaymentAmount.TabIndex = 17;
            this.labelTotalPaymentAmount.Text = "00.00";
            // 
            // labelPrice
            // 
            this.labelPrice.BackColor = System.Drawing.SystemColors.Control;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(12, 132);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(121, 23);
            this.labelPrice.TabIndex = 18;
            this.labelPrice.Text = "Drink Price:";
            // 
            // labelPriceAmount
            // 
            this.labelPriceAmount.BackColor = System.Drawing.SystemColors.Control;
            this.labelPriceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceAmount.Location = new System.Drawing.Point(12, 155);
            this.labelPriceAmount.Name = "labelPriceAmount";
            this.labelPriceAmount.Size = new System.Drawing.Size(121, 23);
            this.labelPriceAmount.TabIndex = 19;
            this.labelPriceAmount.Text = "00.00";
            // 
            // maskedTextBoxPaymentAmount
            // 
            this.maskedTextBoxPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPaymentAmount.Location = new System.Drawing.Point(265, 63);
            this.maskedTextBoxPaymentAmount.Mask = "00.00";
            this.maskedTextBoxPaymentAmount.Name = "maskedTextBoxPaymentAmount";
            this.maskedTextBoxPaymentAmount.Size = new System.Drawing.Size(109, 23);
            this.maskedTextBoxPaymentAmount.TabIndex = 20;
            this.maskedTextBoxPaymentAmount.Text = "0000";
            this.maskedTextBoxPaymentAmount.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxPaymentAmount_MaskInputRejected);
            // 
            // buttonAbort
            // 
            this.buttonAbort.BackColor = System.Drawing.Color.LightCoral;
            this.buttonAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbort.Location = new System.Drawing.Point(265, 118);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(109, 24);
            this.buttonAbort.TabIndex = 21;
            this.buttonAbort.Text = "Abort";
            this.buttonAbort.UseVisualStyleBackColor = false;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // CoffeeMachineForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(396, 416);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.maskedTextBoxPaymentAmount);
            this.Controls.Add(this.labelPriceAmount);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelTotalPaymentAmount);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelReturnAmount);
            this.Controls.Add(this.labelReturn);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.radioButtonWaterOff);
            this.Controls.Add(this.radioButtonWaterOn);
            this.Controls.Add(this.buttonRefillCoffee);
            this.Controls.Add(this.buttonRefillMilk);
            this.Controls.Add(this.buttonRefillSugar);
            this.Controls.Add(this.comboBoxDrinkList);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonBrew);
            this.Controls.Add(this.labelChooseDrink);
            this.Controls.Add(this.labelBackground);
            this.Name = "CoffeeMachineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseDrink;
        private System.Windows.Forms.Button buttonBrew;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ComboBox comboBoxDrinkList;
        private System.Windows.Forms.Button buttonRefillSugar;
        private System.Windows.Forms.Button buttonRefillMilk;
        private System.Windows.Forms.Button buttonRefillCoffee;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.RadioButton radioButtonWaterOn;
        private System.Windows.Forms.RadioButton radioButtonWaterOff;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.Label labelReturnAmount;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalPaymentAmount;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelPriceAmount;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPaymentAmount;
        private System.Windows.Forms.Button buttonAbort;
    }
}

