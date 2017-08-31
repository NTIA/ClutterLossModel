﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUClutterLoss
{
    public class QFunction
    {
        #region Raw Data
        private static double[] RAW_X = new double[] {
            0.00,
            0.05,
            0.10,
            0.15,
            0.20,
            0.25,
            0.30,
            0.35,
            0.40,
            0.45,
            0.50,
            0.55,
            0.60,
            0.65,
            0.70,
            0.75,
            0.80,
            0.85,
            0.90,
            0.95,
            1.00,
            1.05,
            1.10,
            1.15,
            1.20,
            1.25,
            1.30,
            1.35,
            1.40,
            1.45,
            1.50,
            1.55,
            1.60,
            1.65,
            1.70,
            1.75,
            1.80,
            1.85,
            1.90,
            1.95,
            2.00,
            2.05,
            2.10,
            2.15,
            2.20,
            2.25,
            2.30,
            2.35,
            2.40,
            2.45,
            2.50,
            2.55,
            2.60,
            2.65,
            2.70,
            2.75,
            2.80,
            2.85,
            2.90,
            2.95,
            3.00,
            3.05,
            3.10,
            3.15,
            3.20,
            3.25,
            3.30,
            3.35,
            3.40,
            3.45,
            3.50,
            3.55,
            3.60,
            3.65,
            3.70,
            3.75,
            3.80,
            3.85,
            3.90,
            3.95,
            4.00,
            4.05,
            4.10,
            4.15,
            4.20,
            4.25,
            4.30,
            4.35,
            4.40,
            4.45,
            4.50,
            4.55,
            4.60,
            4.65,
            4.70,
            4.75,
            4.80,
            4.85,
            4.90,
            4.95,
            5.00,
            5.05,
            5.10,
            5.15,
            5.20,
            5.25,
            5.30,
            5.35,
            5.40,
            5.45,
            5.50,
            5.55,
            5.60,
            5.65,
            5.70,
            5.75,
            5.80,
            5.85,
            5.90,
            5.95,
            6.00,
            6.05,
            6.10,
            6.15,
            6.20,
            6.25,
            6.30,
            6.35,
            6.40,
            6.45,
            6.50,
            6.55,
            6.60,
            6.65,
            6.70,
            6.75,
            6.80,
            6.85,
            6.90,
            6.95,
            7.00,
            7.05,
            7.10,
            7.15,
            7.20,
            7.25,
            7.30,
            7.35,
            7.40,
            7.45,
            7.50,
            7.55,
            7.60,
            7.65,
            7.70,
            7.75,
            7.80,
            7.85,
            7.90,
            7.95,
            8.00,
            8.05,
            8.10,
            8.15,
            8.20,
            8.25,
            8.30,
            8.35,
            8.40,
            8.45,
            8.50,
            8.55,
            8.60,
            8.65,
            8.70,
            8.75,
            8.80,
            8.85,
            8.90,
            8.95,
            9.00
        };

        private static double[] RAW_Q = new double[] {
            0.5,
            0.48006,
            0.46017,
            0.44038,
            0.42074,
            0.40129,
            0.38209,
            0.36317,
            0.34458,
            0.32636,
            0.30854,
            0.29116,
            0.27425,
            0.25785,
            0.24196,
            0.22663,
            0.21186,
            0.19766,
            0.18406,
            0.17106,
            0.15866,
            0.14686,
            0.13567,
            0.12507,
            0.11507,
            0.10565,
            0.0968,
            0.088508,
            0.080757,
            0.073529,
            0.066807,
            0.060571,
            0.054799,
            0.049471,
            0.044565,
            0.040059,
            0.03593,
            0.032157,
            0.028717,
            0.025588,
            0.02275,
            0.020182,
            0.017864,
            0.015778,
            0.013903,
            0.012224,
            0.010724,
            0.0093867,
            0.0081975,
            0.0071428,
            0.0062097,
            0.0053861,
            0.0046612,
            0.0040246,
            0.003467,
            0.0029798,
            0.0025551,
            0.002186,
            0.0018658,
            0.0015889,
            0.0013499,
            0.0011442,
            0.0009676,
            0.00081635,
            0.00068714,
            0.00057703,
            0.00048342,
            0.00040406,
            0.00033693,
            0.00028029,
            0.00023263,
            0.00019262,
            0.00015911,
            0.00013112,
            0.0001078,
            8.8417e-5,
            7.2348e-5,
            5.9059e-5,
            4.8096e-5,
            3.9076e-5,
            3.1671e-5,
            2.5609e-5,
            2.0658e-5,
            1.6624e-5,
            1.3346e-5,
            1.0689e-5,
            8.5399e-6,
            6.8069e-6,
            5.4125e-6,
            4.2935e-6,
            3.3977e-6,
            2.6823e-6,
            2.1125e-6,
            1.6597e-6,
            1.3008e-6,
            1.0171e-6,
            7.9333e-7,
            6.1731e-7,
            4.7918e-7,
            3.7107e-7,
            2.8665e-7,
            2.2091e-7,
            1.6983e-7,
            1.3024e-7,
            9.9644e-8,
            7.605e-8,
            5.7901e-8,
            4.3977e-8,
            3.332e-8,
            2.5185e-8,
            1.899e-8,
            1.4283e-8,
            1.0718e-8,
            8.0224e-9,
            5.9904e-9,
            4.4622e-9,
            3.3157e-9,
            2.4579e-9,
            1.8175e-9,
            1.3407e-9,
            9.8659e-10,
            7.2423e-10,
            5.3034e-10,
            3.8741e-10,
            2.8232e-10,
            2.0523e-10,
            1.4882e-10,
            1.0766e-10,
            7.7688e-11,
            5.5925e-11,
            4.016e-11,
            2.8769e-11,
            2.0558e-11,
            1.4655e-11,
            1.0421e-11,
            7.3923e-12,
            5.231e-12,
            3.6925e-12,
            2.6001e-12,
            1.8264e-12,
            1.2798e-12,
            8.9459e-13,
            6.2378e-13,
            4.3389e-13,
            3.0106e-13,
            2.0839e-13,
            1.4388e-13,
            9.9103e-14,
            6.8092e-14,
            4.667e-14,
            3.1909e-14,
            2.1763e-14,
            1.4807e-14,
            1.0049e-14,
            6.8033e-15,
            4.5946e-15,
            3.0954e-15,
            2.0802e-15,
            1.3945e-15,
            9.3256e-16,
            6.221e-16,
            4.1397e-16,
            2.748e-16,
            1.8196e-16,
            1.2019e-16,
            7.9197e-17,
            5.2056e-17,
            3.4131e-17,
            2.2324e-17,
            1.4565e-17,
            9.4795e-18,
            6.1544e-18,
            3.9858e-18,
            2.575e-18,
            1.6594e-18,
            1.0668e-18,
            6.8408e-19,
            4.376e-19,
            2.7923e-19,
            1.7774e-19,
            1.1286e-19
        };

        #endregion
    
        /// <summary>
        /// Calculates the inverse Q function for a given probability, returning the x value at which Q(x) = p
        /// </summary>
        /// <param name="p">The probability value</param>
        /// <returns>The x value at which Q(x) = p</returns>
        public static double inverse(double p)
        {
            // we only have a table for the first half, so we'll use symmetry to calculate the other side
            if (p > 0.5)
            {
                return -inverse(1 - p);
            }

            // find the index of where this probability occurs
            // TODO: Use binary search here, it'll be a little bit faster
            int k = 0;
            do
            {
                k++;
            } while (k < RAW_Q.Length && RAW_Q[k - 1] > p);

            if (k == RAW_Q.Length - 1)
            {
                return RAW_X[RAW_X.Length - 1];
            }

            // linear interpolate between the two values
            double p1 = RAW_Q[k - 1];
            double p2 = RAW_Q[k];
            double x1 = RAW_X[k - 1];
            double x2 = RAW_X[k];

            return (x2 - x1) / (p2 - p1) * (p - p1) + x1;
        }
    }
}