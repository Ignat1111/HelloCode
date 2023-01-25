Console.Write("Ввидите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "игнат")
{
   Console.WriteLine("Где ты был? Мы тебя заждались!");
}
else
{
   Console.Write("А ты кто?");
   Console.WriteLine(username);
}