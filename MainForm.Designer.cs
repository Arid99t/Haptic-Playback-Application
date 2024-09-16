namespace PlayGroundApp_3
{
    partial class MainForm
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
            this.trackBarPressure = new System.Windows.Forms.TrackBar();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelMaterialConstant = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.trackBarFingerDistance = new System.Windows.Forms.TrackBar();
            this.labelFingerDistance = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.comboBoxComPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterialConstant = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFingerDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarPressure
            // 
            this.trackBarPressure.Location = new System.Drawing.Point(261, 63);
            this.trackBarPressure.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarPressure.Maximum = 1000;
            this.trackBarPressure.Name = "trackBarPressure";
            this.trackBarPressure.Size = new System.Drawing.Size(347, 56);
            this.trackBarPressure.TabIndex = 0;
            this.trackBarPressure.Scroll += new System.EventHandler(this.trackBarPressure_Scroll);
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Location = new System.Drawing.Point(400, 25);
            this.labelPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(45, 16);
            this.labelPressure.TabIndex = 1;
            this.labelPressure.Text = "Force:";
            // 
            // labelMaterialConstant
            // 
            this.labelMaterialConstant.AutoSize = true;
            this.labelMaterialConstant.Location = new System.Drawing.Point(16, 148);
            this.labelMaterialConstant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaterialConstant.Name = "labelMaterialConstant";
            this.labelMaterialConstant.Size = new System.Drawing.Size(113, 16);
            this.labelMaterialConstant.TabIndex = 5;
            this.labelMaterialConstant.Text = "Material Constant:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(369, 419);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 28);
            this.buttonConnect.TabIndex = 7;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(674, 419);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 16);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Status:";
            // 
            // trackBarFingerDistance
            // 
            this.trackBarFingerDistance.Location = new System.Drawing.Point(261, 160);
            this.trackBarFingerDistance.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarFingerDistance.Maximum = 1000;
            this.trackBarFingerDistance.Name = "trackBarFingerDistance";
            this.trackBarFingerDistance.Size = new System.Drawing.Size(347, 56);
            this.trackBarFingerDistance.TabIndex = 0;
            // 
            // labelFingerDistance
            // 
            this.labelFingerDistance.AutoSize = true;
            this.labelFingerDistance.Location = new System.Drawing.Point(381, 123);
            this.labelFingerDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFingerDistance.Name = "labelFingerDistance";
            this.labelFingerDistance.Size = new System.Drawing.Size(104, 16);
            this.labelFingerDistance.TabIndex = 1;
            this.labelFingerDistance.Text = "Finger Distance:";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(16, 43);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(34, 16);
            this.labelPort.TabIndex = 10;
            this.labelPort.Text = "Port:";
            // 
            // comboBoxComPorts
            // 
            this.comboBoxComPorts.FormattingEnabled = true;
            this.comboBoxComPorts.Location = new System.Drawing.Point(16, 63);
            this.comboBoxComPorts.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxComPorts.Name = "comboBoxComPorts";
            this.comboBoxComPorts.Size = new System.Drawing.Size(160, 24);
            this.comboBoxComPorts.TabIndex = 6;
            // 
            // comboBoxMaterialConstant
            // 
            this.comboBoxMaterialConstant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterialConstant.FormattingEnabled = true;
            this.comboBoxMaterialConstant.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            
            this.comboBoxMaterialConstant.Location = new System.Drawing.Point(16, 172);
            this.comboBoxMaterialConstant.Name = "comboBoxMaterialConstant";
            this.comboBoxMaterialConstant.Size = new System.Drawing.Size(60, 24);
            this.comboBoxMaterialConstant.TabIndex = 11;
            this.comboBoxMaterialConstant.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterialConstant_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 460);
            this.Controls.Add(this.comboBoxMaterialConstant);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxComPorts);
            this.Controls.Add(this.labelMaterialConstant);
            this.Controls.Add(this.labelFingerDistance);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.trackBarFingerDistance);
            this.Controls.Add(this.trackBarPressure);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Project_PlayGround_App_3";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFingerDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarPressure;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelMaterialConstant;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TrackBar trackBarFingerDistance;
        private System.Windows.Forms.Label labelFingerDistance;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ComboBox comboBoxComPorts;
        private System.Windows.Forms.ComboBox comboBoxMaterialConstant;
    }
}