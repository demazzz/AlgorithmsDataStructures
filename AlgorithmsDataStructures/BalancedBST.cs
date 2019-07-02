using System;
using System.Collections.Generic;


namespace AlgorithmsDataStructures2
{
    public static class BalancedBST
    {
        public static int[] GenerateBBSTArray(int[] a)
        {
            if (a.Length > 1)
            {
                int lenght = Convert.ToInt32(Math.Pow(2, ((Math.Ceiling(Math.Log(a.Length) / Math.Log(2))))) - 1); //calculate the lenght
                int[] result = new int[lenght];
                int[] final = new int[lenght]; //build return array
                Array.Sort(a); //ascending sort
                final = FindElements(a, result, 0,lenght);
                return final;
            }
            else return null;
        }
        public static int[] FindElements(int[] a, int[] result, int pos, int lenght)
        {            
            if (a.Length > 1)
                result[pos] = a[a.Length / 2];
            else if (a.Length==1) result[pos] = a[0];
            pos++;
            if (a.Length > 1)
            {
                
                int[] left = new int[a.Length / 2];
                int[] right = new int[a.Length / 2];
                Array.Copy(a, 0, left, 0, a.Length / 2);
                Array.Copy(a, a.Length / 2, right, 0, a.Length / 2);
                FindElements(left, result, pos, lenght);
                FindElements(right, result, pos, lenght);
            }
            return result;
        }
    }
}