using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1MPR
{
    //Класс для хранения данных о серверных платах
    class ServerCard
    {
        /*------------------------------------------Переменные---------------------------------------------------*/
        private List<String[]> listCard;         // Лист, который хранит строковые мыссивы характеристик о плате //
        private List<int[]> listCharacteristic;  // Лист, который хранит интовые массива хар. о плате            //
        /*-------------------------------------------------------------------------------------------------------*/

        /*------------------------------------------Конструкторы-------------------------------------------------*/

        //Конструктор по умолчанию
        public ServerCard()
        {
            listCard = new List<String[]>();
            listCharacteristic = new List<int[]>();
        }
        
        /*----------------------------------------------Методы---------------------------------------------------*/

        /* 
        ** Разбивает передаваемую строку на массив характеристи, добавляет в listCard и listCharacteristic
        ** in[String] - строка считаная из файла, которая хранит информацию о плате
        ** Пример: Название|Кол-во сокетов|Кол-во слотов расширения памяти...
        ** ...|Максимальный объем опретивной памяти, ГБ|Кол-во слотов для расширения карт|Цена
        */
        public void AppendRecord(String strDataCard)
        {
            // Переменная для хранения каждой из характеристик отдельными строками
            String[] dataStringCharacteristics = new String[6];
            int[] dataIntCharacteristics = new int[5];

            // Разбиваем на строковые характеристики и добавляем в listCard
            dataStringCharacteristics = strDataCard.Split('|');
            listCard.Add(dataStringCharacteristics);
            
            // Преобразуем числовые значения, которые хранятся стрингами, преобразуем в инт
            for(int i = 1; i < 6; i++)
                dataIntCharacteristics[i-1] = Int32.Parse(dataStringCharacteristics[i]);

            // Добавляем преобразованные данные в лист интов
            listCharacteristic.Add(dataIntCharacteristics);
        }

        //Метод возвращет лист с данными о серверной плате
        public List<String[]> GetStringList()
        {
            return listCard;
        }

        public List<int[]> GetIntList()
        {
            return listCharacteristic;
        }





    }
}
