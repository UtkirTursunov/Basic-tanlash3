/*
1.Palindrome Tekshiruvi: Palindrom, so'zning boshidan oxiriga qadar o'qilgandagi tartibida ham, oxiridan boshiga 
qadar o'qilgandagi tartibida ham bir xil bo'lgan so'z yoki satrdir. Misol uchun, "kayak", "radar" va "level" so'zlari 
palindromlarga misol bo'lishi mumkin. Sizdan kiritilgan satrning palindrom bo'lishini tekshiruvchi dastur yozishni
so'raymiz. Agar kiritilgan satr palindrom bo'lsa, dastur "Palindrom" degan xabarni chiqaradi, aks holda 
"Palindrom emas" degan xabarni chiqaradi.
Input: "kayak"
Output: "Palindrom"

System.Console.Write("Please enter the word: ");
string s = Console.ReadLine();
string s1 = "";
for (int i = s.Length-1; i >= 0; i--)
{
    s1 = s1 + s[i];
}
if (s1 == s)
{
    System.Console.WriteLine("Palindrom");
}
else
{
    System.Console.WriteLine("Palindrom emas.");
}
*/

/*2.
Temperatura o'girish: Foydalanuvchidan o'zbek tilida graduslar (Selsiyus) bo'yicha temperaturani kiritishni 
so'rang. Keyin kiritilgan temperaturani Fahrenheit va Kelvin ga o'girib, natijalarni ekranga chiqaring. 
Switch-operatoridan foydalaning.
Input: 25
Output: Selsiyus: 25, Fahrenheit: 77.0, Kelvin: 298.15

System.Console.Write("Marhamat temperaturani kiriting: ");
double Selsiyus = Convert.ToDouble(Console.ReadLine());
double Fahrenheit = Selsiyus * 9 / 5 + 32;
double Kelvin = Selsiyus + 273.15;
System.Console.WriteLine("1. Kiritilgan selsiyus temperaturani Fahrenheitga utkazish");
System.Console.WriteLine("2. Kiritilgan selsiyus temperaturani Kelvinga utkazish");
int temper = Convert.ToInt32(Console.ReadLine());
switch (temper)
{
    case 1:
    System.Console.WriteLine($"Siz kiritgan temperaturani Fahrenheitga utkazganda : {Fahrenheit} ga teng buladi");
    break;

    case 2:
    System.Console.WriteLine($"Siz kiritgan temperaturani Kelvinga utkazganda : {Kelvin} ga teng buladi");
    break;

    default : 
    System.Console.WriteLine("Bunday tanlov mavjud emas");
    break;
}*/


/*
3.Sonlarni tartiblash: Foydalanuvchidan o'zbek tilida sonlarni kiritishni so'rang.Keyin kiritilgan sonlarni 
tartiblangan qator (ascending) va teskari tartib (descending) bo'ylab ekranga chiqaring. Switch-operatoridan foydalaning.
Input: 9, 4, 7, 2, 5
Output:
Tartiblangan qator: 2, 4, 5, 7, 9
Teskari tartib: 9, 7, 5, 4, 2

System.Console.Write("Marhamat sonlarni bir-birida ajratgan holda kiriting: ");
string input = Console.ReadLine();

List<int> numbers = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

string.Join(", ", numbers.OrderBy(n => n));
string.Join(", ", numbers.OrderByDescending(n => n));

System.Console.WriteLine("Tartibni tanlang (1 - Tartiblangan, 2 - Teskari tartib): ");
int tanlov = int.Parse(Console.ReadLine());

switch (tanlov)
{
    case 1:
        System.Console.WriteLine("Tartiblangan qator: " + string.Join(" ", numbers.OrderBy(n => n)));
        break;

    case 2:
        System.Console.WriteLine("Teskari tartib: " + string.Join(" ", numbers.OrderByDescending(n => n)));
        break;

    default:
        System.Console.WriteLine("Noto'g'ri tanlov!");
        break;
}
*/


/*4.Berilgan matnning simvol sanasini hisoblash: Foydalanuvchidan bir matn kiritishni so'rang. Keyin, kiritilgan matndagi
har bir simvolni sanash va har bir simvolning nechta marta qaytarilganini aniqlang. Natijalarni ekranga chiqaring.
Input: "Hello, world!"
Output: 'H': 1 martta, 'e': 1 martta, 'l': 3 martta, 'o': 2 martta, ',': 1 martta, ' ': 1 martta,
'w': 1 martta, 'r': 1 martta, 'd': 1 martta, '!': 1 martta*/

Console.Write("Please enter the text: ");
string input = Console.ReadLine();

var charCount = input.Where(char.IsLetter).GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());

foreach (var letters in charCount)
{
    Console.Write($" {letters.Key} : {letters.Value},");
}




















