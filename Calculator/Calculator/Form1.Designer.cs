namespace Calculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnEqul = new System.Windows.Forms.Button();
            this.BtnDec = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnPM = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnBackSpace = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.BtnDiv);
            this.panel1.Controls.Add(this.BtnEqul);
            this.panel1.Controls.Add(this.BtnDec);
            this.panel1.Controls.Add(this.Btn0);
            this.panel1.Controls.Add(this.BtnMul);
            this.panel1.Controls.Add(this.Btn3);
            this.panel1.Controls.Add(this.Btn2);
            this.panel1.Controls.Add(this.Btn1);
            this.panel1.Controls.Add(this.BtnSub);
            this.panel1.Controls.Add(this.Btn6);
            this.panel1.Controls.Add(this.Btn5);
            this.panel1.Controls.Add(this.Btn4);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.Btn9);
            this.panel1.Controls.Add(this.Btn8);
            this.panel1.Controls.Add(this.Btn7);
            this.panel1.Controls.Add(this.BtnPM);
            this.panel1.Controls.Add(this.BtnC);
            this.panel1.Controls.Add(this.BtnCE);
            this.panel1.Controls.Add(this.BtnBackSpace);
            this.panel1.Controls.Add(this.txtDisplay);
            this.panel1.Location = new System.Drawing.Point(13, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 426);
            this.panel1.TabIndex = 0;
            // 
            // BtnDiv
            // 
            this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.Location = new System.Drawing.Point(248, 349);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(71, 64);
            this.BtnDiv.TabIndex = 41;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnEqul
            // 
            this.BtnEqul.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEqul.Location = new System.Drawing.Point(171, 349);
            this.BtnEqul.Name = "BtnEqul";
            this.BtnEqul.Size = new System.Drawing.Size(71, 64);
            this.BtnEqul.TabIndex = 40;
            this.BtnEqul.Text = "=";
            this.BtnEqul.UseVisualStyleBackColor = true;
            this.BtnEqul.Click += new System.EventHandler(this.BtnEqul_Click);
            // 
            // BtnDec
            // 
            this.BtnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDec.Location = new System.Drawing.Point(94, 349);
            this.BtnDec.Name = "BtnDec";
            this.BtnDec.Size = new System.Drawing.Size(71, 64);
            this.BtnDec.TabIndex = 39;
            this.BtnDec.Text = ".";
            this.BtnDec.UseVisualStyleBackColor = true;
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(17, 349);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(71, 64);
            this.Btn0.TabIndex = 38;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMul.Location = new System.Drawing.Point(248, 279);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(71, 64);
            this.BtnMul.TabIndex = 37;
            this.BtnMul.Text = "*";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(171, 279);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(71, 64);
            this.Btn3.TabIndex = 36;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(94, 279);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(71, 64);
            this.Btn2.TabIndex = 35;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(17, 279);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(71, 64);
            this.Btn1.TabIndex = 34;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSub.Location = new System.Drawing.Point(248, 209);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(71, 64);
            this.BtnSub.TabIndex = 33;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(171, 209);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(71, 64);
            this.Btn6.TabIndex = 32;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(94, 209);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(71, 64);
            this.Btn5.TabIndex = 31;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(17, 209);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(71, 64);
            this.Btn4.TabIndex = 30;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(248, 139);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(71, 64);
            this.BtnAdd.TabIndex = 29;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(171, 139);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(71, 64);
            this.Btn9.TabIndex = 28;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(94, 139);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(71, 64);
            this.Btn8.TabIndex = 27;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(17, 139);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(71, 64);
            this.Btn7.TabIndex = 26;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // BtnPM
            // 
            this.BtnPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPM.Location = new System.Drawing.Point(248, 69);
            this.BtnPM.Name = "BtnPM";
            this.BtnPM.Size = new System.Drawing.Size(71, 64);
            this.BtnPM.TabIndex = 25;
            this.BtnPM.Text = "± ";
            this.BtnPM.UseVisualStyleBackColor = true;
            this.BtnPM.Click += new System.EventHandler(this.BtnPM_Click);
            // 
            // BtnC
            // 
            this.BtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.Location = new System.Drawing.Point(171, 69);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(71, 64);
            this.BtnC.TabIndex = 24;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCE.Location = new System.Drawing.Point(94, 69);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(71, 64);
            this.BtnCE.TabIndex = 23;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackSpace.Location = new System.Drawing.Point(17, 69);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(71, 64);
            this.BtnBackSpace.TabIndex = 22;
            this.BtnBackSpace.Text = "⌫";
            this.BtnBackSpace.UseVisualStyleBackColor = true;
            this.BtnBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(17, 13);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(302, 40);
            this.txtDisplay.TabIndex = 21;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 437);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnEqul;
        private System.Windows.Forms.Button BtnDec;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnPM;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnBackSpace;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}

