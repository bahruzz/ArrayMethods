
//string[] names = { "Hacixan", "Rashad", "Kamran", "Ilqar", "Fatime", "Afide", "Fexriyye" };

//string[] arr2 = new string[8];

//string[] arr3 = new string[3] {"Ismayil","Nesir","Ayxan"};

//Console.WriteLine(names[names.Length-1]);

//Console.WriteLine(names[3]);

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(i);
//}


//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}

//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}

//int[,] nums = { { 1, 2, 3 }, { 5, 6, 8 }, { 11, 22, 55 } };

//Console.WriteLine(nums.Rank);

//Console.WriteLine(nums[1,2]);

//int[,,] nums = { { { 3, 5 }, { 9, 0 }, { 150, 22 } }, { { 15044, 22 }, { 13, 21 }, 
//        { 1500, 22 } }, { { 150, 22 }, { 150, 22 }, { 150, 22 } } };


//Console.WriteLine(nums[1,2,0]);

//string[] names = { "Hacixan", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Fexriyye" };

//Console.WriteLine(names.Contains( "Reshad"));

//var datas=names.Reverse().ToArray();

//Console.WriteLine(datas[datas.Length-1]);

//Array.Sort(names);
//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}

//int[] nums = { 3, 5, 7, 8 };
//Array.Sort(nums);
//var datas=nums.Reverse().ToArray();
//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

//int[] arr1 = { 1, 2, 3 };
//int[] arr2= { 1, 2};
//arr1.CopyTo(arr2, 2);

//int[] arr = { 1, 2, 3 };
//Array.Resize(ref arr, 5);
//arr[3] = 200;
//Console.WriteLine(arr[3]);

//string[] arr = { "sd", "sd" };
//Array.Resize(ref arr, 3);
//Console.WriteLine(arr[2]);


//int[] arr1 = { 1, 2, 3 };

//int[] arr2 = { 4, 5 };

//Array.Resize(ref arr2, 5);

//arr1.CopyTo(arr2, 2);

//foreach (var item in arr2)
//{
//    Console.WriteLine(item);
//}

//string[] names = { "Hacixan", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Fexriyye" };

//var data = Array.Find(names, m => m == "Reshad");
//Console.WriteLine(data);

//string[] names = { "Hacixan", "Reshad", "Kamran", "Reshad", "Fatime", "Afide", "Fexriyye" };

//var data = Array.FindAll(names, m => m == "Reshad");

//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}

//
//string[] names = { "Hacixan", "Reshad", "Kamran", "Reshad", "Fatime", "Afide", "Fexriyye" };
//var data = Array.FindAll(names, m => m == "Reshad");

//Console.WriteLine(data.Length);

//string[] names = { "Hacixan", "Reshad", "Kamran", "Reshad", "Fatime", "Afide", "Fexriyye" };

//var data = Array.FindIndex(names, m => m == "Kamran");

//Console.WriteLine(data);

//string[] names = { "Hacixan", "Reshad", "Kamran", "Reshad", "Fatime", "Kamran", "Fexriyye" };
//var data = Array.FindLast(names, m => m == "Kamran");

//Console.WriteLine(data);

//string[] names = { "Hacixan", "Reshad", "Kamran", "Reshad", "Fatime", "Afide", "Fexriyye" };
//var data = names.FirstOrDefault();
//Console.WriteLine(data);

//string[] names = { "Hacixan", "Reshad", "Kamran", "Reshad", "Fatime", "Afide", "Fexriyye" };

//var data = names.LastOrDefault();
//Console.WriteLine(data);

//var data = names.FirstOrDefault(m=>m=="Kamran");

//Console.WriteLine(data);

//var datas = names.Any(m => m == "Kamran");

//var datas = names.All(m => m == "Kamran");


//var data = Array.Exists(names, m => m == "Kamran");
//Console.WriteLine(data);

//var datas=names.Where(m=>m=="Reshad").ToArray();
//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

//var datas = names.OrderBy(m => m );
//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}


//var datas = names.OrderByDescending(m => m);
//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}


//var datas = names.Any(m => m == "Kamran");

//foreach (var item in names)
//{
//    if (item == "Kamran")
//    {
//        Console.WriteLine(true);
//        break;
//    }
//}


//var datas = names.All(m => m == "Reshad");

//string[] names = { "Hacixan", "Reshad", "Kamran", "Reshad", "Fatime", "Afide", "Fexriyye" };

//int count = 0;

//for (int i = 0; i < names.Length; i++)
//{
//    if (names[i] == "Reshad")
//    {
//        count++;
//    }
//}
//if (count == names.Length)
//{
//    Console.WriteLine(true);
//}
//Console.WriteLine(false);

//string[] names = { "Hacixan", "Reshad", "Kamran", "Reshad", "Fatime", "Afide", "Fexriyye" };
//bool CheckAllDatas(string[] datas)

//{
//    int count = 0;

//    for (int i = 0; i < names.Length; i++)
//    {
//        if (names[i] == "Reshad")
//        {
//            count++;
//        }
//    }

//        if (count == names.Length)
//        {
//                  return true;
//        }
//    else
//    {
//        return false;
//    }
//}
//Console.WriteLine(CheckAllDatas(names));


//string[] names = { "Hacixan", "Reshad", "Kamran", "Reshad", "Fatime", "Afide", "Fexriyye" };
//bool CheckAllDatas(string[] datas,string str)

//{
//    int count = 0;

//    for (int i = 0; i < names.Length; i++)
//    {
//        if (names[i] == str)
//        {
//            count++;
//        }
//    }

//    if (count == names.Length)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//Console.WriteLine(CheckAllDatas(names,"Kamran"));


//DateTime date = DateTime.Now;
//Console.WriteLine(date);

//DateTime date = DateTime.Now.AddDays(10);
//Console.WriteLine(date);

//DateTime date = DateTime.Now.AddYears(10);
//Console.WriteLine(date);


//DateTime Birthday = new DateTime(2002, 05, 25);
//Console.WriteLine(Birthday);

//DateTime birthday = new DateTime(2002, 05, 25);
//Console.WriteLine(birthday);

//DateOnly date=new DateOnly(2002,05,25);
//Console.WriteLine(date);


//var date=DateTime.Now;
//Console.WriteLine(date.ToString("dddd, dd MM yyyy "));

//var date = DateTime.Now;
//Console.WriteLine(date.ToString("MM-dd-yyyy  HH:mm "));


//var currentYear = DateTime.Now.Year;
//DateTime birthday = new DateTime(2002, 05, 25);
//var birthdayYear=birthday.Year;
//Console.WriteLine(currentYear - birthdayYear);

