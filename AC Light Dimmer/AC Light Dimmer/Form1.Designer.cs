namespace AC_Light_Dimmer
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
            this.radiobutton_Incandescent = new System.Windows.Forms.RadioButton();
            this.radiobutton_ACLED = new System.Windows.Forms.RadioButton();
            this.groupbox_Bulb = new System.Windows.Forms.GroupBox();
            this.radiobutton_DCLED = new System.Windows.Forms.RadioButton();
            this.numeric_PowerOutput = new System.Windows.Forms.NumericUpDown();
            this.groupbox_Data = new System.Windows.Forms.GroupBox();
            this.textbox_Output = new System.Windows.Forms.TextBox();
            this.groupbox_Con = new System.Windows.Forms.GroupBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.textbox_Comm = new System.Windows.Forms.TextBox();
            this.button_OnOff = new System.Windows.Forms.Button();
            this.groupbox_Bulb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_PowerOutput)).BeginInit();
            this.groupbox_Data.SuspendLayout();
            this.groupbox_Con.SuspendLayout();
            this.SuspendLayout();
            // 
            // radiobutton_Incandescent
            // 
            this.radiobutton_Incandescent.AutoSize = true;
            this.radiobutton_Incandescent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobutton_Incandescent.Location = new System.Drawing.Point(6, 19);
            this.radiobutton_Incandescent.Name = "radiobutton_Incandescent";
            this.radiobutton_Incandescent.Size = new System.Drawing.Size(142, 21);
            this.radiobutton_Incandescent.TabIndex = 0;
            this.radiobutton_Incandescent.TabStop = true;
            this.radiobutton_Incandescent.Text = "Incandescent Bulb";
            this.radiobutton_Incandescent.UseVisualStyleBackColor = true;
            this.radiobutton_Incandescent.CheckedChanged += new System.EventHandler(this.radiobutton_Incandescent_CheckedChanged);
            // 
            // radiobutton_ACLED
            // 
            this.radiobutton_ACLED.AutoSize = true;
            this.radiobutton_ACLED.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobutton_ACLED.Location = new System.Drawing.Point(6, 42);
            this.radiobutton_ACLED.Name = "radiobutton_ACLED";
            this.radiobutton_ACLED.Size = new System.Drawing.Size(111, 21);
            this.radiobutton_ACLED.TabIndex = 1;
            this.radiobutton_ACLED.TabStop = true;
            this.radiobutton_ACLED.Text = "A/C LED Bulb";
            this.radiobutton_ACLED.UseVisualStyleBackColor = true;
            this.radiobutton_ACLED.CheckedChanged += new System.EventHandler(this.radiobutton_ACLED_CheckedChanged);
            // 
            // groupbox_Bulb
            // 
            this.groupbox_Bulb.Controls.Add(this.radiobutton_DCLED);
            this.groupbox_Bulb.Controls.Add(this.radiobutton_Incandescent);
            this.groupbox_Bulb.Controls.Add(this.radiobutton_ACLED);
            this.groupbox_Bulb.Enabled = false;
            this.groupbox_Bulb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_Bulb.Location = new System.Drawing.Point(257, 8);
            this.groupbox_Bulb.Name = "groupbox_Bulb";
            this.groupbox_Bulb.Size = new System.Drawing.Size(231, 100);
            this.groupbox_Bulb.TabIndex = 2;
            this.groupbox_Bulb.TabStop = false;
            this.groupbox_Bulb.Text = "Bulb Type: ";
            // 
            // radiobutton_DCLED
            // 
            this.radiobutton_DCLED.AutoSize = true;
            this.radiobutton_DCLED.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobutton_DCLED.Location = new System.Drawing.Point(6, 65);
            this.radiobutton_DCLED.Name = "radiobutton_DCLED";
            this.radiobutton_DCLED.Size = new System.Drawing.Size(108, 21);
            this.radiobutton_DCLED.TabIndex = 2;
            this.radiobutton_DCLED.TabStop = true;
            this.radiobutton_DCLED.Text = "DC LED Bulb";
            this.radiobutton_DCLED.UseVisualStyleBackColor = true;
            this.radiobutton_DCLED.CheckedChanged += new System.EventHandler(this.radiobutton_DCLED_CheckedChanged);
            // 
            // numeric_PowerOutput
            // 
            this.numeric_PowerOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_PowerOutput.Location = new System.Drawing.Point(11, 25);
            this.numeric_PowerOutput.Name = "numeric_PowerOutput";
            this.numeric_PowerOutput.Size = new System.Drawing.Size(74, 38);
            this.numeric_PowerOutput.TabIndex = 3;
            this.numeric_PowerOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_PowerOutput.ValueChanged += new System.EventHandler(this.numeric_PowerOutput_ValueChanged);
            // 
            // groupbox_Data
            // 
            this.groupbox_Data.Controls.Add(this.button_OnOff);
            this.groupbox_Data.Controls.Add(this.textbox_Output);
            this.groupbox_Data.Controls.Add(this.numeric_PowerOutput);
            this.groupbox_Data.Enabled = false;
            this.groupbox_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_Data.Location = new System.Drawing.Point(15, 114);
            this.groupbox_Data.Name = "groupbox_Data";
            this.groupbox_Data.Size = new System.Drawing.Size(473, 145);
            this.groupbox_Data.TabIndex = 4;
            this.groupbox_Data.TabStop = false;
            this.groupbox_Data.Text = "Dimming Level";
            // 
            // textbox_Output
            // 
            this.textbox_Output.BackColor = System.Drawing.Color.White;
            this.textbox_Output.Location = new System.Drawing.Point(10, 68);
            this.textbox_Output.Multiline = true;
            this.textbox_Output.Name = "textbox_Output";
            this.textbox_Output.ReadOnly = true;
            this.textbox_Output.Size = new System.Drawing.Size(450, 69);
            this.textbox_Output.TabIndex = 4;
            // 
            // groupbox_Con
            // 
            this.groupbox_Con.Controls.Add(this.button_Connect);
            this.groupbox_Con.Controls.Add(this.textbox_Comm);
            this.groupbox_Con.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_Con.Location = new System.Drawing.Point(15, 8);
            this.groupbox_Con.Name = "groupbox_Con";
            this.groupbox_Con.Size = new System.Drawing.Size(236, 100);
            this.groupbox_Con.TabIndex = 5;
            this.groupbox_Con.TabStop = false;
            this.groupbox_Con.Text = "CONNECTION STATUS";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(10, 51);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(213, 35);
            this.button_Connect.TabIndex = 1;
            this.button_Connect.Text = "CONNECT";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // textbox_Comm
            // 
            this.textbox_Comm.BackColor = System.Drawing.Color.White;
            this.textbox_Comm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Comm.Location = new System.Drawing.Point(11, 21);
            this.textbox_Comm.Name = "textbox_Comm";
            this.textbox_Comm.ReadOnly = true;
            this.textbox_Comm.Size = new System.Drawing.Size(212, 23);
            this.textbox_Comm.TabIndex = 0;
            // 
            // button_OnOff
            // 
            this.button_OnOff.Location = new System.Drawing.Point(94, 24);
            this.button_OnOff.Name = "button_OnOff";
            this.button_OnOff.Size = new System.Drawing.Size(142, 38);
            this.button_OnOff.TabIndex = 5;
            this.button_OnOff.Text = "ON";
            this.button_OnOff.UseVisualStyleBackColor = true;
            this.button_OnOff.Click += new System.EventHandler(this.button_OnOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 271);
            this.Controls.Add(this.groupbox_Con);
            this.Controls.Add(this.groupbox_Data);
            this.Controls.Add(this.groupbox_Bulb);
            this.Name = "Form1";
            this.Text = "Light Dimmer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupbox_Bulb.ResumeLayout(false);
            this.groupbox_Bulb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_PowerOutput)).EndInit();
            this.groupbox_Data.ResumeLayout(false);
            this.groupbox_Data.PerformLayout();
            this.groupbox_Con.ResumeLayout(false);
            this.groupbox_Con.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radiobutton_Incandescent;
        private System.Windows.Forms.RadioButton radiobutton_ACLED;
        private System.Windows.Forms.GroupBox groupbox_Bulb;
        private System.Windows.Forms.RadioButton radiobutton_DCLED;
        private System.Windows.Forms.NumericUpDown numeric_PowerOutput;
        private System.Windows.Forms.GroupBox groupbox_Data;
        private System.Windows.Forms.GroupBox groupbox_Con;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.TextBox textbox_Comm;
        private System.Windows.Forms.TextBox textbox_Output;
        private System.Windows.Forms.Button button_OnOff;
    }
}

