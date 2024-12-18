namespace Shapes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_ShapeChoice = new System.Windows.Forms.ComboBox();
            this.Btn_Draw = new System.Windows.Forms.Button();
            this.PL_Canvas = new System.Windows.Forms.Panel();
            this.Txt_Dim1 = new System.Windows.Forms.TextBox();
            this.Txt_Dim2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shape Drawing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Shape: ";
            // 
            // CB_ShapeChoice
            // 
            this.CB_ShapeChoice.FormattingEnabled = true;
            this.CB_ShapeChoice.Items.AddRange(new object[] {
            "Circle",
            "Rectangle",
            "Triangle"});
            this.CB_ShapeChoice.Location = new System.Drawing.Point(12, 65);
            this.CB_ShapeChoice.Name = "CB_ShapeChoice";
            this.CB_ShapeChoice.Size = new System.Drawing.Size(442, 21);
            this.CB_ShapeChoice.TabIndex = 4;
            // 
            // Btn_Draw
            // 
            this.Btn_Draw.Location = new System.Drawing.Point(379, 156);
            this.Btn_Draw.Name = "Btn_Draw";
            this.Btn_Draw.Size = new System.Drawing.Size(75, 23);
            this.Btn_Draw.TabIndex = 5;
            this.Btn_Draw.Text = "Draw Shape";
            this.Btn_Draw.UseVisualStyleBackColor = true;
            this.Btn_Draw.Click += new System.EventHandler(this.Btn_Draw_Click);
            // 
            // PL_Canvas
            // 
            this.PL_Canvas.Location = new System.Drawing.Point(12, 185);
            this.PL_Canvas.Name = "PL_Canvas";
            this.PL_Canvas.Size = new System.Drawing.Size(442, 157);
            this.PL_Canvas.TabIndex = 6;
            this.PL_Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PL_Canvas_Paint);
            // 
            // Txt_Dim1
            // 
            this.Txt_Dim1.Location = new System.Drawing.Point(12, 117);
            this.Txt_Dim1.Name = "Txt_Dim1";
            this.Txt_Dim1.Size = new System.Drawing.Size(218, 20);
            this.Txt_Dim1.TabIndex = 7;
            // 
            // Txt_Dim2
            // 
            this.Txt_Dim2.Location = new System.Drawing.Point(236, 117);
            this.Txt_Dim2.Name = "Txt_Dim2";
            this.Txt_Dim2.Size = new System.Drawing.Size(218, 20);
            this.Txt_Dim2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dimension 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dimension 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 354);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Dim2);
            this.Controls.Add(this.Txt_Dim1);
            this.Controls.Add(this.PL_Canvas);
            this.Controls.Add(this.Btn_Draw);
            this.Controls.Add(this.CB_ShapeChoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_ShapeChoice;
        private System.Windows.Forms.Button Btn_Draw;
        private System.Windows.Forms.Panel PL_Canvas;
        private System.Windows.Forms.TextBox Txt_Dim1;
        private System.Windows.Forms.TextBox Txt_Dim2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

