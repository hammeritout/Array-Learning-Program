namespace Module8ArrayProject
{
    partial class frmOfLight
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNumberEntered = new System.Windows.Forms.TextBox();
            this.lblNumberEntered = new System.Windows.Forms.Label();
            this.btnAddArray = new System.Windows.Forms.Button();
            this.btnShowArray = new System.Windows.Forms.Button();
            this.lblArrayDisplay = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnResetArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(414, 171);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtNumberEntered
            // 
            this.txtNumberEntered.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberEntered.Location = new System.Drawing.Point(178, 59);
            this.txtNumberEntered.Name = "txtNumberEntered";
            this.txtNumberEntered.Size = new System.Drawing.Size(349, 34);
            this.txtNumberEntered.TabIndex = 2;
            // 
            // lblNumberEntered
            // 
            this.lblNumberEntered.AutoSize = true;
            this.lblNumberEntered.Location = new System.Drawing.Point(45, 70);
            this.lblNumberEntered.Name = "lblNumberEntered";
            this.lblNumberEntered.Size = new System.Drawing.Size(100, 17);
            this.lblNumberEntered.TabIndex = 3;
            this.lblNumberEntered.Text = "Enter Number:";
            // 
            // btnAddArray
            // 
            this.btnAddArray.Location = new System.Drawing.Point(21, 171);
            this.btnAddArray.Name = "btnAddArray";
            this.btnAddArray.Size = new System.Drawing.Size(111, 35);
            this.btnAddArray.TabIndex = 4;
            this.btnAddArray.Text = "Add Array";
            this.btnAddArray.UseVisualStyleBackColor = true;
            this.btnAddArray.Click += new System.EventHandler(this.btnAddArray_Click);
            // 
            // btnShowArray
            // 
            this.btnShowArray.Location = new System.Drawing.Point(152, 171);
            this.btnShowArray.Name = "btnShowArray";
            this.btnShowArray.Size = new System.Drawing.Size(111, 35);
            this.btnShowArray.TabIndex = 5;
            this.btnShowArray.Text = "Show Array";
            this.btnShowArray.UseVisualStyleBackColor = true;
            this.btnShowArray.Click += new System.EventHandler(this.btnShowArray_Click);
            // 
            // lblArrayDisplay
            // 
            this.lblArrayDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblArrayDisplay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrayDisplay.Location = new System.Drawing.Point(738, 28);
            this.lblArrayDisplay.Name = "lblArrayDisplay";
            this.lblArrayDisplay.Size = new System.Drawing.Size(198, 417);
            this.lblArrayDisplay.TabIndex = 6;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(21, 279);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(698, 166);
            this.lblMessage.TabIndex = 7;
            // 
            // btnResetArray
            // 
            this.btnResetArray.Location = new System.Drawing.Point(283, 171);
            this.btnResetArray.Name = "btnResetArray";
            this.btnResetArray.Size = new System.Drawing.Size(111, 35);
            this.btnResetArray.TabIndex = 1;
            this.btnResetArray.Text = "Reset Array";
            this.btnResetArray.UseVisualStyleBackColor = true;
            this.btnResetArray.Click += new System.EventHandler(this.btnResetArray_Click);
            // 
            // frmOfLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(992, 468);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblArrayDisplay);
            this.Controls.Add(this.btnShowArray);
            this.Controls.Add(this.btnAddArray);
            this.Controls.Add(this.lblNumberEntered);
            this.Controls.Add(this.txtNumberEntered);
            this.Controls.Add(this.btnResetArray);
            this.Controls.Add(this.btnExit);
            this.Name = "frmOfLight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show me the Numbers";
            this.Load += new System.EventHandler(this.frmOfLight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtNumberEntered;
        private System.Windows.Forms.Label lblNumberEntered;
        private System.Windows.Forms.Button btnAddArray;
        private System.Windows.Forms.Button btnShowArray;
        private System.Windows.Forms.Label lblArrayDisplay;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnResetArray;
    }
}

