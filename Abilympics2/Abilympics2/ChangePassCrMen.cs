using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abilympics2
{
    public partial class ChangePassCrMen : Form
    {
        public ChangePassCrMen()
        {
            InitializeComponent();
        }

        //закрытие формы
        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*сохранение значения пароля в переменную ChangePassCrMen 
        и переход на форму CreatorMenu*/
        private void Button1_Click(object sender, EventArgs e)
        {
            Data.ChangePassCrMen = textBox3.Text;
            Form crm = new CreatorMenu();
            Hide();
            DialogResult res = crm.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                Show();
            }
            else Close();
        }
    }
}
