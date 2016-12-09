namespace PrintCheckInCheckOut
{
    partial class checkInCheckOut
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printResult = new System.Drawing.Printing.PrintDocument();
            this.lbTimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check In";
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckIn.Location = new System.Drawing.Point(224, 78);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.ReadOnly = true;
            this.txtCheckIn.Size = new System.Drawing.Size(564, 36);
            this.txtCheckIn.TabIndex = 1;
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckOut.Location = new System.Drawing.Point(224, 146);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.ReadOnly = true;
            this.txtCheckOut.Size = new System.Drawing.Size(564, 36);
            this.txtCheckOut.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Check Out";
            // 
            // txtRes
            // 
            this.txtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRes.Location = new System.Drawing.Point(12, 325);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.Size = new System.Drawing.Size(867, 302);
            this.txtRes.TabIndex = 4;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(183, 236);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(165, 40);
            this.btnCheckIn.TabIndex = 5;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(354, 236);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(165, 40);
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(525, 236);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(165, 40);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printResult
            // 
            this.printResult.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printResult_PrintPage);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(81, 26);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(62, 25);
            this.lbTimer.TabIndex = 8;
            this.lbTimer.Text = "Timer";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // checkInCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 639);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtCheckOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCheckIn);
            this.Controls.Add(this.label1);
            this.Name = "checkInCheckOut";
            this.Text = "Check In & Check Out";
            this.Load += new System.EventHandler(this.checkInCheckOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printResult;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer timer;
    }
}

