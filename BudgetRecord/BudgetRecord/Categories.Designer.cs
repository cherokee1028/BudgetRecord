namespace BudgetRecord
{
    partial class Categories
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
            this.addnew_btn = new System.Windows.Forms.Button();
            this.cat_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prodsandservs_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.prodsandservs_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // addnew_btn
            // 
            this.addnew_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addnew_btn.Location = new System.Drawing.Point(652, 395);
            this.addnew_btn.Name = "addnew_btn";
            this.addnew_btn.Size = new System.Drawing.Size(136, 32);
            this.addnew_btn.TabIndex = 0;
            this.addnew_btn.Text = "Új kiadás/termék";
            this.addnew_btn.UseVisualStyleBackColor = true;
            this.addnew_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cat_combobox
            // 
            this.cat_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cat_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cat_combobox.FormattingEnabled = true;
            this.cat_combobox.Items.AddRange(new object[] {
            "Összes",
            "Szolgáltatás",
            "Termék"});
            this.cat_combobox.Location = new System.Drawing.Point(16, 40);
            this.cat_combobox.Name = "cat_combobox";
            this.cat_combobox.Size = new System.Drawing.Size(178, 28);
            this.cat_combobox.TabIndex = 1;
            this.cat_combobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kiadás típusa:";
            // 
            // prodsandservs_dgv
            // 
            this.prodsandservs_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodsandservs_dgv.Location = new System.Drawing.Point(16, 74);
            this.prodsandservs_dgv.Name = "prodsandservs_dgv";
            this.prodsandservs_dgv.Size = new System.Drawing.Size(772, 315);
            this.prodsandservs_dgv.TabIndex = 3;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prodsandservs_dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cat_combobox);
            this.Controls.Add(this.addnew_btn);
            this.Name = "Categories";
            this.Text = "Categories";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Categories_FormClosed);
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodsandservs_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addnew_btn;
        private System.Windows.Forms.ComboBox cat_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView prodsandservs_dgv;
    }
}