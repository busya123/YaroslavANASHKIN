/*
// Вид 1
void Method1()
{
    Console.WeiteLine("Автор ...");
}
//Method1();











// Вид 2
void Method2(string msg)
{
    Console.WeiteLine(msg);
}
//Method2("Текст сообщения"); 

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg:"Текст", count: 4);
//Method21(count: 4, msg: "новый текст");







// Вид3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);








//Вид3

//string Method4(int count, string text)
//{
//    Int I = 0;
//    striyg result = String.Empty;
//
//    while (I < count)
//    {
//        result = result + text;
//        I++;       
//    }
//    return result;
//}    
//string res = Method4(10, "z");
//Console.WriteLine(res);
/*
string Method4(int count, string text)
{
    string result = String.Empty;
    for( Int i = 0; i < count; i++)

    {
        result = result + text;
    }
    return result;
}    
striyg res = Method4(10, "z");
//Console.WriteLine(res);

for(int i = 2; i <= 10; i++)
{   
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
}


int[]arr ={1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int [] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
    Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.length ; i++)
    {
        Int minPosition = i;

        int temporaru = array [i]
        array[i] = array[minPosition];
        array[nPosition] =temporary;
    }
}

PrintArray(arr);
*/
