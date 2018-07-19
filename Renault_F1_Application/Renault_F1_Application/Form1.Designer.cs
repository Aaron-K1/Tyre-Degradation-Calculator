namespace Renault_F1_Application
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
            this.FrontLeftBox = new System.Windows.Forms.ComboBox();
            this.FrontRightBox = new System.Windows.Forms.ComboBox();
            this.RearLeftBox = new System.Windows.Forms.ComboBox();
            this.TrackBox = new System.Windows.Forms.ComboBox();
            this.RearRightBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TempLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frontLeftLbl = new System.Windows.Forms.Label();
            this.FLAverage = new System.Windows.Forms.Label();
            this.FLAvgResult = new System.Windows.Forms.Label();
            this.FLModeResult = new System.Windows.Forms.Label();
            this.FLMode = new System.Windows.Forms.Label();
            this.FLRangeResult = new System.Windows.Forms.Label();
            this.FLRange = new System.Windows.Forms.Label();
            this.FRRangeResult = new System.Windows.Forms.Label();
            this.FRRange = new System.Windows.Forms.Label();
            this.FRModeResult = new System.Windows.Forms.Label();
            this.FRMode = new System.Windows.Forms.Label();
            this.FRAverageResult = new System.Windows.Forms.Label();
            this.FRAverage = new System.Windows.Forms.Label();
            this.FrontRightLbl = new System.Windows.Forms.Label();
            this.RLRangeResult = new System.Windows.Forms.Label();
            this.RLRange = new System.Windows.Forms.Label();
            this.RLModeResult = new System.Windows.Forms.Label();
            this.RLMode = new System.Windows.Forms.Label();
            this.RLAverageResult = new System.Windows.Forms.Label();
            this.RLAverage = new System.Windows.Forms.Label();
            this.RearLeftLbl = new System.Windows.Forms.Label();
            this.RRRangeResult = new System.Windows.Forms.Label();
            this.RRRange = new System.Windows.Forms.Label();
            this.RRModeResult = new System.Windows.Forms.Label();
            this.RRMode = new System.Windows.Forms.Label();
            this.RRAverageResult = new System.Windows.Forms.Label();
            this.RRAverage = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FLPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TempTBox = new System.Windows.Forms.TextBox();
            this.FLlbl = new System.Windows.Forms.Label();
            this.RLlbl = new System.Windows.Forms.Label();
            this.Tracklbl = new System.Windows.Forms.Label();
            this.RRlbl = new System.Windows.Forms.Label();
            this.FRlbl = new System.Windows.Forms.Label();
            this.FLPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrontLeftBox
            // 
            this.FrontLeftBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrontLeftBox.BackColor = System.Drawing.Color.White;
            this.FrontLeftBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrontLeftBox.FormattingEnabled = true;
            this.FrontLeftBox.Location = new System.Drawing.Point(229, 67);
            this.FrontLeftBox.Name = "FrontLeftBox";
            this.FrontLeftBox.Size = new System.Drawing.Size(258, 33);
            this.FrontLeftBox.TabIndex = 0;
            this.FrontLeftBox.Text = "Select Tyre...";
            this.FrontLeftBox.SelectedIndexChanged += new System.EventHandler(this.FrontLeftBox_SelectedIndexChanged);
            // 
            // FrontRightBox
            // 
            this.FrontRightBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrontRightBox.BackColor = System.Drawing.Color.White;
            this.FrontRightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrontRightBox.FormattingEnabled = true;
            this.FrontRightBox.Location = new System.Drawing.Point(795, 66);
            this.FrontRightBox.Name = "FrontRightBox";
            this.FrontRightBox.Size = new System.Drawing.Size(258, 33);
            this.FrontRightBox.TabIndex = 1;
            this.FrontRightBox.Text = "Select Tyre...";
            this.FrontRightBox.SelectedIndexChanged += new System.EventHandler(this.FrontRightBox_SelectedIndexChanged);
            // 
            // RearLeftBox
            // 
            this.RearLeftBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RearLeftBox.BackColor = System.Drawing.Color.White;
            this.RearLeftBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RearLeftBox.FormattingEnabled = true;
            this.RearLeftBox.Location = new System.Drawing.Point(229, 147);
            this.RearLeftBox.Name = "RearLeftBox";
            this.RearLeftBox.Size = new System.Drawing.Size(258, 33);
            this.RearLeftBox.TabIndex = 2;
            this.RearLeftBox.Text = "Select Tyre...";
            this.RearLeftBox.SelectedIndexChanged += new System.EventHandler(this.RearLeftBox_SelectedIndexChanged);
            // 
            // TrackBox
            // 
            this.TrackBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBox.BackColor = System.Drawing.Color.White;
            this.TrackBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackBox.FormattingEnabled = true;
            this.TrackBox.Location = new System.Drawing.Point(229, 219);
            this.TrackBox.Name = "TrackBox";
            this.TrackBox.Size = new System.Drawing.Size(258, 33);
            this.TrackBox.TabIndex = 3;
            this.TrackBox.Text = "Select Track...";
            this.TrackBox.SelectedIndexChanged += new System.EventHandler(this.TrackBox_SelectedIndexChanged);
            // 
            // RearRightBox
            // 
            this.RearRightBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RearRightBox.BackColor = System.Drawing.Color.White;
            this.RearRightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RearRightBox.FormattingEnabled = true;
            this.RearRightBox.Location = new System.Drawing.Point(795, 147);
            this.RearRightBox.Name = "RearRightBox";
            this.RearRightBox.Size = new System.Drawing.Size(258, 33);
            this.RearRightBox.TabIndex = 4;
            this.RearRightBox.Text = "Select Tyre...";
            this.RearRightBox.SelectedIndexChanged += new System.EventHandler(this.RearRightBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selections";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TempLbl
            // 
            this.TempLbl.AutoSize = true;
            this.TempLbl.BackColor = System.Drawing.SystemColors.Control;
            this.TempLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempLbl.Location = new System.Drawing.Point(661, 227);
            this.TempLbl.Name = "TempLbl";
            this.TempLbl.Size = new System.Drawing.Size(171, 25);
            this.TempLbl.TabIndex = 6;
            this.TempLbl.Text = "Temperature (ºC):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Results";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frontLeftLbl
            // 
            this.frontLeftLbl.AutoSize = true;
            this.frontLeftLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frontLeftLbl.Location = new System.Drawing.Point(120, 13);
            this.frontLeftLbl.Name = "frontLeftLbl";
            this.frontLeftLbl.Size = new System.Drawing.Size(104, 25);
            this.frontLeftLbl.TabIndex = 8;
            this.frontLeftLbl.Text = "Front Left";
            this.frontLeftLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FLAverage
            // 
            this.FLAverage.AutoSize = true;
            this.FLAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLAverage.Location = new System.Drawing.Point(31, 70);
            this.FLAverage.Name = "FLAverage";
            this.FLAverage.Size = new System.Drawing.Size(92, 25);
            this.FLAverage.TabIndex = 9;
            this.FLAverage.Text = "Average:";
            this.FLAverage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FLAvgResult
            // 
            this.FLAvgResult.BackColor = System.Drawing.Color.White;
            this.FLAvgResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLAvgResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLAvgResult.Location = new System.Drawing.Point(146, 70);
            this.FLAvgResult.Name = "FLAvgResult";
            this.FLAvgResult.Size = new System.Drawing.Size(104, 25);
            this.FLAvgResult.TabIndex = 10;
            this.FLAvgResult.Text = "Average";
            this.FLAvgResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FLModeResult
            // 
            this.FLModeResult.BackColor = System.Drawing.Color.White;
            this.FLModeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLModeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLModeResult.Location = new System.Drawing.Point(146, 114);
            this.FLModeResult.Name = "FLModeResult";
            this.FLModeResult.Size = new System.Drawing.Size(104, 25);
            this.FLModeResult.TabIndex = 12;
            this.FLModeResult.Text = "Mode";
            this.FLModeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FLMode
            // 
            this.FLMode.AutoSize = true;
            this.FLMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLMode.Location = new System.Drawing.Point(31, 114);
            this.FLMode.Name = "FLMode";
            this.FLMode.Size = new System.Drawing.Size(68, 25);
            this.FLMode.TabIndex = 11;
            this.FLMode.Text = "Mode:";
            this.FLMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FLRangeResult
            // 
            this.FLRangeResult.BackColor = System.Drawing.Color.White;
            this.FLRangeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLRangeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLRangeResult.Location = new System.Drawing.Point(146, 160);
            this.FLRangeResult.Name = "FLRangeResult";
            this.FLRangeResult.Size = new System.Drawing.Size(104, 25);
            this.FLRangeResult.TabIndex = 14;
            this.FLRangeResult.Text = "Range";
            this.FLRangeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FLRange
            // 
            this.FLRange.AutoSize = true;
            this.FLRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLRange.Location = new System.Drawing.Point(31, 160);
            this.FLRange.Name = "FLRange";
            this.FLRange.Size = new System.Drawing.Size(75, 25);
            this.FLRange.TabIndex = 13;
            this.FLRange.Text = "Range:";
            this.FLRange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRRangeResult
            // 
            this.FRRangeResult.BackColor = System.Drawing.Color.White;
            this.FRRangeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FRRangeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRRangeResult.Location = new System.Drawing.Point(167, 159);
            this.FRRangeResult.Name = "FRRangeResult";
            this.FRRangeResult.Size = new System.Drawing.Size(117, 25);
            this.FRRangeResult.TabIndex = 21;
            this.FRRangeResult.Text = "Range";
            this.FRRangeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRRange
            // 
            this.FRRange.AutoSize = true;
            this.FRRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRRange.Location = new System.Drawing.Point(52, 159);
            this.FRRange.Name = "FRRange";
            this.FRRange.Size = new System.Drawing.Size(75, 25);
            this.FRRange.TabIndex = 20;
            this.FRRange.Text = "Range:";
            this.FRRange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRModeResult
            // 
            this.FRModeResult.BackColor = System.Drawing.Color.White;
            this.FRModeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FRModeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRModeResult.Location = new System.Drawing.Point(167, 117);
            this.FRModeResult.Name = "FRModeResult";
            this.FRModeResult.Size = new System.Drawing.Size(117, 25);
            this.FRModeResult.TabIndex = 19;
            this.FRModeResult.Text = "Mode";
            this.FRModeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRMode
            // 
            this.FRMode.AutoSize = true;
            this.FRMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRMode.Location = new System.Drawing.Point(52, 113);
            this.FRMode.Name = "FRMode";
            this.FRMode.Size = new System.Drawing.Size(68, 25);
            this.FRMode.TabIndex = 18;
            this.FRMode.Text = "Mode:";
            this.FRMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRAverageResult
            // 
            this.FRAverageResult.BackColor = System.Drawing.Color.White;
            this.FRAverageResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FRAverageResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRAverageResult.Location = new System.Drawing.Point(167, 69);
            this.FRAverageResult.Name = "FRAverageResult";
            this.FRAverageResult.Size = new System.Drawing.Size(117, 25);
            this.FRAverageResult.TabIndex = 17;
            this.FRAverageResult.Text = "Average";
            this.FRAverageResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRAverage
            // 
            this.FRAverage.AutoSize = true;
            this.FRAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRAverage.Location = new System.Drawing.Point(52, 69);
            this.FRAverage.Name = "FRAverage";
            this.FRAverage.Size = new System.Drawing.Size(92, 25);
            this.FRAverage.TabIndex = 16;
            this.FRAverage.Text = "Average:";
            this.FRAverage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrontRightLbl
            // 
            this.FrontRightLbl.AutoSize = true;
            this.FrontRightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrontRightLbl.Location = new System.Drawing.Point(127, 13);
            this.FrontRightLbl.Name = "FrontRightLbl";
            this.FrontRightLbl.Size = new System.Drawing.Size(117, 25);
            this.FrontRightLbl.TabIndex = 15;
            this.FrontRightLbl.Text = "Front Right";
            this.FrontRightLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RLRangeResult
            // 
            this.RLRangeResult.BackColor = System.Drawing.Color.White;
            this.RLRangeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RLRangeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLRangeResult.Location = new System.Drawing.Point(146, 145);
            this.RLRangeResult.Name = "RLRangeResult";
            this.RLRangeResult.Size = new System.Drawing.Size(104, 25);
            this.RLRangeResult.TabIndex = 28;
            this.RLRangeResult.Text = "Range";
            this.RLRangeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RLRange
            // 
            this.RLRange.AutoSize = true;
            this.RLRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLRange.Location = new System.Drawing.Point(31, 145);
            this.RLRange.Name = "RLRange";
            this.RLRange.Size = new System.Drawing.Size(75, 25);
            this.RLRange.TabIndex = 27;
            this.RLRange.Text = "Range:";
            this.RLRange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RLModeResult
            // 
            this.RLModeResult.BackColor = System.Drawing.Color.White;
            this.RLModeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RLModeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLModeResult.Location = new System.Drawing.Point(146, 99);
            this.RLModeResult.Name = "RLModeResult";
            this.RLModeResult.Size = new System.Drawing.Size(104, 25);
            this.RLModeResult.TabIndex = 26;
            this.RLModeResult.Text = "Mode";
            this.RLModeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RLMode
            // 
            this.RLMode.AutoSize = true;
            this.RLMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLMode.Location = new System.Drawing.Point(31, 99);
            this.RLMode.Name = "RLMode";
            this.RLMode.Size = new System.Drawing.Size(68, 25);
            this.RLMode.TabIndex = 25;
            this.RLMode.Text = "Mode:";
            this.RLMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RLAverageResult
            // 
            this.RLAverageResult.BackColor = System.Drawing.Color.White;
            this.RLAverageResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RLAverageResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLAverageResult.Location = new System.Drawing.Point(146, 55);
            this.RLAverageResult.Name = "RLAverageResult";
            this.RLAverageResult.Size = new System.Drawing.Size(104, 25);
            this.RLAverageResult.TabIndex = 24;
            this.RLAverageResult.Text = "Average";
            this.RLAverageResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RLAverage
            // 
            this.RLAverage.AutoSize = true;
            this.RLAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLAverage.Location = new System.Drawing.Point(31, 55);
            this.RLAverage.Name = "RLAverage";
            this.RLAverage.Size = new System.Drawing.Size(92, 25);
            this.RLAverage.TabIndex = 23;
            this.RLAverage.Text = "Average:";
            this.RLAverage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RearLeftLbl
            // 
            this.RearLeftLbl.AutoSize = true;
            this.RearLeftLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RearLeftLbl.Location = new System.Drawing.Point(125, 11);
            this.RearLeftLbl.Name = "RearLeftLbl";
            this.RearLeftLbl.Size = new System.Drawing.Size(99, 25);
            this.RearLeftLbl.TabIndex = 22;
            this.RearLeftLbl.Text = "Rear Left";
            this.RearLeftLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RRRangeResult
            // 
            this.RRRangeResult.BackColor = System.Drawing.Color.White;
            this.RRRangeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RRRangeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRRangeResult.Location = new System.Drawing.Point(167, 145);
            this.RRRangeResult.Name = "RRRangeResult";
            this.RRRangeResult.Size = new System.Drawing.Size(117, 25);
            this.RRRangeResult.TabIndex = 35;
            this.RRRangeResult.Text = "Range";
            this.RRRangeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RRRange
            // 
            this.RRRange.AutoSize = true;
            this.RRRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRRange.Location = new System.Drawing.Point(52, 145);
            this.RRRange.Name = "RRRange";
            this.RRRange.Size = new System.Drawing.Size(75, 25);
            this.RRRange.TabIndex = 34;
            this.RRRange.Text = "Range:";
            this.RRRange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RRModeResult
            // 
            this.RRModeResult.BackColor = System.Drawing.Color.White;
            this.RRModeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RRModeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRModeResult.Location = new System.Drawing.Point(167, 99);
            this.RRModeResult.Name = "RRModeResult";
            this.RRModeResult.Size = new System.Drawing.Size(117, 25);
            this.RRModeResult.TabIndex = 33;
            this.RRModeResult.Text = "Mode";
            this.RRModeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RRMode
            // 
            this.RRMode.AutoSize = true;
            this.RRMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRMode.Location = new System.Drawing.Point(52, 99);
            this.RRMode.Name = "RRMode";
            this.RRMode.Size = new System.Drawing.Size(68, 25);
            this.RRMode.TabIndex = 32;
            this.RRMode.Text = "Mode:";
            this.RRMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RRAverageResult
            // 
            this.RRAverageResult.BackColor = System.Drawing.Color.White;
            this.RRAverageResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RRAverageResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRAverageResult.Location = new System.Drawing.Point(167, 55);
            this.RRAverageResult.Name = "RRAverageResult";
            this.RRAverageResult.Size = new System.Drawing.Size(117, 25);
            this.RRAverageResult.TabIndex = 31;
            this.RRAverageResult.Text = "Average";
            this.RRAverageResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RRAverage
            // 
            this.RRAverage.AutoSize = true;
            this.RRAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRAverage.Location = new System.Drawing.Point(52, 55);
            this.RRAverage.Name = "RRAverage";
            this.RRAverage.Size = new System.Drawing.Size(92, 25);
            this.RRAverage.TabIndex = 30;
            this.RRAverage.Text = "Average:";
            this.RRAverage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(127, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Rear Right";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FLPanel
            // 
            this.FLPanel.BackColor = System.Drawing.Color.Gold;
            this.FLPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLPanel.Controls.Add(this.FLRangeResult);
            this.FLPanel.Controls.Add(this.FLRange);
            this.FLPanel.Controls.Add(this.FLModeResult);
            this.FLPanel.Controls.Add(this.FLMode);
            this.FLPanel.Controls.Add(this.FLAvgResult);
            this.FLPanel.Controls.Add(this.FLAverage);
            this.FLPanel.Controls.Add(this.frontLeftLbl);
            this.FLPanel.Location = new System.Drawing.Point(112, 339);
            this.FLPanel.Name = "FLPanel";
            this.FLPanel.Size = new System.Drawing.Size(363, 216);
            this.FLPanel.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.FRRangeResult);
            this.panel1.Controls.Add(this.FRRange);
            this.panel1.Controls.Add(this.FRModeResult);
            this.panel1.Controls.Add(this.FRMode);
            this.panel1.Controls.Add(this.FRAverageResult);
            this.panel1.Controls.Add(this.FRAverage);
            this.panel1.Controls.Add(this.FrontRightLbl);
            this.panel1.Location = new System.Drawing.Point(680, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 216);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.RLRangeResult);
            this.panel2.Controls.Add(this.RLRange);
            this.panel2.Controls.Add(this.RLModeResult);
            this.panel2.Controls.Add(this.RLMode);
            this.panel2.Controls.Add(this.RLAverageResult);
            this.panel2.Controls.Add(this.RLAverage);
            this.panel2.Controls.Add(this.RearLeftLbl);
            this.panel2.Location = new System.Drawing.Point(112, 627);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 198);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.RRRangeResult);
            this.panel3.Controls.Add(this.RRRange);
            this.panel3.Controls.Add(this.RRModeResult);
            this.panel3.Controls.Add(this.RRMode);
            this.panel3.Controls.Add(this.RRAverageResult);
            this.panel3.Controls.Add(this.RRAverage);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(680, 627);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 198);
            this.panel3.TabIndex = 39;
            // 
            // TempTBox
            // 
            this.TempTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempTBox.Location = new System.Drawing.Point(848, 224);
            this.TempTBox.Name = "TempTBox";
            this.TempTBox.Size = new System.Drawing.Size(205, 30);
            this.TempTBox.TabIndex = 40;
            this.TempTBox.TextChanged += new System.EventHandler(this.TempTBox_TextChanged);
            // 
            // FLlbl
            // 
            this.FLlbl.AutoSize = true;
            this.FLlbl.BackColor = System.Drawing.SystemColors.Control;
            this.FLlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLlbl.Location = new System.Drawing.Point(107, 75);
            this.FLlbl.Name = "FLlbl";
            this.FLlbl.Size = new System.Drawing.Size(105, 25);
            this.FLlbl.TabIndex = 41;
            this.FLlbl.Text = "Front Left: ";
            // 
            // RLlbl
            // 
            this.RLlbl.AutoSize = true;
            this.RLlbl.BackColor = System.Drawing.SystemColors.Control;
            this.RLlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLlbl.Location = new System.Drawing.Point(107, 155);
            this.RLlbl.Name = "RLlbl";
            this.RLlbl.Size = new System.Drawing.Size(101, 25);
            this.RLlbl.TabIndex = 42;
            this.RLlbl.Text = "Rear Left: ";
            // 
            // Tracklbl
            // 
            this.Tracklbl.AutoSize = true;
            this.Tracklbl.BackColor = System.Drawing.SystemColors.Control;
            this.Tracklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tracklbl.Location = new System.Drawing.Point(140, 227);
            this.Tracklbl.Name = "Tracklbl";
            this.Tracklbl.Size = new System.Drawing.Size(68, 25);
            this.Tracklbl.TabIndex = 43;
            this.Tracklbl.Text = "Track:";
            // 
            // RRlbl
            // 
            this.RRlbl.AutoSize = true;
            this.RRlbl.BackColor = System.Drawing.SystemColors.Control;
            this.RRlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRlbl.Location = new System.Drawing.Point(661, 155);
            this.RRlbl.Name = "RRlbl";
            this.RRlbl.Size = new System.Drawing.Size(113, 25);
            this.RRlbl.TabIndex = 45;
            this.RRlbl.Text = "Rear Right: ";
            // 
            // FRlbl
            // 
            this.FRlbl.AutoSize = true;
            this.FRlbl.BackColor = System.Drawing.SystemColors.Control;
            this.FRlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRlbl.Location = new System.Drawing.Point(661, 74);
            this.FRlbl.Name = "FRlbl";
            this.FRlbl.Size = new System.Drawing.Size(117, 25);
            this.FRlbl.TabIndex = 44;
            this.FRlbl.Text = "Front Right: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 1047);
            this.Controls.Add(this.RRlbl);
            this.Controls.Add(this.FRlbl);
            this.Controls.Add(this.Tracklbl);
            this.Controls.Add(this.RLlbl);
            this.Controls.Add(this.FLlbl);
            this.Controls.Add(this.TempTBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FLPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TempLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RearRightBox);
            this.Controls.Add(this.TrackBox);
            this.Controls.Add(this.RearLeftBox);
            this.Controls.Add(this.FrontRightBox);
            this.Controls.Add(this.FrontLeftBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FLPanel.ResumeLayout(false);
            this.FLPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FrontLeftBox;
        private System.Windows.Forms.ComboBox FrontRightBox;
        private System.Windows.Forms.ComboBox RearLeftBox;
        private System.Windows.Forms.ComboBox TrackBox;
        private System.Windows.Forms.ComboBox RearRightBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TempLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label frontLeftLbl;
        private System.Windows.Forms.Label FLAverage;
        private System.Windows.Forms.Label FLAvgResult;
        private System.Windows.Forms.Label FLModeResult;
        private System.Windows.Forms.Label FLMode;
        private System.Windows.Forms.Label FLRangeResult;
        private System.Windows.Forms.Label FLRange;
        private System.Windows.Forms.Label FRRangeResult;
        private System.Windows.Forms.Label FRRange;
        private System.Windows.Forms.Label FRModeResult;
        private System.Windows.Forms.Label FRMode;
        private System.Windows.Forms.Label FRAverageResult;
        private System.Windows.Forms.Label FRAverage;
        private System.Windows.Forms.Label FrontRightLbl;
        private System.Windows.Forms.Label RLRangeResult;
        private System.Windows.Forms.Label RLRange;
        private System.Windows.Forms.Label RLModeResult;
        private System.Windows.Forms.Label RLMode;
        private System.Windows.Forms.Label RLAverageResult;
        private System.Windows.Forms.Label RLAverage;
        private System.Windows.Forms.Label RearLeftLbl;
        private System.Windows.Forms.Label RRRangeResult;
        private System.Windows.Forms.Label RRRange;
        private System.Windows.Forms.Label RRModeResult;
        private System.Windows.Forms.Label RRMode;
        private System.Windows.Forms.Label RRAverageResult;
        private System.Windows.Forms.Label RRAverage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel FLPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TempTBox;
        private System.Windows.Forms.Label FLlbl;
        private System.Windows.Forms.Label RLlbl;
        private System.Windows.Forms.Label Tracklbl;
        private System.Windows.Forms.Label RRlbl;
        private System.Windows.Forms.Label FRlbl;
    }
}

