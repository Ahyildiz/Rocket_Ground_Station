using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public struct Rocket
{
    public double bme_alt, bme_pres, bme_temp;
    public double gps_alt, gps_lat, gps_lon;
    public double gyro_x, gyro_y, gyro_z, acc_x, acc_y, acc_z;
    public double rc_angx, rc_angy, rc_angz, rc_speed;
}

[StructLayout(LayoutKind.Explicit)]
public struct Union
{
    [FieldOffset(0)] public string char_arr;
    [FieldOffset(0)] public float float_val;
}



namespace Astra
{
    public partial class angz_label : Form
    {
        public delegate void d1(string indata);
        public bool serial_open = false;
        Image img;
        int i = 0,j=0;
        int counter = 0;
        int gps_lat_str = 4, gps_lon_str, gps_alt_str, alt_str, pres_str,tmp_str,accx_str,accy_str,accz_str, gyrox_str, gyroy_str, gyroz_str,angx_str, angy_str, angz_str, spd_str;
        int something_length = 0;
        string anan_nasıl;
        Rocket astra_rc;
        public angz_label()
        {
            InitializeComponent();
            button2.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serial_open = true;
            button1.Enabled = false;
            button2.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serial_open = false;
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {            
            if (serial_open)
            {
                string indata = serialPort1.ReadLine();
                d1 writeit = new d1(Write_To_Form);
                Invoke(writeit, indata);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int new_w = 320, new_h = 320;

            Bitmap bmp = new Bitmap(img.Width, img.Height);
            /*
            if (astra_rc.rc_angz < 0)
            {
                astra_rc.rc_angz = -astra_rc.rc_angz;
            }

            if (astra_rc.rc_angz <= 90)
            {
                new_w = (int)(bmp.Width * Math.Cos(2 * Math.PI * (float)astra_rc.rc_angz / 360) - bmp.Height * Math.Sin(2 * Math.PI * (float)astra_rc.rc_angz / 360));
                new_h = (int)(bmp.Height * Math.Cos(2 * Math.PI * (float)astra_rc.rc_angz / 360) - bmp.Width * Math.Sin(2 * Math.PI * (float)astra_rc.rc_angz / 360));
            }else if (astra_rc.rc_angz <= 180)
            {
                new_w = (int)(bmp.Width * -Math.Cos(2 * Math.PI * (float)astra_rc.rc_angz / 360) - bmp.Height * Math.Sin(2 * Math.PI * (float)astra_rc.rc_angz / 360));
                new_h = (int)(bmp.Height * -Math.Cos(2 * Math.PI * (float)astra_rc.rc_angz / 360) - bmp.Width * Math.Sin(2 * Math.PI * (float)astra_rc.rc_angz / 360));
            }
            else if (astra_rc.rc_angz <= 270)
            {
                new_w = (int)(bmp.Width * -Math.Cos(2 * Math.PI * (float)astra_rc.rc_angz / 360) - bmp.Height * -Math.Sin(2 * Math.PI * (float)astra_rc.rc_angz / 360));
                new_h = (int)(bmp.Height * -Math.Cos(2 * Math.PI * (float)astra_rc.rc_angz / 360) - bmp.Width * -Math.Sin(2 * Math.PI * (float)astra_rc.rc_angz / 360));
            }
            else
            {
                new_w = (int)(bmp.Width * Math.Cos(2 * Math.PI * (float)astra_rc.rc_angz / 360) - bmp.Height * -Math.Sin(2 * Math.PI * (float)astra_rc.rc_angz / 360));
                new_h = (int)(bmp.Height * Math.Cos(2 * Math.PI * (float)astra_rc.rc_angz / 360) - bmp.Width * -Math.Sin(2 * Math.PI * (float)astra_rc.rc_angz / 360));
            }
            */
            Bitmap bit_map = new Bitmap(new_w, new_h);
            Graphics gfx = Graphics.FromImage(bit_map);

            gfx.TranslateTransform(new_w / 2, new_h / 2);
            gfx.RotateTransform((-(float)astra_rc.rc_angz ));
            gfx.TranslateTransform(-img.Width / 2, -img.Height / 2);
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            gfx.DrawImage(img, 0, 0);
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.DrawImage(bit_map, 220, -50);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        public void Write_To_Form(string indata)
        {

            // Recieved data handler
            
            string handshake = "$AT;";
            
            if (handshake[0] == indata[0] && handshake[1] == indata[1] && handshake[2] == indata[2] && handshake[3] == indata[3] )
            {
                altitude_chart.ChartAreas[0].AxisX.Minimum = 0;
                angle_chart.ChartAreas[0].AxisX.Minimum = 0;
                angle_chart.ChartAreas[0].AxisY.Minimum = -150;
                angle_chart.ChartAreas[0].AxisY.Maximum = 150;
                speed_chart.ChartAreas[0].AxisX.Minimum = 0;

                textBox1.Text = indata;
                counter = 0;
                for (i = 0; i < indata.Length ; i++)
                {
                    if (indata[i] == ',')
                    {
                        counter++;
                        switch (counter)
                        {
                            case 1:
                                gps_lon_str = i + 1;
                                break;
                            case 2:
                                gps_alt_str = i + 1;
                                break;
                            case 3:
                                alt_str = i + 1;
                                break;
                            case 4:
                                pres_str = i + 1;
                                break;
                            case 5:
                                tmp_str = i + 1;
                                break;
                            case 6:
                                accx_str = i + 1;
                                break;
                            case 7:
                                accy_str = i + 1;
                                break;
                            case 8:
                                accz_str = i + 1;
                                break;
                            case 9:
                                gyrox_str = i + 1;
                                break;
                            case 10:
                                gyroy_str = i + 1;
                                break;
                            case 11:
                                gyroz_str = i + 1;
                                break;
                            case 12:
                                angx_str = i + 1;
                                break;
                            case 13:
                                angy_str = i + 1;
                                break;
                            case 14:
                                angz_str = i + 1;
                                break;
                            case 15: spd_str = i + 1;
                                break;
                            default: return;
                        }
                    }
                }
                if (counter <= 15) {
                    

                    astra_rc.gps_lat = double.Parse(indata.Substring(gps_lat_str, gps_lon_str - 1 - gps_lat_str));
                    astra_rc.gps_lon = double.Parse(indata.Substring(gps_lon_str, gps_alt_str - 1 - gps_lon_str));
                    astra_rc.gps_alt = double.Parse(indata.Substring(gps_alt_str, alt_str - 1 - gps_alt_str));
                    astra_rc.bme_alt = double.Parse(indata.Substring(alt_str, pres_str - 1 - alt_str)) /100;
                    astra_rc.bme_pres = double.Parse(indata.Substring(pres_str, tmp_str - 1 - pres_str)) / 100;
                    astra_rc.bme_temp = double.Parse(indata.Substring(tmp_str, accx_str - 1 - tmp_str)) / 100;
                    astra_rc.acc_x = double.Parse(indata.Substring(accx_str, accy_str - 1 - accx_str)) / 100;
                    astra_rc.acc_y = double.Parse(indata.Substring(accy_str, accz_str - 1 - accy_str)) / 100;
                    astra_rc.acc_z = double.Parse(indata.Substring(accz_str, gyrox_str - 1 - accz_str)) / 100;
                    astra_rc.gyro_x = double.Parse(indata.Substring(gyrox_str, gyroy_str - 1 - gyrox_str)) / 100;
                    astra_rc.gyro_y = double.Parse(indata.Substring(gyroy_str, gyroz_str - 1 - gyroy_str)) / 100;
                    astra_rc.gyro_z = double.Parse(indata.Substring(gyroz_str, angx_str - 1 - gyroz_str)) / 100;
                    astra_rc.rc_angx = double.Parse(indata.Substring(angx_str, angy_str - 1 - angx_str)) / 100;
                    astra_rc.rc_angy = double.Parse(indata.Substring(angy_str, angz_str - 1 - angy_str)) / 100;
                    astra_rc.rc_angz = double.Parse(indata.Substring(angz_str, spd_str - 1 - angz_str)) / 100;
                    //astra_rc.rc_speed = double.Parse(indata.Substring(spd_str, indata.Length - 1 - spd_str)) / 100;

                    lat_label.Text = indata.Substring(gps_lat_str, gps_lon_str - 1 - gps_lat_str);
                    lon_label.Text = indata.Substring(gps_lon_str, gps_alt_str - 1 - gps_lon_str);
                    gps_alt_label.Text = indata.Substring(gps_alt_str, alt_str - 1 - gps_alt_str);
                    bme_alt_label.Text = indata.Substring(alt_str, pres_str - 1 - alt_str);
                    bme_pres_label.Text = indata.Substring(pres_str, tmp_str - 1 - pres_str);
                    bme_tmp_label.Text = indata.Substring(tmp_str, accx_str - 1 - tmp_str);
                    accx_label.Text = indata.Substring(accx_str, accy_str - 1 - accx_str);
                    accy_label.Text = indata.Substring(accy_str, accz_str - 1 - accy_str);
                    accz_label.Text = indata.Substring(accz_str, gyrox_str - 1 - accz_str);
                    gyrox_label.Text = indata.Substring(gyrox_str, gyroy_str - 1 - gyrox_str);
                    gyroy_label.Text = indata.Substring(gyroy_str, gyroz_str - 1 - gyroy_str);
                    gyroz_label.Text = indata.Substring(gyroz_str, angx_str - 1 - gyroz_str);
                    rc_angx_label.Text = indata.Substring(angx_str, angy_str - 1 - angx_str);
                    rc_angy_label.Text = indata.Substring(angy_str, angz_str - 1 - angy_str);
                    rc_angz_label.Text = indata.Substring(angz_str, spd_str - 1 - angz_str);
                    //rc_spd_label.Text = indata.Substring(spd_str, indata.Length - 1 - spd_str);

                    //rc_angz_label.Text = astra_rc.rc_angz.ToString();
                    rc_spd_label.Text = astra_rc.rc_speed.ToString();
                    this.altitude_chart.Series[0].Points.AddXY(j, astra_rc.bme_alt);
                    this.angle_chart.Series[0].Points.AddXY(j, astra_rc.rc_angz);
                    this.speed_chart.Series[0].Points.AddXY(j, astra_rc.rc_speed);
                    j++;
                    Invalidate();
                }
            }
            else if(something_length < 54)
            {
                something_length += indata.Length;
                //anan_nasıl
            }
            else
            {
                something_length = 0;
                    
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img = Image.FromFile(@"C:\Users\UserAdminv2\Desktop\Test_arduino\Astra_GUI\Astra\Photos\rocket.png");
        }
    }
}
