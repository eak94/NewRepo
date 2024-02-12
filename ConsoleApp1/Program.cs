/*Дана структура с именем AEROFLOT, содержащая следующие поля: 
• Название пункта назначения рейса.
• Номер рейса. 
• Тип самолета. */
/*Написать программу, которая выполняет следующие действия: 
• Ввод с клавиатуры данных в массив, состоящий из 7 элементов типа AEROFLOT, и занесение их в файл данных. 
• Чтение данных из файла и вывод их на экран. 
• Вывод на экран пунктов назначения и номеров рейсов, обслуживаемых самолетом, тип которого введен с клавиатуры (если таких нет — вывести об этом сообщение). 
• Список должен быть упорядочен по алфавиту названий пунктов назначения. 
• Запишите список в текстовый файл*/


using System.Xml.Serialization;
using System.Xml;

namespace AEROFLOT
{
    /// <summary>
    /// Структура таблицы перелетов.
    /// </summary>
    public struct AEROFLOT
    {
        /// <summary>
        /// Название пункта назначение рейса.
        /// </summary>
        public string Name;
        /// <summary>
        /// Номер рейса.
        /// </summary>
        public int Number;
        /// <summary>
        /// Тип самолета.
        /// </summary>
        public string Type;

        /// <summary>
        /// Метод для вывода информации о рейсе.
        /// </summary>
        /// <param name="file">Путь к файлу. </param>
        public void WriteFile(string file)
        {
            //Для записи в текстовый файл используется класс StreamWriter

            //Параметр `true` указывает на то, что при создании `StreamWriter
            //будет использоваться режим дозаписи, то есть новые данные будут добавляться в конец файла, а не перезаписывать его полностью.
            //Если бы вместо `true` был указан `false`, то при каждой записи данные будут перезаписываться с начала файла.
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.Write($"\nНазвание пункта назначения рейса: {Name}");
                writer.Write($"\nНомер рейса: {Number}\nТип самолета:{Type}\n");
            }
        }
    }

    /// <summary>
    /// Создание класса Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Метод AEROFLOT
        /// </summary>
        internal static void Main()
        {
            // Вызов метода ввода данных в массив
            AEROFLOT[] aeroflotArray = ListAeroflot();

            // Сортировка массива по алфавиту названий пунктов назначения
            Console.Write($"Отсортированный по алфавиту");
            SortFile(aeroflotArray);

            // Запись полученного массива в текстовый файл расположенный по указанному пути
            WriteFileMarshArray(aeroflotArray, @"C:\Users\Евгения\source\repos\Лаба6\ConsoleApp1\AEROFLOT.txt");

            // Чтение данных из текстового файла расположенному по указанному пути
            ReadFile(@"C:\Users\Евгения\source\repos\Лаба6\ConsoleApp1\AEROFLOT.txt");

            //Поиск типа самолета
            TypeAeroflot(aeroflotArray);

            //Запись в XML файл, а далее чтение массива из XML-файла
            WriteReadFileXml(aeroflotArray);

        }

        /// <summary>
        /// Ввод данных о рейсе.
        /// </summary>
        /// <returns></returns>
        public static AEROFLOT[] ListAeroflot()
        {
            //задаем массив длиной 7
            Console.WriteLine($"Введите количество записей:");
            int count = int.Parse(Console.ReadLine());
            AEROFLOT[] aeroflotArray = new AEROFLOT[count];
            //заполним массив записями введеными пользователем
            for (int i = 0; i < aeroflotArray.Length; i++)
            {
                Console.WriteLine($"Введите данные по маршруту:");
                Console.Write("Название пункта назначение рейса: ");
                aeroflotArray[i].Name = Console.ReadLine();

                Console.Write("Номер рейса: ");
                aeroflotArray[i].Number = int.Parse(Console.ReadLine());

                Console.Write("Тип самолета: ");
                aeroflotArray[i].Type = Console.ReadLine();

                Console.WriteLine();
            }
            return aeroflotArray;
        }

        /// <summary>
        /// Метод для сортировки пунктов назначения в алфавитном порядке.
        /// </summary>
        /// <param name="aeroflotArray">Созданный массив ранее.</param>
        /// <returns>Отсортированный массив.</returns>
        public static void SortFile(AEROFLOT[] aeroflotArray)
        {
            //
            for (int i = 0; i < aeroflotArray.Length - 1; i++)
            {
                for (int j = 0; j < aeroflotArray.Length - i - 1; j++)
                {
                    if (string.Compare(aeroflotArray[j].Name, aeroflotArray[j + 1].Name) > 0)
                    {
                        // Обмен элементов массива местами с помощью кортежа 
                        (aeroflotArray[j + 1], aeroflotArray[j]) = (aeroflotArray[j], aeroflotArray[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// Метод для записи массива в текстовый файл.
        /// </summary>
        /// <param name="marshArray">Массив.</param>
        /// <param name="file">Путь к файлу.</param>
        public static void WriteFileMarshArray(AEROFLOT[] aeroflotArray, string file)
        {
            for (int i = 0; i < aeroflotArray.Length; i++)
            {
                aeroflotArray[i].WriteFile(file);
            }
        }

        /// <summary>
        /// Метод чтения данных из текстового файла.
        /// </summary>
        /// <param name="file">Путь к файлу.</param>
        public static void ReadFile(string file)
        {
            //Для чтения текстового файла используется класс StreamReader
            using (StreamReader reader = new StreamReader(file))
            {
                string text = reader.ReadToEnd();
                Console.WriteLine(text);
            }
        }

        /// <summary>
        /// Метод поиска интересующего типа самолета.
        /// </summary>
        /// <param name="aeroflotArray">Массив с данными о самолетах.</param>
        public static void TypeAeroflot(AEROFLOT[] aeroflotArray)
        {
            Console.Write("Введите тип интересующего вас самолета: ");
            string route = (Console.ReadLine());

            bool b = false;
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Евгения\source\repos\Лаба6\ConsoleApp1\AEROFLOT.txt", true))
            {
                writer.Write($"\nВас интересует следующий тип: {route}");
            }

            for (int i = 0; i < aeroflotArray.Length; i++)
            {
                if (aeroflotArray[i].Type == route)
                {
                    b = true;
                    aeroflotArray[i].WriteFile(@"C:\Users\Евгения\source\repos\Лаба6\ConsoleApp1\AEROFLOT.txt");
                    Console.Write($"Результат поиска: {route}");
                    ReadFile(@"C:\Users\Евгения\source\repos\Лаба6\ConsoleApp1\AEROFLOT.txt");
                }
            }

            if (b == false)
            {
                Console.WriteLine("Тип не найден");
            }
        }

        /// <summary>
        /// Метод для записи и чтения xml-файла
        /// </summary>
        /// <param name="aeroflotArray">Массив с данными о самолетах.</param>
        public static void WriteReadFileXml(AEROFLOT[] aeroflotArray)
        {
            // передаем в конструктор массив AEROFLOT[]
            XmlSerializer aeroflotXml = new XmlSerializer(typeof(AEROFLOT[]));

            //Получаем поток, куда будем записывать сериализованный объект
            // Записываем массив структур в XML-файл.
            using (XmlWriter writerAroflot = XmlWriter.Create(@"C:\Users\Евгения\source\repos\Лаба6\ConsoleApp1\AEROFLOTXml.xml"))
            {
                // Сериализация массива структур в XML и запись в файл
                //Для удобного сохранения и извлечения объектов из файлов xml может использоваться класс XmlSerializer из пространства имен System.Xml.Serialization.
                //Данный класс упрощает сохранение сложных объектов в формат xml и последующее их извлечение
                aeroflotXml.Serialize(writerAroflot, aeroflotArray);
            }

            Console.WriteLine("Массив структур записан в XML-файл\n");

            // Чтение массива из XML-файла.
            using (XmlReader reader = XmlReader.Create(@"C:\Users\Евгения\source\repos\Лаба6\ConsoleApp1\AEROFLOTXml.xml"))
            {
                // десериализуем объект
                aeroflotArray = (AEROFLOT[])aeroflotXml.Deserialize(reader);
            }

            Console.WriteLine("Массив структур считан из XML-файла. \nРезультат: \n");
            //Показываем в консоле результат 
            for (int i = 0; i < aeroflotArray.Length; i++)
            {
                Console.WriteLine($"Название пункта назначения рейса: {aeroflotArray[i].Name}");
                Console.WriteLine($"Номер рейса: {aeroflotArray[i].Number}");
                Console.WriteLine($"Тип самолета: {aeroflotArray[i].Type}");
            }
        }
    }
}

