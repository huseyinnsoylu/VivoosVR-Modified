﻿namespace VivoosVR
{
    partial class Settings_Page
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
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSensorInterval = new System.Windows.Forms.TextBox();
            this.txtSensorVisible = new System.Windows.Forms.TextBox();
            this.txtNeulogPort = new System.Windows.Forms.TextBox();
            this.txtNeulogIP = new System.Windows.Forms.TextBox();
            this.txtNeulogPath = new System.Windows.Forms.TextBox();
            this.txtScenarioPath = new System.Windows.Forms.TextBox();
            this.txtSocketIP = new System.Windows.Forms.TextBox();
            this.lblNeulogPath = new System.Windows.Forms.Label();
            this.lblScenarioPath = new System.Windows.Forms.Label();
            this.lblSocketIP = new System.Windows.Forms.Label();
            this.lblSocketPort = new System.Windows.Forms.Label();
            this.lblNeulogIP = new System.Windows.Forms.Label();
            this.lblNeulogPort = new System.Windows.Forms.Label();
            this.lblSensorVisible = new System.Windows.Forms.Label();
            this.lblSensorInterval = new System.Windows.Forms.Label();
            this.txtSocketPort = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.76433F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23567F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Controls.Add(this.btnExit, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnBack, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1436, 56);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Image = global::VivoosVR.Properties.Resources.Shutdown_52px;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(1325, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 47);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Çıkış";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Image = global::VivoosVR.Properties.Resources.Back;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBack.Location = new System.Drawing.Point(1239, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 47);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Geri";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 783);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1436, 56);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(1255, 8);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 39);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Location = new System.Drawing.Point(396, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 425);
            this.panel1.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.43956F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.56044F));
            this.tableLayoutPanel3.Controls.Add(this.txtSensorInterval, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.txtSensorVisible, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtNeulogPort, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtNeulogIP, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtNeulogPath, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtScenarioPath, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtSocketIP, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblNeulogPath, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblScenarioPath, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblSocketIP, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSocketPort, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblNeulogIP, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblNeulogPort, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblSensorVisible, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblSensorInterval, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.txtSocketPort, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(95, 22);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.45055F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.54945F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(455, 380);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // txtSensorInterval
            // 
            this.txtSensorInterval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSensorInterval.Location = new System.Drawing.Point(277, 349);
            this.txtSensorInterval.Name = "txtSensorInterval";
            this.txtSensorInterval.Size = new System.Drawing.Size(169, 20);
            this.txtSensorInterval.TabIndex = 15;
            // 
            // txtSensorVisible
            // 
            this.txtSensorVisible.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSensorVisible.Location = new System.Drawing.Point(277, 305);
            this.txtSensorVisible.Name = "txtSensorVisible";
            this.txtSensorVisible.Size = new System.Drawing.Size(169, 20);
            this.txtSensorVisible.TabIndex = 14;
            // 
            // txtNeulogPort
            // 
            this.txtNeulogPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNeulogPort.Location = new System.Drawing.Point(277, 259);
            this.txtNeulogPort.Name = "txtNeulogPort";
            this.txtNeulogPort.Size = new System.Drawing.Size(169, 20);
            this.txtNeulogPort.TabIndex = 13;
            // 
            // txtNeulogIP
            // 
            this.txtNeulogIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNeulogIP.Location = new System.Drawing.Point(277, 212);
            this.txtNeulogIP.Name = "txtNeulogIP";
            this.txtNeulogIP.Size = new System.Drawing.Size(169, 20);
            this.txtNeulogIP.TabIndex = 12;
            // 
            // txtNeulogPath
            // 
            this.txtNeulogPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNeulogPath.Location = new System.Drawing.Point(277, 160);
            this.txtNeulogPath.Name = "txtNeulogPath";
            this.txtNeulogPath.Size = new System.Drawing.Size(169, 20);
            this.txtNeulogPath.TabIndex = 11;
            // 
            // txtScenarioPath
            // 
            this.txtScenarioPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtScenarioPath.Location = new System.Drawing.Point(277, 111);
            this.txtScenarioPath.Name = "txtScenarioPath";
            this.txtScenarioPath.Size = new System.Drawing.Size(169, 20);
            this.txtScenarioPath.TabIndex = 10;
            // 
            // txtSocketIP
            // 
            this.txtSocketIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSocketIP.Location = new System.Drawing.Point(277, 14);
            this.txtSocketIP.Name = "txtSocketIP";
            this.txtSocketIP.Size = new System.Drawing.Size(169, 20);
            this.txtSocketIP.TabIndex = 9;
            // 
            // lblNeulogPath
            // 
            this.lblNeulogPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNeulogPath.AutoSize = true;
            this.lblNeulogPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeulogPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNeulogPath.Location = new System.Drawing.Point(3, 162);
            this.lblNeulogPath.Name = "lblNeulogPath";
            this.lblNeulogPath.Size = new System.Drawing.Size(214, 16);
            this.lblNeulogPath.TabIndex = 6;
            this.lblNeulogPath.Text = "Neulog\'un Bilgisayardaki Yeri";
            // 
            // lblScenarioPath
            // 
            this.lblScenarioPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScenarioPath.AutoSize = true;
            this.lblScenarioPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScenarioPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScenarioPath.Location = new System.Drawing.Point(3, 113);
            this.lblScenarioPath.Name = "lblScenarioPath";
            this.lblScenarioPath.Size = new System.Drawing.Size(108, 16);
            this.lblScenarioPath.TabIndex = 4;
            this.lblScenarioPath.Text = "Senaryo Dizini";
            // 
            // lblSocketIP
            // 
            this.lblSocketIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSocketIP.AutoSize = true;
            this.lblSocketIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocketIP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSocketIP.Location = new System.Drawing.Point(3, 16);
            this.lblSocketIP.Name = "lblSocketIP";
            this.lblSocketIP.Size = new System.Drawing.Size(66, 16);
            this.lblSocketIP.TabIndex = 0;
            this.lblSocketIP.Text = "Soket IP";
            // 
            // lblSocketPort
            // 
            this.lblSocketPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSocketPort.AutoSize = true;
            this.lblSocketPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocketPort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSocketPort.Location = new System.Drawing.Point(3, 66);
            this.lblSocketPort.Name = "lblSocketPort";
            this.lblSocketPort.Size = new System.Drawing.Size(80, 16);
            this.lblSocketPort.TabIndex = 1;
            this.lblSocketPort.Text = "Soket Port";
            // 
            // lblNeulogIP
            // 
            this.lblNeulogIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNeulogIP.AutoSize = true;
            this.lblNeulogIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeulogIP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNeulogIP.Location = new System.Drawing.Point(3, 214);
            this.lblNeulogIP.Name = "lblNeulogIP";
            this.lblNeulogIP.Size = new System.Drawing.Size(76, 16);
            this.lblNeulogIP.TabIndex = 5;
            this.lblNeulogIP.Text = "Neulog IP";
            // 
            // lblNeulogPort
            // 
            this.lblNeulogPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNeulogPort.AutoSize = true;
            this.lblNeulogPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeulogPort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNeulogPort.Location = new System.Drawing.Point(3, 261);
            this.lblNeulogPort.Name = "lblNeulogPort";
            this.lblNeulogPort.Size = new System.Drawing.Size(90, 16);
            this.lblNeulogPort.TabIndex = 3;
            this.lblNeulogPort.Text = "Neulog Port";
            // 
            // lblSensorVisible
            // 
            this.lblSensorVisible.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSensorVisible.AutoSize = true;
            this.lblSensorVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensorVisible.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSensorVisible.Location = new System.Drawing.Point(3, 299);
            this.lblSensorVisible.Name = "lblSensorVisible";
            this.lblSensorVisible.Size = new System.Drawing.Size(254, 32);
            this.lblSensorVisible.TabIndex = 2;
            this.lblSensorVisible.Text = "Sensör Bİlgilerinin Görünür Olacağı Zaman Aralığı";
            // 
            // lblSensorInterval
            // 
            this.lblSensorInterval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSensorInterval.AutoSize = true;
            this.lblSensorInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensorInterval.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSensorInterval.Location = new System.Drawing.Point(3, 343);
            this.lblSensorInterval.Name = "lblSensorInterval";
            this.lblSensorInterval.Size = new System.Drawing.Size(208, 32);
            this.lblSensorInterval.TabIndex = 7;
            this.lblSensorInterval.Text = "Sensörlerden Ne Sıklıta Veri Okunacağı (ms)";
            // 
            // txtSocketPort
            // 
            this.txtSocketPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSocketPort.Location = new System.Drawing.Point(277, 64);
            this.txtSocketPort.Name = "txtSocketPort";
            this.txtSocketPort.Size = new System.Drawing.Size(169, 20);
            this.txtSocketPort.TabIndex = 8;
            // 
            // Settings_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1436, 839);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "Settings_Page";
            this.Text = "Ayarlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Page_Load);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtSensorInterval;
        private System.Windows.Forms.TextBox txtSensorVisible;
        private System.Windows.Forms.TextBox txtNeulogPort;
        private System.Windows.Forms.TextBox txtNeulogIP;
        private System.Windows.Forms.TextBox txtNeulogPath;
        private System.Windows.Forms.TextBox txtScenarioPath;
        private System.Windows.Forms.TextBox txtSocketIP;
        private System.Windows.Forms.Label lblNeulogPath;
        private System.Windows.Forms.Label lblScenarioPath;
        private System.Windows.Forms.Label lblSocketIP;
        private System.Windows.Forms.Label lblSocketPort;
        private System.Windows.Forms.Label lblNeulogIP;
        private System.Windows.Forms.Label lblNeulogPort;
        private System.Windows.Forms.Label lblSensorVisible;
        private System.Windows.Forms.Label lblSensorInterval;
        private System.Windows.Forms.TextBox txtSocketPort;
    }
}