using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Акатова;
using WindowsFormsApp6;

namespace WindowsFormsApp6
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }
        private void FormParent_Load(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            label2.Text = FormAutorization.Enter_User.First_Name + " " + FormAutorization.Enter_User.Second_Name;
            label3.Text = model.Roles.First(x => x.ID == FormAutorization.Enter_User.RoleID).Name;
            pictureBox1.Image = Image.FromFile(@"Photo\" + FormAutorization.Enter_User.Pictures);
        }

        private void FormManager_Load(object sender, EventArgs e)
        {

        }
    }
}