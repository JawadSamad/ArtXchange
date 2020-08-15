using System;
using System.Collections.Generic;
using System.Text;

namespace ArtXchange.Utility
{
    public class SD
    {
        public const string Role_User_Student = "Student";
        public const string Role_Admin = "Admin";
        public const string Role_Employee = "Employee";
        public const string ssShoppingCart = "Shopping Cart Session";

        public static double GetPriceBasedOnQuantity(double quantity, double price, double price3, double price6)
        {
            if (quantity < 3)
            {
                return price;
            }
            else
            {
                if (quantity < 6)
                {
                    return price3;
                }
                else
                {
                    return price6;
                }
            }
        }

        public static string ConvertToRawHtml(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }
    }
}
