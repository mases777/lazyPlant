using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.EnglishVersion
{
    public partial class Watering : UserControl
    {
        public Watering()
        {
            InitializeComponent();
        }

        /*ТЕМЕНУГА ПОЛИВАНЕ : Можете да премахвате редовно увяхналите цветя(мъртва глава), за да предизвикате появата на нови пъпки.

        За теменужки, отглеждани в саксии, контейнери или градински кутии, организирайте по-редовно поливане, така че почвената смес никога да не остане суха твърде дълго.*/
        public void got_info()
        {
            switch (label1.Text)
            {
                case "Иглика": panel2.Visible = true; pictureBox1.BringToFront(); break;

                case "Primrose": panel2.Visible = true; pictureBox1.BringToFront(); break;

                case "Каланхое": panel2.Visible = true; pictureBox2.BringToFront(); break;

                case "Kalanchoe": panel2.Visible = true; pictureBox2.BringToFront(); break;

                case "Теменуга": panel2.Visible = true; pictureBox3.BringToFront(); break;

                case "Viola": panel2.Visible = true; pictureBox3.BringToFront(); break;

                case "Гербер": panel2.Visible = true; pictureBox4.BringToFront(); break;

                case "Gerbera": panel2.Visible = true; pictureBox4.BringToFront(); break;

                case "Циклама": panel2.Visible = true; pictureBox5.BringToFront(); break;

                case "Cyclamen": panel2.Visible = true; pictureBox5.BringToFront(); break;

                case "Мушкато": panel2.Visible = true; pictureBox6.BringToFront(); break;

                case "Geranium": panel2.Visible = true; pictureBox6.BringToFront(); break;

                default:
                    break;
            }
        }
    }
}
