# Special Topics in C# - PART 1

#### This exercise is based on the <a href="https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/?couponCode=MT260714G2">"C# COMPLETO Programação Orientada a Objetos + Projetos"</a> course.

#### This repository covers the concepts and use of Extension Methods in C#.

## Extension Methods

#### Methods that extend the functionality of a type without modifying its source code or inheriting from it.

#### How to create an extension method?

- Create a static class.
- Inside the class, create a static method.
- The first parameter of the method must have the this keyword as a prefix, followed by the declaration of a parameter of the type you want to extend. This parameter will be a reference to the object itself.