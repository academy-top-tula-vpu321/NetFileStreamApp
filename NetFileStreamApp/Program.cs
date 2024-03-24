using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
string fileName = "file01.dat";
string text = "Записывает последовательность байтов в текущий файловый поток из диапазона только для чтения и перемещает текущую позицию внутри файлового потока на число записанных байтов.";
string insert = "***********";


//using (FileStream stream = new("file01.dat", FileMode.Create))
//{
//    Console.WriteLine($"Name: {stream.Name}");
//    Console.WriteLine($"Length: {stream.Length}");
//    Console.WriteLine($"Position: {stream.Position}");

//    stream.Write(Encoding.UTF8.GetBytes(text));
//}

using (var stream = File.Create(fileName))
{
    stream.Write(Encoding.UTF8.GetBytes(text));
    stream.Seek(-20, SeekOrigin.End);
    stream.Write(Encoding.UTF8.GetBytes(insert));
}

//using (var stream = File.OpenRead(fileName))
//{
//    var buffer = new byte[stream.Length];
//    //stream.Read(buffer, 0, buffer.Length);
//    await stream.ReadAsync(buffer, 0, buffer.Length);

//    Console.WriteLine(Encoding.UTF8.GetString(buffer));
//}

//int size = 10;
//int[] array = new int[size];

//using(var streamBin = File.Create(fileName))
//{
//    Random random = new();
//    int number = random.Next();

//    for (int i = 0; i < size; i++)
//        array[i] = random.Next();

//    streamBin.Write(BitConverter.GetBytes(number));
//    foreach(int i in array)
//        streamBin.Write(BitConverter.GetBytes(i));
//}

//using (var streamBin = File.OpenRead(fileName))
//{
//    byte[] buffer = new byte[sizeof(int)];
//    streamBin.Read(buffer, 0, buffer.Length);
//    //Console.WriteLine();
//}


//FileStream stream = File.Open("file01.dat", FileMode.Open);
//FileStream stream2 = File.OpenWrite("file01.dat");
//FileStream stream3 = File.OpenRead("file01.dat");

