using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// 1 
            //System.Int32 int32_1 = 1;
            //System.Boolean bool_1 = false;
            //System.Byte byte_1 = 64;
            //System.Char char1 = 'A';
            //System.Decimal decimal1 = 9.1m;
            //System.Double double1 = 0.1;
            //System.SByte sbyte_1 = -128;
            //System.Single single_1 = .2f;
            //System.UInt32 uint32_1 = 16;
            //System.Int64 int64_1 = 256;
            //System.UInt64 Uint64_1 = 2048;
            //System.Int16 int16_1 = 4;
            //System.UInt16 Uint16_1 = 2;
            //Console.WriteLine(Uint16_1);
            //Console.WriteLine($"int16={int16_1}");
            //Console.WriteLine(Uint64_1);
            //Console.WriteLine(int64_1);
            //Console.WriteLine(uint32_1);
            //Console.WriteLine(single_1);
            //Console.WriteLine(double1);
            //Console.WriteLine(decimal1);
            //Console.WriteLine(char1);
            //Console.Write(int32_1);
            //Console.Write("\n");
            //Console.Write(bool_1);
            //Console.Write("\n");
            //Console.Write(byte_1);
            //Console.Write("\n");
            //Console.Write(sbyte_1);
            //Console.Write("\n");
            //Console.Write(" Введите значение int16:"); int16_1 = Convert.ToInt16(Console.ReadLine()); Console.WriteLine(int16_1);
            //Console.Write(" Введите значение Uint64:"); Uint64_1 = Convert.ToUInt64(Console.ReadLine()); Console.WriteLine(Uint64_1);
            //Console.Write(" Введите значение int64:"); int64_1 = Convert.ToInt64(Console.ReadLine()); Console.WriteLine(int64_1);
            //Console.Write(" Введите значение single:"); single_1 = Convert.ToSingle(Console.ReadLine()); Console.WriteLine(single_1);
            //Console.Write(" Введите значение uint16:"); Uint16_1 = Convert.ToUInt16(Console.ReadLine()); Console.WriteLine(Uint16_1);
            //Console.Write(" Введите значение uint32:"); uint32_1 = Convert.ToUInt32(Console.ReadLine()); Console.WriteLine(uint32_1);
            //Console.Write(" Введите значение doubole:"); double1 = Convert.ToDouble(Console.ReadLine()); Console.WriteLine(double1);
            //Console.Write(" Введите значение decimal1:"); decimal1 = Convert.ToDecimal(Console.ReadLine()); Console.WriteLine(decimal1);
            //Console.Write(" Введите значение char1:"); char1 = Convert.ToChar(Console.ReadLine()); Console.WriteLine(char1);
            //Console.Write(" Введите значение int32:"); int32_1 = Convert.ToInt32(Console.ReadLine()); Console.WriteLine(int32_1);
            //Console.Write(" Введите значение bool:"); bool_1 = Convert.ToBoolean(Console.ReadLine()); Console.WriteLine(bool_1);
            //Console.Write(" Введите значение byte:"); byte_1 = Convert.ToByte(Console.ReadLine()); Console.WriteLine(byte_1);
            //Console.Write(" Введите значение sbyte:"); sbyte_1 = Convert.ToSByte(Console.ReadLine()); Console.WriteLine(sbyte_1);
            ///b
            ///неявное преобразование
            //byte b = 5;
            //short s = b;
            //int i = b;
            //long l = b;
            //double n = l;
            ////Пробуем преобразовать long в double
            //double d = l;
            //Console.WriteLine("Byte = {0}, Short = {1}, int = {2}, long = {3},double = {4}", b, s, i, l,d);

            /////b
            /////явное преобразование
            //short short_1 = 45;
            //byte byte_1 = (byte)short_1;
            //int int_2 = 12;
            //long long_2 = (long)int_2;
            //double double_1= 2.1;
            //long long_3 = (short)double_1;
            //int int_3 = 14;
            //double double_2 = (double)int_3;
            //byte byte_3 = 128;
            //short short_3 = (short)byte_3;
            //Console.WriteLine("Byte = {0},long_2 ={1}, Double ={2}, Int = {3}, short ={4}", byte_1,long_2,double_1,int_3,short_3);
            /////
            /////преобразование с помощью convert 
            //short short_2 = 45;
            //long long_1 = 1234;
            //int int_1 = Convert.ToInt32(long_1);
            //byte byte_2 = Convert.ToByte(short_2);
            //Console.WriteLine("Byte = {0},Int = {1}", byte_2,int_1);
            /////c
            ///// распоковка и упаковка типов 
            //int int_4 = 1;
            //object o = int_4;
            //o = 12;
            //int_4 = (int)o;
            //Console.WriteLine("Int_4={0}", int_4);
            /////d
            ///// неявно типизированная переменная 
            //var x = 1;
            //for (; x < 10; x++)
            //{ Console.WriteLine(x); }
            /////e
            /////пример работу с Nullable
            //int? int_5 = null;
            //if (int_5.HasValue)
            //    Console.WriteLine(int_5.Value);
            //else
            //    Console.WriteLine("int_5 = null");
            /// f
            /// Определите переменную типа var и присвойте ей любое
            /// значение.Затем следующей инструкцией присвойте ей значение
            ///другого типа. Объясните причину ошибки.!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            ////var qwert = "hello";
            ////int int_6 = qwert;


            ///2
            ///a Объявите строковые литералы. Сравните их
            //string a = "hello";
            //string b = "world";
            //int result = System.String.Compare(a, b);
            //Console.WriteLine(result);
            //if (result < 0)
            //{
            //    Console.WriteLine("a перед b");
            //}
            //else if (result > 0)
            //{
            //    Console.WriteLine("b перед a");
            //}
            //else  Console.WriteLine("a=b");
            /////b Создайте три строки на основе String. Выполните: сцепление,
            /////копирование, выделение подстроки, разделение строки на слова,
            /////вставки подстроки в заданную позицию, удаление заданной
            /////подстроки.
            /////concat
            //string string_1 = "welcome";
            //string string_2 = "home";
            //string string_3 = "my freind";
            //string string_4 = string_1 + " " + string_2 + " " + string_3;
            //Console.WriteLine(String.Concat(string_4));

            /////разделение на слова 
            //string text = "Не сдавайся";

            //string[] words = text.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries); ///удалить все пустые подстроки(второй параметр)

            //foreach (string s in words)
            //{
            //    Console.WriteLine(s);
            //}
            /////вставка в заданую позицию 
            //string string_5 = "Восстань ";
            //string string_6 = "и не знай поражений ";
            //string_5 = string_5.Insert(9,string_6);
            //Console.WriteLine(string_5);
            /////удаление подстраки 
            //string string_7 = "Я устал";
            //int index = string_7.Length - 1;
            //string_7 = string_7.Remove(index);
            //Console.WriteLine(string_7);
            /////string.IsNullOrEmpty
            //string string_8 = "";
            //string string_9 = null;
            //if(string.IsNullOrEmpty(string_8))
            //{
            //   Console.WriteLine("строка пуста");
            //}
            //else
            //{
            //    Console.WriteLine("значение null");

            //}


            //Console.WriteLine(" Длинна '{0}' = {1}.", string_8, string_8.Length);
            //Console.WriteLine("значение строки  '{0}'", string_9);

            ///3
            ///a создать двумерный массив и вывести его 
            //int[,] arr = new int[2, 2];

            //Random ran = new Random();


            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        arr[i, j] = ran.Next(1, 15);
            //        Console.Write("{0}\t", arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            /////массив строк
            //string[] strarr = new string [100];
            //int n ;
            //Console.WriteLine("Введите количество элементов : ");

            //n = int.Parse(Console.ReadLine());

            //for(int i = 0; i <n;i++)
            //{
            //    strarr[i] = Console.ReadLine();
            //} 

            //Console.WriteLine("Результирущий массив: ");
            //for(int i = 0; i<n ; i++)

            //{
            //    Console.WriteLine(strarr[i]);
            //}
            //Console.WriteLine("Введите номер элемента(учтите нумерация с 0): ");
            /// bсоздать массив и поменять произвольный элемент
            //string[] str_mas = { "привет", "ухожу", "пора", "домой", "устал" }; 
            //Console.WriteLine("Одномерный массив строк: ");
            //for (var i = 0; i < str_mas.Length; i++)
            //    Console.Write(str_mas[i] + ' ');
            //Console.WriteLine();
            //Console.WriteLine("Длинна массива: " + str_mas.Length.ToString());
            //Console.WriteLine("Номер элемента который хотите изменить: ");
            //int id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Строка для замены: ");
            //str_mas[id - 1] = Console.ReadLine();
            //Console.WriteLine("Результат:");
            //for (var i = 0; i < str_mas.Length; i++)
            //    Console.Write(str_mas[i] + ' ');
            //Console.Write('\n');
            ///создать ступенчатый массив вещественных чисел

            //int[][] myArr = new int[3][] { new int[2], new int[3], new int[4] };
            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    for (int j = 0; j < myArr[i].Length; j++)
            //    {
            //        Console.Write($"myArr[{i}][{j}] = ");
            //        myArr[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    Console.WriteLine(string.Join(" ", myArr[i]));///сцепляем все элеменыт массива строк,помещая между ними заданный разделитель 
            //}
            ///создать неявно типизированные переменные для хранения    массива и строки 
            //var arr3 = new object[0];
            //var str = "hi mark";


            ///4
            ///
            //   var kort = (2,"hello","","world",-2);
            //    Console.WriteLine(kort);
            //    ///распоковка в переменные 
            //    Console.WriteLine("Элементы кортежа:1={0} 2={1} 3={2} 4={3} 5={4}", kort.Item1,kort.Item2, kort.Item3, kort.Item4, kort.Item5);
            //    ///сравнение кортежа
            //    var kort_1 = (2, "hello", "", "worl", -2);
            //    if (kort_1.Equals(kort) )
            //    {
            //        Console.WriteLine("кортежи равны");
            //    }
            //    else
            //    {
            //        Console.WriteLine("кортежи не равны");

            //    }

            //    Console.ReadKey();

            //}
            //(int, string, int, string, string) GetResult(int[] par1, string[] par2)
            //{

            //    var kort = (2, "hello", -2, "world", "");
            //    return kort;
            //}
          
            //void func1()
            //{
            //    checked
            //    {
            //       int zd_6 = 2147483647;
            //        Console.WriteLine(zd_6);
            //    }
            //}
            //void func2()
            //{
            //    int zd_6 = 2147483647;
            //    Console.WriteLine(zd_6);
            //}
            //func1();
            //func2();
            //int checked_1 =  2147483647;
            //int checked_2 = checked_1 + 1;
            ////int checked_2 = checked(checked_1 + 1);
            //Console.WriteLine(checked_2);
        }
    }
}
