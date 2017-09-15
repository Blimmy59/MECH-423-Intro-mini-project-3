namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblXAxis;
            System.Windows.Forms.Label lblYAxis;
            System.Windows.Forms.Label lblZAxis;
            this.txtXAxis = new System.Windows.Forms.TextBox();
            this.txtYAxis = new System.Windows.Forms.TextBox();
            this.txtZAxis = new System.Windows.Forms.TextBox();
            this.dropDownBox = new System.Windows.Forms.ComboBox();
            this.button = new System.Windows.Forms.Button();
            this.gumStick = new System.IO.Ports.SerialPort(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            lblXAxis = new System.Windows.Forms.Label();
            lblYAxis = new System.Windows.Forms.Label();
            lblZAxis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblXAxis
            // 
            lblXAxis.AutoSize = true;
            lblXAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblXAxis.Location = new System.Drawing.Point(231, 134);
            lblXAxis.Name = "lblXAxis";
            lblXAxis.Size = new System.Drawing.Size(107, 37);
            lblXAxis.TabIndex = 0;
            lblXAxis.Text = "X Axis";
            // 
            // lblYAxis
            // 
            lblYAxis.AutoSize = true;
            lblYAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblYAxis.Location = new System.Drawing.Point(231, 184);
            lblYAxis.Name = "lblYAxis";
            lblYAxis.Size = new System.Drawing.Size(108, 37);
            lblYAxis.TabIndex = 1;
            lblYAxis.Text = "Y Axis";
            // 
            // lblZAxis
            // 
            lblZAxis.AutoSize = true;
            lblZAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblZAxis.Location = new System.Drawing.Point(231, 234);
            lblZAxis.Name = "lblZAxis";
            lblZAxis.Size = new System.Drawing.Size(106, 37);
            lblZAxis.TabIndex = 2;
            lblZAxis.Text = "Z Axis";
            // 
            // txtXAxis
            // 
            this.txtXAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXAxis.Location = new System.Drawing.Point(47, 131);
            this.txtXAxis.Name = "txtXAxis";
            this.txtXAxis.Size = new System.Drawing.Size(178, 44);
            this.txtXAxis.TabIndex = 3;
            // 
            // txtYAxis
            // 
            this.txtYAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYAxis.Location = new System.Drawing.Point(47, 181);
            this.txtYAxis.Name = "txtYAxis";
            this.txtYAxis.Size = new System.Drawing.Size(178, 44);
            this.txtYAxis.TabIndex = 4;
            // 
            // txtZAxis
            // 
            this.txtZAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZAxis.Location = new System.Drawing.Point(47, 231);
            this.txtZAxis.Name = "txtZAxis";
            this.txtZAxis.Size = new System.Drawing.Size(178, 44);
            this.txtZAxis.TabIndex = 5;
            // 
            // dropDownBox
            // 
            this.dropDownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownBox.FormattingEnabled = true;
            this.dropDownBox.Location = new System.Drawing.Point(47, 48);
            this.dropDownBox.Name = "dropDownBox";
            this.dropDownBox.Size = new System.Drawing.Size(178, 45);
            this.dropDownBox.TabIndex = 6;
            this.dropDownBox.DropDown += new System.EventHandler(this.dropDownBox_DropDown);
            // 
            // button
            // 
            this.button.AccessibleName = "btnCom";
            this.button.Location = new System.Drawing.Point(231, 45);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(159, 54);
            this.button.TabIndex = 7;
            this.button.Text = "Connect";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // gumStick
            // 
            this.gumStick.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.gumStick_DataReceived);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 311);
            this.Controls.Add(this.button);
            this.Controls.Add(this.dropDownBox);
            this.Controls.Add(this.txtZAxis);
            this.Controls.Add(this.txtYAxis);
            this.Controls.Add(this.txtXAxis);
            this.Controls.Add(lblZAxis);
            this.Controls.Add(lblYAxis);
            this.Controls.Add(lblXAxis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXAxis;
        private System.Windows.Forms.TextBox txtYAxis;
        private System.Windows.Forms.TextBox txtZAxis;
        private System.Windows.Forms.ComboBox dropDownBox;
        private System.Windows.Forms.Button button;
        private System.IO.Ports.SerialPort gumStick;
        private System.Windows.Forms.Timer Timer;
    }
}

