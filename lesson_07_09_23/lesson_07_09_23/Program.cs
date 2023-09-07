//task1


/*int a, b, c;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
double p = (a + b + c) / 2;
double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
Console.WriteLine(S);*/


//task2


/*int[] nums = new int[3];
string a = Console.ReadLine();
string[] data = a.Split(new char[] { ' ' });
for (int i = 0; i < 3; i++)
{
    nums[i] = Convert.ToInt32(data[i]);
}
int m = max(nums);
Console.WriteLine(m);

int max(int[] nums)
{
    int m = nums[0];
    for (int i = 1; i < 3; i++)
    {
        if (nums[i] > m) { m = nums[i]; }
    }
    return m;
}*/


//task3


/*using System.Linq;

string a = Console.ReadLine();
string[] data = a.Split(new char[] { ' ' });
int[] nums = new int[data.Length];

for (int i = 0; i < data.Length; i++)
{
    nums[i] = Convert.ToInt32(data[i]);
}

int fnd = nums[nums.Length - 1]; //remove last element

if (!isin(nums, fnd))
{
    Console.WriteLine("Элемента нет в среди этих чисел");
} 
else
{
    print_all_ind(nums, fnd);
}



bool isin(int[] nums, int fnd) // проверка на то, есть ли элемент в строке
{
    bool f = false;
    for(int i = 0; i < nums.Length - 1; i++)
    {
        if (nums[i] == fnd)
        {
            f = true;
        }
    }
    return f;
}

void print_all_ind(int[] nums, int fnd) 
{
    for (int i = 0; i < nums.Length - 1; i++)
    {

        if (nums[i] == fnd)
        {
            Console.WriteLine(i);
        }
    }
}*/

//task4

/*
string a = Console.ReadLine();
string[] data = a.Split(new char[] { ' ' });
int[] nums = new int[data.Length];
for (int i = 0; i < data.Length; i++)
{
    nums[i] = Convert.ToInt32(data[i]);
}

int max = nums[0], min = nums[0], imax = 0, imin = 0;
for (int i = 1; i <  nums.Length; i++) // идем с единицы, т.к. нулевые значения уже приравняли
{
    if (nums[i] > max)
    {
        max = nums[i];
        imax = i;
    }
    if (nums[i] < min)
    {
        min = nums[i];
        imin = i;
    }
}

Console.WriteLine($"Max={max} Max index={imax}");
Console.WriteLine($"Min={min} Min index={imin}");
*/


//task4.1

/*string a = Console.ReadLine();
string[] data = a.Split(new char[] { ' ' });
int[] nums = new int[data.Length];

for (int i = 0; i < data.Length; i++)
{
    nums[i] = Convert.ToInt32(data[i]);
}

int max = nums[0], min = nums[0], imax = 0, imin = 0;
for (int i = 1; i < nums.Length; i++) // идем с единицы, т.к. нулевые значения уже приравняли
{
    if (nums[i] > max)
    {
        max = nums[i];
        imax = i;
    }
    if (nums[i] < min)
    {
        min = nums[i];
        imin = i;
    }
}

int tmp = nums[imax]; //меняем строки местами
nums[imax] = nums[imin];
nums[imin] = tmp;

//string str = string.Join(" ", nums); 
Console.WriteLine(string.Join(" ", nums));
*/

//task5


int a = Convert.ToInt32(Console.ReadLine());
print_tree(a);


void print_line(int count_spaces, int count_stars)
{
    for (int i = 0; i < count_spaces; i++)
    {
        Console.Write(" ");
    }
    for (int i = 0; i < count_stars; i++)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}

void print_tree(int a)
{
    int count_spaces = a - 1;
    int count_stars = 1;
    for (int i = 0; i < a; i++)
    {
        print_line(count_spaces, count_stars);
        count_spaces--;
        count_stars+=2;
    }
    print_line(a - 1, 1);
}