// See https://aka.ms/new-console-template for more information


int[] arr = { 1,3,5,7,9};
int max = arr.Max();
int min = arr.Min();
int minimumSum = 0;
int maximumSum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] != max) {
        minimumSum = minimumSum + arr[i];
    }
    if (arr[i] != min)
    {
        maximumSum = maximumSum + arr[i];
    }
}
Console.WriteLine(minimumSum);
Console.WriteLine(maximumSum);