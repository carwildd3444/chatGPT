//Працівник
/*Працівники
Створити ієрархію класів для подання інформації про працівників з погодинною оплатою  та працівників, що працюють на ставку. 
Для кожного працівника зберігати  ПІБ,  дату прийому на роботу, посаду, ід. код, стаж роботи на поточній(останній) на посаді).

Створити програму для роботи з працівниками
	Додавання  працівника  у базу
	Збереження бази працівників( у файл)
	Завантаження бази працівників з файлу
	Перегляд  працівників, впорядкованих по ПІБ(з інформацією про посади, відпрацьовані дні чи години)
	Пошук певного працівника за прізвищем, за посадою
	Видалення(звільнення) певного працівника  з бази
	Зміна посади працівника
	Нарахування заробітної плати працівникам(згідно посадового окладу та стажу одним,  та згідно тарифної ставки за годину по окладу  іншим)
	Зміна числа відпрацьованих годин для працівників на погодинній оплаті, числа відпрацьованих та лікарняних днів  - іншим.

*/

using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

Console.WriteLine("Employee");

Console.WriteLine("\tMENU\n +" +
    "1. Add New Employee\n" +
    "2. Save Employee to a file\n" +
    "3. Load Employee\n" +
    "4. Show All Employee\n" +
    "5. Find View employees sorted by last name\r\n\n" +
    "6. Delete Employee\n" +
    "7. Change of position of an employee\r\n\n" +
    "8. Sell Employee");
Console.WriteLine("______________________________");

Console.Write("Your choice: ");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        var item = new Employee();
        item.FullName = Console.ReadLine();
        item.Description = Console.ReadLine();
        item.ID = int.Parse(Console.ReadLine());
        item.DateOfEmployment = int.Parse(Console.ReadLine());
        item.Position = Console.ReadLine();
        break;
}


public class Employee
{
    // властивості Працівник
    public string FullName { get; set; }
    public string? Description { get; set; }
    public int ID { get; set; }
    public int DateOfEmployment { get; set; }
    public string Position { get; set; }

    public void ReadFromConsole()
    {
        Console.Write("Enter Full Name: ");
        FullName = Console.ReadLine();

        Description = Console.ReadLine();

        ID = int.Parse(Console.ReadLine());
        DateOfEmployment = int.Parse(Console.ReadLine());
        Position = Console.ReadLine();
    }

    public void Show()
    {
        Console.WriteLine($"Name: {FullName}");
        Console.WriteLine($"Price: {Description}$");
        Console.WriteLine($"Quantity: {ID}$");
        Console.WriteLine($"Discount: {DateOfEmployment}%");
        Console.WriteLine($"Category: {Position}");
    }



