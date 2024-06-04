using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme12Pr4
{
    /// <summary>
    /// Класс, описывающий фигуру
    /// </summary>
    class Figures
    {
        /// <summary>
        /// Поле названия фигуры
        /// </summary>
        public string name;
        /// <summary>
        /// Поле значения стороны1 фигуры
        /// </summary>
        public int side1;
        /// <summary>
        /// Поле значения стороны2 фигуры
        /// </summary>
        public int side2;
        /// <summary>
        /// Поле значения стороны3 фигуры
        /// </summary>
        public int side3;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Figures() 
        {
            name = "Квадрат";
            side1 = 5;
        }
        /// <summary>
        /// Конструктор с тремя параметрчми
        /// </summary>
        /// <param name="name">название фигуры</param>
        /// <param name="side1">сторона1 фигуры</param>
        /// <param name="side2">сторона2 фигуры</param>
        public Figures(string name, int side1, int side2)
        {
            this.name = name;
            this.side1 = side1;
            this.side2 = side2;
        }
        /// <summary>
        /// Мето вывода инфорации о квадрате
        /// </summary>
        /// <returns></returns>
        public string ShowInfo1()
        {
            return $"Название фигуры - {name}\tСторона 1 = {side1} см";
        }
        /// <summary>
        /// Метод вычисления периметра и площади квадрата
        /// </summary>
        /// <returns>сторона1</returns>
        public string PandS1()
        {
            return $"Периметр фигуры - {side1 * 4}\tПлощадь фигуры - {side1 * side1}";
        }
        /// <summary>
        /// Метод вывода информации о прямоугольнике
        /// </summary>
        /// <returns>название,сторона1,сторона2 фигуры</returns>
        public string ShowInfo2()
        {
            return $"Название фигуры - {name}\tСторона 1 = {side1} см\tСторона 2 = {side2} см";
        }
        /// <summary>
        /// Метод вычисления периметра и площади прямоугольника
        /// </summary>
        /// <returns>сторона1,сторона2 фигуры</returns>
        public string PandS2()
        {
            return $"Периметр фигуры - {(side1 + side2)*2}\tПлощадь фигуры - {side1 * side2}";
        }
        /// <summary>
        /// Конструктор с четырьмя параметрами
        /// </summary>
        /// <param name="name">название фигуры</param>
        /// <param name="side1">сторона1 фигуры</param>
        /// <param name="side2">сторона2 фигуры</param>
        /// <param name="side3">сторона3 фигуры</param>
        public Figures(string name, int side1, int side2, int side3):
            this(name,side1,side2)
        {
            this.side3 = side3;
        }
        /// <summary>
        /// Метод вывода информации о треугольнике
        /// </summary>
        /// <returns>название,сторона1,сторона2,сторона3 фигуры</returns>
        public string ShowInfo3()
        {
            return $"Название фигуры - {name}\tСторона 1 = {side1} см\tСторона 2 = {side2} см\tСторона 3 = {side3}";
        }
        /// <summary>
        /// Метод вычисления периметра и площади треугольника
        /// </summary>
        /// <returns>сторона1,сторона2,сторона3 фигуры</returns>
        public string PandS3()
        {
            int p = (side1 + side2 + side3) / 2;
            return $"Периметр фигуры - {side1 + side2 + side3}\tПлощадь фигуры - {p*(p-side1)*(p-side2)*(p-side3)}";
        }


    }
}
