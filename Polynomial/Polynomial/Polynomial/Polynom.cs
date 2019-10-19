//-----------------------------------------------------------------------
// <copyright file="Polynom.cs" company="EPAM">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Zhenis Duissekov</author>
//-----------------------------------------------------------------------

namespace Polynom
{
    using System;

    /// <summary>
    /// Polynom class set size and set array
    /// </summary>
    public class Polynom : SystemException
    {
        private int n;
        private double[] array;

        /// <summary>
        /// sets size
        /// and sets array of zeros
        /// </summary>
        /// <param name="a"></param>
        public Polynom(int a)
        {
            Console.Write("q");
            SetN = a;
            Console.Write("q");
            Console.Write(a);
            SetArray = new double[a];
            Console.Write("q");
        }

        /// <summary>
        /// sets size and values of array
        /// </summary>
        /// <param name="b"></param>
        public Polynom(params double[] b)
        {
            SetN = b.Length;
            SetArray = b;
        }

        /// <summary>
        /// sets N
        /// </summary>
        public int SetN
        {
            set
            {
                n = value;
            }
        }

        /// <summary>
        /// returns the n
        /// </summary>
        public int GetN
        {
            get
            {
                return n;
            }
        }

        /// <summary>
        /// sets the array of coeff(initializes them)
        /// </summary>
        public double[] SetArray
        {
            set => array = (double[])value.Clone();
        }

        /// <summary>
        /// returns an array of coeff
        /// </summary>
        public double[] GetArray
        {
            get
            {
                return array;
            }
        }

        /// <summary>
        /// gets the size of polynom
        /// </summary>
        /// <returns>returns the size</returns>
        public int GetPolynomSize()
        {
            return this.GetN;
        }

        /// <summary>
        /// this method overrides general method Equals from Object
        /// and checks if two polynoms are equal
        /// </summary>
        /// <returns>boolean for equal or not</returns>
        public override bool Equals(object obj)
        {
              if (obj == null || GetType() != obj.GetType()) return false;
              Polynom p = (Polynom)obj;
              return (n == p.n);
        }
        

        /// <summary>
        /// method that uses coefficients and power to create a string of polynomial
        /// </summary>
        /// <returns>string polynomial</returns>
        public string OutputPolynom()
        {
            double EPSILON = 0.0001;
            string str = string.Empty;
            string str_pow = string.Empty;
            string str_coef = string.Empty;
            int i = this.GetArray.Length - 1;
            foreach (var element in this.GetArray)
            {
                if (i > 1)
                {
                    str_pow = "X^" + Convert.ToString(i);
                }

                if (i == 1)
                {
                    str_pow = "X";
                }

                if (i == 0)
                {
                    str_pow = string.Empty;
                }

                if (Math.Abs(element) < EPSILON)
                {
                    str_coef = string.Empty;
                    str_pow = string.Empty;
                }
                else if (Math.Abs(element - 1) < EPSILON)
                {
                    if (i == this.GetArray.Length - 1)
                    {
                        str_coef = string.Empty;
                    }
                    else if (i == 0)
                    {
                        str_coef = "+1";
                    }
                    else
                    {
                        str_coef = "+";
                    }
                }
                else if (Math.Abs(element - -1) < EPSILON)
                {
                    if (i == this.GetArray.Length - 1)
                    {
                        str_coef = "-";
                    }
                    else if (i == 0)
                    {
                        str_coef = "-1";
                    }
                    else
                    {
                        str_coef = "-";
                    }
                }
                else if ((element > 1) && (i != this.GetArray.Length - 1))
                {
                    str_coef = "+" + Convert.ToString(element);
                }
                else
                {
                    str_coef = Convert.ToString(element);
                }

                str = str + str_coef + str_pow;
                i--;
            }

            return str;
        }

        public void SubtractPolynom(Polynom a, Polynom b)
        {
            int a_size = a.array.Length;
            int b_size = b.array.Length;
            int max_size = (a_size > b_size) ? a_size : b_size;
            Polynom result = new Polynom(max_size);
        }

        public void AddPolynom(Polynom a, Polynom b)
        {
            throw new NotImplementedException();
        }
    }
}
