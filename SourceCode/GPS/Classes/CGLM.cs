﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgOpenGPS
{
   public static class glm
    {
        public const byte SET_1 = 1;
        public const byte SET_2 = 2;
        public const byte SET_3 = 4;
        public const byte SET_4 = 8;
        public const byte SET_5 = 16;
        
        public const byte RESET_1 = 254;
        public const byte RESET_2 = 253;
        public const byte RESET_3 = 251;
        public const byte RESET_4 = 247;
        public const byte RESET_5 = 239;

       //inches to meters
       public static double in2m = 0.0254;

       //meters to inches
       public static double m2in = 39.3701;

       public static double twoPI = 6.2857142857142857142857142857143;
                     
       public static double PIBy2 = 1.5714285714285714285714285714286;

       public static float acos(float x)
        {
            return (float)Math.Acos(x);
        }

        public static float acosh(float x)
        {
            if (x < (1f)) return (0f);
            return (float)Math.Log(x + Math.Sqrt(x * x - (1f)));
        }

        public static float asin(float x)
        {
            return (float)Math.Asin(x);
        }

        public static float asinh(float x)
        {
            return (float)(x < 0f ? -1f : (x > 0f ? 1f : 0f)) * (float)Math.Log(Math.Abs(x) + Math.Sqrt(1f + x * x));
        }

        public static float atan(float y, float x)
        {
            return (float)Math.Atan2(y, x);
        }

        public static float atan(float y_over_x)
        {
            return (float)Math.Atan(y_over_x);
        }

        public static float atanh(float x)
        {
            if (Math.Abs(x) >= 1f) return 0;
            return (0.5f) * (float)Math.Log((1f + x) / (1f - x));
        }

        public static float cos(float angle)
        {
            return (float)Math.Cos(angle);
        }

        public static float cosh(float angle)
        {
            return (float)Math.Cosh(angle);
        }

        public static float degrees(float radians)
        {
            return radians * (57.295779513082320876798154814105f);
        }
        public static double degrees(double radians)
        {
            return radians * (57.295779513082320876798154814105f);
        }

        public static float radians(float degrees)
        {
            return degrees * (0.01745329251994329576923690768489f);
        }
        public static double radians(double degrees)
        {
            return degrees * (0.01745329251994329576923690768489f);
        }

        public static float sin(float angle)
        {
            return (float)Math.Sin(angle);
        }

        public static float sinh(float angle)
        {
            return (float)Math.Sinh(angle);
        }

        public static float tan(float angle)
        {
            return (float)Math.Tan(angle);
        }

        public static float tanh(float angle)
        {
            return (float)Math.Tanh(angle);
        }

    }
}
