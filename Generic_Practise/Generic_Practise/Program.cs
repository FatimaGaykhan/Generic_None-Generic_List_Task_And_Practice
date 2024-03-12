using System.Collections;
using System.Collections.ObjectModel;
using Generic_Practise;

//IntList datas = new IntList();
//datas.Add(1);
//datas.Add(2);
//datas.Add(3);

//var response = datas.GetAll();
//foreach (var item in response)
//{
//    Console.WriteLine(item);
//}
//StringList stringList = new StringList();
//stringList.Add("salam");
//stringList.Add("sagol");
//stringList.Add("necesen");
//var result= stringList.GetAll();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
//DataList<string> datas = new DataList<string>();
//datas.Add(1);
//datas.Add(2);
//datas.Add(3);
//var result = datas.GetAll();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
//datas.Delete(2);
//var result = datas.GetAll();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//DataList<Book> books = new DataList<Book>();
//books.Add(new Book { Id = 1, Name = "test1" });
//books.Add(new Book { Id = 2, Name = "test2" });
//books.Add(new Book { Id = 3, Name = "test3" });
//var booksResult = books.GetAll();
//foreach (var item in booksResult)
//{
//    Console.WriteLine(item.Name);
//}

//datas.Add("Fatima");
//datas.Add("Sadigkhan");
//datas.Add("Inji");
//datas.Add("Gunel");
//datas.Add("Elvin");

//datas.Delete("Elvin");
//var result=datas.GetAll();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
//datas.Delete("Fatima");
//var result = datas.GetAll();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//Repository<string> data1 = new Repository<string>();
//Repository<int> data2 = new Repository<int>();
//Repository<bool> data3 = new Repository<bool>();
//Repository<Book,BaseEntity> data4 = new Repository<Book,BaseEntity>();

//ArrayList list1 = new ArrayList();
//list1.Add(100);
//list1.Add("Salam");
//list1.Add(true);
//foreach (var item in list1)
//{
//    Console.WriteLine(item);
//}

//Hashtable hashtable = new Hashtable();
//hashtable.Add("Name", "Nasir");
//hashtable.Add("role", "Admin");
//hashtable.Add(100, 200);
//foreach (DictionaryEntry item in hashtable)
//{
//    Console.WriteLine(item.Key+" "+item.Value);
//}
//SortedList sortedList = new SortedList();
//sortedList.Add(100, 200);
//sortedList.Add(5, 100);
//sortedList.Add(55,100);
//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item.Key + " " + item.Value);
//}
//SortedList<string, int> datas = new SortedList<string, int>();
//datas.Add("roleId", 100);
//datas.Add("age", 30);
//foreach (KeyValuePair<string,int> item in datas)
//{
//    Console.WriteLine(item.Key + " " + item.Value);
//}

//Dictionary<string, string> datas = new Dictionary<string, string>();
//datas.Add("Test1","salam1");
//datas.Add("Test2", "salam2");
//datas.Add("Test3", "salam3");

//foreach (KeyValuePair<string,string> item in datas)
//{
//    Console.WriteLine(item.Key + " " + item.Value);
//}
//Console.WriteLine(datas["Test1"]);

//foreach (KeyValuePair<string,string> item in datas)
//{
//    if (item.Value=="salam2")
//    {
//        Console.WriteLine(item.Key);
//    }
//}

//Stack<int> nums = new();
//nums.Push(1);
//nums.Push(100);
//nums.Push(18);

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}
//Queue<int> nums = new();
//nums.Enqueue(1);
//nums.Enqueue(100);
//nums.Enqueue(18);

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}
//IEnumerable<int> nums = new List<int>();
//var result = nums.ToList();

List<int> numbers = new();
List<int> numbers2 = new List<int> { 54, 56, 67 };

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
//Console.WriteLine(numbers.Count);
//Console.WriteLine(numbers[0]);

//for (int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(numbers.FirstOrDefault (m=>m==5));

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}
////numbers.RemoveAt(0);
//Console.WriteLine("--------");
//numbers.AddRange(numbers2);
//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}


