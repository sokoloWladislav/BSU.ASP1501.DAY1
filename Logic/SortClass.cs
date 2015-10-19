using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public delegate double Key(double[] array);
    public static class SortClass
    {
        private static List<Key> keys;
        static SortClass()
        {
            keys = new List<Key>();
            keys.Add(Key1);
            keys.Add(Key2);
            keys.Add(Key3);
        }

        public static void Sort(double[][] array, Key key)
        {

            for (int i = 0; i < array.Length - 1; ++i)
                for (int j = 0; j < array.Length - i - 1; ++j)
                {
                    if (key(array[j]) > key(array[j + 1]))
                        Swap(ref array[j], ref array[j + 1]);
                }
        }

        public static void SortBySum(double[][] array)
        {
            Sort(array, keys[0]);
        }

        public static void SortByMax(double[][] array)
        {
            Sort(array, keys[1]);
        }

        public static void SortByMin(double[][] array)
        {
            Sort(array, keys[2]);
        }

        private static double Key1(double[] array)
        {
            if (array == null)
                return Double.NaN;
            double result = 0;
            foreach (double elem in array)
                result += elem;
            return result;
        }

        private static double Key2(double[] array)
        {
            if (array == null)
                return Double.NaN;
            double result = array[0];
            for (int i = 1; i < array.Length; ++i)
                if (array[i] > result)
                    result = array[i];
            return result;
        }

        private static double Key3(double[] array)
        {
            if (array == null)
                return Double.NaN;
            double result = array[0];
            for (int i = 1; i < array.Length; ++i)
                if (array[i] < result)
                    result = array[i];
            return result;
        }

        private static void Swap(ref double[] a, ref double[] b)
        {
            double[] temp = a;
            a = b;
            b = temp;
        }
    }
}
