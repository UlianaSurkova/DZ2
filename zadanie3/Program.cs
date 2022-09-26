Console.Write("Введите цифру, обозначающую любой день недели! ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("это выходной -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("нет такого дня недели,введите цифру от 1 до 7");
  }
  else Console.WriteLine("это не выходной -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);