// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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
