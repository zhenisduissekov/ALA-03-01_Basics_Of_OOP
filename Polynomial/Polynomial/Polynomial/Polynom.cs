//-----------------------------------------------------------------------
// <copyright file="Polynom.cs" company="EPAM">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// while making this code, I was reading lots of webpages including this:
// https://studassistent.ru/charp/realizaciya-klassa-predstavlyayuschego-mnogochlen-c
// which heavily affect my code while redoing it properly
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
            SetN = a;   
            SetArray = new double[a];
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
        /// method that uses coefficients and power to create a string of polynomial
        /// </summary>
        /// <returns>string polynomial</returns>
        //public string OutputPolynom()
        public override string ToString()
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
            return (str == "") ? "0" : str;
        }

        public void SubtractPolynom(Polynom a, Polynom b)
        {
            int a_size = a.array.Length;
            int b_size = b.array.Length;
            int max_size = (a_size > b_size) ? a_size : b_size;
            Polynom result = new Polynom(max_size);
        }

        public static Polynom operator +(Polynom a, Polynom b)
        {
            Polynom max_polynom = (a.array.Length >= b.array.Length) ? a : b;
            Polynom min_polynom = (a.array.Length < b.array.Length) ? a : b;
            Polynom result = new Polynom(max_polynom.array);


            for (int i = 0; i < min_polynom.array.Length; i++)
            {
                result.array[max_polynom.array.Length - min_polynom.array.Length + i] = min_polynom.array[i] + max_polynom.array[max_polynom.array.Length - min_polynom.array.Length + i];
            }
            return result;
        }

        public static Polynom operator -(Polynom a, Polynom b)
        {
            Polynom max_polynom = (a.array.Length >= b.array.Length) ? a : b;
            Polynom min_polynom = (a.array.Length < b.array.Length) ? a : b;
            if (max_polynom == b)
            {
                max_polynom *= -1;
            }
            else
            {
                min_polynom *= -1;
            }

            Polynom result = min_polynom + max_polynom;

            return result;
        }


        public static Polynom operator *(Polynom a, double c)
        {
            Polynom result = new Polynom(a.array);

            for (int i = 0; i< a.array.Length; i++)
            {

                result.array[i] *= c; 
            }

            return result;
        }


        public double CalculatePolynom(double x)
        {
            int len = this.array.Length - 1;
            double res = this.array[len];
            for (int i = 0; i < len; i++)
            {
                res += this.array[i] * Math.Pow(x, i); 
            }
            return res;
        }
    }
}
