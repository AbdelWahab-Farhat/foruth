// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Stack<int> myStack = new Stack<int>(10);
myStack.Push(10);
myStack.Push(20);
myStack.Push(30);
myStack.Push(40);
myStack.Push(50);

System.Console.WriteLine("The elements in the Stack are: " + myStack.Count);

foreach (var item in myStack)
{
    Console.WriteLine(item);
    System.Console.WriteLine("The elements in the Stack are: " + myStack.Count);
}