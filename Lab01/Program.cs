using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения типа: int, string, char, double, bool, byte, sbyte, decimal, float, short, ushort, uint, ulong");
            int iNum = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            char chNum = Convert.ToChar(Console.ReadLine());
            double douNum = Convert.ToDouble(Console.ReadLine());
            bool answer = Convert.ToBoolean(Console.ReadLine());
            byte smallNum = Convert.ToByte(Console.ReadLine());
            sbyte sbNum = Convert.ToSByte(Console.ReadLine());
            decimal deNum = Convert.ToDecimal(Console.ReadLine());
            float fNum = Convert.ToSingle(Console.ReadLine());
            short shNum = Convert.ToInt16(Console.ReadLine());
            ushort ushNum = Convert.ToUInt16(Console.ReadLine());
            uint uiNum = Convert.ToUInt32(Console.ReadLine());
            ulong ulNum = Convert.ToUInt64(Console.ReadLine());
            //nint niNum = Convert.ToInt32(Console.ReadLine());
            //nuint nuiNum = Convert.ToUInt32(Console.ReadLine());

            //Console.WriteLine(i + " " + str + " " + c + " "+ f + " " + lol + " " + b + " " + sb + " " + dc + " " + fl + " " + sh + " " + ush + " " + ui + " " + ul);

            //      явные преобразования
            double d1 = 25.5;
            int i = (int)d1;

            float f2 = 15.9f;
            short s = (short)f2;

            long l3 = 125;
            byte b = (byte)l3;

            uint u4 = 31;
            ushort us = (ushort)u4;

            decimal de5 = 1.5E6m;
            float fl = (float)de5;

            // неявные преобразования
            byte b6 = 2;
            short sb6 = b6;

            long l7 = 236;
            float fl7 = l7;

            short s8 = 10;
            int is8 = s8;

            int i9 = 6;
            double id9 = i9;

            float f10 = 5.4f;
            double fd10 = f10;
            //
            //упаковка и распаковка
            Object box = iNum;
            box = 15;
            iNum = (int)box;

            //NullAble
            int? nullAbleNum = null;

            //неявно типизированная переменная
            var implNum = 566;
            Console.WriteLine(implNum);

            //задание 2

            string str1 = "Mama";
            string str2 = "Papa";
            Console.WriteLine($"Сравнение строк: {str1 == str2}");

            Console.WriteLine($"Копирование строк: {String.Copy(str1)}");
            Console.WriteLine($"Cкладывание строк: {String.Concat(str1, str2)}");
            Console.WriteLine($"Выделить подстроку: {str2.Substring(2)}");
            Console.WriteLine($"Деление строки на слова:");
            string strAll = "How are you ?";
            string[] arrStr;
            arrStr = strAll.Split();
            for (int count = 0; count < arrStr.Length; count++)
            {
                Console.WriteLine(arrStr[count]);
            }
            Console.WriteLine($"Вставить подстроку в строку в указанную позицию: {strAll.Insert(12, str1)}");
            Console.WriteLine($"Удаление заданной подстроки: {str2.Remove(2)}");

            string strEmpty = "";
            string strNull = null;
            Console.WriteLine($"Сравнение строк: {strEmpty == strNull}");
            Console.WriteLine($"Использование метода .IsNullOrEmpty для пустой строки : {String.IsNullOrEmpty(strEmpty)} для строки null: {String.IsNullOrEmpty(strNull)}");

            StringBuilder strBuilder = new StringBuilder("sweet home", 20);
            strBuilder.Append(new char[] { '!', '!' });
            strBuilder.Insert(0, "My ");
            strBuilder.Remove(8, 5);
            Console.WriteLine(strBuilder);
        }
    }
}