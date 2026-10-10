# Special Topics in C# - PART 1

#### This exercise is based on the <a href="https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/?couponCode=MT260714G2">"C# COMPLETO Programação Orientada a Objetos + Projetos"</a> course.

#### This repository covers the concepts and use of Extension Methods in C#.

## Extension Methods

#### Methods that extend the functionality of a type without modifying its source code or inheriting from it.

#### How to create an extension method?

- Create a static class.
- Inside the class, create a static method.
- The first parameter of the method must have the this keyword as a prefix, followed by the declaration of a parameter of the type you want to extend. This parameter will be a reference to the object itself.

### Extension Methods - ElapsedTime()

#### Let's create an extension method called ElapsedTime() for the DateTime struct that displays the elapsed time in hours (if less than 24 hours) or days otherwise.

#### For example:

``` C#
DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
Console.WriteLine(dt.ElapsedTime());
```

<strong>"4.5 hours"<br>
"3.2 days"</strong>

### Extension Methods - Cut(int)

#### Let's create an extension method called Cut(int) for the String class that takes an integer as a parameter and returns a substring of the original string with the specified length.

#### For example:

``` C#
String s1 = "Good morning dear students!";
Console.WriteLine(s1.Cut(10));
```

<strong>"Good morni..."</strong>