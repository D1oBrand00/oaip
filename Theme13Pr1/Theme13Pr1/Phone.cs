using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme13Pr1
{
    /// <summary>
    /// Класс, описывающий телефон
    /// </summary>
    class Phone
    {
        /// <summary>
        /// Поле названия производителя
        /// </summary>
        public string name;
        /// <summary>
        /// Поле название модели 
        /// </summary>
        public string model;
        /// <summary>
        /// Поле значения цены телефона
        /// </summary>
        public int cost;

        /// <summary>
        /// Конструктор без параметров 
        /// </summary>
        public Phone()
        {
            this.name = "Ipoh";
            

        }

        /// <summary>
        /// Конструктор с одним параметром 
        /// </summary>
        /// <param name="name">название проз-ля</param>
        public Phone(string name)                                        
        {
            this.name = name;
        }
        /// <summary>
        /// Конструктор с двумя параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="model"></param>
        public Phone(string name, string model) : 
            this( name)
        {
            this.model = model; ;                                                                     
        }
        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="model"></param>
        /// <param name="cost"></param>
        public Phone(string name, string model,int cost) :
            this(name,model)
        {
            this.cost=cost; ;
        }
        /// <summary>
        /// Метод вывода информации о телефоне
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Name - {name}\nModel - {model}\nCost - {cost}$";
        }

        
        
    }
}
