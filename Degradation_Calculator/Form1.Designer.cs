namespace Degradation_Calculator
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
            FrontLeftBox = new System.Windows.Forms.ComboBox();
            FrontRightBox = new System.Windows.Forms.ComboBox();
            RearLeftBox = new System.Windows.Forms.ComboBox();
            TrackBox = new System.Windows.Forms.ComboBox();
            RearRightBox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            TempLbl = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            frontLeftLbl = new System.Windows.Forms.Label();
            FLAverage = new System.Windows.Forms.Label();
            FLAvgResult = new System.Windows.Forms.Label();
            FLModeResult = new System.Windows.Forms.Label();
            FLMode = new System.Windows.Forms.Label();
            FLRangeResult = new System.Windows.Forms.Label();
            FLRange = new System.Windows.Forms.Label();
            FRRangeResult = new System.Windows.Forms.Label();
            FRRange = new System.Windows.Forms.Label();
            FRModeResult = new System.Windows.Forms.Label();
            FRMode = new System.Windows.Forms.Label();
            FRAverageResult = new System.Windows.Forms.Label();
            FRAverage = new System.Windows.Forms.Label();
            FrontRightLbl = new System.Windows.Forms.Label();
            RLRangeResult = new System.Windows.Forms.Label();
            RLRange = new System.Windows.Forms.Label();
            RLModeResult = new System.Windows.Forms.Label();
            RLMode = new System.Windows.Forms.Label();
            RLAverageResult = new System.Windows.Forms.Label();
            RLAverage = new System.Windows.Forms.Label();
            RearLeftLbl = new System.Windows.Forms.Label();
            RRRangeResult = new System.Windows.Forms.Label();
            RRRange = new System.Windows.Forms.Label();
            RRModeResult = new System.Windows.Forms.Label();
            RRMode = new System.Windows.Forms.Label();
            RRAverageResult = new System.Windows.Forms.Label();
            RRAverage = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            FLPanel = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            TempTBox = new System.Windows.Forms.TextBox();
            FLlbl = new System.Windows.Forms.Label();
            RLlbl = new System.Windows.Forms.Label();
            Tracklbl = new System.Windows.Forms.Label();
            RRlbl = new System.Windows.Forms.Label();
            FRlbl = new System.Windows.Forms.Label();
            FLPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // FrontLeftBox
            // 
            FrontLeftBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            FrontLeftBox.BackColor = System.Drawing.Color.White;
            FrontLeftBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FrontLeftBox.FormattingEnabled = true;
            FrontLeftBox.Location = new System.Drawing.Point(209, 147);
            FrontLeftBox.Margin = new System.Windows.Forms.Padding(2);
            FrontLeftBox.Name = "FrontLeftBox";
            FrontLeftBox.Size = new System.Drawing.Size(226, 28);
            FrontLeftBox.TabIndex = 0;
            FrontLeftBox.Text = "Select Tyre...";
            FrontLeftBox.SelectedIndexChanged += FrontLeftBox_SelectedIndexChanged;
            // 
            // FrontRightBox
            // 
            FrontRightBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            FrontRightBox.BackColor = System.Drawing.Color.White;
            FrontRightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FrontRightBox.FormattingEnabled = true;
            FrontRightBox.Location = new System.Drawing.Point(704, 147);
            FrontRightBox.Margin = new System.Windows.Forms.Padding(2);
            FrontRightBox.Name = "FrontRightBox";
            FrontRightBox.Size = new System.Drawing.Size(226, 28);
            FrontRightBox.TabIndex = 1;
            FrontRightBox.Text = "Select Tyre...";
            FrontRightBox.SelectedIndexChanged += FrontRightBox_SelectedIndexChanged;
            // 
            // RearLeftBox
            // 
            RearLeftBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            RearLeftBox.BackColor = System.Drawing.Color.White;
            RearLeftBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RearLeftBox.FormattingEnabled = true;
            RearLeftBox.Location = new System.Drawing.Point(209, 222);
            RearLeftBox.Margin = new System.Windows.Forms.Padding(2);
            RearLeftBox.Name = "RearLeftBox";
            RearLeftBox.Size = new System.Drawing.Size(226, 28);
            RearLeftBox.TabIndex = 2;
            RearLeftBox.Text = "Select Tyre...";
            RearLeftBox.SelectedIndexChanged += RearLeftBox_SelectedIndexChanged;
            // 
            // TrackBox
            // 
            TrackBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TrackBox.BackColor = System.Drawing.Color.White;
            TrackBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TrackBox.FormattingEnabled = true;
            TrackBox.Location = new System.Drawing.Point(209, 80);
            TrackBox.Margin = new System.Windows.Forms.Padding(2);
            TrackBox.Name = "TrackBox";
            TrackBox.Size = new System.Drawing.Size(226, 28);
            TrackBox.TabIndex = 3;
            TrackBox.Text = "Select Track...";
            TrackBox.SelectedIndexChanged += TrackBox_SelectedIndexChanged;
            // 
            // RearRightBox
            // 
            RearRightBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            RearRightBox.BackColor = System.Drawing.Color.White;
            RearRightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RearRightBox.FormattingEnabled = true;
            RearRightBox.Location = new System.Drawing.Point(704, 222);
            RearRightBox.Margin = new System.Windows.Forms.Padding(2);
            RearRightBox.Name = "RearRightBox";
            RearRightBox.Size = new System.Drawing.Size(226, 28);
            RearRightBox.TabIndex = 4;
            RearRightBox.Text = "Select Tyre...";
            RearRightBox.SelectedIndexChanged += RearRightBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(438, 21);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 26);
            label1.TabIndex = 5;
            label1.Text = "Selections";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TempLbl
            // 
            TempLbl.AutoSize = true;
            TempLbl.BackColor = System.Drawing.SystemColors.Control;
            TempLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TempLbl.Location = new System.Drawing.Point(586, 80);
            TempLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            TempLbl.Name = "TempLbl";
            TempLbl.Size = new System.Drawing.Size(135, 20);
            TempLbl.TabIndex = 6;
            TempLbl.Text = "Temperature (ºC):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(460, 283);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 26);
            label2.TabIndex = 7;
            label2.Text = "Results";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frontLeftLbl
            // 
            frontLeftLbl.AutoSize = true;
            frontLeftLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            frontLeftLbl.Location = new System.Drawing.Point(105, 13);
            frontLeftLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            frontLeftLbl.Name = "frontLeftLbl";
            frontLeftLbl.Size = new System.Drawing.Size(89, 20);
            frontLeftLbl.TabIndex = 8;
            frontLeftLbl.Text = "Front Left";
            frontLeftLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FLAverage
            // 
            FLAverage.AutoSize = true;
            FLAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FLAverage.Location = new System.Drawing.Point(27, 66);
            FLAverage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FLAverage.Name = "FLAverage";
            FLAverage.Size = new System.Drawing.Size(72, 20);
            FLAverage.TabIndex = 9;
            FLAverage.Text = "Average:";
            FLAverage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FLAvgResult
            // 
            FLAvgResult.BackColor = System.Drawing.Color.White;
            FLAvgResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FLAvgResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FLAvgResult.Location = new System.Drawing.Point(128, 66);
            FLAvgResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FLAvgResult.Name = "FLAvgResult";
            FLAvgResult.Size = new System.Drawing.Size(91, 24);
            FLAvgResult.TabIndex = 10;
            FLAvgResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FLModeResult
            // 
            FLModeResult.BackColor = System.Drawing.Color.White;
            FLModeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FLModeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FLModeResult.Location = new System.Drawing.Point(128, 107);
            FLModeResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FLModeResult.Name = "FLModeResult";
            FLModeResult.Size = new System.Drawing.Size(91, 24);
            FLModeResult.TabIndex = 12;
            FLModeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FLMode
            // 
            FLMode.AutoSize = true;
            FLMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FLMode.Location = new System.Drawing.Point(27, 107);
            FLMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FLMode.Name = "FLMode";
            FLMode.Size = new System.Drawing.Size(53, 20);
            FLMode.TabIndex = 11;
            FLMode.Text = "Mode:";
            FLMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FLRangeResult
            // 
            FLRangeResult.BackColor = System.Drawing.Color.White;
            FLRangeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FLRangeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FLRangeResult.Location = new System.Drawing.Point(128, 150);
            FLRangeResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FLRangeResult.Name = "FLRangeResult";
            FLRangeResult.Size = new System.Drawing.Size(91, 24);
            FLRangeResult.TabIndex = 14;
            FLRangeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FLRange
            // 
            FLRange.AutoSize = true;
            FLRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FLRange.Location = new System.Drawing.Point(27, 150);
            FLRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FLRange.Name = "FLRange";
            FLRange.Size = new System.Drawing.Size(61, 20);
            FLRange.TabIndex = 13;
            FLRange.Text = "Range:";
            FLRange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRRangeResult
            // 
            FRRangeResult.BackColor = System.Drawing.Color.White;
            FRRangeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FRRangeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FRRangeResult.Location = new System.Drawing.Point(146, 149);
            FRRangeResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FRRangeResult.Name = "FRRangeResult";
            FRRangeResult.Size = new System.Drawing.Size(102, 24);
            FRRangeResult.TabIndex = 21;
            FRRangeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRRange
            // 
            FRRange.AutoSize = true;
            FRRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FRRange.Location = new System.Drawing.Point(46, 149);
            FRRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FRRange.Name = "FRRange";
            FRRange.Size = new System.Drawing.Size(61, 20);
            FRRange.TabIndex = 20;
            FRRange.Text = "Range:";
            FRRange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRModeResult
            // 
            FRModeResult.BackColor = System.Drawing.Color.White;
            FRModeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FRModeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FRModeResult.Location = new System.Drawing.Point(146, 110);
            FRModeResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FRModeResult.Name = "FRModeResult";
            FRModeResult.Size = new System.Drawing.Size(102, 24);
            FRModeResult.TabIndex = 19;
            FRModeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRMode
            // 
            FRMode.AutoSize = true;
            FRMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FRMode.Location = new System.Drawing.Point(46, 106);
            FRMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FRMode.Name = "FRMode";
            FRMode.Size = new System.Drawing.Size(53, 20);
            FRMode.TabIndex = 18;
            FRMode.Text = "Mode:";
            FRMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRAverageResult
            // 
            FRAverageResult.BackColor = System.Drawing.Color.White;
            FRAverageResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FRAverageResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FRAverageResult.Location = new System.Drawing.Point(146, 65);
            FRAverageResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FRAverageResult.Name = "FRAverageResult";
            FRAverageResult.Size = new System.Drawing.Size(102, 24);
            FRAverageResult.TabIndex = 17;
            FRAverageResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRAverage
            // 
            FRAverage.AutoSize = true;
            FRAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FRAverage.Location = new System.Drawing.Point(46, 65);
            FRAverage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FRAverage.Name = "FRAverage";
            FRAverage.Size = new System.Drawing.Size(72, 20);
            FRAverage.TabIndex = 16;
            FRAverage.Text = "Average:";
            FRAverage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrontRightLbl
            // 
            FrontRightLbl.AutoSize = true;
            FrontRightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            FrontRightLbl.Location = new System.Drawing.Point(111, 13);
            FrontRightLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FrontRightLbl.Name = "FrontRightLbl";
            FrontRightLbl.Size = new System.Drawing.Size(100, 20);
            FrontRightLbl.TabIndex = 15;
            FrontRightLbl.Text = "Front Right";
            FrontRightLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RLRangeResult
            // 
            RLRangeResult.BackColor = System.Drawing.Color.White;
            RLRangeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            RLRangeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RLRangeResult.Location = new System.Drawing.Point(128, 136);
            RLRangeResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RLRangeResult.Name = "RLRangeResult";
            RLRangeResult.Size = new System.Drawing.Size(91, 24);
            RLRangeResult.TabIndex = 28;
            RLRangeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RLRange
            // 
            RLRange.AutoSize = true;
            RLRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RLRange.Location = new System.Drawing.Point(27, 136);
            RLRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RLRange.Name = "RLRange";
            RLRange.Size = new System.Drawing.Size(61, 20);
            RLRange.TabIndex = 27;
            RLRange.Text = "Range:";
            RLRange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RLModeResult
            // 
            RLModeResult.BackColor = System.Drawing.Color.White;
            RLModeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            RLModeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RLModeResult.Location = new System.Drawing.Point(128, 92);
            RLModeResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RLModeResult.Name = "RLModeResult";
            RLModeResult.Size = new System.Drawing.Size(91, 24);
            RLModeResult.TabIndex = 26;
            RLModeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RLMode
            // 
            RLMode.AutoSize = true;
            RLMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RLMode.Location = new System.Drawing.Point(27, 92);
            RLMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RLMode.Name = "RLMode";
            RLMode.Size = new System.Drawing.Size(53, 20);
            RLMode.TabIndex = 25;
            RLMode.Text = "Mode:";
            RLMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RLAverageResult
            // 
            RLAverageResult.BackColor = System.Drawing.Color.White;
            RLAverageResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            RLAverageResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RLAverageResult.Location = new System.Drawing.Point(128, 52);
            RLAverageResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RLAverageResult.Name = "RLAverageResult";
            RLAverageResult.Size = new System.Drawing.Size(91, 24);
            RLAverageResult.TabIndex = 24;
            RLAverageResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RLAverage
            // 
            RLAverage.AutoSize = true;
            RLAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RLAverage.Location = new System.Drawing.Point(27, 52);
            RLAverage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RLAverage.Name = "RLAverage";
            RLAverage.Size = new System.Drawing.Size(72, 20);
            RLAverage.TabIndex = 23;
            RLAverage.Text = "Average:";
            RLAverage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RearLeftLbl
            // 
            RearLeftLbl.AutoSize = true;
            RearLeftLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            RearLeftLbl.Location = new System.Drawing.Point(110, 10);
            RearLeftLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RearLeftLbl.Name = "RearLeftLbl";
            RearLeftLbl.Size = new System.Drawing.Size(85, 20);
            RearLeftLbl.TabIndex = 22;
            RearLeftLbl.Text = "Rear Left";
            RearLeftLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RRRangeResult
            // 
            RRRangeResult.BackColor = System.Drawing.Color.White;
            RRRangeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            RRRangeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RRRangeResult.Location = new System.Drawing.Point(146, 136);
            RRRangeResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RRRangeResult.Name = "RRRangeResult";
            RRRangeResult.Size = new System.Drawing.Size(102, 24);
            RRRangeResult.TabIndex = 35;
            RRRangeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RRRange
            // 
            RRRange.AutoSize = true;
            RRRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RRRange.Location = new System.Drawing.Point(46, 136);
            RRRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RRRange.Name = "RRRange";
            RRRange.Size = new System.Drawing.Size(61, 20);
            RRRange.TabIndex = 34;
            RRRange.Text = "Range:";
            RRRange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RRModeResult
            // 
            RRModeResult.BackColor = System.Drawing.Color.White;
            RRModeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            RRModeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RRModeResult.Location = new System.Drawing.Point(146, 92);
            RRModeResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RRModeResult.Name = "RRModeResult";
            RRModeResult.Size = new System.Drawing.Size(102, 24);
            RRModeResult.TabIndex = 33;
            RRModeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RRMode
            // 
            RRMode.AutoSize = true;
            RRMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RRMode.Location = new System.Drawing.Point(46, 92);
            RRMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RRMode.Name = "RRMode";
            RRMode.Size = new System.Drawing.Size(53, 20);
            RRMode.TabIndex = 32;
            RRMode.Text = "Mode:";
            RRMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RRAverageResult
            // 
            RRAverageResult.BackColor = System.Drawing.Color.White;
            RRAverageResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            RRAverageResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RRAverageResult.Location = new System.Drawing.Point(146, 52);
            RRAverageResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RRAverageResult.Name = "RRAverageResult";
            RRAverageResult.Size = new System.Drawing.Size(102, 24);
            RRAverageResult.TabIndex = 31;
            RRAverageResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RRAverage
            // 
            RRAverage.AutoSize = true;
            RRAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RRAverage.Location = new System.Drawing.Point(46, 52);
            RRAverage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RRAverage.Name = "RRAverage";
            RRAverage.Size = new System.Drawing.Size(72, 20);
            RRAverage.TabIndex = 30;
            RRAverage.Text = "Average:";
            RRAverage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(111, 10);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(96, 20);
            label9.TabIndex = 29;
            label9.Text = "Rear Right";
            label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FLPanel
            // 
            FLPanel.BackColor = System.Drawing.Color.Gold;
            FLPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FLPanel.Controls.Add(FLRangeResult);
            FLPanel.Controls.Add(FLRange);
            FLPanel.Controls.Add(FLModeResult);
            FLPanel.Controls.Add(FLMode);
            FLPanel.Controls.Add(FLAvgResult);
            FLPanel.Controls.Add(FLAverage);
            FLPanel.Controls.Add(frontLeftLbl);
            FLPanel.Location = new System.Drawing.Point(98, 317);
            FLPanel.Margin = new System.Windows.Forms.Padding(2);
            FLPanel.Name = "FLPanel";
            FLPanel.Size = new System.Drawing.Size(318, 203);
            FLPanel.TabIndex = 36;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Gold;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(FRRangeResult);
            panel1.Controls.Add(FRRange);
            panel1.Controls.Add(FRModeResult);
            panel1.Controls.Add(FRMode);
            panel1.Controls.Add(FRAverageResult);
            panel1.Controls.Add(FRAverage);
            panel1.Controls.Add(FrontRightLbl);
            panel1.Location = new System.Drawing.Point(595, 317);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(316, 203);
            panel1.TabIndex = 37;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Gold;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(RLRangeResult);
            panel2.Controls.Add(RLRange);
            panel2.Controls.Add(RLModeResult);
            panel2.Controls.Add(RLMode);
            panel2.Controls.Add(RLAverageResult);
            panel2.Controls.Add(RLAverage);
            panel2.Controls.Add(RearLeftLbl);
            panel2.Location = new System.Drawing.Point(98, 587);
            panel2.Margin = new System.Windows.Forms.Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(319, 185);
            panel2.TabIndex = 38;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.Gold;
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(RRRangeResult);
            panel3.Controls.Add(RRRange);
            panel3.Controls.Add(RRModeResult);
            panel3.Controls.Add(RRMode);
            panel3.Controls.Add(RRAverageResult);
            panel3.Controls.Add(RRAverage);
            panel3.Controls.Add(label9);
            panel3.Location = new System.Drawing.Point(595, 587);
            panel3.Margin = new System.Windows.Forms.Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(316, 185);
            panel3.TabIndex = 39;
            // 
            // TempTBox
            // 
            TempTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TempTBox.Location = new System.Drawing.Point(749, 77);
            TempTBox.Margin = new System.Windows.Forms.Padding(2);
            TempTBox.Name = "TempTBox";
            TempTBox.Size = new System.Drawing.Size(180, 26);
            TempTBox.TabIndex = 40;
            TempTBox.TextChanged += TempTBox_TextChanged;
            // 
            // FLlbl
            // 
            FLlbl.AutoSize = true;
            FLlbl.BackColor = System.Drawing.SystemColors.Control;
            FLlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FLlbl.Location = new System.Drawing.Point(102, 155);
            FLlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FLlbl.Name = "FLlbl";
            FLlbl.Size = new System.Drawing.Size(87, 20);
            FLlbl.TabIndex = 41;
            FLlbl.Text = "Front Left: ";
            // 
            // RLlbl
            // 
            RLlbl.AutoSize = true;
            RLlbl.BackColor = System.Drawing.SystemColors.Control;
            RLlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RLlbl.Location = new System.Drawing.Point(102, 230);
            RLlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RLlbl.Name = "RLlbl";
            RLlbl.Size = new System.Drawing.Size(84, 20);
            RLlbl.TabIndex = 42;
            RLlbl.Text = "Rear Left: ";
            // 
            // Tracklbl
            // 
            Tracklbl.AutoSize = true;
            Tracklbl.BackColor = System.Drawing.SystemColors.Control;
            Tracklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Tracklbl.Location = new System.Drawing.Point(131, 87);
            Tracklbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Tracklbl.Name = "Tracklbl";
            Tracklbl.Size = new System.Drawing.Size(52, 20);
            Tracklbl.TabIndex = 43;
            Tracklbl.Text = "Track:";
            // 
            // RRlbl
            // 
            RRlbl.AutoSize = true;
            RRlbl.BackColor = System.Drawing.SystemColors.Control;
            RRlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            RRlbl.Location = new System.Drawing.Point(587, 230);
            RRlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RRlbl.Name = "RRlbl";
            RRlbl.Size = new System.Drawing.Size(94, 20);
            RRlbl.TabIndex = 45;
            RRlbl.Text = "Rear Right: ";
            // 
            // FRlbl
            // 
            FRlbl.AutoSize = true;
            FRlbl.BackColor = System.Drawing.SystemColors.Control;
            FRlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FRlbl.Location = new System.Drawing.Point(587, 153);
            FRlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FRlbl.Name = "FRlbl";
            FRlbl.Size = new System.Drawing.Size(97, 20);
            FRlbl.TabIndex = 44;
            FRlbl.Text = "Front Right: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1040, 982);
            Controls.Add(RRlbl);
            Controls.Add(FRlbl);
            Controls.Add(Tracklbl);
            Controls.Add(RLlbl);
            Controls.Add(FLlbl);
            Controls.Add(TempTBox);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(FLPanel);
            Controls.Add(label2);
            Controls.Add(TempLbl);
            Controls.Add(label1);
            Controls.Add(RearRightBox);
            Controls.Add(TrackBox);
            Controls.Add(RearLeftBox);
            Controls.Add(FrontRightBox);
            Controls.Add(FrontLeftBox);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Form1";
            Text = "Form1";
            FLPanel.ResumeLayout(false);
            FLPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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