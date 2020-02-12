using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.EnglishVersion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        public bool language;

        public Form1()
        {
            language = true;
            InitializeComponent();
            flowLayoutPanel1.Height = button1.Height;
            flowLayoutPanel1.Top = button1.Top;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Height = button1.Height;
            flowLayoutPanel1.Top = button1.Top;
            panel4.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button2.Height;
            flowLayoutPanel1.Top = button2.Top;
            panel4.Visible = true;
            watering1.BringToFront();
            getInfo();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button3.Height;
            flowLayoutPanel1.Top = button3.Top;
            panel4.Visible = true;
            flowers1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button4.Height;
            flowLayoutPanel1.Top = button4.Top;
            panel4.Visible = true;
            myLazyPlant1.BringToFront();
            getInfo();
            if (language)
            {
                myLazyPlant1.TalkBulgarian();
            }
            else
            {
                myLazyPlant1.TalkEnglish();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button5.Height;
            flowLayoutPanel1.Top = button5.Top;
            panel4.Visible = true;
            tips1.BringToFront();
            getInfo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button6.Height;
            flowLayoutPanel1.Top = button6.Top;
            panel4.Visible = true;
            settings1.BringToFront();
            getInfo();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button7.Height;
            flowLayoutPanel1.Top = button7.Top;
            panel4.Visible = true;
            aboutUs1.BringToFront();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 550;
                mouseY = MousePosition.Y - 5;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            language = false;
            button1.Text = "          Home";
            button2.Text = "       Watering";
            button3.Text = "        Flowers";
            button4.Text = "     My Lazy Plant";
            button5.Text = "           Tips";
            button6.Text = "        Settings";
            button7.Text = "        About Us";
            button8.Text = "  EXIT";
            button9.Text = "MINIMIZE";
            button10.Text = "First choose flower";
            //flowers
            flowers1.label1.Text = "Choose flower: ";
            flowers1.button2.Text = "Choose";
            //flowers1.comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            languageTranslaterToEnglishForFlowersText();
            languageTranslaterToEnglishForFlowersName();
            flowers1.comboBox1.Items.Clear();
            object[] flowers = new object[] { "Primrose", "Viola", "Kalanchoe", "Cyclamen", "Gerbera", "Geranium" };
            flowers1.comboBox1.Items.AddRange(flowers);
            //flowers1.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            //tips
            tips1.LocationAndSunlight.Text = "Location and Sunlight";
            tips1.Temperature.Text = "Temperatue";
            tips1.Soil.Text = "Soil";
            tips1.Fertilization.Text = "Fertilization";
            tips1.Transplanting.Text = "Тransplanting";
            languageTranslaterToEnglishForTips();
            //mylazyplant
            myLazyPlant1.TalkEnglish();
        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            language = true;
            button1.Text = "         Начало";
            button2.Text = "       Поливане";
            button3.Text = "          Цветя";
            button4.Text = "        Моето          Растение";
            button5.Text = "         Съвети";
            button6.Text = "      Настройки";
            button7.Text = "         За нас";
            button8.Text = "ИЗХОД";
            button9.Text = "   МИНИ";
            button10.Text = "Първо изберете цвете";
            //flowers
            flowers1.label1.Text = "Изберете цвете: ";
            flowers1.button2.Text = "Избери";
            //flowers1.comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            languageTraslaterToBulgarianForFlowersName();
            languageTraslaterToBulgarianForFlowersText();
            flowers1.comboBox1.Items.Clear();
            object[] flowers = new object[] { "Иглика", "Теменуга", "Каланхое", "Циклама", "Гербер", "Мушкато" };
            flowers1.comboBox1.Items.AddRange(flowers);
            //flowers1.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            //tips
            tips1.LocationAndSunlight.Text = "Местоположение и светлина";
            tips1.Temperature.Text = "Температура";
            tips1.Soil.Text = "Почва";
            tips1.Fertilization.Text = "Наторяване";
            tips1.Transplanting.Text = "Пресаждане";
            languageTraslaterToBulgarianForTips();
            //mylazyplant
            myLazyPlant1.TalkBulgarian();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button3.Height;
            flowLayoutPanel1.Top = button3.Top;
            panel4.Visible = true;
            flowers1.BringToFront();
        }

        public void getInfo()
        {
            if (flowers1.name != null)
            {
                myLazyPlant1.textBox1.Visible = true;
                myLazyPlant1.textBox1.Text = flowers1.name;
                watering1.label1.Text = flowers1.name;
                tips1.textBox1.Text = flowers1.name;
                button10.Visible = false;
                myLazyPlant1.got_info();
                watering1.got_info();
                myLazyPlant1.MyFlowerTalk();
                myLazyPlant1.move();
            }
            else
            {
                button10.Visible = true;
                button10.BringToFront();
            }
        }

        public void languageTranslaterToEnglishForFlowersName()
        {
            switch (flowers1.comboBox1.Text)
            {
                case "Иглика": flowers1.comboBox1.Text = "Primrose"; break;

                case "Теменуга": flowers1.comboBox1.Text = "Viola"; break;

                case "Каланхое": flowers1.comboBox1.Text = "Kalanchoe"; break;

                case "Циклама": flowers1.comboBox1.Text = "Cyclamen"; break;

                case "Гербер": flowers1.comboBox1.Text = "Gerbera"; break;

                case "Мушкато": flowers1.comboBox1.Text = "Geranium"; break;

                default:
                    break;
            }

        }

        public void languageTraslaterToBulgarianForFlowersName()
        {
            switch (flowers1.comboBox1.Text)
            {
                case "Primrose": flowers1.comboBox1.Text = "Иглика"; break;

                case "Viola": flowers1.comboBox1.Text = "Теменуга"; break;

                case "Kalanchoe": flowers1.comboBox1.Text = "Каланхое"; break;

                case "Cyclamen": flowers1.comboBox1.Text = "Циклама"; break;

                case "Gerbera": flowers1.comboBox1.Text = "Гербер"; break;

                case "Geranium": flowers1.comboBox1.Text = "Мушкато"; break;

                default:
                    break;
            }
        }

        public void languageTranslaterToEnglishForFlowersText()
        {
            switch (flowers1.comboBox1.Text)
            {
                case "Иглика":
                    flowers1.pictureBox1.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Primrose flowers are suitable for use in garden beds and borders as well as in containers or for naturalizing areas of the lawn. In fact, when given the proper growing conditions, these vigorous plants will multiply each year, adding stunning colors to the landscape.";
                    break;
                case "Primrose":
                    flowers1.pictureBox1.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Primrose flowers are suitable for use in garden beds and borders as well as in containers or for naturalizing areas of the lawn. In fact, when given the proper growing conditions, these vigorous plants will multiply each year, adding stunning colors to the landscape.";
                    break;
                case "Каланхое":
                    flowers1.pictureBox2.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "The genus Kalanchoe includes more than 100 plants, but only a few are regularly seen in cultivation. Kalanchoes are native to arid areas, and they are popular succulents. Modern hybrids are valued for their interesting leaf-forms or for their flowers."; 
                    break;
                case "Kalanchoe":
                    flowers1.pictureBox2.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "The genus Kalanchoe includes more than 100 plants, but only a few are regularly seen in cultivation. Kalanchoes are native to arid areas, and they are popular succulents. Modern hybrids are valued for their interesting leaf-forms or for their flowers.";
                    break;
                case "Теменуга":
                    flowers1.pictureBox3.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "There are over 500 different species of violas and they are easy to care for. Most of the violas cultivated in gardens are grown as annuals or short-lived perennials. Many will self-seed and give you years of delight. Violas are primarily cool-season bloomers."; 
                    break;
                case "Viola":
                    flowers1.pictureBox3.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "There are over 500 different species of violas and they are easy to care for. Most of the violas cultivated in gardens are grown as annuals or short-lived perennials. Many will self-seed and give you years of delight. Violas are primarily cool-season bloomers."; 
                    break;
                case "Гербер":
                    flowers1.pictureBox4.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Gerbera is a genus of the family of sunflowers, Daisies and Asters - Asteraceae, with a wide distribution from Africa to Madagascar, tropical Asia and South America. Through hybridization, Gerberas are available in a massive array of colors."; 
                    break;
                case "Gerbera":
                    flowers1.pictureBox4.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Gerbera is a genus of the family of sunflowers, Daisies and Asters - Asteraceae, with a wide distribution from Africa to Madagascar, tropical Asia and South America. Through hybridization, Gerberas are available in a massive array of colors.";
                    break;
                case "Циклама":
                    flowers1.pictureBox5.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Cyclamen is a small but diverse genus of plants. It is a tuberous perennial with heart-shaped leaves and flowers in shades of pink, red, or white. Even the foliage is attractive, often having silver marbling on the top sides of the leaves.";
                    break;
                case "Cyclamen":
                    flowers1.pictureBox5.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Cyclamen is a small but diverse genus of plants. It is a tuberous perennial with heart-shaped leaves and flowers in shades of pink, red, or white. Even the foliage is attractive, often having silver marbling on the top sides of the leaves.";
                    break;
                case "Мушкато":
                    flowers1.pictureBox6.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Geraniums make popular bedding plants in the garden, but they’re also commonly grown indoors or outside in hanging baskets. Growing geranium plants is easy as long as you can give them what they need.";
                    break;
                case "Geranium":
                    flowers1.pictureBox6.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Geraniums make popular bedding plants in the garden, but they’re also commonly grown indoors or outside in hanging baskets. Growing geranium plants is easy as long as you can give them what they need.";
                    break;

                default:
                    break;
            }
        }

        public void languageTraslaterToBulgarianForFlowersText()
        {
            switch (flowers1.comboBox1.Text)
            {
                case "Primrose":
                    flowers1.pictureBox1.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "С разнообразната си цветна палитра, игликата е колоритно градинско цвете.Игликата произхожда от умерените зони на северното полукълбо. В България са известни 8 вида иглики в диво състояние, като 4 от тях са защитени от Закона за биологичното разнообразие."; 
                    break;
                case "Иглика":
                    flowers1.pictureBox1.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "С разнообразната си цветна палитра, игликата е колоритно градинско цвете.Игликата произхожда от умерените зони на северното полукълбо. В България са известни 8 вида иглики в диво състояние, като 4 от тях са защитени от Закона за биологичното разнообразие.";
                    break;
                case "Kalanchoe":
                    flowers1.pictureBox2.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Каланхоето е много красиво и разнообразно на багри цвете, което може да ни радва с красотата си през дългите зимни дни, а и не само тогава. Произхожда от тропиците на Африка и Азия и остров Мадагаскар. Цветовете на каланхоето са изключително нежни и красиви."; 
                    break;
                case "Каланхое":
                    flowers1.pictureBox2.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Каланхоето е много красиво и разнообразно на багри цвете, което може да ни радва с красотата си през дългите зимни дни, а и не само тогава. Произхожда от тропиците на Африка и Азия и остров Мадагаскар. Цветовете на каланхоето са изключително нежни и красиви."; 
                    break;
                case "Viola":
                    flowers1.pictureBox3.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Още от ерата на Романтизма теменугата покорява женското сърце със своята деликатност, нежност, изящни цветове в наситени розови, карминеночервени, цикламени тонове и неоспорима красота. Днес тя е изящна декорация за откритите тревни площи и за домашния балкон."; 
                    break;
                case "Теменуга":
                    flowers1.pictureBox3.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Още от ерата на Романтизма теменугата покорява женското сърце със своята деликатност, нежност, изящни цветове в наситени розови, карминеночервени, цикламени тонове и неоспорима красота. Днес тя е изящна декорация за откритите тревни площи и за домашния балкон.";
                    break;
                case "Gerbera":
                    flowers1.pictureBox4.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Герберът е многогодишно вечнозелено растение. Среща в Южна Африка, но има представители и в Индия, Австралия и Мадагаскар. Изящни цветове, разположени на дълги дръжки, които не увяхват цели седмици, великолепни багри – идеално цвете, достойно да украси всеки дом.";
                    break;
                case "Гербер":
                    flowers1.pictureBox4.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Герберът е многогодишно вечнозелено растение. Среща в Южна Африка, но има представители и в Индия, Австралия и Мадагаскар. Изящни цветове, разположени на дълги дръжки, които не увяхват цели седмици, великолепни багри – идеално цвете, достойно да украси всеки дом."; 
                    break;
                case "Cyclamen":
                    flowers1.pictureBox5.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Цикламата, родом от Мала Азия, е известна с ароматните си, кадифено меки, изящни цветове в наситени розови, карминеночервени, цикламени тонове. У нас в диво състояние се среща по северните склонове на Стара планина. Предпочита хладни и засенчени терени.";
                    break;
                case "Циклама":
                    flowers1.pictureBox5.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Цикламата, родом от Мала Азия, е известна с ароматните си, кадифено меки, изящни цветове в наситени розови, карминеночервени, цикламени тонове. У нас в диво състояние се среща по северните склонове на Стара планина. Предпочита хладни и засенчени терени.";
                    break;
                case "Geranium":
                    flowers1.pictureBox6.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Мушкато – любимо растение на много цветари, идеално за отглеждане в домашни условия. Освен с красиви  и ярки цветове, мушкатото има свойство да пречиства въздуха от бактерии, а уханието му повдига настроението. Предпочита хладни и засенчени места.";
                    break;
                case "Мушкато":
                    flowers1.pictureBox6.BringToFront();
                    flowers1.panel2.Visible = true;
                    flowers1.button2.Visible = true;
                    flowers1.label3.Text = "Мушкато – любимо растение на много цветари, идеално за отглеждане в домашни условия. Освен с красиви  и ярки цветове, мушкатото има свойство да пречиства въздуха от бактерии, а уханието му повдига настроението. Предпочита хладни и засенчени места.";
                    break;
                default:
                    break;
            }
        }

        public void languageTranslaterToEnglishForTips()
        {
            switch (tips1.textBox1.Text)
            {
                case "Иглика":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Primrose like places with more sunlight in the spring, but in the summer direct rays can kill it. If you are growing it outdoors, choose a place with a changing shadow.";
                    tips1.TemperatureText.Text = "Prefers a moderate temperature but also tolerates heat. In winter, degrees should be within 41-50°F (5-10°C), and in summer up to 82.4°F (28°C), maximum 86°F (30°C) degrees.";
                    tips1.SoilText.Text = "Primrose likes soil rich in humus. To give more color, you can feed it 1-2 times a month with mineral fertilizers. If you are looking at it outdoors, be sure to cover it with peat moss to protect it in winter.";
                    tips1.FertilizationText.Text = "Fertilization of primrose is done with caution because they are sensitive to some salts and lack thereof. Fertilizers containing iron are suitable.";
                    tips1.Transplanting.Text = "Transplanting";
                    tips1.TransplantingText.Text = "You can transplant the primrose after the period of active flowering is over, and it is desirable to provide the plant with a more shady place during the first 24 hours after grafting until it becomes accustomed to your new home.";
                    break;
                case "Primrose":
                    tips1.LocationAndSunlight.Visible = true;
                    tips1.Temperature.Visible = true;
                    tips1.Soil.Visible = true;
                    tips1.Fertilization.Visible = true;
                    tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Primrose like places with more sunlight in the spring, but in the summer direct rays can kill it. If you are growing it outdoors, choose a place with a changing shadow.";
                    tips1.TemperatureText.Text = "Prefers a moderate temperature but also tolerates heat. In winter, degrees should be within 41-50°F (5-10°C), and in summer up to 82.4°F (28°C), maximum 86°F (30°C) degrees.";
                    tips1.SoilText.Text = "Primrose likes soil rich in humus. To give more color, you can feed it 1-2 times a month with mineral fertilizers. If you are looking at it outdoors, be sure to cover it with peat moss to protect it in winter.";
                    tips1.FertilizationText.Text = "Fertilization of primrose is done with caution because they are sensitive to some salts and lack thereof. Fertilizers containing iron are suitable.";
                    tips1.Transplanting.Text = "Transplanting";
                    tips1.TransplantingText.Text = "You can transplant the primrose after the period of active flowering is over, and it is desirable to provide the plant with a more shady place during the first 24 hours after grafting until it becomes accustomed to your new home.";
                    break;
                case "Каланхое":
                    tips1.LocationAndSunlight.Visible = true;
                    tips1.Temperature.Visible = true;
                    tips1.Soil.Visible = true;
                    tips1.Fertilization.Visible = true;
                    tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Kalanchoe is a light-loving plant, so it is advisable to provide it with about 8 hours of sunlight a day. But because it is also a plant on a short day, it can withstand even more shady places, but it will not bloom as much.";
                    tips1.TemperatureText.Text = "Kalancho likes to keep him warm. It is nice that temperatures do not drop by 62-68.6°F (17-20°C). Prefers a humid climate, but thrives in temperate, too.";
                    tips1.SoilText.Text = "Kalanchoe is not a capricious plant, so it is made up of ordinary soil mix. It is desirable to fertilize about 3 times a month with mineral fertilizers as it sometimes suffers from a deficiency of trace elements such as zinc or calcium.";
                    tips1.FertilizationText.Text = "To grow well, you can also nourish the soil with egg shells or by watering the plant with some fresh milk. After the appearance of flower buds, it is good to stop fertilizing.";
                    tips1.Transplanting.Text = "Reproduction";
                    tips1.TransplantingText.Text = "Kalanchoea is propagated by cuttings or seeds, but outside it must be relatively warm. The plant is transplanted in spring.";
                    break;
                case "Kalanchoe":
                    tips1.LocationAndSunlight.Visible = true;
                    tips1.Temperature.Visible = true;
                    tips1.Soil.Visible = true;
                    tips1.Fertilization.Visible = true;
                    tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Kalanchoe is a light-loving plant, so it is advisable to provide it with about 8 hours of sunlight a day. But because it is also a plant on a short day, it can withstand even more shady places, but it will not bloom as much.";
                    tips1.TemperatureText.Text = "Kalancho likes to keep him warm. It is nice that temperatures do not drop by 62-68.6°F (17-20°C). Prefers a humid climate, but thrives in temperate, too.";
                    tips1.SoilText.Text = "Kalanchoe is not a capricious plant, so it is made up of ordinary soil mix. It is desirable to fertilize about 3 times a month with mineral fertilizers as it sometimes suffers from a deficiency of trace elements such as zinc or calcium.";
                    tips1.FertilizationText.Text = "To grow well, you can also nourish the soil with egg shells or by watering the plant with some fresh milk. After the appearance of flower buds, it is good to stop fertilizing.";
                    tips1.Transplanting.Text = "Reproduction";
                    tips1.TransplantingText.Text = "Kalanchoea is propagated by cuttings or seeds, but outside it must be relatively warm. The plant is transplanted in spring.";
                    break;
                case "Теменуга":
                    tips1.LocationAndSunlight.Visible = true;
                    tips1.Temperature.Visible = true;
                    tips1.Soil.Visible = true;
                    tips1.Fertilization.Visible = true;
                    tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "The location should be chosen relatively light but with a light shade. This means that the continuous impact of sunlight on the flowers can lead to their drying and death.";
                    tips1.TemperatureText.Text = "Since violet is particularly hardy, it will resist winder colds very well, even down to 5°F (-15°C) and max 68°F (20°C) .";
                    tips1.SoilText.Text = "Provide soil that is quite rich and well drained for beautiful blooming. But ordinary garden soil is fine, too.";
                    tips1.FertilizationText.Text = "To feed the flowers is just compost, no more fertilizer is required. For longer flowering, faded buds should be removed immediately.";
                    tips1.Transplanting.Text = "Pests";
                    tips1.TransplantingText.Text = "The pests are snails and aphids. Aphids should be removed immediately with an appropriate detergent, otherwise you risk the three-colored violet becoming infected, the leaves and yellowing and the flowers growing with anomalies.";
                    break;
                case "Viola":
                    tips1.LocationAndSunlight.Visible = true;
                    tips1.Temperature.Visible = true;
                    tips1.Soil.Visible = true;
                    tips1.Fertilization.Visible = true;
                    tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "The location should be chosen relatively light but with a light shade. This means that the continuous impact of sunlight on the flowers can lead to their drying and death.";
                    tips1.TemperatureText.Text = "Since violet is particularly hardy, it will resist winder colds very well, even down to 5°F (-15°C) and max 68°F (20°C) .";
                    tips1.SoilText.Text = "Provide soil that is quite rich and well drained for beautiful blooming. But ordinary garden soil is fine, too.";
                    tips1.FertilizationText.Text = "To feed the flowers is just compost, no more fertilizer is required. For longer flowering, faded buds should be removed immediately.";
                    tips1.Transplanting.Text = "Pests";
                    tips1.Text = "The pests are snails and aphids. Aphids should be removed immediately with an appropriate detergent, otherwise you risk the three-colored violet becoming infected, the leaves and yellowing and the flowers growing with anomalies.";
                    break;
                case "Гербер":
                    tips1.LocationAndSunlight.Visible = true;
                    tips1.Temperature.Visible = true;
                    tips1.Soil.Visible = true;
                    tips1.Fertilization.Visible = true;
                    tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "This is the most important condition of the flower. To grow healthy and beautiful, the flower needs a spot with direct light to keep it warm throughout the day. Even the slightest shading may not bear it. The plant loves warm places and direct sunlight, but becomes ill if it is flowing.";
                    tips1.TemperatureText.Text = "In winter, do not leave the flower in a room where the temperature drops below 15°C.";
                    tips1.SoilText.Text = "You can grow gerberas in a pot in ordinary garden soil or in a mixture of sand, peat and leaflet. It is important that the soil is well drained, light and must not have compost.";
                    tips1.FertilizationText.Text = "In the spring and summer, be sure to fertilize the gerbera regularly - preferably with phosphorous fertilizer or fertilizer rich in manganese and iron.";
                    tips1.Transplanting.Text = "Pests";
                    tips1.TransplantingText.Text = "Gerberas are often attacked by mites, whitefly, caterpillars, aphids and thrips, and are also affected by fungi. Watch the leaves of the flower - if they change their dark color, then something is missing from the plant. ";
                    break;
                case "Gerbera":
                    tips1.LocationAndSunlight.Visible = true;
                    tips1.Temperature.Visible = true;
                    tips1.Soil.Visible = true;
                    tips1.Fertilization.Visible = true;
                    tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "This is the most important condition of the flower. To grow healthy and beautiful, the flower needs a spot with direct light to keep it warm throughout the day. Even the slightest shading may not bear it. The plant loves warm places and direct sunlight, but becomes ill if it is flowing.";
                    tips1.TemperatureText.Text = "In winter, do not leave the flower in a room where the temperature drops below 15°C.";
                    tips1.SoilText.Text = "You can grow gerberas in a pot in ordinary garden soil or in a mixture of sand, peat and leaflet. It is important that the soil is well drained, light and must not have compost.";
                    tips1.FertilizationText.Text = "In the spring and summer, be sure to fertilize the gerbera regularly - preferably with phosphorous fertilizer or fertilizer rich in manganese and iron.";
                    tips1.Transplanting.Text = "Pests";
                    tips1.TransplantingText.Text = "Gerberas are often attacked by mites, whitefly, caterpillars, aphids and thrips, and are also affected by fungi. Watch the leaves of the flower - if they change their dark color, then something is missing from the plant. ";
                    break;
                case "Циклама":
                    tips1.LocationAndSunlight.Visible = true;
                    tips1.Temperature.Visible = true;
                    tips1.Soil.Visible = true;
                    tips1.Fertilization.Visible = true;
                    tips1.Transplanting.Visible = true;
                    tips1.Text = "The cyclamen does not like too much sunlight. Premises with a lack of sunlight, facing north are preferred by the flower.";
                    tips1.TemperatureText.Text = "Feels good at 10-15°C Celsius. At temperatures above 20°C, the plant is doomed to die.";
                    tips1.Text = "Use a peat-soil mixture of guaranteed origin.";
                    tips1.FertilizationText.Text = "Cyclamen feeds on fertilizer regularly. May-September should not be fertilized. When the leaf rosette is developed and visible signs of flowering are used, phosphorus fertilizer is used to feed";
                    tips1.Transplanting.Text = "WARNING";
                    tips1.TransplantingText.Text = "After the first buds appear, the pot should not be moved because they will drip.\n After yellowing and dropping the leaves of the cyclamen, the pots are placed in a dark and cool place.";
                    break;
                case "Cyclamen":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.Text = "The cyclamen does not like too much sunlight. Premises with a lack of sunlight, facing north are preferred by the flower.";
                    tips1.TemperatureText.Text = "Feels good at 10-15°C Celsius. At temperatures above 20°C, the plant is doomed to die.";
                    tips1.Text = "Use a peat-soil mixture of guaranteed origin.";
                    tips1.FertilizationText.Text = "Cyclamen feeds on fertilizer regularly. May-September should not be fertilized. When the leaf rosette is developed and visible signs of flowering are used, phosphorus fertilizer is used to feed";
                    tips1.Transplanting.Text = "WARNING";
                    tips1.TransplantingText.Text = "After the first buds appear, the pot should not be moved because they will drip.\n After yellowing and dropping the leaves of the cyclamen, the pots are placed in a dark and cool place.";
                    break;
                case "Мушкато":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Geranium loves a lot of sunlight, in good light it will grow well and enjoy beautiful and abundant colors, and the leaves will be healthy and juicy. In winter, it is also good to have extra light from artificial sources";
                    tips1.TemperatureText.Text = "During the period of growth and flowering, the geranium feels most comfortable at 68-77°F (20-25°C). The optimum temperature for the winter season is 53.6-59°F (12-15°C)";
                    tips1.SoilText.Text = "It is best for the geranium to be planted in mixed soil (garden soil, sand and fertilizer). It must be well drained and not retain water.";
                    tips1.FertilizationText.Text = "The geranium should be nourished twice or thrice a month, cleaned from the blooms and received plenty of light";
                    tips1.Transplanting.Text = "Reproduction";
                    tips1.TransplantingText.Text = "Spring is the perfect time for seedling seedlings. To do this, take a few cuttings and let them wilt for a few hours before stitching them to a new place.";
                    break;
                case "Geranium":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Geranium loves a lot of sunlight, in good light it will grow well and enjoy beautiful and abundant colors, and the leaves will be healthy and juicy. In winter, it is also good to have extra light from artificial sources";
                    tips1.TemperatureText.Text = "During the period of growth and flowering, the geranium feels most comfortable at 68-77°F (20-25°C). The optimum temperature for the winter season is 53.6-59°F (12-15°C)";
                    tips1.SoilText.Text = "It is best for the geranium to be planted in mixed soil (garden soil, sand and fertilizer). It must be well drained and not retain water.";
                    tips1.FertilizationText.Text = "The geranium should be nourished twice or thrice a month, cleaned from the blooms and received plenty of light";
                    tips1.Transplanting.Text = "Reproduction";
                    tips1.TransplantingText.Text = "Spring is the perfect time for seedling seedlings. To do this, take a few cuttings and let them wilt for a few hours before stitching them to a new place.";
                    break;

                default:
                    break;
            }

        }

        public void languageTraslaterToBulgarianForTips()
        {
            switch (tips1.textBox1.Text)
            {
                case "Primrose":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Игликата харесва места с повече слънчева светлина през пролетта, но през лятото  преките лъчи могат да я убият. Ако я отглеждате на открито, изберете място с шарена сянка.";
                    tips1.TemperatureText.Text = "Предпочита умерената температура, но понася и топлината. През зимата градусите трябва да са в рамките на 5-10°C, а през лятото до 28°C, максимум 30°C.";
                    tips1.SoilText.Text = "Игликата харесва почва, богата на хумус. За да дава повече цвят, може 1-2 пъти в месеца да я подхранвате с минерални торове. Ако пък я гледате на открито, задължително я покрийте с торфен мъх, за да я предпазите през зимата.";
                    tips1.FertilizationText.Text = "Подхранването на игликите се прави с повишено внимание, защото са чувствителни към някои соли, както и към липсата на такива. Подходящи са торовете, съдържащи желязо.";
                    tips1.Transplanting.Text = "Пресаждане";
                    tips1.TransplantingText.Text = "Може да пресадите примулата след като приключи периода на активен цъфтеж, като първите 24 часа след присаждане е желателно да осигурите на растението по-сенчесто място, докато свикне с новия си дом.";
                    break;
                case "Иглика":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Игликата харесва места с повече слънчева светлина през пролетта, но през лятото  преките лъчи могат да я убият. Ако я отглеждате на открито, изберете място с шарена сянка.";
                    tips1.TemperatureText.Text = "Предпочита умерената температура, но понася и топлината. През зимата градусите трябва да са в рамките на 5-10°C, а през лятото до 28°C, максимум 30°C.";
                    tips1.SoilText.Text = "Игликата харесва почва, богата на хумус. За да дава повече цвят, може 1-2 пъти в месеца да я подхранвате с минерални торове. Ако пък я гледате на открито, задължително я покрийте с торфен мъх, за да я предпазите през зимата.";
                    tips1.FertilizationText.Text = "Подхранването на игликите се прави с повишено внимание, защото са чувствителни към някои соли, както и към липсата на такива. Подходящи са торовете, съдържащи желязо.";
                    tips1.Transplanting.Text = "Пресаждане";
                    tips1.TransplantingText.Text = "Може да пресадите примулата след като приключи периода на активен цъфтеж, като първите 24 часа след присаждане е желателно да осигурите на растението по-сенчесто място, докато свикне с новия си дом.";
                    break;
                case "Kalanchoe":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.Text = "Каланхоето е светлолюбиво растение, затова е желателно да му осигурявате около 8 часа светлина дневно. Но тъй като е и растение на късия ден, то може да издържа и на по-сенчести места, само че няма да цъфти толкова обилно.";
                    tips1.TemperatureText.Text = "Каланхоето обича да му е топло. Хубаво е температурите да не падат по 17-20°C. Предпочита по-влажен климат, но вирее и на умерен.";
                    tips1.SoilText.Text = "Каланхоето не е капризно растение, затова го устройва обикновена почвена смес. Желателно е да се тори около 3 пъти месечно с минерални торове, тъй като понякога страда от недостиг на микроелементи като цинк или калций.";
                    tips1.FertilizationText.Text = "За да расте здраво, можете също да подхранвате почвата с черупки от яйце или като поливате растението с малко прясно мляко. След появата на цветни пъпки е добре да спрете торенето.";
                    tips1.Transplanting.Text = "Размножаване";
                    tips1.TransplantingText.Text = "Каланхоете се размножава с помощта на резници или семена, но навън трябва да е сравнително топло. Растението се пресажда на пролет.";
                    break;
                case "Каланхое":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.Text = "Каланхоето е светлолюбиво растение, затова е желателно да му осигурявате около 8 часа светлина дневно. Но тъй като е и растение на късия ден, то може да издържа и на по-сенчести места, само че няма да цъфти толкова обилно.";
                    tips1.TemperatureText.Text = "Каланхоето обича да му е топло. Хубаво е температурите да не падат по 17-20°C. Предпочита по-влажен климат, но вирее и на умерен.";
                    tips1.SoilText.Text = "Каланхоето не е капризно растение, затова го устройва обикновена почвена смес. Желателно е да се тори около 3 пъти месечно с минерални торове, тъй като понякога страда от недостиг на микроелементи като цинк или калций.";
                    tips1.FertilizationText.Text = "За да расте здраво, можете също да подхранвате почвата с черупки от яйце или като поливате растението с малко прясно мляко. След появата на цветни пъпки е добре да спрете торенето.";
                    tips1.Transplanting.Text = "Размножаване";
                    tips1.TransplantingText.Text = "Каланхоете се размножава с помощта на резници или семена, но навън трябва да е сравнително топло. Растението се пресажда на пролет.";
                    break;
                case "Viola":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Мястото трябва да бъде избрано сравнително светло, но с лека сянка. Това означава, че непрекъснатият удар на слънчева светлина върху цветята може да доведе до тяхното изсъхване и смърт.";
                    tips1.TemperatureText.Text = "Тъй като теменугата е особено издръжлива, тя ще устои много добре на простудни студове, дори до -15°C и издържа до топлина 20°C.";
                    tips1.SoilText.Text = "Осигурете почва, която е добре изцедена и богата на минерали за красив цъфтеж. Но обикновената градинска почва също не е лош избор добре.";
                    tips1.FertilizationText.Text = "За да се хранят цветята е само компост, не се изисква повече тор. За по-дълъг цъфтеж избледнените пъпки трябва да бъдат отстранени незабавно.";
                    tips1.Transplanting.Text = "Вредители";
                    tips1.TransplantingText.Text = "Вредителите са охлюви и листни въшки. Листните въшки трябва да се отстранят веднага с подходящ препарат, в противен случай рискувате трицветната теменуга да се зарази, листата и да пожълтеят и цветчетата да растат с аномалии.";
                    break;
                case "Теменуга":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Мястото трябва да бъде избрано сравнително светло, но с лека сянка. Това означава, че непрекъснатият удар на слънчева светлина върху цветята може да доведе до тяхното изсъхване и смърт.";
                    tips1.TemperatureText.Text = "Тъй като теменугата е особено издръжлива, тя ще устои много добре на простудни студове, дори до -15°C и издържа до топлина 20°C.";
                    tips1.SoilText.Text = "Осигурете почва, която е добре изцедена и богата на минерали за красив цъфтеж. Но обикновената градинска почва също не е лош избор добре.";
                    tips1.FertilizationText.Text = "За да се хранят цветята е само компост, не се изисква повече тор. За по-дълъг цъфтеж избледнените пъпки трябва да бъдат отстранени незабавно.";
                    tips1.Transplanting.Text = "Вредители";
                    tips1.TransplantingText.Text = "Вредителите са охлюви и листни въшки. Листните въшки трябва да се отстранят веднага с подходящ препарат, в противен случай рискувате трицветната теменуга да се зарази, листата и да пожълтеят и цветчетата да растат с аномалии.";
                    break;
                case "Gerbera":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Това е най-важното условие на цветето. За да расте здраво и красиво, цветето се нуждае от място с пряка светлина, която да го огрява през целия ден. И най-малкото засенчване може да не му понесе. Растението обича топлите места и преките слънчеви лъчи, но се разболява, ако е на течение.";
                    tips1.TemperatureText.Text = "През зимата не оставяйте цветето в стая, където температурата пада под 15°C.";
                    tips1.SoilText.Text = "Гербер в саксия може да си отгледате в обикновена градинска пръст или в смес от пясък, торф и листовка. Важно е почвата да е добре дренирана, да е лека и задължително да няма компост.";
                    tips1.FertilizationText.Text = "През пролетта и лятото задължително наторявайте гербера редовно – за предпочитане с фосфорна тор или тор, богата на манган и желязо.";
                    tips1.Text = "Вредители";
                    tips1.TransplantingText.Text = "Герберите често са нападани от акари, белокрилка, гъсеници, листни въшки и трипс, разболяват се и от гъбички. Наблюдавайте листата на цветето – ако променят тъмния си цвят, значи нещо не достига на растението.";
                    break;
                case "Гербер":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Това е най-важното условие на цветето. За да расте здраво и красиво, цветето се нуждае от място с пряка светлина, която да го огрява през целия ден. И най-малкото засенчване може да не му понесе. Растението обича топлите места и преките слънчеви лъчи, но се разболява, ако е на течение.";
                    tips1.TemperatureText.Text = "През зимата не оставяйте цветето в стая, където температурата пада под 15°C.";
                    tips1.SoilText.Text = "Гербер в саксия може да си отгледате в обикновена градинска пръст или в смес от пясък, торф и листовка. Важно е почвата да е добре дренирана, да е лека и задължително да няма компост.";
                    tips1.FertilizationText.Text = "През пролетта и лятото задължително наторявайте гербера редовно – за предпочитане с фосфорна тор или тор, богата на манган и желязо.";
                    tips1.Text = "Вредители";
                    tips1.TransplantingText.Text = "Герберите често са нападани от акари, белокрилка, гъсеници, листни въшки и трипс, разболяват се и от гъбички. Наблюдавайте листата на цветето – ако променят тъмния си цвят, значи нещо не достига на растението.";
                    break;
                case "Cyclamen":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Цикламата не обича прекалените слънчеви лъчи. Помещения с недостиг на слънчева светлина, със северно изложение са предпочитани от цветето.";
                    tips1.TemperatureText.Text = "Чувства се добре при температури 10-15°C. При температура над 20°C, растението е обречено на смърт.";
                    tips1.SoilText.Text = "Използвайте торфо-почвена смес с гарантиран произход.";
                    tips1.FertilizationText.Text = "Цикламата се подхранва с тор редовно. През май-септември не трябва да се наторява. При развита листна розетка и видими признаци на цъфтеж се използва фосфорен тор за подхранване.";
                    tips1.Transplanting.Text = "ВНИМАНИЕ";
                    tips1.TransplantingText.Text = "След появата на първите пъпки саксията не бива да се премества, защото те ще окапят. След като пожълтеят и окапят листата на цикламата, саксиите се поставят на тъмно и прохладно място.";
                    break;
                case "Циклама":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Цикламата не обича прекалените слънчеви лъчи. Помещения с недостиг на слънчева светлина, със северно изложение са предпочитани от цветето.";
                    tips1.TemperatureText.Text = "Чувства се добре при температури 10-15°C. При температура над 20°C, растението е обречено на смърт.";
                    tips1.SoilText.Text = "Използвайте торфо-почвена смес с гарантиран произход.";
                    tips1.FertilizationText.Text = "Цикламата се подхранва с тор редовно. През май-септември не трябва да се наторява. При развита листна розетка и видими признаци на цъфтеж се използва фосфорен тор за подхранване.";
                    tips1.Transplanting.Text = "ВНИМАНИЕ";
                    tips1.TransplantingText.Text = "След появата на първите пъпки саксията не бива да се премества, защото те ще окапят. След като пожълтеят и окапят листата на цикламата, саксиите се поставят на тъмно и прохладно място.";
                    break;
                case "Мушкато":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Мушкатото обича много светлина, при хубаво осветление то ще се развива добре и ще ви радва с красиви и обилни цветове, а листата ще бъдат здрави и сочни. През зимата е добре да има и допълнителна светлина от изкуствени източници. ";
                    tips1.TemperatureText.Text = "В период на растеж и цъфтене мушкатото се чувства най-комфортно при температура 20-25 °C. Оптималната температура за зимния сезон е 12°C - 15°C.";
                    tips1.SoilText.Text = "Най-добре за мушкатото е да бъде посадено в смесена почва (градинска пръст, пясък и тор). Трябва добре да се оттича и да не задържа вода.";
                    tips1.FertilizationText.Text = "Мушкатото трябва да се подхранва два-три пъти месечно, да се очиства от прецъфтелите цветове и да получава много светлина.";
                    tips1.Transplanting.Text = "Размножаване";
                    tips1.TransplantingText.Text = "Пролетта е идеалното време за разсад на мушкато. За целта отделете няколко резници и ги оставете за няколко часа да завехнат преди да ги боднете на ново място.";
                    break;
                case "Geranium":
                    tips1.LocationAndSunlight.Visible = true; tips1.Temperature.Visible = true; tips1.Soil.Visible = true; tips1.Fertilization.Visible = true; tips1.Transplanting.Visible = true;
                    tips1.LocationAndSunlightText.Text = "Мушкатото обича много светлина, при хубаво осветление то ще се развива добре и ще ви радва с красиви и обилни цветове, а листата ще бъдат здрави и сочни. През зимата е добре да има и допълнителна светлина от изкуствени източници. ";
                    tips1.TemperatureText.Text = "В период на растеж и цъфтене мушкатото се чувства най-комфортно при температура 20-25 °C. Оптималната температура за зимния сезон е 12°C - 15°C.";
                    tips1.SoilText.Text = "Най-добре за мушкатото е да бъде посадено в смесена почва (градинска пръст, пясък и тор). Трябва добре да се оттича и да не задържа вода.";
                    tips1.FertilizationText.Text = "Мушкатото трябва да се подхранва два-три пъти месечно, да се очиства от прецъфтелите цветове и да получава много светлина.";
                    tips1.Transplanting.Text = "Размножаване";
                    tips1.TransplantingText.Text = "Пролетта е идеалното време за разсад на мушкато. За целта отделете няколко резници и ги оставете за няколко часа да завехнат преди да ги боднете на ново място.";
                    break;

                default:
                    break;
            }
        }
       
    }
}
