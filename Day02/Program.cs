int[] arrNum = {1,2,3,4,5};
int[] result = new int[arrNum.Length];

for (var i = 0; i < arrNum.Length; i++)
{
    var temp = 1;
    for (var j = 0 ; j < arrNum.Length; j++)
    {
        if(arrNum[i] != arrNum[j])
        {
            temp = temp * arrNum[j];
        }
    }
    result[i] = temp;
}

for (var i = 0; i < result.Length; i++)
{
    System.Console.WriteLine(result[i]);
}