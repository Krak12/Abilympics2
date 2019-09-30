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
    public partial class ChangePassSpMen : Form
    {
        public ChangePassSpMen()
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
            Data.ChangePassSpMen = textBox3.Text;
            Form spm = new SpecialistMenu();
            Hide();
            DialogResult res = spm.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                Show();
            }
            else Close();
        }
    }
}
