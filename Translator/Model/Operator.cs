﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.Model
{
   public interface IOperator
    {
        int? СomparativePriority { get; }
    }

    public class Operator : IRPNElement, IOperator
    {
        public int? СomparativePriority { get; private set; }
        public int? StackPriority { get; private set; }

        public string Sign { get; private set; }
        public Operator(string sign)
        {
            this.Sign = sign;
        }
        public Operator(string sign, int priority)
        {
            this.Sign = sign;
            this.СomparativePriority = priority;
        }

        public Operator(string sign, int comparativePriority, int stackPriority)
        {
            this.Sign = sign;
            this.СomparativePriority = comparativePriority;
            this.StackPriority = stackPriority;
        }

        public override bool Equals(object obj)
        {
            if (obj is Operator temp) return this.Sign == temp.Sign;
            return false;
        }
        public override int GetHashCode()
        {
            return Sign.GetHashCode();
        }

        public override string ToString()
        {
            return Sign;
        }




        //public static bool operator !=(Operator o1, Operator o2)
        //{
        //    if (o1.Sign == o2.Sign) return false;
        //    else return true;
        //}

        //public static bool operator ==(Operator o1,Operator o2)
        //{
        //    if (o1.Sign == o2.Sign) return true;
        //    else return false;
        //}
    }


    public class OperatorRepository
    {
        private List<Operator> items;

        public OperatorRepository()
        {
            items = new List<Operator>
            {
                new Operator("if",-1),
                new Operator("while",-1),
                new Operator("(",0),
                
                //new Operator("if",0),
                //new Operator("do",0),

               
                //new Operator("=",0),

                 new Operator(")",1),



                new Operator("¶",1),

                new Operator("or",1),
                new Operator("then",1),
                new Operator("while",1),
                new Operator("?",1),
                new Operator(":",1),
                new Operator("=",2),//todo:check is work good with and


                new Operator("[",3),
                new Operator("]",4),

                new Operator("and",5),

                new Operator("not",6),

                

                new Operator("<",7),
                new Operator(">",7),
                new Operator("<=",7),
                new Operator(">=",7),
                new Operator("==",7),
                new Operator("!=",7),

                new Operator("+",8),
                new Operator("-",8),

                new Operator("*",9),
                new Operator("/",9),


                new Operator("fi"),
                new Operator("enddo"),
                new Operator("read"),
                new Operator("write")
            };
        }

        public Operator this[string sign]=>items.FirstOrDefault(i=>i.Sign==sign);

    }
}
