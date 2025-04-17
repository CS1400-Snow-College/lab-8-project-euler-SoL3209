Console.Clear();
Console.WriteLine("This program will do EXACTLY what it was asked.");
Console.Write(@"Choose your fate:
1. Even Fibonacci Numbers

2. Smallest Multiple

3. Another problem

4. Yet another problem");
int userChoice = Convert.ToInt32(Console.ReadLine());
long eulerProblem = userChoice switch
{
1 => Cheese(),
2 => Ham(),
3 => FrenchWine(),
4 => BoiledPotatoes(),
};
static int Cheese()
{
Console.WriteLine("Let's do some calacations...");
int sum = 0;
for(int i = 1; i<1000; i++)
{
if(i % 3 == 0 || i % 5 == 0)
{
sum += i;
}}
Console.WriteLine(sum);
return sum;
}
static int Ham()
{
Console.WriteLine("Remainer 5 from 30 or some stuff");
int a = 1;
int b = 2;
int sum = 0;
while(b<4000000)
{
if(b % 2 == 0)
sum += b;
int next = a + b;
a = b;
b = next;
}
Console.WriteLine(sum);
return sum;
}
static int FrenchWine()
{
Console.WriteLine("Is very French, no?");
int num = 1;
while(true)
{
if (num % 2 == 0 && num % 3 == 0 && num % 4 == 0 && num % 5 == 0 && num % 6 == 0 && num % 7 == 0 && num % 8 == 0 && num % 9 == 0 && num % 10 == 0 && num % 11 == 0 && num % 12 == 0 && num % 13 == 0 && num % 14 == 0 && num % 15 == 0 && num % 16 == 0 && num % 17 == 0 && num % 18 == 0 && num % 19 == 0 && num % 20 == 0)
{
Console.WriteLine(num);
return num;
}
num++;
}}
static long BoiledPotatoes()
{
Console.WriteLine("Prime numbers");
long sum = 2;
for(int i = 3; i<2000000; i += 2)
{
if(IsPrime(i))
sum += i;
}
Console.WriteLine(sum);
return sum;
}
static bool IsPrime(long num)
{
if(num == 2 || num == 3)
return true;
if(num < 2)
return false;
for(int i = 3; i <= Math.Sqrt(num); i += 2)
{
if(num % i == 0)
return false;
}
return true;
}