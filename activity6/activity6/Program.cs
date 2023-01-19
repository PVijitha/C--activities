decimal[] user = new decimal[10];
Console.WriteLine("Enter the fare");
for(int i = 0;i < user.Length; i++)
{
    user[i] = decimal.Parse(Console.ReadLine());
}
Console.WriteLine(string.Join(",", user));

string[] des = new string[10];
Console.WriteLine("Enter the destinations");
for(int j = 0;j < des.Length; j++)
{
    des[j] = Console.ReadLine();
}
Console.WriteLine(string.Join(",", des));

Console.WriteLine("Enter the index number");
int index = int.Parse(Console.ReadLine());
if(user.Length > index)
{
    Console.WriteLine(user[index]);
    Console.WriteLine(des[index]);
}