Console.WriteLine("#1.1#");
for (int i = 10; i >= 1; i--) {
    Console.WriteLine(i);
}
Console.WriteLine("#1.2#");
for (int i = 50; i >= 1; i--) {
    if (i % 2 == 0) {
        Console.WriteLine(i);
    }
}
Console.WriteLine("#сумма#");
int sum = 0;
for (int i = 1; i <= 10; i++) {
    sum += i;
}
Console.WriteLine($"Сумма: {sum}");
Console.WriteLine("#2#");
int sum3 = 0;
int count7 = 0;
for (int i = 1; i <= 100; i++) {
    if (i % 3 == 0) {
        sum3 += i;
    }
    if (i % 7 == 0) {
        count7 += 1;
    }
}
Console.WriteLine($" {sum3} {count7}");
Console.WriteLine("#3#");

int number = Convert.ToInt32(Console.ReadLine());
int total = 0;
int countminus = 0;
int countplus = 0;

while (number != 0) {
    if (number < 0) {
        countminus += 1;
    }
    if (number > 0) {
        countplus += 1;
    }
    total += number;
    number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"{countplus} {countminus}");
Console.WriteLine($"Сумма: {total}");
Console.WriteLine("#4#");
string password;
do
{
    Console.Write("Введите пароль: ");
    password = Console.ReadLine();
}
while (password != "qwerty" && boolpassword);

Console.WriteLine("Доступ разрешён");