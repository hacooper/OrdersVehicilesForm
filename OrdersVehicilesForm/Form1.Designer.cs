
namespace OrdersVehicilesForm
{
    partial class Form1
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
            System.Windows.Forms.Button vehicilesUpButton;
            this.orderCustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.orderTypeTextBox = new System.Windows.Forms.TextBox();
            this.orderDurationTextBox = new System.Windows.Forms.TextBox();
            this.OrderVehicileTypeListBox = new System.Windows.Forms.ListBox();
            this.orderCustomerNameLabel = new System.Windows.Forms.Label();
            this.orderTypeLabel = new System.Windows.Forms.Label();
            this.orderDurationLabel = new System.Windows.Forms.Label();
            this.orderVehicileListBoxLabel = new System.Windows.Forms.Label();
            this.ordersGroupBox = new System.Windows.Forms.GroupBox();
            this.orderButtonDown = new System.Windows.Forms.Button();
            this.ordersUpButton = new System.Windows.Forms.Button();
            this.VehicleTypeLabel = new System.Windows.Forms.Label();
            this.vehicileMakeLabel = new System.Windows.Forms.Label();
            this.vehicileYearlabel = new System.Windows.Forms.Label();
            this.vehicileMilesLabel = new System.Windows.Forms.Label();
            this.vehicileValueNewLabel = new System.Windows.Forms.Label();
            this.vehicileTypeTextBox = new System.Windows.Forms.TextBox();
            this.vehicileMakeTextBox = new System.Windows.Forms.TextBox();
            this.vehicileYearTextBox = new System.Windows.Forms.TextBox();
            this.vehicileMilesTextBox = new System.Windows.Forms.TextBox();
            this.vehicileValueNewTextBox = new System.Windows.Forms.TextBox();
            this.VehicilesGroupBox = new System.Windows.Forms.GroupBox();
            this.vehicilesDownButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ordersFetchButton = new System.Windows.Forms.Button();
            this.vehicilesFetchButton = new System.Windows.Forms.Button();
            this.vehicileOrderAssignButton = new System.Windows.Forms.Button();
            this.CommitButton = new System.Windows.Forms.Button();
            vehicilesUpButton = new System.Windows.Forms.Button();
            this.ordersGroupBox.SuspendLayout();
            this.VehicilesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicilesUpButton
            // 
            vehicilesUpButton.Location = new System.Drawing.Point(702, 31);
            vehicilesUpButton.Name = "vehicilesUpButton";
            vehicilesUpButton.Size = new System.Drawing.Size(75, 23);
            vehicilesUpButton.TabIndex = 21;
            vehicilesUpButton.Text = "UP";
            vehicilesUpButton.UseVisualStyleBackColor = true;
            vehicilesUpButton.Click += new System.EventHandler(this.vehicilesUpButton_Click);
            // 
            // orderCustomerNameTextBox
            // 
            this.orderCustomerNameTextBox.Location = new System.Drawing.Point(17, 56);
            this.orderCustomerNameTextBox.Name = "orderCustomerNameTextBox";
            this.orderCustomerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderCustomerNameTextBox.TabIndex = 0;
            // 
            // orderTypeTextBox
            // 
            this.orderTypeTextBox.Location = new System.Drawing.Point(150, 56);
            this.orderTypeTextBox.Name = "orderTypeTextBox";
            this.orderTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderTypeTextBox.TabIndex = 1;
            // 
            // orderDurationTextBox
            // 
            this.orderDurationTextBox.Location = new System.Drawing.Point(281, 56);
            this.orderDurationTextBox.Name = "orderDurationTextBox";
            this.orderDurationTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderDurationTextBox.TabIndex = 2;
            // 
            // OrderVehicileTypeListBox
            // 
            this.OrderVehicileTypeListBox.FormattingEnabled = true;
            this.OrderVehicileTypeListBox.Items.AddRange(new object[] {
            "Auto",
            "Bus",
            "Truck"});
            this.OrderVehicileTypeListBox.Location = new System.Drawing.Point(410, 56);
            this.OrderVehicileTypeListBox.Name = "OrderVehicileTypeListBox";
            this.OrderVehicileTypeListBox.Size = new System.Drawing.Size(100, 43);
            this.OrderVehicileTypeListBox.TabIndex = 3;
            this.OrderVehicileTypeListBox.SelectedIndexChanged += new System.EventHandler(this.OrderVehicileTypeListBox_SelectedIndexChanged);
            // 
            // orderCustomerNameLabel
            // 
            this.orderCustomerNameLabel.AutoSize = true;
            this.orderCustomerNameLabel.Location = new System.Drawing.Point(14, 27);
            this.orderCustomerNameLabel.Name = "orderCustomerNameLabel";
            this.orderCustomerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.orderCustomerNameLabel.TabIndex = 4;
            this.orderCustomerNameLabel.Text = "Customer Name";
            // 
            // orderTypeLabel
            // 
            this.orderTypeLabel.AutoSize = true;
            this.orderTypeLabel.Location = new System.Drawing.Point(150, 27);
            this.orderTypeLabel.Name = "orderTypeLabel";
            this.orderTypeLabel.Size = new System.Drawing.Size(60, 13);
            this.orderTypeLabel.TabIndex = 5;
            this.orderTypeLabel.Text = "Order Type";
            // 
            // orderDurationLabel
            // 
            this.orderDurationLabel.AutoSize = true;
            this.orderDurationLabel.Location = new System.Drawing.Point(281, 27);
            this.orderDurationLabel.Name = "orderDurationLabel";
            this.orderDurationLabel.Size = new System.Drawing.Size(76, 13);
            this.orderDurationLabel.TabIndex = 6;
            this.orderDurationLabel.Text = "Order Duration";
            // 
            // orderVehicileListBoxLabel
            // 
            this.orderVehicileListBoxLabel.AutoSize = true;
            this.orderVehicileListBoxLabel.Location = new System.Drawing.Point(410, 27);
            this.orderVehicileListBoxLabel.Name = "orderVehicileListBoxLabel";
            this.orderVehicileListBoxLabel.Size = new System.Drawing.Size(100, 13);
            this.orderVehicileListBoxLabel.TabIndex = 7;
            this.orderVehicileListBoxLabel.Text = "Order Vehicile Type";
            // 
            // ordersGroupBox
            // 
            this.ordersGroupBox.Controls.Add(this.orderButtonDown);
            this.ordersGroupBox.Controls.Add(this.ordersUpButton);
            this.ordersGroupBox.Controls.Add(this.orderCustomerNameLabel);
            this.ordersGroupBox.Controls.Add(this.orderVehicileListBoxLabel);
            this.ordersGroupBox.Controls.Add(this.orderCustomerNameTextBox);
            this.ordersGroupBox.Controls.Add(this.orderDurationLabel);
            this.ordersGroupBox.Controls.Add(this.orderTypeTextBox);
            this.ordersGroupBox.Controls.Add(this.orderTypeLabel);
            this.ordersGroupBox.Controls.Add(this.orderDurationTextBox);
            this.ordersGroupBox.Controls.Add(this.OrderVehicileTypeListBox);
            this.ordersGroupBox.Location = new System.Drawing.Point(27, 24);
            this.ordersGroupBox.Name = "ordersGroupBox";
            this.ordersGroupBox.Size = new System.Drawing.Size(683, 121);
            this.ordersGroupBox.TabIndex = 8;
            this.ordersGroupBox.TabStop = false;
            this.ordersGroupBox.Text = "Orders";
            this.ordersGroupBox.Enter += new System.EventHandler(this.ordersGroupBox_Enter);
            // 
            // orderButtonDown
            // 
            this.orderButtonDown.Location = new System.Drawing.Point(568, 76);
            this.orderButtonDown.Name = "orderButtonDown";
            this.orderButtonDown.Size = new System.Drawing.Size(75, 23);
            this.orderButtonDown.TabIndex = 9;
            this.orderButtonDown.Text = "DOWN";
            this.orderButtonDown.UseVisualStyleBackColor = true;
            this.orderButtonDown.Click += new System.EventHandler(this.orderButtonDown_Click);
            // 
            // ordersUpButton
            // 
            this.ordersUpButton.Location = new System.Drawing.Point(568, 27);
            this.ordersUpButton.Name = "ordersUpButton";
            this.ordersUpButton.Size = new System.Drawing.Size(75, 23);
            this.ordersUpButton.TabIndex = 8;
            this.ordersUpButton.Text = "UP";
            this.ordersUpButton.UseVisualStyleBackColor = true;
            this.ordersUpButton.Click += new System.EventHandler(this.ordersUpButton_Click);
            // 
            // VehicleTypeLabel
            // 
            this.VehicleTypeLabel.AutoSize = true;
            this.VehicleTypeLabel.Location = new System.Drawing.Point(14, 31);
            this.VehicleTypeLabel.Name = "VehicleTypeLabel";
            this.VehicleTypeLabel.Size = new System.Drawing.Size(71, 13);
            this.VehicleTypeLabel.TabIndex = 9;
            this.VehicleTypeLabel.Text = "Vehicile Type";
            // 
            // vehicileMakeLabel
            // 
            this.vehicileMakeLabel.AutoSize = true;
            this.vehicileMakeLabel.Location = new System.Drawing.Point(150, 31);
            this.vehicileMakeLabel.Name = "vehicileMakeLabel";
            this.vehicileMakeLabel.Size = new System.Drawing.Size(74, 13);
            this.vehicileMakeLabel.TabIndex = 10;
            this.vehicileMakeLabel.Text = "Vehicile Make";
            // 
            // vehicileYearlabel
            // 
            this.vehicileYearlabel.AutoSize = true;
            this.vehicileYearlabel.Location = new System.Drawing.Point(281, 31);
            this.vehicileYearlabel.Name = "vehicileYearlabel";
            this.vehicileYearlabel.Size = new System.Drawing.Size(69, 13);
            this.vehicileYearlabel.TabIndex = 11;
            this.vehicileYearlabel.Text = "Vehicile Year";
            // 
            // vehicileMilesLabel
            // 
            this.vehicileMilesLabel.AutoSize = true;
            this.vehicileMilesLabel.Location = new System.Drawing.Point(410, 31);
            this.vehicileMilesLabel.Name = "vehicileMilesLabel";
            this.vehicileMilesLabel.Size = new System.Drawing.Size(71, 13);
            this.vehicileMilesLabel.TabIndex = 12;
            this.vehicileMilesLabel.Text = "Vehicile Miles";
            // 
            // vehicileValueNewLabel
            // 
            this.vehicileValueNewLabel.AutoSize = true;
            this.vehicileValueNewLabel.Location = new System.Drawing.Point(540, 31);
            this.vehicileValueNewLabel.Name = "vehicileValueNewLabel";
            this.vehicileValueNewLabel.Size = new System.Drawing.Size(99, 13);
            this.vehicileValueNewLabel.TabIndex = 13;
            this.vehicileValueNewLabel.Text = "Vehicile Value New";
            // 
            // vehicileTypeTextBox
            // 
            this.vehicileTypeTextBox.Location = new System.Drawing.Point(17, 62);
            this.vehicileTypeTextBox.Name = "vehicileTypeTextBox";
            this.vehicileTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicileTypeTextBox.TabIndex = 15;
            // 
            // vehicileMakeTextBox
            // 
            this.vehicileMakeTextBox.Location = new System.Drawing.Point(150, 62);
            this.vehicileMakeTextBox.Name = "vehicileMakeTextBox";
            this.vehicileMakeTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicileMakeTextBox.TabIndex = 16;
            // 
            // vehicileYearTextBox
            // 
            this.vehicileYearTextBox.Location = new System.Drawing.Point(281, 62);
            this.vehicileYearTextBox.Name = "vehicileYearTextBox";
            this.vehicileYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicileYearTextBox.TabIndex = 17;
            // 
            // vehicileMilesTextBox
            // 
            this.vehicileMilesTextBox.Location = new System.Drawing.Point(410, 62);
            this.vehicileMilesTextBox.Name = "vehicileMilesTextBox";
            this.vehicileMilesTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicileMilesTextBox.TabIndex = 18;
            // 
            // vehicileValueNewTextBox
            // 
            this.vehicileValueNewTextBox.Location = new System.Drawing.Point(543, 62);
            this.vehicileValueNewTextBox.Name = "vehicileValueNewTextBox";
            this.vehicileValueNewTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicileValueNewTextBox.TabIndex = 19;
            // 
            // VehicilesGroupBox
            // 
            this.VehicilesGroupBox.Controls.Add(this.vehicilesDownButton);
            this.VehicilesGroupBox.Controls.Add(vehicilesUpButton);
            this.VehicilesGroupBox.Controls.Add(this.button1);
            this.VehicilesGroupBox.Controls.Add(this.VehicleTypeLabel);
            this.VehicilesGroupBox.Controls.Add(this.vehicileValueNewTextBox);
            this.VehicilesGroupBox.Controls.Add(this.vehicileMakeLabel);
            this.VehicilesGroupBox.Controls.Add(this.vehicileMilesTextBox);
            this.VehicilesGroupBox.Controls.Add(this.vehicileYearlabel);
            this.VehicilesGroupBox.Controls.Add(this.vehicileYearTextBox);
            this.VehicilesGroupBox.Controls.Add(this.vehicileMilesLabel);
            this.VehicilesGroupBox.Controls.Add(this.vehicileMakeTextBox);
            this.VehicilesGroupBox.Controls.Add(this.vehicileValueNewLabel);
            this.VehicilesGroupBox.Controls.Add(this.vehicileTypeTextBox);
            this.VehicilesGroupBox.Location = new System.Drawing.Point(27, 237);
            this.VehicilesGroupBox.Name = "VehicilesGroupBox";
            this.VehicilesGroupBox.Size = new System.Drawing.Size(813, 111);
            this.VehicilesGroupBox.TabIndex = 20;
            this.VehicilesGroupBox.TabStop = false;
            this.VehicilesGroupBox.Text = "Vehiciles";
            // 
            // vehicilesDownButton
            // 
            this.vehicilesDownButton.Location = new System.Drawing.Point(702, 70);
            this.vehicilesDownButton.Name = "vehicilesDownButton";
            this.vehicilesDownButton.Size = new System.Drawing.Size(75, 23);
            this.vehicilesDownButton.TabIndex = 22;
            this.vehicilesDownButton.Text = "DOWN";
            this.vehicilesDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.vehicilesDownButton.UseVisualStyleBackColor = true;
            this.vehicilesDownButton.Click += new System.EventHandler(this.vehicilesDownButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ordersFetchButton
            // 
            this.ordersFetchButton.Location = new System.Drawing.Point(44, 189);
            this.ordersFetchButton.Name = "ordersFetchButton";
            this.ordersFetchButton.Size = new System.Drawing.Size(100, 23);
            this.ordersFetchButton.TabIndex = 21;
            this.ordersFetchButton.Text = "Get Orders";
            this.ordersFetchButton.UseVisualStyleBackColor = true;
            this.ordersFetchButton.Click += new System.EventHandler(this.ordersFetchButton_Click);
            // 
            // vehicilesFetchButton
            // 
            this.vehicilesFetchButton.Location = new System.Drawing.Point(44, 385);
            this.vehicilesFetchButton.Name = "vehicilesFetchButton";
            this.vehicilesFetchButton.Size = new System.Drawing.Size(100, 23);
            this.vehicilesFetchButton.TabIndex = 22;
            this.vehicilesFetchButton.Text = "Get Vehiciles";
            this.vehicilesFetchButton.UseVisualStyleBackColor = true;
            this.vehicilesFetchButton.Click += new System.EventHandler(this.vehicilesFetchButton_Click);
            // 
            // vehicileOrderAssignButton
            // 
            this.vehicileOrderAssignButton.Location = new System.Drawing.Point(44, 431);
            this.vehicileOrderAssignButton.Name = "vehicileOrderAssignButton";
            this.vehicileOrderAssignButton.Size = new System.Drawing.Size(100, 23);
            this.vehicileOrderAssignButton.TabIndex = 23;
            this.vehicileOrderAssignButton.Text = "Assign";
            this.vehicileOrderAssignButton.UseVisualStyleBackColor = true;
            this.vehicileOrderAssignButton.Click += new System.EventHandler(this.vehicileOrderAssignButton_Click);
            // 
            // CommitButton
            // 
            this.CommitButton.Location = new System.Drawing.Point(177, 431);
            this.CommitButton.Name = "CommitButton";
            this.CommitButton.Size = new System.Drawing.Size(100, 23);
            this.CommitButton.TabIndex = 24;
            this.CommitButton.Text = "Commit";
            this.CommitButton.UseVisualStyleBackColor = true;
            this.CommitButton.Click += new System.EventHandler(this.CommitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 493);
            this.Controls.Add(this.CommitButton);
            this.Controls.Add(this.vehicileOrderAssignButton);
            this.Controls.Add(this.vehicilesFetchButton);
            this.Controls.Add(this.ordersFetchButton);
            this.Controls.Add(this.VehicilesGroupBox);
            this.Controls.Add(this.ordersGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ordersGroupBox.ResumeLayout(false);
            this.ordersGroupBox.PerformLayout();
            this.VehicilesGroupBox.ResumeLayout(false);
            this.VehicilesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox orderCustomerNameTextBox;
        private System.Windows.Forms.TextBox orderTypeTextBox;
        private System.Windows.Forms.TextBox orderDurationTextBox;
        private System.Windows.Forms.ListBox OrderVehicileTypeListBox;
        private System.Windows.Forms.Label orderCustomerNameLabel;
        private System.Windows.Forms.Label orderTypeLabel;
        private System.Windows.Forms.Label orderDurationLabel;
        private System.Windows.Forms.Label orderVehicileListBoxLabel;
        private System.Windows.Forms.GroupBox ordersGroupBox;
        private System.Windows.Forms.Label VehicleTypeLabel;
        private System.Windows.Forms.Label vehicileMakeLabel;
        private System.Windows.Forms.Label vehicileYearlabel;
        private System.Windows.Forms.Label vehicileMilesLabel;
        private System.Windows.Forms.Label vehicileValueNewLabel;
        private System.Windows.Forms.TextBox vehicileTypeTextBox;
        private System.Windows.Forms.TextBox vehicileMakeTextBox;
        private System.Windows.Forms.TextBox vehicileYearTextBox;
        private System.Windows.Forms.TextBox vehicileMilesTextBox;
        private System.Windows.Forms.TextBox vehicileValueNewTextBox;
        private System.Windows.Forms.GroupBox VehicilesGroupBox;
        private System.Windows.Forms.Button ordersFetchButton;
        private System.Windows.Forms.Button orderButtonDown;
        private System.Windows.Forms.Button ordersUpButton;
        private System.Windows.Forms.Button vehicilesDownButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button vehicilesFetchButton;
        private System.Windows.Forms.Button vehicileOrderAssignButton;
        private System.Windows.Forms.Button CommitButton;
    }
}

