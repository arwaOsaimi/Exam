using System;
class aaaa{

public static void Main(string [] args){
    int[] Books = new int[3]; 
//    Books = Book.PrintDetails("Book","Arwa", 15.5D);
   ////////6

string firstName = Console.ReadLine();
int age = Convert.ToInt32(Console.ReadLine);
double myfavorateNumber =Convert.ToInt32(Console.ReadLine);

Console.WriteLine($"Hello, my name is {firstName} . I am {age} years old, and my favorite number is {myfavorateNumber} ");
////////////// 1

////////////// 2
int[] integers = new int[5]; 
foreach (int i in integers){
Console.WriteLine(i);
}

////////////// 3
int numberFromUser = Convert.ToInt32(Console.ReadLine);
Console.WriteLine(IsEven(numberFromUser));

////////////// 4
Console.WriteLine("Enter your age:" + age);
if(age<=12){
    Console.WriteLine("You are a child");
}else if(age <=17 ){
    Console.WriteLine("You are a teenager");
}else if(age >= 18 ){
    Console.WriteLine("You are a adult");
}
////////////// 5
switch(numberFromUser){
    case 1:
    Console.WriteLine("January");
    break;
    case 2:
    Console.WriteLine("February");
    break;
    case 3:
    Console.WriteLine("March");
    break;
    case 5:
    Console.WriteLine("June");
    break;
}
}


static int IsEven(int number){
if(number==2){
Console.WriteLine("Number Is Even!");
}else{
    Console.WriteLine("Number Is Odd!");
}
return number;
} //////////////3


}

//////////////6
// class Book{
//     String Title;
//     String Author;
//     double Price;

//     public void PrintDetails( string Title, string Author, double Price){
//     Console.WriteLine("Title:"+ Title , "Author" + Author , "Price:"+Price);

//     }

// }
