﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Client
    {
        public static void Execute()
        {
            Order order;

            order = new Order(new HondaFactory(), nameof(ISedan), "compact");
            Console.WriteLine(order.ManufacturedCarName());

            var toyota = new ToyotaFactory();
            order = new Order(toyota, nameof(ISedan), "compact");
            Console.WriteLine(order.ManufacturedCarName());


            order = new Order(toyota, nameof(ISuv), "full");
            Console.WriteLine(order.ManufacturedCarName());

        }
    }
}
