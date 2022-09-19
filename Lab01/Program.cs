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

            //задание 3

            int[,] arr = { { 1, 1, 1 }, { 0, 0, 0 }, { 1, 0, 1 } };
            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;
            for (int rrr = 0; rrr < rows; rrr++)
            {
                for (int ccc = 0; ccc < columns; ccc++)
                {
                    Console.Write($"{arr[rrr, ccc]} \t");
                }
                Console.WriteLine();
            }

            string[] strArr = { "Как", "тебя", "зовут?" };
            for (int ii = 0; ii < strArr.Length; ii++)
            {
                Console.WriteLine(strArr[ii]);
            }
            Console.WriteLine(strArr.Length);

            Console.WriteLine($"Введите позицию и значение:");
            int index = Convert.ToInt32(Console.ReadLine());

            string strChange = Console.ReadLine();

            strArr[index] = strChange;

            for (int j = 0; j < strArr.Length; j++)
            {
                Console.WriteLine(strArr[j]);
            }

            float[][] flArr = new float[3][];
            flArr[0] = new float[2];
            flArr[1] = new float[3];
            flArr[2] = new float[4];

            Console.WriteLine("Введите значения первой строки:");
            for (int k = 0; k < 2; k++)
            {
                flArr[0][k] = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine("Введите значения второй строки:");
            for (int k = 0; k < 3; k++)
            {
                flArr[1][k] = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine("Введите значения третьей строки:");
            for (int k = 0; k < 4; k++)
            {
                flArr[2][k] = Convert.ToSingle(Console.ReadLine());
            }

            for (int a = 0; a < 2; a++)
            {
                Console.Write(flArr[0][a] + " ");
            }
            Console.WriteLine();

            for (int a = 0; a < 3; a++)
            {
                Console.Write(flArr[1][a] + " ");
            }
            Console.WriteLine();

            for (int a = 0; a < 4; a++)
            {
                Console.Write(flArr[2][a] + " ");
            }

            var implArr = new[] { 1, 2, 3 };
            var implStr = "Hello";

        }
    }
}