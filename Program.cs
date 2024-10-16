//==================== 1.Tub sonlar ====================//

Console.WriteLine("Sonni kiriting: ");
int son = int.Parse(Console.ReadLine());

bool tub = true;

if (son <= 1)
{
    tub = false;
}
else
{
    if (son != 2 && son  % 2 == 0)
    {
        tub = false;
    }
    else
    {
        for (int i = 3; i*i <= son; i+=2)
        {
            if (son % i == 0)
            {
                tub = false;
                break;
            }
        }
    }
}

if (tub)
{
    Console.WriteLine("Tub");
}
else
{
    Console.WriteLine("Tub emas");
}

//==================== 2.Bo'luvchisiz sonlar ====================//

Console.WriteLine("Sonni kiriting: ");
int son1 = int.Parse(Console.ReadLine());

for (int i = 2; i <= 10; i++)
{
    if (son1 % i == 0)
    {
        Console.WriteLine(i+" ");
    }
}

//==================== 3.Daraja hisoblash ====================//

Console.WriteLine("Sonni kiriting: ");
int Son = int.Parse(Console.ReadLine());
Console.WriteLine("Darajani kiriting: ");
int Daraja = int.Parse(Console.ReadLine());

 if (Daraja < 0)
{
    Console.WriteLine("Daraja musbat butun son bo'lishi kerak.");
    return;
}

int natija = 1;
for (int i = 1; i <= Daraja; i++)
{
    natija *= Son; 
}

Console.WriteLine(natija);

//==================== 4.Harajatlar to'plamini hisoblash ====================//

Console.WriteLine("Nechta miqdor qo'shmoqchisiz?: ");
int n = int.Parse(Console.ReadLine());

int[] sonlar = new int[n];

Console.WriteLine("Miqdorlarni kiriting: ");
for (int i = 0; i < n; i++)
{
    sonlar[i] = int.Parse(Console.ReadLine());
} 

int hisoblash = 0;
for (int i = 0; i<n; i++)
{
    hisoblash += sonlar[i];
}

Console.WriteLine(hisoblash);

//==================== 5.Armstrong sonlar ====================//

Console.Write("Bir son kiriting: ");
int SON = int.Parse(Console.ReadLine());

int originalSon = SON;
int yigindi = 0;
int darajalarSoni = 0; 

while (SON > 0)
{
    SON /= 10; 
    darajalarSoni++; 
}

SON = originalSon;

while (SON > 0)
{
    int raqam = SON % 10; 
    yigindi += (int)Math.Pow(raqam, darajalarSoni); 
    SON /= 10; 
}

if (yigindi == originalSon)
{
    Console.WriteLine("Armstrong son");
}
else
{
    Console.WriteLine("Armstrong son emas");
}

//==================== 6.Sifatli bo'luvchilar ====================//

Console.Write("Sonni kiriting: ");
int x = int.Parse(Console.ReadLine());

List<int> boluvchilar = new List<int>();
List<int> boluvchilar2 = new List<int>();

for (int i = 1; i <= n; i++)
{
    if (x % i == 0)
    {
        boluvchilar.Add(i);
    }
}

for (int i = 0; i < boluvchilar.Count-1; i++)
{
    if (boluvchilar[i+1] == boluvchilar[i]+1) 
    {
        boluvchilar2.Add(boluvchilar[i]);
        boluvchilar2.Add(boluvchilar[i+1]);
    }
}

HashSet<int> SifatliBoluvchilar = new HashSet<int>(boluvchilar2);

Console.WriteLine(SifatliBoluvchilar.Count);