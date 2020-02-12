using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1.EnglishVersion
{
    public partial class Flowers : UserControl
    {
        public string name;
        public Flowers()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                switch (comboBox1.Text)
            {
                case "Иглика": pictureBox1.BringToFront();
                    panel2.Visible = true; button2.Visible = true; label3.Text = "С разнообразната си цветна палитра, игликата е колоритно градинско цвете.Игликата произхожда от умерените зони на северното полукълбо. В България са известни 8 вида иглики в диво състояние, като 4 от тях са защитени от Закона за биологичното разнообразие."; break;
                case "Primrose": pictureBox1.BringToFront();
                    panel2.Visible = true; button2.Visible = true; label3.Text = "Primrose flowers are suitable for use in garden beds and borders as well as in containers or for naturalizing areas of the lawn. In fact, when given the proper growing conditions, these vigorous plants will multiply each year, adding stunning colors to the landscape."; break;
                case "Каланхое": pictureBox2.BringToFront();
                    panel2.Visible = true; button2.Visible = true; label3.Text = "Каланхоето е много красиво и разнообразно на багри цвете, което може да ни радва с красотата си през дългите зимни дни, а и не само тогава. Произхожда от тропиците на Африка и Азия и остров Мадагаскар. Цветовете на каланхоето са изключително нежни и красиви."; break;
                case "Kalanchoe": pictureBox2.BringToFront();
                    panel2.Visible = true; button2.Visible = true; label3.Text = "The genus Kalanchoe includes more than 100 plants, but only a few are regularly seen in cultivation. Kalanchoes are native to arid areas, and they are popular succulents. Modern hybrids are valued for their interesting leaf-forms or for their flowers."; break;
                case "Теменуга": pictureBox3.BringToFront();
                    panel2.Visible = true; button2.Visible = true; label3.Text = "Още от ерата на Романтизма теменугата покорява женското сърце със своята деликатност, нежност, изящни цветове в наситени розови, карминеночервени, цикламени тонове и неоспорима красота. Днес тя е изящна декорация за откритите тревни площи и за домашния балкон."; break;
                case "Viola": pictureBox3.BringToFront();
                    panel2.Visible = true; button2.Visible = true; label3.Text = "There are over 500 different species of violas and they are easy to care for. Most of the violas cultivated in gardens are grown as annuals or short-lived perennials. Many will self-seed and give you years of delight. Violas are primarily cool-season bloomers."; break;
                case "Гербер": pictureBox4.BringToFront();
                    panel2.Visible = true; button2.Visible = true; label3.Text = "Герберът е многогодишно вечнозелено растение. Среща в Южна Африка, но има представители и в Индия, Австралия и Мадагаскар. Изящни цветове, разположени на дълги дръжки, които не увяхват цели седмици, великолепни багри – идеално цвете, достойно да украси всеки дом."; break;
                case "Gerbera": pictureBox4.BringToFront();
                    panel2.Visible = true; button2.Visible = true; label3.Text = "Gerbera is a genus of the family of sunflowers, Daisies and Asters - Asteraceae, with a wide distribution from Africa to Madagascar, tropical Asia and South America. Through hybridization, Gerberas are available in a massive array of colors."; break;
                case "Циклама": pictureBox5.BringToFront();
                    panel2.Visible = true; button2.Visible = true; label3.Text = "Цикламата, родом от Мала Азия, е известна с ароматните си, кадифено меки, изящни цветове в наситени розови, карминеночервени, цикламени тонове. У нас в диво състояние се среща по северните склонове на Стара планина. Предпочита хладни и засенчени терени."; break;
                case "Cyclamen": pictureBox5.BringToFront();
                    panel2.Visible = true; button2.Visible = true; label3.Text = "Cyclamen is a small but diverse genus of plants. It is a tuberous perennial with heart-shaped leaves and flowers in shades of pink, red, or white. Even the foliage is attractive, often having silver marbling on the top sides of the leaves. "; break;
                case "Мушкато": pictureBox6.BringToFront();
                    panel2.Visible = true; button2.Visible = true; label3.Text = "Мушкато – любимо растение на много цветари, идеално за отглеждане в домашни условия. Освен с красиви  и ярки цветове, мушкатото има свойство да пречиства въздуха от бактерии, а уханието му повдига настроението. Предпочита хладни и засенчени места."; break;
                case "Geranium": pictureBox6.BringToFront();
                    panel2.Visible = true; button2.Visible = true; label3.Text = "Geraniums make popular bedding plants in the garden, but they’re also commonly grown indoors or outside in hanging baskets. Growing geranium plants is easy as long as you can give them what they need."; break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.name = comboBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
