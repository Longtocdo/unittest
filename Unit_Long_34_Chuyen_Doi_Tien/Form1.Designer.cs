namespace Unit_Long_34_Chuyen_Doi_Tien
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
            this.btn_Long_34 = new System.Windows.Forms.Button();
            this.usd_long_34_tb = new System.Windows.Forms.TextBox();
            this.er_long_34_tb = new System.Windows.Forms.TextBox();
            this.lb_usd = new System.Windows.Forms.Label();
            this.lb_er_long_34 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Long_34
            // 
            this.btn_Long_34.Location = new System.Drawing.Point(273, 201);
            this.btn_Long_34.Name = "btn_Long_34";
            this.btn_Long_34.Size = new System.Drawing.Size(130, 55);
            this.btn_Long_34.TabIndex = 0;
            this.btn_Long_34.Text = "Chuyển đổi";
            this.btn_Long_34.UseVisualStyleBackColor = true;
            this.btn_Long_34.Click += new System.EventHandler(this.btn_Long_34_Click);
            // 
            // usd_long_34_tb
            // 
            this.usd_long_34_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.usd_long_34_tb.Location = new System.Drawing.Point(77, 222);
            this.usd_long_34_tb.Name = "usd_long_34_tb";
            this.usd_long_34_tb.Size = new System.Drawing.Size(130, 34);
            this.usd_long_34_tb.TabIndex = 1;
            // 
            // er_long_34_tb
            // 
            this.er_long_34_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.er_long_34_tb.Location = new System.Drawing.Point(482, 222);
            this.er_long_34_tb.Name = "er_long_34_tb";
            this.er_long_34_tb.Size = new System.Drawing.Size(130, 34);
            this.er_long_34_tb.TabIndex = 1;
            // 
            // lb_usd
            // 
            this.lb_usd.AutoSize = true;
            this.lb_usd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lb_usd.Location = new System.Drawing.Point(97, 167);
            this.lb_usd.Name = "lb_usd";
            this.lb_usd.Size = new System.Drawing.Size(90, 39);
            this.lb_usd.TabIndex = 2;
            this.lb_usd.Text = "USD";
            // 
            // lb_er_long_34
            // 
            this.lb_er_long_34.AutoSize = true;
            this.lb_er_long_34.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lb_er_long_34.Location = new System.Drawing.Point(484, 167);
            this.lb_er_long_34.Name = "lb_er_long_34";
            this.lb_er_long_34.Size = new System.Drawing.Size(116, 39);
            this.lb_er_long_34.TabIndex = 2;
            this.lb_er_long_34.Text = "EURO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_er_long_34);
            this.Controls.Add(this.lb_usd);
            this.Controls.Add(this.er_long_34_tb);
            this.Controls.Add(this.usd_long_34_tb);
            this.Controls.Add(this.btn_Long_34);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Long_34;
        private System.Windows.Forms.TextBox usd_long_34_tb;
        private System.Windows.Forms.TextBox er_long_34_tb;
        private System.Windows.Forms.Label lb_usd;
        private System.Windows.Forms.Label lb_er_long_34;
    }
}

