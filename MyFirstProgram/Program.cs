// See https://aka.ms/new-console-template for more information
int x; //Declaration
x = 123; //Initialization
string RoomMate = "Josh"; //Both Declaration and Initialization in the same line
int one, two;
bool alive = true;
one = 3;
two = 4;
var Result = one * two;
Console.Write(Result);
Console.WriteLine("\tLance\bHancock" + RoomMate);
Console.WriteLine("Are you alive"+alive);
char symbol = '@'; //Note you can only use '' and not ""
String name = "Lance";
Console.WriteLine("Your symbol is:" + symbol);
Console.WriteLine("Hello "+ name);
String userName = name + symbol;
Console.WriteLine(userName);
const double Pi = 3.14159;
Console.WriteLine("This is PI "+Pi);
double ab = 3.14;
int ac = Convert.ToInt32(ab);
Console.WriteLine(ac);
String cat = "5";
int cat2 = Convert.ToInt32(cat);
Console.WriteLine(cat2);
int dog = 5;
String dog2 = Convert.ToString(dog);
Console.WriteLine(dog2);
float temp = (float)67.78M;
int temp2 = Convert.ToInt32(temp);
Console.WriteLine(temp2);
Console.WriteLine(ac);
Console.WriteLine(dog2.GetType());
int p = 123;
double q = Convert.ToDouble(p) + 0.1;
Console.WriteLine(q);
//To convert a string to a char
String g = "$";
char h = Convert.ToChar(g);
Console.WriteLine(h);
String I = "true";
bool j = Convert.ToBoolean(I);
Console.WriteLine(j);
Console.ReadKey();