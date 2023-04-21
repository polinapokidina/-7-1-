using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file1.Filter = "(*.jpg)|*.jpg";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //Создаем переменную fname строкового типа
            string fname;

            //Открываем проводник;
            file1.ShowDialog();

            //Используем переменную для хранения имени выбранного файла
            fname = file1.FileName;

            //Загружаем файл в элемент PictureBox
            pct.Image = Image.FromFile(fname);

            //Заполнения текстового поля полным именем файла
            txtName.Text = fname;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFile1.FileName = file1.SafeFileName;
            saveFile1.ShowDialog();
            pct.Image.Save(saveFile1.FileName);

        }
    }
}
