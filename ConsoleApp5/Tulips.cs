﻿using ConsoleApp5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Tulips : Flowers, ITulips
    {
        public string type;
        public double price;
        public DateTime dataPost;

        public override string Type
        {
            get { return "Mr/Ms. " + type; }
            set { type = value; }
        }

        public override double Price
        {
            get
            {
                if (price > 0) return price;
                else throw new Exception("price < 0");
            }
            set { price = value; }
        }

        public override DateTime DataPost
        {
            get { return dataPost; }
            set { dataPost = DateTime.Now; }
        }
    }
}