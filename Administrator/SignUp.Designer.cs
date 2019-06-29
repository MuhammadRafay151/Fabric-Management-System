namespace Administrator
{
    partial class SignUp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.Note = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ContactNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.Selectdate = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.ShopManager = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Font = new System.Drawing.Font("Corbert", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note.Location = new System.Drawing.Point(565, 640);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(275, 32);
            this.Note.TabIndex = 16;
            this.Note.Text = "Kindly Fill All Fields";
            this.Note.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserId:";
            // 
            // UserID
            // 
            this.UserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserID.Location = new System.Drawing.Point(507, 186);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(221, 20);
            this.UserID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.Location = new System.Drawing.Point(507, 245);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(221, 20);
            this.Password.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact Number:";
            // 
            // ContactNumber
            // 
            this.ContactNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ContactNumber.Location = new System.Drawing.Point(507, 303);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Size = new System.Drawing.Size(221, 20);
            this.ContactNumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address:";
            // 
            // Address
            // 
            this.Address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Address.Location = new System.Drawing.Point(507, 362);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(221, 20);
            this.Address.TabIndex = 9;
            // 
            // Browse
            // 
            this.Browse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.Location = new System.Drawing.Point(856, 485);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(205, 54);
            this.Browse.TabIndex = 11;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Selectdate
            // 
            this.Selectdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Selectdate.AutoSize = true;
            this.Selectdate.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selectdate.Location = new System.Drawing.Point(338, 433);
            this.Selectdate.Name = "Selectdate";
            this.Selectdate.Size = new System.Drawing.Size(180, 23);
            this.Selectdate.TabIndex = 13;
            this.Selectdate.Text = "DATE OF JOINING:";
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(539, 433);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(54, 23);
            this.Date.TabIndex = 14;
            this.Date.Text = "Date";
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBtn.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.Location = new System.Drawing.Point(342, 565);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(719, 54);
            this.SignUpBtn.TabIndex = 15;
            this.SignUpBtn.Text = "SIGN UP";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // ShopManager
            // 
            this.ShopManager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShopManager.Location = new System.Drawing.Point(507, 124);
            this.ShopManager.Name = "ShopManager";
            this.ShopManager.Size = new System.Drawing.Size(221, 20);
            this.ShopManager.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(779, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShopManager);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Selectdate);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ContactNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(1309, 720);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Note;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ContactNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label Selectdate;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.TextBox ShopManager;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
