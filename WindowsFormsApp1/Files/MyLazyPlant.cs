using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.EnglishVersion;

namespace WindowsFormsApp1.EnglishVersion
{
    public partial class MyLazyPlant : UserControl
    {

        public MyLazyPlant()
        {
            InitializeComponent();
        }

        public void got_info()
        {

            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            textBox1.Visible = false;

            switch (textBox1.Text)
            {
                case "Иглика":
                    pictureBox1.BringToFront();
                    pictureBox1.Visible = true;
                    break;

                case "Primrose":
                    pictureBox1.BringToFront();
                    pictureBox1.Visible = true;
                    break;

                case "Каланхое":
                    pictureBox2.BringToFront();
                    pictureBox2.Visible = true;
                    break;

                case "Kalanchoe":
                    pictureBox2.BringToFront();
                    pictureBox2.Visible = true;
                    break;

                case "Теменуга":
                    pictureBox3.BringToFront();
                    pictureBox3.Visible = true;
                    break;

                case "Viola":
                    pictureBox3.BringToFront();
                    pictureBox3.Visible = true;
                    break;

                case "Гербер":
                    pictureBox4.BringToFront();
                    pictureBox4.Visible = true;
                    break;

                case "Gerbera":
                    pictureBox4.BringToFront();
                    pictureBox4.Visible = true;
                    break;

                case "Циклама":
                    pictureBox5.BringToFront();
                    pictureBox5.Visible = true;
                    break;

                case "Cyclamen":
                    pictureBox5.BringToFront();
                    pictureBox5.Visible = true;
                    break;

                case "Мушкато":
                    pictureBox6.BringToFront();
                    pictureBox6.Visible = true;
                    break;

                case "Geranium":
                    pictureBox6.BringToFront();
                    pictureBox6.Visible = true;
                    break;

                default:
                    break;
            }
            pictureBox7.BringToFront();
            pictureBox8.BringToFront();
            label1.BringToFront();
        }

        public void MyFlowerTalk()
        {
            label1.Visible = true;
        }

        public void TalkBulgarian()
        {
            List<string> BulgarianQuotes = new List<string>();
            BulgarianQuotes.Add("Можеш да отрежеш всички цветя, " + Environment.NewLine + "но не можеш да спреш пролетта! " + Environment.NewLine + "~ Пабло Неруда");
            BulgarianQuotes.Add("Една роза може да е моята градина. " + Environment.NewLine + "Един приятел – моят свят. " + Environment.NewLine + "~ Лио Бускалия");
            BulgarianQuotes.Add("Само живеенето не стига, " + Environment.NewLine + "човек трябва да има слънце, " + Environment.NewLine + "свобода и малко цветя. " + Environment.NewLine + "~ Ханс Кристиан Андерсен");
            BulgarianQuotes.Add("Вместо да се ядосвам, " + Environment.NewLine + "че розата има шипове, аз се радвам на това, " + Environment.NewLine + "че наред с шиповете расте и роза. " + Environment.NewLine + "~ Жозеф Жубер");
            BulgarianQuotes.Add("От едно цвете не можеш " + Environment.NewLine + "да направиш венец. " + Environment.NewLine + "~ Джордж Хърбърт");
            BulgarianQuotes.Add("Ще научиш, че човек сам " + Environment.NewLine + "трябва да поддържа собствената си градина " + Environment.NewLine + "и украсява душата си, вместо да чака " + Environment.NewLine + "някой друг да му подари цветя. " + Environment.NewLine + "~ Хорхе Луис Борхес");
            BulgarianQuotes.Add("Цветя - това са мисли " + Environment.NewLine + "на природата за любовта. " + Environment.NewLine + "~ Бетина фон Армин");
            BulgarianQuotes.Add("Времето, което си изгубил за твоята роза, " + Environment.NewLine + "я прави толкова важна. " + Environment.NewLine + "~ Антоан Сейнт - Екзюпери");
            BulgarianQuotes.Add("В живота има моменти, " + Environment.NewLine + "в които розата е по-важна от къса хляб. " + Environment.NewLine + "~ Райнер Мария Рилке");
            BulgarianQuotes.Add("В цветята има повече живот, " + Environment.NewLine + "отколкото в книгите. " + Environment.NewLine + "~ Марсел Пруст");
            BulgarianQuotes.Add("Винаги имай в библиотеката си нова книга, " + Environment.NewLine + "в избата – пълно буре, " + Environment.NewLine + "в градината – свежо цвете. " + Environment.NewLine + "~ Епикур");
            BulgarianQuotes.Add("При розите има бодли. " + Environment.NewLine + "- Оръжие поставено на показ от неувереност. " + Environment.NewLine + "~ Вадим Панов");
            BulgarianQuotes.Add("... пътя на човека, спасяващ света, " + Environment.NewLine + "съвсем не е осеян с рози. " + Environment.NewLine + "~ Върнър Виндж");
            BulgarianQuotes.Add("...нашият разум е като цвете, " + Environment.NewLine + "което трябва да има корени в богатата почва " + Environment.NewLine + "на миналото. " + Environment.NewLine + "~ Робърт Шекли");
            BulgarianQuotes.Add("В радост или тъга цветята " + Environment.NewLine + "са нашите постоянни приятели. " + Environment.NewLine + "~ Какудзо Окакура");
            BulgarianQuotes.Add("Всяка роза е автограф от " + Environment.NewLine + "ръката на Всемогъщият Бог. " + Environment.NewLine + "~ Теодор Паркър");
            BulgarianQuotes.Add("Като цяло, е хубаво, когато имате " + Environment.NewLine + "време да спрете и да подушите розите... " + Environment.NewLine + "~ Джоан Харис");
            var random = new Random();
            int index = random.Next(BulgarianQuotes.Count);
            label1.BackColor = Color.Transparent;
            label1.Text = BulgarianQuotes[index];
        }

