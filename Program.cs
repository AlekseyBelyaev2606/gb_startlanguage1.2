Console.Clear();
Console.WriteLine("Введите первое число");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int three = int.Parse(Console.ReadLine());
if (first > second){
    if(second > three){
    Console.WriteLine($"Первое число {first} больше");
    }
    else{
        if (first > three){
            Console.WriteLine($"Первое число {first} больше");
        }
        else{
            Console.WriteLine($"Третье число {three} больше");
        }
    }
}
else if (first < second && second < three){
    Console.WriteLine($"Третье число {three} больше");
}

else{
    Console.WriteLine($"Второе число {second} больше");
}