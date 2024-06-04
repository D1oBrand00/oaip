using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme11Pr1
{
    /// <summary>
    /// Класс, описывающий адрес
    /// </summary>
    class Adress
    {
        //Задание 2. Создать класс с именем Address. В теле класса требуется создать поля: index, country, city, street, house, apartаment. Создать экземпляр класса Address. В поля экземпляра записать информацию о почтовом адресе. Выведите на экран значения полей, описывающих адрес.
        /// <summary>
        /// Поле индекса
        /// </summary>
        public ushort index;
        /// <summary>
        /// Поле названия страны
        /// </summary>
        public string country;
        /// <summary>
        /// Поле названия города
        /// </summary>
        public string city;
        /// <summary>
        /// Поле названия улицы
        /// </summary>
        public string street;
        /// <summary>
        /// Поле номера дома
        /// </summary>
        public ushort house;
        /// <summary>
        /// Поле номера квартиры
        /// </summary>
        public ushort apartament;
        /// <summary>
        /// Метод вывода информации об адресе
        /// </summary>
        /// <returns>индекс,страна,город,улица,дом,квартира</returns>
        public override string ToString()
        {
            return $"{index}\t{country}\t{city}\t\t{street}\t{house}\t{apartament}";
        }
    }
}
