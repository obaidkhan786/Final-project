namespace WindowsFormsApp8
{
    partial class addroom
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
            this.btn_addroom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_rmtype = new System.Windows.Forms.TextBox();
            this.txt_rmno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addroom
            // 
            this.btn_addroom.Location = new System.Drawing.Point(239, 174);
            this.btn_addroom.Name = "btn_addroom";
            this.btn_addroom.Size = new System.Drawing.Size(75, 23);
            this.btn_addroom.TabIndex = 25;
            this.btn_addroom.Text = "Add Room";
            this.btn_addroom.UseVisualStyleBackColor = true;
            this.btn_addroom.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Add Room";
            // 
            // txt_rmtype
            // 
            this.txt_rmtype.Location = new System.Drawing.Point(172, 127);
            this.txt_rmtype.Name = "txt_rmtype";
            this.txt_rmtype.Size = new System.Drawing.Size(171, 20);
            this.txt_rmtype.TabIndex = 23;
            // 
            // txt_rmno
            // 
            this.txt_rmno.Location = new System.Drawing.Point(169, 79);
            this.txt_rmno.Name = "txt_rmno";
            this.txt_rmno.Size = new System.Drawing.Size(171, 20);
            this.txt_rmno.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Room No:";
            // 
            // addroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 230);
            this.Controls.Add(this.btn_addroom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_rmtype);
            this.Controls.Add(this.txt_rmno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addroom";
            this.Text = "addroom";
            this.Load += new System.EventHandler(this.addroom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addroom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_rmtype;
        private System.Windows.Forms.TextBox txt_rmno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}