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

        /*----------------------------------------Переменные--------------------------------------------------*/
        private ServerCard dataServerCard = new ServerCard();         //Объект класса серверных карт          //
                                                                                                              //
        /*---------------------------Ключи, для словаря важности критериев------------------------------------*/
        private String COUNT_SOCKETS = "count_sockets";               // Кол-во скокетов                      //
        private String COUNT_SLOT_MEM = "count_slot_memory";          // Кол-во слотов для расширения памяти  //
        private String MAX_MEMORY = "max_memory";                     // Максимальная память                  //
        private String COUNT_SLOT_FOR_CARD = "count_slot_for_card";   // Кол-во слотов для карт расширения    //
        private String PRICE = "price";                               // Цена                                 //
        /*----------------------------------------------------------------------------------------------------*/

        public Form1()
        {
            InitializeComponent();
        }

        /*-------------------------------Методы и реакция на действие пользователей--------------------------------*/


        /* 
        ** Метод для обработки всех альтернатив
        ** [in] List <int[]> - Массив характеристи в формате Int
        ** [in] Dictionary<String, int> - Словарь, который хранит важность каждого из критериев
        ** [out] List <List<int>>
        */
        private List<List<int>> DataProcessing(List<int[]> characteristics, Dictionary<String, int> importance)
        {
            List<List<int>> listLevelOfQuality = new List<List<int>>();
            List<int> listLevelOfQualityAdtv = new List<int>();
            List<int> listLevelOfQualityMltpl = new List<int>();

            //Переменные для оценки критериев
            int ratingCountSockets = 0;    // Кол-во сокетов
            int ratingCountSlotMem = 0;    // Кол-во слотов расширения памяти
            int ratingMaxMem = 0;          // Кол-во максимальной памяти
            int ratingCountSlotCard = 0;   // Кол-во слотов для карт расширения
            int ratingPrice = 0;           // Цена


            // Выполняем расчет для каждой из альтернатив
            foreach(int[] value in characteristics)
            {
                /*-------Даем оценку каждому из критериев--------*/
                
                //Кол-во сокетов
                if (value[0] == 1)
                    ratingCountSockets = 3;
                else if (value[0] > 1)
                    ratingCountSockets = 5;

                // Кол-во слотов для расширения памяти
                if (value[1] < 2)
                    ratingCountSlotMem = 1;
                else if (value[1] >= 2 && value[1] < 4)
                    ratingCountSlotMem = 3;
                else if (value[1] == 4)
                    ratingCountSlotMem = 4;
                else if (value[1] > 4)
                    ratingCountSlotMem = 5;

                // Максимальная память(оперативная)
                if (value[2] >= 4 && value[2] <= 8)
                    ratingMaxMem = 1;
                else if (value[2] > 8 && value[2] <= 16)
                    ratingMaxMem = 3;
                else if (value[2] > 16 && value[2] <= 32)
                    ratingMaxMem = 4;
                else if (value[2] > 32)
                    ratingMaxMem = 5;

                // Кол-во слотов для карт расширения
                if (value[3] >= 1 && value[3] <= 2)
                    ratingCountSlotCard = 2;
                else if (value[3] == 3)
                    ratingCountSlotCard = 3;
                else if (value[3] == 4)
                    ratingCountSlotCard = 4;
                else if (value[3] > 4)
                    ratingCountSlotCard = 5;

                // Цена
                if (value[4] < 14000)
                    ratingPrice = 5;
                else if (value[4] > 14000 && value[4] < 14500)
                    ratingPrice = 4;
                else if (value[4] >= 14500 && value[4] < 15500)
                    ratingPrice = 3;
                else if (value[4] >= 15500 && value[4] < 16000)
                    ratingPrice = 2;
                else if (value[4] >= 16000 && value[4] < 16500)
                    ratingPrice = 1;

                // Получаем показатель качества альтернативы c помощью аддитивной свертки
                int levelOfQuality = (ratingCountSockets * importance[COUNT_SOCKETS]) + (ratingCountSlotMem * importance[COUNT_SLOT_MEM])
                    + (ratingMaxMem * importance[MAX_MEMORY]) + (ratingCountSlotCard * importance[COUNT_SLOT_FOR_CARD])
                    + (ratingPrice * importance[PRICE]);
                // Добавляем в лист, в котором храняться показатели после аддитивной свертки
                listLevelOfQualityAdtv.Add(levelOfQuality);

                // Получаем показатель качества алтернативы с помощью мультипликативной свертки
                levelOfQuality = (ratingCountSockets * importance[COUNT_SOCKETS]) * (ratingCountSlotMem * importance[COUNT_SLOT_MEM])
                    * (ratingMaxMem * importance[MAX_MEMORY]) * (ratingCountSlotCard * importance[COUNT_SLOT_FOR_CARD])
                    * (ratingPrice * importance[PRICE]);
                // Добавляем в лист, в котором храняться показатели после мультипликативной свертки
                listLevelOfQualityMltpl.Add(levelOfQuality);
            }

            //Добавляем заполненые лист в аутлист
            listLevelOfQuality.Add(listLevelOfQualityAdtv);
            listLevelOfQuality.Add(listLevelOfQualityMltpl);

            return listLevelOfQuality;
        }

        /*
        ** Выбор лучшей альтернативы с ипользование аддитивной и мультипликативной свертки
        ** [in] - объект класса ServerCard, из которого будут получены данные для расчета
        */
        private void SelectBestAlternative(ServerCard serverCard)
        {
            /*---------------------------------------Переменные-----------------------------------------------------------*/
            Dictionary<String, int> dictionaryImportance = new Dictionary<string, int>(); // Важность критериев           //
            List<List<int>> listLevelOfQuality = new List<List<int>>();  // Лист с листами, в которых показатели важности //
            /*------------------------------------------------------------------------------------------------------------*/

            /*-----------------------Получаем важность критериев установленных пользователем--------------------------------*/
            dictionaryImportance.Add(COUNT_SOCKETS, (int)numUpDSocket.Value);          //Кол-во сокетов                     //
            dictionaryImportance.Add(COUNT_SLOT_MEM, (int)numUpDSlotMem.Value);        //Кол-во слотов для расширения памяти//
            dictionaryImportance.Add(MAX_MEMORY, (int)numUpDMaxMem.Value);             //Максимальная память                //
            dictionaryImportance.Add(COUNT_SLOT_FOR_CARD, (int)numUpDSlotCard.Value);  //Кол-во слотов для карт расширения  //
            dictionaryImportance.Add(PRICE, (int)numUpDPrice.Value);                   //Цена                               //
            /*--------------------------------------------------------------------------------------------------------------*/

            //Получаем данные
            listLevelOfQuality = DataProcessing(serverCard.GetIntList(), dictionaryImportance);
            int bestNumAdtv = -1;
            int bestNumMltpl = -1;
            int positionBestAdtv = -1;
            int positionBestMltp = -1;
            for (int i = 0; i < listLevelOfQuality.Count; i++)
            {
                
                for (int j = 0; j < listLevelOfQuality[i].Count; j++)
                {
                    if ((listLevelOfQuality[i][j] > bestNumAdtv || bestNumAdtv == -1) && i == 0)
                    {
                        bestNumAdtv = listLevelOfQuality[i][j];
                        positionBestAdtv = j;
                    }
                    else if ((listLevelOfQuality[i][j] > bestNumMltpl || bestNumMltpl == -1) && i == 1)
                    {
                        bestNumMltpl = listLevelOfQuality[i][j];
                        positionBestMltp = j;
                    }                   
                }
            }

            txtBoxOutPut.AppendText("Лучшая альтернатива при аддитивной свертке: " + "(" + (positionBestAdtv + 1) + ") " + serverCard.GetStringList()[positionBestAdtv][0]);
            txtBoxOutPut.AppendText("\nЛучшая альтернатива при мультипликативной свертке: " + "(" + (positionBestMltp + 1) + ") " + serverCard.GetStringList()[positionBestMltp][0] + "\n\n");



        }

        /*
        ** Обработка нажатия на ToolStrip, - открыть файл. 
        */
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
            dataTextFile = dataServerCard.GetStringList();

            // Заполняем таблицу данными
            foreach (String[] row in dataTextFile){
                tableData.Rows.Add(row);
                tableData.Rows[tableData.Rows.Count-1].HeaderCell.Value = tableData.Rows.Count.ToString();
            }
        }

        //Нажетие на кнопку "Решать"
        private void SolutionClick(object sender, EventArgs e)
        {
            
            if(tableData.Rows.Count == 0) //Данные с информацией об альтернативах не заргружены
                MessageBox.Show("Загрузите данные", "Ошибка", MessageBoxButtons.OK);
            else  //Данные есть, решаем
            {
                SelectBestAlternative(dataServerCard);
            }
           

        }
    }
}
