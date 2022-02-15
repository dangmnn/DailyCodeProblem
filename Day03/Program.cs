int[] arrNum = {3, 4, -1, 1};
int result = 1;
int count = 0;
Array.Sort(arrNum);
int[] temp = arrNum.Distinct().ToArray();

for (var i = 0; i < temp.Length; i++)
{
    if(temp[i] > 0)
    {
        if(i != temp.Length-1)
        {
            if(temp[i+1] - temp[i] != 1)
            {
                result = temp[i] + 1;
            }else
            {
                count++;
            }
        }
    }
    else
    {
        count++;
    }
}

if(count == temp.Length -1)
{
    result = temp[temp.Length-1] +1;
}
System.Console.WriteLine(result);