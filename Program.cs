//First Task
 int number = Convert.ToInt32(Console.ReadLine());
 if(number<1000 && number>99){
     Console.WriteLine((number%100)/10);
 }else{
     Console.WriteLine("Число не является трёхзначным");
 }
//Second Task
 int number0 = Convert.ToInt32(Console.ReadLine());
 if (number0<10000000 && number0 > 999999){
     Console.WriteLine((number0/10000)%10);
 }else{
     Console.WriteLine("третьей цифры нет");
 }
//The third digit from the right
 int number1 = Convert.ToInt32(Console.ReadLine());
 if(number1<10000000 && number1 > 999999){
     Console.WriteLine((number1/100)%10);
 }else{
     Console.WriteLine("в конце нет третьей цифры");
 }