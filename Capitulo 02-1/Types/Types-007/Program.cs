﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_007
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.MyInstanceField = "Some New Value";
        }
    }

    public class MyClass
    {
        public string MyInstanceField;
        public string Concatenate(string valueToAppend)
        {
            return MyInstanceField + valueToAppend;
        }
    }
}
