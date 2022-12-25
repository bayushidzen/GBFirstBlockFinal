Console.Clear();
string[] arr1 = {"hello","2","world",":-)"};
string[] arr2 = new string[arr1.Length-1];
int j = 0;

for (int i=0; i< arr1.Length;i++)
{
    if (arr1[i].Length <= 3) 
    {
        arr2[j] = arr1[i];
        Console.WriteLine(arr2[j]);
        j++;
    }
}