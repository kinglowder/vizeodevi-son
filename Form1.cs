using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
namespace deneme
{
    public partial class Form1 : Form
    {
        //1912901042-faruk uzun
        public Form1()
        {
            InitializeComponent();
        }



        private const string api = "7dd2ae243ec7279ff34e3fe8d2954284";
        private const string baglanti = "http://api.openweathermap.org/data/2.5/weather?q=Aydin&mode=xml&units=metric&APPID=" + api;

        private void Form1_Load(object sender, EventArgs e)
        {

            XDocument hava = XDocument.Load(baglanti);

            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            label_derece.Text = sicaklik.ToString() + "°";
            var durum = hava.Descendants("clouds").ElementAt(0).Attribute("name").Value;
            label_durum.Text = durum.ToString();
            var yer = hava.Descendants("city").ElementAt(0).Attribute("name").Value;
            label_yer.Text = yer.ToString();
            if (durum.Contains("clear sky") == true)

            {


                picture_bulutlu.Visible = false;
                picture_gunesli.Visible = true;
            }
            else
            {
                picture_bulutlu.Visible = true;
                picture_gunesli.Visible = false;
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
