namespace Calculator
{
    partial class frmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblHistory = new System.Windows.Forms.Label();
            this.btnOFF = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnON = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.ForeColor = System.Drawing.Color.DarkRed;
            this.txtResult.Location = new System.Drawing.Point(21, 34);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResult.MaxLength = 50;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(285, 26);
            this.txtResult.TabIndex = 0;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.TextChanged += new System.EventHandler(this.tResult_TextChanged);
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHistory.Location = new System.Drawing.Point(17, 9);
            this.lblHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(42, 20);
            this.lblHistory.TabIndex = 1;
            this.lblHistory.Text = "label";
            // 
            // btnOFF
            // 
            this.btnOFF.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOFF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOFF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOFF.Location = new System.Drawing.Point(21, 115);
            this.btnOFF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(60, 38);
            this.btnOFF.TabIndex = 2;
            this.btnOFF.Text = "O&FF";
            this.btnOFF.UseVisualStyleBackColor = true;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBackspace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBackspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Location = new System.Drawing.Point(151, 116);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(60, 38);
            this.btnBackspace.TabIndex = 3;
            this.btnBackspace.Text = "<---";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(86, 115);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 38);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(249, 116);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.operation_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSeven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSeven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Location = new System.Drawing.Point(20, 160);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(60, 38);
            this.btnSeven.TabIndex = 6;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnEight
            // 
            this.btnEight.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Location = new System.Drawing.Point(86, 160);
            this.btnEight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(60, 38);
            this.btnEight.TabIndex = 7;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNine
            // 
            this.btnNine.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnNine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Location = new System.Drawing.Point(152, 160);
            this.btnNine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(60, 38);
            this.btnNine.TabIndex = 8;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSub
            // 
            this.btnSub.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Location = new System.Drawing.Point(249, 160);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(60, 38);
            this.btnSub.TabIndex = 9;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.operation_Click);
            // 
            // btnFour
            // 
            this.btnFour.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Location = new System.Drawing.Point(20, 205);
            this.btnFour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(60, 38);
            this.btnFour.TabIndex = 10;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnFive
            // 
            this.btnFive.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnFive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Location = new System.Drawing.Point(86, 205);
            this.btnFive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(60, 38);
            this.btnFive.TabIndex = 11;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSix
            // 
            this.btnSix.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Location = new System.Drawing.Point(152, 205);
            this.btnSix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(60, 38);
            this.btnSix.TabIndex = 12;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMul
            // 
            this.btnMul.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMul.Location = new System.Drawing.Point(249, 205);
            this.btnMul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(60, 38);
            this.btnMul.TabIndex = 13;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.operation_Click);
            // 
            // btnOne
            // 
            this.btnOne.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Location = new System.Drawing.Point(20, 249);
            this.btnOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(60, 38);
            this.btnOne.TabIndex = 14;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnTwo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Location = new System.Drawing.Point(86, 249);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(60, 38);
            this.btnTwo.TabIndex = 15;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnThree
            // 
            this.btnThree.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnThree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Location = new System.Drawing.Point(152, 249);
            this.btnThree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(60, 38);
            this.btnThree.TabIndex = 16;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Location = new System.Drawing.Point(249, 249);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(60, 38);
            this.btnDiv.TabIndex = 17;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.operation_Click);
            // 
            // btnZero
            // 
            this.btnZero.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Location = new System.Drawing.Point(20, 294);
            this.btnZero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(60, 38);
            this.btnZero.TabIndex = 18;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDot
            // 
            this.btnDot.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Location = new System.Drawing.Point(86, 294);
            this.btnDot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(60, 38);
            this.btnDot.TabIndex = 19;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNegative.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnNegative.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNegative.Location = new System.Drawing.Point(153, 294);
            this.btnNegative.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(60, 38);
            this.btnNegative.TabIndex = 20;
            this.btnNegative.Text = "+/-";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnResult
            // 
            this.btnResult.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Location = new System.Drawing.Point(249, 294);
            this.btnResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(60, 38);
            this.btnResult.TabIndex = 21;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnON
            // 
            this.btnON.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnON.Location = new System.Drawing.Point(20, 115);
            this.btnON.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(60, 38);
            this.btnON.TabIndex = 22;
            this.btnON.Text = "ON";
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // btnText
            // 
            this.btnText.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnText.Location = new System.Drawing.Point(21, 70);
            this.btnText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(60, 35);
            this.btnText.TabIndex = 23;
            this.btnText.Text = "text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(89, 70);
            this.txtWords.Multiline = true;
            this.txtWords.Name = "txtWords";
            this.txtWords.ReadOnly = true;
            this.txtWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWords.Size = new System.Drawing.Size(217, 35);
            this.txtWords.TabIndex = 24;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 344);
            this.Controls.Add(this.txtWords);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.txtResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCalculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnDiv;
       // private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.TextBox txtWords;
    }
}

