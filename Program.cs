using System.Collections;



namespace С_7
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();
            Dictionary<int,string> keyValuePairs = new Dictionary<int, string>();
            ArrayList arrayList = new ArrayList();
            HashSet<string> keys = new HashSet<string>();

            list.Add("asd");
            list.Remove("asd");
            list.Contains("asd"); // поиск элемента(находит первый попавшийся)
            list.Clear();
            int c = list.Count; // возвроащает кол-во элементов в списке
            

            int c2 = keyValuePairs.Count;
            keyValuePairs.Add(1, "asd");
            keyValuePairs.Remove(1);
            keyValuePairs.Clear();
            keyValuePairs.ContainsKey(2); // поиск конкретного ключа


            keys.Add("asd");
            keys.Remove("asd");
            keys.Clear();
            keys.Contains("asd");
            int c3 = keys.Count;


            Dictionary<string, string> dictAng = new Dictionary<string, string>()
        {
            {"Russia", "Россия"},
            {"USA","США"},
            {"France", "Франция"}
        };
            Dictionary<string, string> dictRus = new Dictionary<string, string>()
        {
            {"Россия", "Russia"},
            {"США","USA"},
            {"Франция", "France"}
        };

            Console.WriteLine("Выберите направление перевода:");
            Console.WriteLine("1.Английский -> Русский");
            Console.WriteLine("2.Русский -> Английский");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Введите слово на английском ->");
                string word = Console.ReadLine();
                if (dictAng.ContainsKey(word))
                {
                    Console.WriteLine($"Перевод на русский: {dictAng[word]}");
                }
                else { Console.WriteLine("Перевод не найден!"); }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Введите слово на русском ->");
                string word = Console.ReadLine();
                if (dictRus.ContainsKey(word))
                {
                    Console.WriteLine($"Перевод на английский: {dictRus[word]}");
                }
                else { Console.WriteLine("Перевод не найден!"); }
            }
            else Console.WriteLine("НЕТ ТАКОЙ КОМАНДЫ!!!!!!");


            Person<int> tom = new Person<int>(546, "Tom");
            Person<string> bob = new Person<string>("abc123", "Bob");
            int tomId = tom.Id;
            string bobId = bob.Id;

            Console.WriteLine(tomId);  // 546
            Console.WriteLine(bobId);  // abc123

            Point3D poin = new Point3D(3, 4, 2);
            Console.WriteLine(poin.ToString());


            Sword sword = new Sword("ajsd", 50, "BadaBums", "Еще что то");
            GamePers<Sword> SAN = new GamePers<Sword>("San", "Чубака", sword);
            sword.Print();
            Console.WriteLine(SAN.ToString());


        }


       


        class ClassName<T1, T2>
        {
            //реализация методов и полей класса
            //которые работают с обобщёнными типами Т1,Т2,...ТN
            public T1 Id { get; }
            public T2 Password { get; set; }
            public string Name { get; set; }
            public ClassName(T1 id,T2 password, string name)
            {
                Id = id;
                Name = name;
                Password = password;
            }
        }

        class Person<T>
        {
            public T Id {  get; set; }
            public string Name { get; set; }
            public Person(T id,string name) 
            {
                Id = id;
                Name = name;
            }
        }

    }
}
