namespace ScreenSaver
{
    partial class ScreenSaverForm
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
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.rotateTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlWeather = new System.Windows.Forms.Panel();
            this.lblLow = new System.Windows.Forms.Label();
            this.grpTomorrow = new System.Windows.Forms.GroupBox();
            this.lblTomorrowTemps = new System.Windows.Forms.Label();
            this.lblTomorrowStatus = new System.Windows.Forms.Label();
            this.lblCurrentWeather = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblWeatherStatus = new System.Windows.Forms.Label();
            this.lblWeatherHeader = new System.Windows.Forms.Label();
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.pnlArticle2 = new System.Windows.Forms.Panel();
            this.pnlArticle1 = new System.Windows.Forms.Panel();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.pnlEvents = new System.Windows.Forms.Panel();
            this.lblEventsHeader = new System.Windows.Forms.Label();
            this.analogClock = new ScreenSaver.AnalogClock();
            this.pnlWeather.SuspendLayout();
            this.grpTomorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.pnlArticle2.SuspendLayout();
            this.pnlArticle1.SuspendLayout();
            this.pnlEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // rotateTimer
            // 
            this.rotateTimer.Interval = 5000;
            // 
            // pnlWeather
            // 
            this.pnlWeather.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlWeather.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlWeather.Controls.Add(this.lblLow);
            this.pnlWeather.Controls.Add(this.grpTomorrow);
            this.pnlWeather.Controls.Add(this.lblCurrentWeather);
            this.pnlWeather.Controls.Add(this.lblHigh);
            this.pnlWeather.Controls.Add(this.lblWeatherStatus);
            this.pnlWeather.Controls.Add(this.lblWeatherHeader);
            this.pnlWeather.Controls.Add(this.picWeatherIcon);
            this.pnlWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlWeather.Location = new System.Drawing.Point(1053, 271);
            this.pnlWeather.Name = "pnlWeather";
            this.pnlWeather.Size = new System.Drawing.Size(276, 474);
            this.pnlWeather.TabIndex = 3;
            // 
            // lblLow
            // 
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.lblLow.Location = new System.Drawing.Point(-2, 294);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(276, 23);
            this.lblLow.TabIndex = 7;
            this.lblLow.Text = "Low: 52";
            this.lblLow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpTomorrow
            // 
            this.grpTomorrow.Controls.Add(this.lblTomorrowTemps);
            this.grpTomorrow.Controls.Add(this.lblTomorrowStatus);
            this.grpTomorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.grpTomorrow.Location = new System.Drawing.Point(24, 343);
            this.grpTomorrow.Name = "grpTomorrow";
            this.grpTomorrow.Size = new System.Drawing.Size(225, 112);
            this.grpTomorrow.TabIndex = 10;
            this.grpTomorrow.TabStop = false;
            this.grpTomorrow.Text = "Tomorrow";
            // 
            // lblTomorrowTemps
            // 
            this.lblTomorrowTemps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.lblTomorrowTemps.Location = new System.Drawing.Point(6, 70);
            this.lblTomorrowTemps.Name = "lblTomorrowTemps";
            this.lblTomorrowTemps.Size = new System.Drawing.Size(213, 23);
            this.lblTomorrowTemps.TabIndex = 9;
            this.lblTomorrowTemps.Text = "High: 70 / Low: 54 ";
            this.lblTomorrowTemps.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTomorrowStatus
            // 
            this.lblTomorrowStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTomorrowStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.lblTomorrowStatus.Location = new System.Drawing.Point(6, 34);
            this.lblTomorrowStatus.Name = "lblTomorrowStatus";
            this.lblTomorrowStatus.Size = new System.Drawing.Size(213, 23);
            this.lblTomorrowStatus.TabIndex = 8;
            this.lblTomorrowStatus.Text = "Sunny";
            this.lblTomorrowStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrentWeather
            // 
            this.lblCurrentWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWeather.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.lblCurrentWeather.Location = new System.Drawing.Point(-2, 231);
            this.lblCurrentWeather.Name = "lblCurrentWeather";
            this.lblCurrentWeather.Size = new System.Drawing.Size(276, 36);
            this.lblCurrentWeather.TabIndex = 6;
            this.lblCurrentWeather.Text = "Currently: 57";
            this.lblCurrentWeather.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHigh
            // 
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.lblHigh.Location = new System.Drawing.Point(-2, 264);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(276, 41);
            this.lblHigh.TabIndex = 5;
            this.lblHigh.Text = "High: 68";
            this.lblHigh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeatherStatus
            // 
            this.lblWeatherStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.lblWeatherStatus.Location = new System.Drawing.Point(-2, 52);
            this.lblWeatherStatus.Name = "lblWeatherStatus";
            this.lblWeatherStatus.Size = new System.Drawing.Size(276, 35);
            this.lblWeatherStatus.TabIndex = 4;
            this.lblWeatherStatus.Text = "Sunny";
            this.lblWeatherStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeatherHeader
            // 
            this.lblWeatherHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblWeatherHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.lblWeatherHeader.Location = new System.Drawing.Point(-2, 14);
            this.lblWeatherHeader.Name = "lblWeatherHeader";
            this.lblWeatherHeader.Size = new System.Drawing.Size(276, 44);
            this.lblWeatherHeader.TabIndex = 3;
            this.lblWeatherHeader.Text = "Today\'s Forecast";
            this.lblWeatherHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.picWeatherIcon.Image = global::ScreenSaver.Properties.Resources.Sunny;
            this.picWeatherIcon.Location = new System.Drawing.Point(60, 90);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(155, 130);
            this.picWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeatherIcon.TabIndex = 2;
            this.picWeatherIcon.TabStop = false;
            // 
            // picHeader
            // 
            this.picHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.picHeader.Image = global::ScreenSaver.Properties.Resources.ColemanHeader1;
            this.picHeader.Location = new System.Drawing.Point(331, 3);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(666, 135);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 1;
            this.picHeader.TabStop = false;
            // 
            // lblTitle2
            // 
            this.lblTitle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(148)))), ((int)(((byte)(253)))));
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(3, 11);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(979, 61);
            this.lblTitle2.TabIndex = 5;
            this.lblTitle2.Text = "Title 2";
            // 
            // lblDescription2
            // 
            this.lblDescription2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(148)))), ((int)(((byte)(253)))));
            this.lblDescription2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription2.Location = new System.Drawing.Point(3, 85);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(979, 137);
            this.lblDescription2.TabIndex = 6;
            this.lblDescription2.Text = "Description 2";
            // 
            // pnlArticle2
            // 
            this.pnlArticle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(148)))), ((int)(((byte)(253)))));
            this.pnlArticle2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlArticle2.Controls.Add(this.lblTitle2);
            this.pnlArticle2.Controls.Add(this.lblDescription2);
            this.pnlArticle2.Location = new System.Drawing.Point(29, 504);
            this.pnlArticle2.Name = "pnlArticle2";
            this.pnlArticle2.Size = new System.Drawing.Size(991, 233);
            this.pnlArticle2.TabIndex = 7;
            // 
            // pnlArticle1
            // 
            this.pnlArticle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(148)))), ((int)(((byte)(253)))));
            this.pnlArticle1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlArticle1.Controls.Add(this.lblDescription1);
            this.pnlArticle1.Controls.Add(this.lblTitle1);
            this.pnlArticle1.Location = new System.Drawing.Point(350, 161);
            this.pnlArticle1.Name = "pnlArticle1";
            this.pnlArticle1.Size = new System.Drawing.Size(668, 319);
            this.pnlArticle1.TabIndex = 8;
            // 
            // lblDescription1
            // 
            this.lblDescription1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription1.Location = new System.Drawing.Point(3, 79);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(658, 220);
            this.lblDescription1.TabIndex = 1;
            this.lblDescription1.Text = "Description 1";
            // 
            // lblTitle1
            // 
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(3, 10);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(658, 58);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Title 1";
            // 
            // pnlEvents
            // 
            this.pnlEvents.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlEvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEvents.Controls.Add(this.lblEventsHeader);
            this.pnlEvents.Location = new System.Drawing.Point(29, 25);
            this.pnlEvents.Name = "pnlEvents";
            this.pnlEvents.Size = new System.Drawing.Size(285, 455);
            this.pnlEvents.TabIndex = 10;
            // 
            // lblEventsHeader
            // 
            this.lblEventsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.lblEventsHeader.Location = new System.Drawing.Point(3, 10);
            this.lblEventsHeader.Name = "lblEventsHeader";
            this.lblEventsHeader.Size = new System.Drawing.Size(275, 31);
            this.lblEventsHeader.TabIndex = 0;
            this.lblEventsHeader.Text = "Events at a Glance";
            this.lblEventsHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // analogClock
            // 
            this.analogClock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.analogClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.analogClock.CalendarType = ScreenSaver.AnalogClock.CalendarTypes.Gregorian;
            this.analogClock.Caption = "CIX";
            this.analogClock.ClockStyle = ScreenSaver.AnalogClock.ClockStyles.Standard;
            this.analogClock.DateStyle = ScreenSaver.AnalogClock.DateStyles.Full;
            this.analogClock.Enabled = false;
            this.analogClock.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogClock.HandColor = System.Drawing.Color.Black;
            this.analogClock.HandStyle = ScreenSaver.AnalogClock.HandStyles.Uniform;
            this.analogClock.InnerColor = System.Drawing.Color.SkyBlue;
            this.analogClock.Location = new System.Drawing.Point(1028, 12);
            this.analogClock.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.analogClock.MinimumSize = new System.Drawing.Size(50, 50);
            this.analogClock.Name = "analogClock";
            this.analogClock.NumberStyle = ScreenSaver.AnalogClock.NumberStyles.All;
            this.analogClock.OuterColor = System.Drawing.Color.SteelBlue;
            this.analogClock.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock.Size = new System.Drawing.Size(326, 250);
            this.analogClock.TabIndex = 4;
            this.analogClock.TextColor = System.Drawing.Color.Black;
            this.analogClock.TickColor = System.Drawing.Color.Black;
            this.analogClock.TickStyle = ScreenSaver.AnalogClock.TickStyles.All;
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pnlEvents);
            this.Controls.Add(this.pnlArticle1);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.pnlArticle2);
            this.Controls.Add(this.analogClock);
            this.Controls.Add(this.pnlWeather);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScreenSaverForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseMove);
            this.pnlWeather.ResumeLayout(false);
            this.grpTomorrow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.pnlArticle2.ResumeLayout(false);
            this.pnlArticle1.ResumeLayout(false);
            this.pnlEvents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ScreenSaver.AnalogClock analogClock;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Timer rotateTimer;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.PictureBox picWeatherIcon;
        private System.Windows.Forms.Panel pnlWeather;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblCurrentWeather;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblWeatherStatus;
        private System.Windows.Forms.Label lblWeatherHeader;
        private System.Windows.Forms.GroupBox grpTomorrow;
        private System.Windows.Forms.Label lblTomorrowTemps;
        private System.Windows.Forms.Label lblTomorrowStatus;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Panel pnlArticle2;
        private System.Windows.Forms.Panel pnlArticle1;
        private System.Windows.Forms.Panel pnlEvents;
        private System.Windows.Forms.Label lblEventsHeader;
        private System.Windows.Forms.Label lblDescription1;
        private System.Windows.Forms.Label lblTitle1;
    }
}

