
// Первая группа методов которые 
// ничего не возвращают и не принимают
// Вид 1
void Method1 ()
{
Console.WriteLine("Автор ...");
}
//Method1(); // вызвов метода !если без() будет ошибка!

// Вид 2
void Method2(string msg) // Ничего не возвращает но может
                         // принимать какие-то аргументы
{
Console.WriteLine(msg);
}
//Method2("Текст сообщения ");

void Method21(string msg, int count)
{
    int i = 0;
while (i < count)
{

Console.WriteLine (msg) ;
i++;
}
}
//Method21(msg:"Текст",count: 4);
//Method21(count: 4, msg: "новый текст");

// Вид 3 .    Что-то возвращают но ничего не принимают
int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

// Вид 4 !!!Что-то принимают и что-то возвращают!!!
string Method4(int count,string text)
{
int i =0;
string result = String.Empty;// пустая строка
while (i<count)
{
result = result+text;
    i++;
}
return result;
}
string res = Method4(10,"Dunkan ");
Console.WriteLine(res);

