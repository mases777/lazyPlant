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
    public partial class AboutUs : UserControl
    {
        public AboutUs()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel3.Visible = false;
                panel4.Visible = false;
                NameEmre.Visible = false;
                InfoEmre.Visible = false;
                AgeEmre.Visible = false;
                GraduateEmre.Visible = false;
                GoalsEmre.Visible = false;
                ContactWithMeEmre.Visible = false;
                textBox1ContactWithMeEmreText.Visible = false;
                panel1.Visible = true;
                panel2.Visible = true;
                NameAnna.Visible = true;
                ContactWithMeAnnaText.Visible = true;
                InfoAnna.Visible = true;
                AgeAnna.Visible = true;
                GraduateAnna.Visible = true;
                GoalsAnna.Visible = true;
                ContactWithMeAnna.Visible = true;
                ContactWithMeAnnaText.Visible = true;
            }
            else if (panel1.Visible == true)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                NameAnna.Visible = false;
                InfoAnna.Visible = false;
                AgeAnna.Visible = false;
                GraduateAnna.Visible = false;
                GoalsAnna.Visible = false;
                ContactWithMeAnna.Visible = false;
                ContactWithMeAnnaText.Visible = false;

            }
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                NameAnna.Visible = false;
                InfoAnna.Visible = false;
                AgeAnna.Visible = false;
                GraduateAnna.Visible = false;
                GoalsAnna.Visible = false;
                ContactWithMeAnna.Visible = false;
                ContactWithMeAnnaText.Visible = false;
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                NameAnna.Visible = false;
                ContactWithMeAnnaText.Visible = false;
                InfoAnna.Visible = false;
                AgeAnna.Visible = false;
                GraduateAnna.Visible = false;
                GoalsAnna.Visible = false;
                ContactWithMeAnna.Visible = false;
                ContactWithMeAnnaText.Visible = false;
                panel3.Visible = true;
                panel4.Visible = true;
                NameEmre.Visible = true;
                InfoEmre.Visible = true;
                AgeEmre.Visible = true;
                GraduateEmre.Visible = true;
                GoalsEmre.Visible = true;
                ContactWithMeEmre.Visible = true;
                textBox1ContactWithMeEmreText.Visible = true;
            }
            else if (panel3.Visible == true)
            {
                panel3.Visible = false;
                panel4.Visible = false;
                NameEmre.Visible = false;
                InfoEmre.Visible = false;
                AgeEmre.Visible = false;
                GraduateEmre.Visible = false;
                GoalsEmre.Visible = false;
                ContactWithMeEmre.Visible = false;
                textBox1ContactWithMeEmreText.Visible = false;
            }
            

        }

        private void panel3_Click(object sender, EventArgs e)
        {

            panel3.Visible = false;
            panel4.Visible = false;
            NameEmre.Visible = false;
            InfoEmre.Visible = false;
            AgeEmre.Visible = false;
            GraduateEmre.Visible = false;
            GoalsEmre.Visible = false;
            ContactWithMeEmre.Visible = false;
            textBox1ContactWithMeEmreText.Visible = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
