Console.WriteLine("Methods!");

SayHi("Mike", 33);
SayHi("John", 35);
SayHi("Tom", 39);

static void SayHi(string name, int age)
{
    Console.WriteLine($"Hello {name} you are {age}");
}

//Return Statement

int cubedNumber = cube(5);
Console.WriteLine(cubedNumber);

static int cube(int num)
{
    int result = num * num * num;
    return result;
}

//If Statement

bool isMale = true;
bool isTall = false;

if (isMale && isTall)
{
    Console.WriteLine("You are a tall male");
}
else if (isMale && !isTall)
{
    Console.WriteLine("You are a short male");
}
else if (!isMale && isTall)
{
    Console.WriteLine("You are not a male but you are tall");
}
else
{
    Console.WriteLine("You are not Male and not tall");
}

// more if statements and comparisons
Console.WriteLine(GetMax(20, 10, 40));

static int GetMax(int num1, int num2, int num3)
{
    int result;

    if (num1 >= num2 && num1 >= num3) {
        result = num1;
    } else if  (num2 >= num1 && num2 >= num3){
        result = num2;
    } else
    {
        result = num3;
    }

    return result;
}