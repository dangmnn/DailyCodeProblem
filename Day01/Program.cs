int[] arrNum = {10, 15, 3, 7};
int k = 18;

for (var i = 0; i < arrNum.Length; i++)
{
    for (var j = i + 1; j < arrNum.Length; j++)
    {
        if (arrNum[i] + arrNum[j] == k)
        {
            System.Console.WriteLine(arrNum[i] + " + " + arrNum[j] + " = " + k);
            break;
        }
    }
}