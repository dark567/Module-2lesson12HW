﻿using ConsoleApp5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Carnations : Flowers, ICarnations
    {
        private string type;
        private double price;
        private int count;
        private DateTime dataPost;

        public static List<Carnations> _modelCarnations;

        static Carnations() => _modelCarnations = new List<Carnations>();

        public Carnations(string _type, double _price, int _count, DateTime? _dataPost)
        {
            this.type = _type;
            this.price = _price;
            this.count = _count;
            this.dataPost = _dataPost ?? DateTime.Now;
        }

        public override string Type
        {
            get => "Carnations: " + type;
            set => type = value ?? throw new ArgumentNullException(nameof(value), "type cannot be null");
        }

        public override double Price
        {
            get => price > 0 ? price: throw new Exception("price < 0");
            set => price = value;
        }

        public override DateTime DataPost
        {
            get => dataPost;
            set => dataPost = DateTime.Now;
        }

        public override int Count
        {

            get => count > 0 ? count : throw new Exception("count < 0");
            set => count = value;
        }

        public void Propolka()
        {
            Console.WriteLine("Propolka");
        }
    }
}
