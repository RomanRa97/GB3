int N = Convert.ToInt32(Console.ReadLine());

int [] array = new int[N];
int i = 0;

while (i<N)
{
    array[i] = (int)Math.Pow(i+1, 3);
    Console.Write(array[i]+" ");
    i ++;
}
