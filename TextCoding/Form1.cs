using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TextCoding
{
    public partial class Form1 : Form
    {
        string hashValue = "";
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * Обработчик кнопки "Выполнить" 
         */
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string text = textBoxMessage.Text; //Получить исходное послание
            //Если исходное послание не пустое
            if (text.Length != 0) 
            {
                string hash = BitConverter.ToString(Sha1.Hash(Encoding.Default.GetBytes(text))); //Вычислить хэш исходного послания
                hashValue = hash;
                //Вывести хеш на экран в соответствии с настройками форматирования
                if (cbxDeleteDashes.Checked && cbxToLowCase.Checked) 
                { 
                    textBoxResult.Text = HashOutputEdit(hash, true, true);
                }
                else if (cbxDeleteDashes.Checked) 
                {
                    textBoxResult.Text = HashOutputEdit(hash, true, false);
                }
                else if (cbxToLowCase.Checked) 
                {
                    textBoxResult.Text = HashOutputEdit(hash, false, true);
                }
                else 
                {
                    textBoxResult.Text = HashOutputEdit(hash);
                }
            }
            else 
            {
                //Если исходное послание пустое - удалить текст из объекта textBoxResult  
                textBoxResult.Text = null;
            }
        }
        private void checkBox_Click(object sender, EventArgs e) 
        {
            string hash = hashValue;
            if (cbxDeleteDashes.Checked) 
            {
                 textBoxResult.Text = HashOutputEdit(textBoxResult.Text, true, false);
            }
            if (!cbxDeleteDashes.Checked) 
            {
                if (cbxToLowCase.Checked)
                {
                    textBoxResult.Text = HashOutputEdit(hash, false, true);
                }
                else
                {
                    textBoxResult.Text = hash;
                }
            }
            if (cbxToLowCase.Checked) 
            {
                 textBoxResult.Text = HashOutputEdit(textBoxResult.Text, false, true);
            }
            if (!cbxToLowCase.Checked) 
            {
                if (cbxDeleteDashes.Checked)
                {
                    textBoxResult.Text = HashOutputEdit(hash, true, false);
                }
                else 
                {
                    textBoxResult.Text = hash;
                }
            }
        }
        /*
         * Функция, настраивающая формат вывода хэша на экран
         */
        private string HashOutputEdit(string hash, bool deleteDashes = false, bool toLower = false) 
        {
            //Если не нужно удалять чёрточки в хеше и не нужно выводить хеш в нижнем регистре
            if (!deleteDashes && !toLower)
            {
                return hash; //Вернуть хеш без изменений
            }
            else
            {
                //Если необходимо удалить чёрточки из хеша
                if (deleteDashes)
                {
                    string[] charsToRemove = new string[] { "-" }; //Список удаляемых из хеша символов
                    foreach (var c in charsToRemove)
                    {
                        hash = hash.Replace(c, string.Empty); //Удалить из хеша символы, указанные в списке удаляемых символов
                    }
                }
                //Если необходимо перевести символы хеша в нижний регистр
                if (toLower) 
                {
                    hash = hash.ToLower(); //Перевести хеш в нижний регистр
                }
                return hash; //Вернуть отформатированный хеш
            }
        }
    }
}