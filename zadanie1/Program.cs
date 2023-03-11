
 // ЗАДАЧА 1
// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine()!; 
// if(number.Length == 3){
//   Console.WriteLine($"{number} -> {number[1]}");
// }

// else 
// {
//   Console.WriteLine("Введено неверное число.");
// }

// ЗАДАЧА 2
// Console.WriteLine("Введите число:");
// string number = Console.ReadLine();
// if(number.Length == 3) {
//   Console.WriteLine($"{number} -> {number[2]}");
// }

// else {
//   Console.WriteLine("В данном числе нет третьей цифры");
// }

// ЗАДАЧА 3 

 Console.Write("Введите день недели (1-7): ");
int weekday;
 weekday = Convert.ToInt32(Console.ReadLine());
 switch (weekday)
 {
    case 1:
         Console.WriteLine("Это понедельник, но не выходной");
         break;
     case 2:
         Console.WriteLine("Это вторник, но не выходной");
         break;
     case 3:
         Console.WriteLine("Это среда, но не выходной");   
         break;
     case 4:
         Console.WriteLine("Это четверг, но не выходной");
        break;
     case 5:
         Console.WriteLine("Это пятница, но не выходной");
         break;
    case 6:
        Console.WriteLine("Это суббота, и это выходной!");
        break;
     case 7:
        Console.WriteLine("Это воскресенье, и это выходной!");
      break;
 }
