Console.WriteLine("Введите координаты первой точки: x y z");
string[] arr= Console.ReadLine().Split();
Console.WriteLine("Введите координаты второй точки: x y z");
string[] arr1= Console.ReadLine().Split();

int x1 = int.Parse(arr[0]);
int y1 = int.Parse(arr[1]);
int z1 = int.Parse(arr[2]);
int x2 = int.Parse(arr1[0]);
int y2 = int.Parse(arr1[1]);
int z2 = int.Parse(arr1[2]);

double d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine(d);