        public void TalkEnglish()
        {
            List<string> EnglishQuotes = new List<string>();
            EnglishQuotes.Add("Love is the flower " + Environment.NewLine + "you’ve got to let grow." + Environment.NewLine + "~ John Lennon");
            EnglishQuotes.Add("Flowers… are a proud assertion " + Environment.NewLine + "that a ray of beauty out values " + Environment.NewLine + "all the utilities in the world." + Environment.NewLine + "~ Ralph Waldo Emerson ");
            EnglishQuotes.Add("Flowers don’t tell, " + Environment.NewLine + "they show." + Environment.NewLine + "~ Stephanie Skeem");
            EnglishQuotes.Add("Flowers are like friends; " + Environment.NewLine + "They bring color to your world." + Environment.NewLine + "~ Unknown");
            EnglishQuotes.Add("Earth laughs in flowers." + Environment.NewLine + "~ Ralph Waldo Emerson");
            EnglishQuotes.Add("Butterflies are self propelled flowers." + Environment.NewLine + "~ Robert A.Heinlein");
            EnglishQuotes.Add("A flower blossoms for its own joy." + Environment.NewLine + "~ Oscar Wilde ");
            EnglishQuotes.Add("...  who wants flowers when youre dead? " + Environment.NewLine + "nobody." + Environment.NewLine + "~ J.D.Salinger");
            EnglishQuotes.Add("The violets in the mountains " + Environment.NewLine + "have broken the rocks." + Environment.NewLine + "~ Tennessee Williams");
            EnglishQuotes.Add("In joy or sadness, " + Environment.NewLine + "flowers are our constant friends." + Environment.NewLine + "~ Okakura Kakuzo");
            EnglishQuotes.Add("Perfumes are the feelings of flowers." + Environment.NewLine + "~ Heinrich Heine");
            EnglishQuotes.Add("Butterflies are not insects, " + Environment.NewLine + "Captain John Sterling said soberly. " + Environment.NewLine + "They are self-propelled flowers." + Environment.NewLine + "~ Robert A.Heinlein");
            EnglishQuotes.Add("Pick a flower on Earth " + Environment.NewLine + "and you move the farthest star." + Environment.NewLine + "~ Paul A.M.Dirac");
            EnglishQuotes.Add("I have lost my smile, " + Environment.NewLine + "but don't worry. " + Environment.NewLine + "The dandelion has it." + Environment.NewLine + "~ Thich Nhat Hanh");
            EnglishQuotes.Add("Everyone mourns the first blossom. " + Environment.NewLine + "Who will grieve the rest who fall ?" + Environment.NewLine + "~ Leigh Bardugo");
            EnglishQuotes.Add("Lord, make me now " + Environment.NewLine + "As happy as the field. " + Environment.NewLine + "With flowers enriched..." + Environment.NewLine + "~ Eileen Soper");
            EnglishQuotes.Add("Flowers always make people better, " + Environment.NewLine + "happier, and more helpful; " + Environment.NewLine + "they are sunshine, " + Environment.NewLine + "food and medicine to the mind." + Environment.NewLine + "~ Luther Burbank ");
            EnglishQuotes.Add("Flowers are " + Environment.NewLine + "the Romeos and the Juliets of the nature!" + Environment.NewLine + "~ Mehmet Murat ildan ");
            EnglishQuotes.Add("Flowers were meant " + Environment.NewLine + "to give love and be loved. " + Environment.NewLine + "~ Anthony T.Hincks ");
            var random = new Random();
            int index = random.Next(EnglishQuotes.Count);
            label1.Text = EnglishQuotes[index]; 
        }

        public void move()
        {
            List<PictureBox> images = new List<PictureBox>();
            images.Add(pictureBox9);
            images.Add(pictureBox10);
            foreach (var im in images)
            {
                im.Visible = false;
            }
            var random = new Random();
            int index = random.Next(images.Count);
            images[index].Visible = true;
            images[index].BringToFront();
        }

        private void MyLazyPlant_Load(object sender, EventArgs e)
        {
        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
