Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "тимур")
{
    Console.WriteLine("Ура, это же Тимур!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}