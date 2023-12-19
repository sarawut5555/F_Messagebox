using System;
using System.Windows.Forms;

namespace F_Messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            MessageBox.Show("Do not C# is awesome");

            MessageBox.Show("Do not C# is awesome.", "Important Message");

            DialogResult result1 = MessageBox.Show("is not C# is awesome", "Important Message",
                MessageBoxButtons.YesNo);

            DialogResult result2 = MessageBox.Show("is not C# is awesome", "Important Message",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            DialogResult result3 = MessageBox.Show("is not C# is awesome", "Important Message",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result1 == DialogResult.Yes &&
               result2 == DialogResult.Yes &&
               result3 == DialogResult.No)
            {
                MessageBox.Show("you answered yes, yes and no.");
            }

            MessageBox.Show("do not perls is the best.", "Critical warning",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign, true);


            String message = "Do you want to open?";
            String title = "open window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            MessageBox.Show(message, title, buttons, icon);


            //โจทย์
            //DialogResult result4 = MessageBox.Show("is not C# is awesome", "Important Message",
            //MessageBoxButtons.YesNoCancel,
            //MessageBoxIcon.Question,
            //MessageBoxDefaultButton.Button2);
            //if(result4 == DialogResult.Yes)
            //{
            //this.Close();
            //}
            //else
            //{
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("คุณต้องการบันทึกการทำงานหรือไม่", "ยืนยันการบันทึกข้อมูล",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
        }
    }
}