
namespace Astra
{
    partial class angz_label
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(angz_label));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lat_label = new System.Windows.Forms.Label();
            this.altitude_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.angle_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.speed_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lon_label = new System.Windows.Forms.Label();
            this.gps_alt_label = new System.Windows.Forms.Label();
            this.bme_alt_label = new System.Windows.Forms.Label();
            this.bme_pres_label = new System.Windows.Forms.Label();
            this.bme_tmp_label = new System.Windows.Forms.Label();
            this.str_lat_lab = new System.Windows.Forms.Label();
            this.str_lon_lab = new System.Windows.Forms.Label();
            this.str_gps_alt_lab = new System.Windows.Forms.Label();
            this.str_bme_alt_lab = new System.Windows.Forms.Label();
            this.str_bme_pres_lab = new System.Windows.Forms.Label();
            this.str_bme_tmp_lab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gyroz_label = new System.Windows.Forms.Label();
            this.gyroy_label = new System.Windows.Forms.Label();
            this.gyrox_label = new System.Windows.Forms.Label();
            this.accz_label = new System.Windows.Forms.Label();
            this.accy_label = new System.Windows.Forms.Label();
            this.accx_label = new System.Windows.Forms.Label();
            this.rc_angz_label = new System.Windows.Forms.Label();
            this.rc_angy_label = new System.Windows.Forms.Label();
            this.rc_angx_label = new System.Windows.Forms.Label();
            this.rc_angz_str = new System.Windows.Forms.Label();
            this.rc_angy_str = new System.Windows.Forms.Label();
            this.rc_angx_str = new System.Windows.Forms.Label();
            this.rc_spd_label = new System.Windows.Forms.Label();
            this.rc_spd_str = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.altitude_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect Arduino";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Disconnect Arduino";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 551);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(606, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lat_label
            // 
            this.lat_label.AutoSize = true;
            this.lat_label.Location = new System.Drawing.Point(97, 292);
            this.lat_label.Name = "lat_label";
            this.lat_label.Size = new System.Drawing.Size(41, 13);
            this.lat_label.TabIndex = 3;
            this.lat_label.Text = "gps_lat";
            // 
            // altitude_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.altitude_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.altitude_chart.Legends.Add(legend1);
            this.altitude_chart.Location = new System.Drawing.Point(247, 12);
            this.altitude_chart.Name = "altitude_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Altitude (m)";
            this.altitude_chart.Series.Add(series1);
            this.altitude_chart.Size = new System.Drawing.Size(436, 239);
            this.altitude_chart.TabIndex = 4;
            this.altitude_chart.Text = "Altitude";
            // 
            // angle_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.angle_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.angle_chart.Legends.Add(legend2);
            this.angle_chart.Location = new System.Drawing.Point(338, 257);
            this.angle_chart.Name = "angle_chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Angle (°)";
            this.angle_chart.Series.Add(series2);
            this.angle_chart.Size = new System.Drawing.Size(436, 268);
            this.angle_chart.TabIndex = 5;
            this.angle_chart.Text = "chart2";
            // 
            // speed_chart
            // 
            chartArea3.Name = "ChartArea1";
            this.speed_chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.speed_chart.Legends.Add(legend3);
            this.speed_chart.Location = new System.Drawing.Point(656, 12);
            this.speed_chart.Name = "speed_chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Speed (m/s)";
            this.speed_chart.Series.Add(series3);
            this.speed_chart.Size = new System.Drawing.Size(436, 239);
            this.speed_chart.TabIndex = 6;
            this.speed_chart.Text = "chart3";
            // 
            // lon_label
            // 
            this.lon_label.AutoSize = true;
            this.lon_label.Location = new System.Drawing.Point(97, 314);
            this.lon_label.Name = "lon_label";
            this.lon_label.Size = new System.Drawing.Size(44, 13);
            this.lon_label.TabIndex = 7;
            this.lon_label.Text = "gps_lon";
            // 
            // gps_alt_label
            // 
            this.gps_alt_label.AutoSize = true;
            this.gps_alt_label.Location = new System.Drawing.Point(97, 336);
            this.gps_alt_label.Name = "gps_alt_label";
            this.gps_alt_label.Size = new System.Drawing.Size(41, 13);
            this.gps_alt_label.TabIndex = 8;
            this.gps_alt_label.Text = "gps_alt";
            // 
            // bme_alt_label
            // 
            this.bme_alt_label.AutoSize = true;
            this.bme_alt_label.Location = new System.Drawing.Point(97, 358);
            this.bme_alt_label.Name = "bme_alt_label";
            this.bme_alt_label.Size = new System.Drawing.Size(44, 13);
            this.bme_alt_label.TabIndex = 9;
            this.bme_alt_label.Text = "bme_alt";
            // 
            // bme_pres_label
            // 
            this.bme_pres_label.AutoSize = true;
            this.bme_pres_label.Location = new System.Drawing.Point(97, 380);
            this.bme_pres_label.Name = "bme_pres_label";
            this.bme_pres_label.Size = new System.Drawing.Size(53, 13);
            this.bme_pres_label.TabIndex = 10;
            this.bme_pres_label.Text = "bme_pres";
            // 
            // bme_tmp_label
            // 
            this.bme_tmp_label.AutoSize = true;
            this.bme_tmp_label.Location = new System.Drawing.Point(97, 402);
            this.bme_tmp_label.Name = "bme_tmp_label";
            this.bme_tmp_label.Size = new System.Drawing.Size(50, 13);
            this.bme_tmp_label.TabIndex = 11;
            this.bme_tmp_label.Text = "bme_tmp";
            // 
            // str_lat_lab
            // 
            this.str_lat_lab.AutoSize = true;
            this.str_lat_lab.Location = new System.Drawing.Point(11, 292);
            this.str_lat_lab.Name = "str_lat_lab";
            this.str_lat_lab.Size = new System.Drawing.Size(51, 13);
            this.str_lat_lab.TabIndex = 12;
            this.str_lat_lab.Text = "Latitude :";
            // 
            // str_lon_lab
            // 
            this.str_lon_lab.AutoSize = true;
            this.str_lon_lab.Location = new System.Drawing.Point(12, 314);
            this.str_lon_lab.Name = "str_lon_lab";
            this.str_lon_lab.Size = new System.Drawing.Size(60, 13);
            this.str_lon_lab.TabIndex = 13;
            this.str_lon_lab.Text = "Longitude :";
            // 
            // str_gps_alt_lab
            // 
            this.str_gps_alt_lab.AutoSize = true;
            this.str_gps_alt_lab.Location = new System.Drawing.Point(10, 336);
            this.str_gps_alt_lab.Name = "str_gps_alt_lab";
            this.str_gps_alt_lab.Size = new System.Drawing.Size(72, 13);
            this.str_gps_alt_lab.TabIndex = 14;
            this.str_gps_alt_lab.Text = "GPS altitude :";
            // 
            // str_bme_alt_lab
            // 
            this.str_bme_alt_lab.AutoSize = true;
            this.str_bme_alt_lab.Location = new System.Drawing.Point(10, 358);
            this.str_bme_alt_lab.Name = "str_bme_alt_lab";
            this.str_bme_alt_lab.Size = new System.Drawing.Size(73, 13);
            this.str_bme_alt_lab.TabIndex = 15;
            this.str_bme_alt_lab.Text = "BME altitude :";
            // 
            // str_bme_pres_lab
            // 
            this.str_bme_pres_lab.AutoSize = true;
            this.str_bme_pres_lab.Location = new System.Drawing.Point(11, 380);
            this.str_bme_pres_lab.Name = "str_bme_pres_lab";
            this.str_bme_pres_lab.Size = new System.Drawing.Size(79, 13);
            this.str_bme_pres_lab.TabIndex = 16;
            this.str_bme_pres_lab.Text = "BME pressure :";
            // 
            // str_bme_tmp_lab
            // 
            this.str_bme_tmp_lab.AutoSize = true;
            this.str_bme_tmp_lab.Location = new System.Drawing.Point(12, 402);
            this.str_bme_tmp_lab.Name = "str_bme_tmp_lab";
            this.str_bme_tmp_lab.Size = new System.Drawing.Size(73, 13);
            this.str_bme_tmp_lab.TabIndex = 17;
            this.str_bme_tmp_lab.Text = "Temperature :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gyro Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Gyro Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Gyro X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Acceleration Z:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Acceleration Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Acceleration X:";
            // 
            // gyroz_label
            // 
            this.gyroz_label.AutoSize = true;
            this.gyroz_label.Location = new System.Drawing.Point(97, 535);
            this.gyroz_label.Name = "gyroz_label";
            this.gyroz_label.Size = new System.Drawing.Size(38, 13);
            this.gyroz_label.TabIndex = 31;
            this.gyroz_label.Text = "gyro_z";
            // 
            // gyroy_label
            // 
            this.gyroy_label.AutoSize = true;
            this.gyroy_label.Location = new System.Drawing.Point(97, 512);
            this.gyroy_label.Name = "gyroy_label";
            this.gyroy_label.Size = new System.Drawing.Size(38, 13);
            this.gyroy_label.TabIndex = 30;
            this.gyroy_label.Text = "gyro_y";
            // 
            // gyrox_label
            // 
            this.gyrox_label.AutoSize = true;
            this.gyrox_label.Location = new System.Drawing.Point(97, 490);
            this.gyrox_label.Name = "gyrox_label";
            this.gyrox_label.Size = new System.Drawing.Size(38, 13);
            this.gyrox_label.TabIndex = 29;
            this.gyrox_label.Text = "gyro_x";
            // 
            // accz_label
            // 
            this.accz_label.AutoSize = true;
            this.accz_label.Location = new System.Drawing.Point(97, 468);
            this.accz_label.Name = "accz_label";
            this.accz_label.Size = new System.Drawing.Size(36, 13);
            this.accz_label.TabIndex = 28;
            this.accz_label.Text = "acc_z";
            // 
            // accy_label
            // 
            this.accy_label.AutoSize = true;
            this.accy_label.Location = new System.Drawing.Point(97, 446);
            this.accy_label.Name = "accy_label";
            this.accy_label.Size = new System.Drawing.Size(36, 13);
            this.accy_label.TabIndex = 27;
            this.accy_label.Text = "acc_y";
            // 
            // accx_label
            // 
            this.accx_label.AutoSize = true;
            this.accx_label.Location = new System.Drawing.Point(97, 424);
            this.accx_label.Name = "accx_label";
            this.accx_label.Size = new System.Drawing.Size(36, 13);
            this.accx_label.TabIndex = 26;
            this.accx_label.Text = "acc_x";
            // 
            // rc_angz_label
            // 
            this.rc_angz_label.AutoSize = true;
            this.rc_angz_label.Location = new System.Drawing.Point(292, 336);
            this.rc_angz_label.Name = "rc_angz_label";
            this.rc_angz_label.Size = new System.Drawing.Size(36, 13);
            this.rc_angz_label.TabIndex = 40;
            this.rc_angz_label.Text = "ang_z";
            // 
            // rc_angy_label
            // 
            this.rc_angy_label.AutoSize = true;
            this.rc_angy_label.Location = new System.Drawing.Point(292, 314);
            this.rc_angy_label.Name = "rc_angy_label";
            this.rc_angy_label.Size = new System.Drawing.Size(36, 13);
            this.rc_angy_label.TabIndex = 39;
            this.rc_angy_label.Text = "ang_y";
            // 
            // rc_angx_label
            // 
            this.rc_angx_label.AutoSize = true;
            this.rc_angx_label.Location = new System.Drawing.Point(292, 292);
            this.rc_angx_label.Name = "rc_angx_label";
            this.rc_angx_label.Size = new System.Drawing.Size(36, 13);
            this.rc_angx_label.TabIndex = 38;
            this.rc_angx_label.Text = "ang_x";
            // 
            // rc_angz_str
            // 
            this.rc_angz_str.AutoSize = true;
            this.rc_angz_str.Location = new System.Drawing.Point(206, 336);
            this.rc_angz_str.Name = "rc_angz_str";
            this.rc_angz_str.Size = new System.Drawing.Size(47, 13);
            this.rc_angz_str.TabIndex = 34;
            this.rc_angz_str.Text = "Angle Z:";
            // 
            // rc_angy_str
            // 
            this.rc_angy_str.AutoSize = true;
            this.rc_angy_str.Location = new System.Drawing.Point(207, 314);
            this.rc_angy_str.Name = "rc_angy_str";
            this.rc_angy_str.Size = new System.Drawing.Size(47, 13);
            this.rc_angy_str.TabIndex = 33;
            this.rc_angy_str.Text = "Angle Y:";
            // 
            // rc_angx_str
            // 
            this.rc_angx_str.AutoSize = true;
            this.rc_angx_str.Location = new System.Drawing.Point(207, 292);
            this.rc_angx_str.Name = "rc_angx_str";
            this.rc_angx_str.Size = new System.Drawing.Size(47, 13);
            this.rc_angx_str.TabIndex = 32;
            this.rc_angx_str.Text = "Angle X:";
            // 
            // rc_spd_label
            // 
            this.rc_spd_label.AutoSize = true;
            this.rc_spd_label.Location = new System.Drawing.Point(292, 358);
            this.rc_spd_label.Name = "rc_spd_label";
            this.rc_spd_label.Size = new System.Drawing.Size(39, 13);
            this.rc_spd_label.TabIndex = 42;
            this.rc_spd_label.Text = "rc_spd";
            // 
            // rc_spd_str
            // 
            this.rc_spd_str.AutoSize = true;
            this.rc_spd_str.Location = new System.Drawing.Point(206, 358);
            this.rc_spd_str.Name = "rc_spd_str";
            this.rc_spd_str.Size = new System.Drawing.Size(77, 13);
            this.rc_spd_str.TabIndex = 41;
            this.rc_spd_str.Text = "Rocket speed:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 239);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // angz_label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 583);
            this.Controls.Add(this.rc_spd_label);
            this.Controls.Add(this.rc_spd_str);
            this.Controls.Add(this.rc_angz_label);
            this.Controls.Add(this.rc_angy_label);
            this.Controls.Add(this.rc_angx_label);
            this.Controls.Add(this.rc_angz_str);
            this.Controls.Add(this.rc_angy_str);
            this.Controls.Add(this.rc_angx_str);
            this.Controls.Add(this.gyroz_label);
            this.Controls.Add(this.gyroy_label);
            this.Controls.Add(this.gyrox_label);
            this.Controls.Add(this.accz_label);
            this.Controls.Add(this.accy_label);
            this.Controls.Add(this.accx_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.str_bme_tmp_lab);
            this.Controls.Add(this.str_bme_pres_lab);
            this.Controls.Add(this.str_bme_alt_lab);
            this.Controls.Add(this.str_gps_alt_lab);
            this.Controls.Add(this.str_lon_lab);
            this.Controls.Add(this.str_lat_lab);
            this.Controls.Add(this.bme_tmp_label);
            this.Controls.Add(this.bme_pres_label);
            this.Controls.Add(this.bme_alt_label);
            this.Controls.Add(this.gps_alt_label);
            this.Controls.Add(this.lon_label);
            this.Controls.Add(this.speed_chart);
            this.Controls.Add(this.angle_chart);
            this.Controls.Add(this.altitude_chart);
            this.Controls.Add(this.lat_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "angz_label";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astra Roket Takımı Yer İstasyonu Arayüzü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.altitude_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lat_label;
        private System.Windows.Forms.DataVisualization.Charting.Chart altitude_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart angle_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart speed_chart;
        private System.Windows.Forms.Label lon_label;
        private System.Windows.Forms.Label gps_alt_label;
        private System.Windows.Forms.Label bme_alt_label;
        private System.Windows.Forms.Label bme_pres_label;
        private System.Windows.Forms.Label bme_tmp_label;
        private System.Windows.Forms.Label str_lat_lab;
        private System.Windows.Forms.Label str_lon_lab;
        private System.Windows.Forms.Label str_gps_alt_lab;
        private System.Windows.Forms.Label str_bme_alt_lab;
        private System.Windows.Forms.Label str_bme_pres_lab;
        private System.Windows.Forms.Label str_bme_tmp_lab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label gyroz_label;
        private System.Windows.Forms.Label gyroy_label;
        private System.Windows.Forms.Label gyrox_label;
        private System.Windows.Forms.Label accz_label;
        private System.Windows.Forms.Label accy_label;
        private System.Windows.Forms.Label accx_label;
        private System.Windows.Forms.Label rc_angz_label;
        private System.Windows.Forms.Label rc_angy_label;
        private System.Windows.Forms.Label rc_angx_label;
        private System.Windows.Forms.Label rc_angz_str;
        private System.Windows.Forms.Label rc_angy_str;
        private System.Windows.Forms.Label rc_angx_str;
        private System.Windows.Forms.Label rc_spd_label;
        private System.Windows.Forms.Label rc_spd_str;
    }
}

