// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1
int x_1;
x_1 = Convert.ToInt32(Console.ReadLine());
string str;
str = Console.ReadLine();
if(x_1>str.Length)
{
    Console.WriteLine(str.ToUpper());
}
else
    Console.WriteLine(str.ToLower());
//2
int x = 15, y = 10;

if(x>y)
{ Console.WriteLine("x is greater than y"); }
if(x<y)
{ Console.WriteLine("y is greater than x"); }
if(x==y)
{ Console.WriteLine("x equal to y"); }
else
    Console.WriteLine("x and y are not comparable");
//3
string dayweek;
dayweek = Console.ReadLine();
string result = dayweek switch
{
"Dushanba"=>$"{dayweek}-Monday",
"Seshanba"=>$"{dayweek}-Tuesday",
"Chorshanba"=>$"{dayweek}-Wednesday",
"Payshanba"=>$"{dayweek}-Thursday",
"Juma"=>$"{dayweek}-Friday",
"Shanba"=>$"{dayweek}-Saturday",
"Yakshanba"=>$"{dayweek}-Sunday"
};
Console.WriteLine(result);
