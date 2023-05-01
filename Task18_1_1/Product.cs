﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18_1_1
{
    public class Product
    {
        private string _type;

        // составные части
        private Dictionary<string, string> _parts = new Dictionary<string, string>();
        /// <summary>
        ///  Метод - конструктор
        /// </summary>
        public Product(string type)
        {
            _type = type;
        }
        // Индексатор
        public string this[string key]
        {
            set
            {
                _parts[key] = value;
            }
        }
        /// <summary>
        /// Метод для получения информации о продукте
        /// </summary>
        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"Вид транспортного средства: {_type}");
            Console.WriteLine($" Рама : {_parts["frame"]}");
            Console.WriteLine($" Двигатель : {_parts["engine"]}");
            Console.WriteLine($" Колеся: {_parts["wheels"]}");
            Console.WriteLine($" Двери : {_parts["doors"]}");
        }
    }
}
