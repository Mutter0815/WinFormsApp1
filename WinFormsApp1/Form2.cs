using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{

    public partial class Form2 : Form
    {
        public int[] Result = new int[10];
        int number = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            if (radioButton1.Checked) Result[number] = 1;//проверяем, какой ответ был выбран
            if (radioButton2.Checked) Result[number] = 2;
            if (radioButton3.Checked) Result[number] = 3;
            if (radioButton4.Checked) Result[number] = 4;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            number++;
            switch (number)
            {
                case 1:
                    label1.Text = "Сколько данных вы используете в месяц для интернет-серфинга и использования приложений?";
                    radioButton1.Text = "Менее 1 ГБ";
                    radioButton2.Text = "От 1 до 3 ГБ";
                    radioButton3.Text = "От 3 до 5 ГБ";
                    radioButton4.Text = "Более 5 ГБ";
                    break;
                case 2:
                    label1.Text = "Как часто вы отправляете SMS-сообщения?";
                    radioButton1.Text = "Редко или никогда";
                    radioButton2.Text = "Один или два раза в день";
                    radioButton3.Text = "От 3 до 5 раз в день";
                    radioButton4.Text = "Более 5 раз в день";
                    break;
                case 3:
                    label1.Text = "Есть ли у вас потребность в международных звонках или отправке сообщений?";
                    radioButton1.Text = "Да, я часто звоню или отправляю сообщения за границу";
                    radioButton2.Text = "Нет, я не звоню и не отправляю сообщения за границу";
                    radioButton3.Text = "Да,я звоню но не так часто";
                    radioButton4.Text = "Нет,я не звоню,но отправляю сообщения за границу";
                    break;
                case 4:
                    label1.Text = "Какие функции мобильного телефона для вас наиболее важны: скорость интернета, количество минут звонков, количество SMS-сообщений, доступ к специальным функциям (например, голосовой поиск, карты, социальные сети)?";
                    radioButton1.Text = "Скорость интернета";
                    radioButton2.Text = "Количество минут звонков";
                    radioButton3.Text = "Количество SMS-сообщений";
                    radioButton4.Text = "Доступ к специальным функциям";
                    break;
                case 5:
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    label1.Text = "Завершите опрос!";
                    button2.Text = "Завершить";
                    button1.Visible = false;
                    break;


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (number != 5)
            //{
            //    this.Close();
            //}
            //if (number == 5)
            //{
            //    var form3 = new Form3();
            //    form3.ShowDialog();
            //}


        }
    }
}
