namespace BudgetRecord
{
    partial class Newprod
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
            this.label1 = new System.Windows.Forms.Label();
            this.prod_btn = new System.Windows.Forms.RadioButton();
            this.serv_btn = new System.Windows.Forms.RadioButton();
            this.amount_textbox = new System.Windows.Forms.TextBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.loc_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.amount_label = new System.Windows.Forms.Label();
            this.loc_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kiadás típusa:";
            // 
            // prod_btn
            // 
            this.prod_btn.AutoSize = true;
            this.prod_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prod_btn.Location = new System.Drawing.Point(171, 45);
            this.prod_btn.Name = "prod_btn";
            this.prod_btn.Size = new System.Drawing.Size(91, 24);
            this.prod_btn.TabIndex = 5;
            this.prod_btn.Text = "Új ternék";
            this.prod_btn.UseVisualStyleBackColor = true;
            this.prod_btn.CheckedChanged += new System.EventHandler(this.prod_btn_CheckedChanged);
            // 
            // serv_btn
            // 
            this.serv_btn.AutoSize = true;
            this.serv_btn.Checked = true;
            this.serv_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serv_btn.Location = new System.Drawing.Point(21, 45);
            this.serv_btn.Name = "serv_btn";
            this.serv_btn.Size = new System.Drawing.Size(131, 24);
            this.serv_btn.TabIndex = 6;
            this.serv_btn.TabStop = true;
            this.serv_btn.Text = "Új szolgáltatás";
            this.serv_btn.UseVisualStyleBackColor = true;
            // 
            // amount_textbox
            // 
            this.amount_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.amount_textbox.Location = new System.Drawing.Point(132, 225);
            this.amount_textbox.Name = "amount_textbox";
            this.amount_textbox.Size = new System.Drawing.Size(208, 26);
            this.amount_textbox.TabIndex = 9;
            this.amount_textbox.Visible = false;
            // 
            // price_textbox
            // 
            this.price_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.price_textbox.Location = new System.Drawing.Point(132, 181);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(208, 26);
            this.price_textbox.TabIndex = 10;
            // 
            // loc_textbox
            // 
            this.loc_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loc_textbox.Location = new System.Drawing.Point(132, 139);
            this.loc_textbox.Name = "loc_textbox";
            this.loc_textbox.Size = new System.Drawing.Size(208, 26);
            this.loc_textbox.TabIndex = 11;
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name_textbox.Location = new System.Drawing.Point(132, 91);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(208, 26);
            this.name_textbox.TabIndex = 12;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name_label.Location = new System.Drawing.Point(17, 94);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(99, 20);
            this.name_label.TabIndex = 15;
            this.name_label.Text = "Megnevezés";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.price_label.Location = new System.Drawing.Point(18, 184);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(76, 20);
            this.price_label.TabIndex = 16;
            this.price_label.Text = "Egységár";
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.amount_label.Location = new System.Drawing.Point(17, 228);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(85, 20);
            this.amount_label.TabIndex = 18;
            this.amount_label.Text = "Mennyiség";
            this.amount_label.Visible = false;
            // 
            // loc_label
            // 
            this.loc_label.AutoSize = true;
            this.loc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loc_label.Location = new System.Drawing.Point(18, 142);
            this.loc_label.Name = "loc_label";
            this.loc_label.Size = new System.Drawing.Size(68, 20);
            this.loc_label.TabIndex = 19;
            this.loc_label.Text = "Helyszín";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(132, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Mentés";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Newprod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loc_label);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.loc_textbox);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.amount_textbox);
            this.Controls.Add(this.serv_btn);
            this.Controls.Add(this.prod_btn);
            this.Controls.Add(this.label1);
            this.Name = "Newprod";
            this.Text = "Newprod";
            this.Load += new System.EventHandler(this.Newprod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton prod_btn;
        private System.Windows.Forms.RadioButton serv_btn;
        private System.Windows.Forms.TextBox amount_textbox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.TextBox loc_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.Label loc_label;
        private System.Windows.Forms.Button button1;
    }
}