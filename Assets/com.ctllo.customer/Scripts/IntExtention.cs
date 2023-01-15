/***
 * Copyright (c) The Knights of CTLLO
 * Date:2023
 */
namespace CtlloSpace
{
    public static class IntExtention
    {
        public static string ToChineseNumber(this int number)
        {
            switch (number)
            {
                case 0:
                    return "2";
                case 1:
                    return "3";
            }
            return null;
        }
    }
}