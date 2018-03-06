using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Globalization;
using System.Threading;

namespace Calculator
{
    class Converter
    {
        
         public static String NumWordsWrapper(double n)
         {
            string words = "";
            double intPart;
            int decPart = 0;
            bool isZero = false;
            CultureInfo culture;
            
            culture = CultureInfo.CreateSpecificCulture("sr-Latn"); 
         
            if (n == 0)
                return "нула";

            
            try
            {
                n = Math.Floor(n * 100) / 100;
                string ans = n.ToString ("G15", CultureInfo.InvariantCulture);
                string[] splitter = ans.Split('.');
                intPart = double.Parse(splitter[0]);
                decPart = int.Parse(splitter[1]);
                if (splitter[1].Length > 0) // if first digit is zero
                {
                    int index = splitter[1].IndexOf('0');
                    if (index == 0)
                        isZero = true;
                    else isZero = false;
                }
            }
            catch
            {
                intPart = n;
            }

            words = NumWords(intPart, culture);
            
            // decimal part
            if (decPart > 0)
            {
                if (words != "")
                {
                    words += " тачка ";
                    if (isZero) words += " нула "; 
                    words += decPart.ToWords(culture); // converts number to words, in Serbian lang
                }
           }
            
            // fixing grammer
            if (words.Contains("један хиљада"))
                words = words.Replace("један хиљада", "једнa хиљада");
            if (words.Contains("два хиљада"))
                words = words.Replace("два хиљада", "двe хиљадe");
            if (words.Contains("три хиљада"))
                words = words.Replace("три хиљада", "три хиљадe");
            if (words.Contains("четири хиљада"))
                words = words.Replace("четири хиљада", "четири хиљадe");
            if (words.Contains("један милионa"))
                words = words.Replace("један милионa", "један милион");
            if (words.Contains("један милијарди"))
                words = words.Replace("један милијарди", "једнa милијардa");
            if (words.Contains("два милијарди"))
                words = words.Replace("два милијарди", "двe милијардe");
            if (words.Contains("три милијарди"))
                words = words.Replace("три милијарди", "три милијардe");
            if (words.Contains("четири милијарди"))
                words = words.Replace("четири милијарди", "четири милијардe");
            if (words.Contains("један трилионa"))
                words = words.Replace("један трилионa", "један трилион"); 

             return words;
        }

        static String NumWords(double n, CultureInfo culture) //converts double to words
        {
            string[] suffixesArr = new string[] { "хиљадa", "милионa", "милијарди", "трилионa", "квадрилионa", "квинтилиона", "сеxтиллионa", "септиллионa", "оцтиллионa", "нониллионa", "дециллионa", "ундециллионa", "дуодециллионa", "тредециллионa", "Qуаттуордециллионa", "Qуиндециллионa", "Сеxдециллионa", "Септдециллионa", "Оцтодециллионa", "Новемдециллионa", "Вигинтиллионa" };
            string words = "";

            if (n < 0)
            {
                words += "минус ";
                n *= -1;
            }

            int power = (suffixesArr.Length + 1) * 3;

            // converts big numbers to words, in Serbian language
            while (power > 3)
            {
                double pow = Math.Pow(10, power);
                if (n >= pow)
                {
                    if (n % pow > 0)
                    {
                        words += ((int)(Math.Floor(n / pow))).ToWords(culture)  + " " + suffixesArr[(power / 3) - 1] + " ";
                    }
                    else if (n % pow == 0)
                    {
                        words += ((int)(Math.Floor(n / pow))).ToWords(culture) + " " + suffixesArr[(power / 3) - 1];
                    }
                    n %= pow;
                }
                power -= 3;
            }

            if (n >= 0 && n <= 999999)
                words += ((int)n).ToWords(culture); // converts numbers between zero and thousands to words, in Serbian language
            
            return words;
        }
    }
}
