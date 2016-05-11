using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1MPR
{

    public partial class Form1 : Form
    {

        private ServerCard dataServerCard = new ServerCard();

        public Form1()
        {
            InitializeComponent();
        }

        //Открыть тектовый файл
        private void OpenFile(object sender, EventArgs e)
        {
            /*------------------------------------------ПЕРЕМЕННЫЕ----------------------------------------------- */
            List<String[]> dataTextFile = new List<String[]>();       // Лист для считывания данных по категориям //
            String readLine;                                          // Перменная для считывания строки файла    //                                           
            bool read = false;                                        // True, когда надо начать считывать в Лист //
            /*----------------------------------------------------------------------------------------------------*/

            /*-------------------------------Получаем данные из файл и заполняем БД-------------------------------*/ 

            //Открываем текстовый файл с данными о серверных платах
            System.IO.StreamReader textFile = new System.IO.StreamReader(@"file.txt", Encoding.GetEncoding(1251));
            
            //Цикл для построчного считывания данных из файл из загрузки в лист массивов 
            while ((readLine = textFile.ReadLine()) != null){

                //Флаг определяющий, что начались строки с нужными данными
                //Заполняем объект класса ServerCard данными
                if (read)                                  
                    dataServerCard.AppendRecord(readLine); 

                //Если встретилась данная строка, со следующей нужные данные
                if (readLine.Equals("Серверные платы:"))  
                    read = true;
            }

            /*------------------------------------------Заполняем таблицу данн-------------------------------------*/
            
            // Очищаем строки в таблице
            tableData.Rows.Clear();

            // Получаем данные из базы
            dataTextFile = dataServerCard.GetListRecords();

            // Заполняем таблицу данными
            foreach (String[] row in dataTextFile){
                tableData.Rows.Add(row);
                tableData.Rows[tableData.Rows.Count-1].HeaderCell.Value = tableData.Rows.Count.ToString();
            }


        }
    }
}
