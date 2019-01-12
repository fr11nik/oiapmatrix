using System;
using System.Drawing;
using System.Windows.Forms;

namespace matrix
{
    public partial class Form1 : Form
    {
        Random R = new Random();
        DataGridView dg; //Создание траблицы
        
        private int Order { get; set; } //Порядок матрицы
        Specification spec = new Specification(); //Инициализация класса
        public Form1()
        {
            InitializeComponent();
            dg = new DataGridView(); //Инициализация таблицы
           
            
        }

        private void textBox1_Click(object sender, EventArgs e) => textBox1.Text = ""; //При нажатии обнулять текст

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Order matrix
                Order = int.Parse(textBox1.Text);
            }
            catch (Exception ex) { MessageBox.Show($"Error:{ex.Message}"); }
            //Matrix settings
            spec.Settings(dg, 101, 180, Order, Order);

            //Add matrix
            Controls.Add(dg);
            
            
            int count = 0; //Счетчик нечетных элементов
            for (int j = 0; j < Order; j++)
            {               
                for (int i1 = 0; i1 < Order; i1++)
                {
                    dg[j, i1].Value = R.Next(1,25);  //Заполнение матрицы                   
                }                             
            }            
            bool check;
            
            
            for (int j = 0; j < Order; j++)
            {
                check = true;      //Проверяем значения столбца при помощи bool переменной
                for (int i = 1; i < Order; i++)
                {
                    if ((int)dg[j, i].Value < (int)dg[j, i-1].Value)  
                        //Если предыдущее значение больше мы переходим к другому столбцу
                    {
                        check = false;                       
                        break;                        
                    }
                    
                }
                //Если наша проверка под конец осталась true мы увелич счетчик
                if (check)
                {
                    count++;
                    
                }
            }         
            label2.Text = $"Найти количество столбцов, элементы которых \n упорядочены по убыванию {count}";
            if (count!=0)
            {
                
                MessageBox.Show("s");
            }
       }
        
             
    }
}
                                                                   
                
                     
        
    


