namespace BakeryInventorySystem
{
    partial class frmEditProduct
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
            this.cboCateg = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtPROCODE = new System.Windows.Forms.TextBox();
            this.TXTDESC = new System.Windows.Forms.RichTextBox();
            this.TXTPRICE = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TXTPRONAME = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.BTNSAVE = new System.Windows.Forms.Button();
            this.LBLUNIT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTQTY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboCateg
            // 
            this.cboCateg.FormattingEnabled = true;
            this.cboCateg.Items.AddRange(new object[] {
            "Bread",
            "Cake",
            "Cookie",
            "Biscuit"});
            this.cboCateg.Location = new System.Drawing.Point(194, 245);
            this.cboCateg.Margin = new System.Windows.Forms.Padding(4);
            this.cboCateg.Name = "cboCateg";
            this.cboCateg.Size = new System.Drawing.Size(450, 24);
            this.cboCateg.TabIndex = 69;
            this.cboCateg.Text = "Select";
            this.cboCateg.SelectedIndexChanged += new System.EventHandler(this.cboCateg_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(66, 82);
            this.Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 18);
            this.Label1.TabIndex = 68;
            this.Label1.Text = "Code:";
            // 
            // txtPROCODE
            // 
            this.txtPROCODE.Enabled = false;
            this.txtPROCODE.Location = new System.Drawing.Point(194, 80);
            this.txtPROCODE.Margin = new System.Windows.Forms.Padding(4);
            this.txtPROCODE.Name = "txtPROCODE";
            this.txtPROCODE.Size = new System.Drawing.Size(450, 22);
            this.txtPROCODE.TabIndex = 67;
            // 
            // TXTDESC
            // 
            this.TXTDESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDESC.Location = new System.Drawing.Point(194, 162);
            this.TXTDESC.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TXTDESC.Name = "TXTDESC";
            this.TXTDESC.Size = new System.Drawing.Size(450, 73);
            this.TXTDESC.TabIndex = 60;
            this.TXTDESC.Text = "";
            this.TXTDESC.TextChanged += new System.EventHandler(this.TXTDESC_TextChanged);
            // 
            // TXTPRICE
            // 
            this.TXTPRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPRICE.Location = new System.Drawing.Point(194, 290);
            this.TXTPRICE.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TXTPRICE.Name = "TXTPRICE";
            this.TXTPRICE.Size = new System.Drawing.Size(130, 36);
            this.TXTPRICE.TabIndex = 61;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(66, 126);
            this.Label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 18);
            this.Label2.TabIndex = 62;
            this.Label2.Text = "Name :";
            // 
            // TXTPRONAME
            // 
            this.TXTPRONAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPRONAME.Location = new System.Drawing.Point(194, 122);
            this.TXTPRONAME.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TXTPRONAME.Name = "TXTPRONAME";
            this.TXTPRONAME.Size = new System.Drawing.Size(450, 26);
            this.TXTPRONAME.TabIndex = 59;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(66, 166);
            this.Label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(104, 18);
            this.Label3.TabIndex = 63;
            this.Label3.Text = "Description :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(66, 246);
            this.Label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(91, 18);
            this.Label7.TabIndex = 65;
            this.Label7.Text = "Category : ";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(336, 290);
            this.Label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(32, 20);
            this.Label4.TabIndex = 66;
            this.Label4.Text = "Rp";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(66, 290);
            this.Label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(57, 18);
            this.Label6.TabIndex = 64;
            this.Label6.Text = "Price :";
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(475, 422);
            this.Button2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(130, 39);
            this.Button2.TabIndex = 58;
            this.Button2.Text = "Close";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(334, 422);
            this.btnList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(130, 39);
            this.btnList.TabIndex = 57;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSAVE.Location = new System.Drawing.Point(194, 422);
            this.BTNSAVE.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(130, 39);
            this.BTNSAVE.TabIndex = 56;
            this.BTNSAVE.Text = "Save";
            this.BTNSAVE.UseVisualStyleBackColor = true;
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // LBLUNIT
            // 
            this.LBLUNIT.AutoSize = true;
            this.LBLUNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUNIT.Location = new System.Drawing.Point(509, 359);
            this.LBLUNIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLUNIT.Name = "LBLUNIT";
            this.LBLUNIT.Size = new System.Drawing.Size(49, 20);
            this.LBLUNIT.TabIndex = 72;
            this.LBLUNIT.Text = "Unit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 363);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Quantity:";
            // 
            // TXTQTY
            // 
            this.TXTQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTQTY.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TXTQTY.Location = new System.Drawing.Point(326, 352);
            this.TXTQTY.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TXTQTY.Name = "TXTQTY";
            this.TXTQTY.Size = new System.Drawing.Size(176, 34);
            this.TXTQTY.TabIndex = 70;
            // 
            // frmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 551);
            this.Controls.Add(this.LBLUNIT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTQTY);
            this.Controls.Add(this.cboCateg);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtPROCODE);
            this.Controls.Add(this.TXTDESC);
            this.Controls.Add(this.TXTPRICE);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TXTPRONAME);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.BTNSAVE);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product";
            this.Load += new System.EventHandler(this.frmEditProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ComboBox cboCateg;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtPROCODE;
        internal System.Windows.Forms.RichTextBox TXTDESC;
        internal System.Windows.Forms.TextBox TXTPRICE;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TXTPRONAME;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button btnList;
        internal System.Windows.Forms.Button BTNSAVE;
        internal System.Windows.Forms.Label LBLUNIT;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox TXTQTY;
    }
}