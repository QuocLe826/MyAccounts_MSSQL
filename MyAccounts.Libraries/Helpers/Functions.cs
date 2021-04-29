using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAccounts.Libraries.Helpers
{
    public class Functions
    {
        /// <summary>
        /// Convert object to String
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Return the String data type</returns>
        public static string ToString(object obj)
        {
            try
            {
                if (obj == null)
                {
                    return String.Empty;
                }
                return obj.ToString().Trim();
            }
            catch
            {
                return String.Empty;
            }
        }

        /// <summary>
        /// Convert object to Integer
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Return the Integer data type</returns>
        public static int ParseInteger(object obj)
        {
            try
            {
                int result;
                if (obj == null)
                {
                    return 0;
                }
                if (int.TryParse(obj.ToString(), out result))
                {
                    return result;
                }
                return result;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Convert object to Float
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Return the Float data type</returns>
        public static float ParseFloat(object obj)
        {
            try
            {
                float result;
                if (obj == null)
                {
                    return 0;
                }
                if (float.TryParse(obj.ToString(), out result))
                {
                    return result;
                }
                return result;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Convert object to Long
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Return the Long data type</returns>
        public static float ParseLong(object obj)
        {
            try
            {
                long result;
                if (obj == null)
                {
                    return 0;
                }
                if (long.TryParse(obj.ToString(), out result))
                {
                    return result;
                }
                return result;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Convert object to Double
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Return the Double data type</returns>
        public static double ParseDouble(object obj)
        {
            try
            {
                double result;
                if (obj == null)
                {
                    return 0;
                }
                if (double.TryParse(obj.ToString(), out result))
                {
                    return result;
                }
                return result;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Convert object to Decimal
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>>Return the Decimal data type</returns>
        public static decimal ParseDecimal(object obj)
        {
            try
            {
                decimal result;
                if (obj == null)
                {
                    return 0;
                }
                if (decimal.TryParse(obj.ToString(), out result))
                {
                    return result;
                }
                return result;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Convert object to Boolean
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Return the Boolean data type</returns>
        public static bool ParseBoolean(object obj)
        {
            try
            {
                bool result;
                if (obj == null)
                {
                    return false;
                }
                if (bool.TryParse(obj.ToString(), out result))
                {
                    return result;
                }
                return result;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Convert object to DateTime
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>>Return the DateTime data type</returns>
        public static DateTime ParseDateTime(object obj)
        {
            try
            {
                DateTime dateTime;
                if (obj == null)
                {
                    return new DateTime();
                }
                if (DateTime.TryParse(obj.ToString(), out dateTime))
                {
                    return dateTime;
                }
                return dateTime;
            }
            catch
            {
                return new DateTime();
            }
        }

        public static string ConvertDate(DateTime date, string format)
        {
            return date.ToString(format);
        }
    }
}
