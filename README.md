# Understanding abstract classes with C#

The C# programming language enables a class designer to specify that a base class declares a method that does not supply an implementation. This is called an abstract method. The implementation of this method is supplied by the derived classes. Any class with one or more abstract method is called an abstract class.

Fig 1 UML model of the abstract class.



The purpose of an abstract class is primarily to provide an appropriate base class from which other classes can inherit and thus share a common design. However, abstract classes can have data attributes, concrete methods, and constructors. For example, the Vehicle class might include load and maxLoad attributes and a constructor to initialize them. Not all inheritance hierarchies contain abstract classes. However, programmers often write client code that uses only abstract base class types to reduce the client code's dependencies on a range of specific derived class types. The C# compiler always prevents you form instantiating an abstract class, for example the following statement is illegal.

 Vehicle v = new Vehicle(); // this is illegal and the compiler generates an error.
Although we cannot instantiate objects of abstract base classes, we will see that we can use abstract base classes to declare variables that can hold references to objects of any concrete classes derived from those abstract classes.

The employee abstract class: A example using Polymorphism through inheritance
What is polymorphism?
The term polymorphism refers to the ability of two or more objects belonging to different classes to respond to exactly the same message (method call) in different class-specific ways, thus polymorphism enables us to "program in the general" rather than "program in the specific".

Polymorphism allows:

Different behavoirs from the same type.
Runtime polymorphism is done via overriding.
Compile time polymorphism is done via method overloading.
Invoke methods of a derived class through a base class.
I think the best way to learn about this concept is through an example, so I wrote a set of examples using an inheritance hierarchy containing types of employees in a company.
Fig 2 Employee hierarchy UML class diagram.



We use abstract class Employee to represent the general concept of an employee. The classes that inherit from Employee are: CommissionEmployee, PieceEmployee and HourlyEmployee.

1. I use abstract class Employee to represent the general concept of an employee. The classes that inherit from Employee are: CommissionEmployee, PieceEmployee and HourlyEmployee.

Listing 1. Abstract base class Employee



In this example, class Employee will provide two methods Earnings and Details, and properties that manipulate an Employee's instance variables, the method Earnings certainly applies generally to all employee's, but each earnings calculation depends on the derived employee's class. So these two methods must be abstract in the Employee class because an implementation does not make sense there, so each derived class must override those methods with an appropriate implementation.

2. I wrote three concrete classes: HourlyWorker, CommissionWorker and PieceWorker. Such classes provide implementations of the abstracts methods declared in our abstract class, because abstract base classes are too general to create real objects.

Listing 2. Concrete derived class HourlyEmployee



Listing 3. Concrete derived class CommissionEmployee



Listing 4. Concrete derived class PieceWorker



To test our example, the following program creates an array of our abstract base class Employee, then assigns the four instances of our concretes classes to the array variable. Finally, the program iterates through array Employee and polymorphically invokes methods Earnings and Details to display the output of each of these methods.

Listing 5. Test program for our example.



Fig 3. The output for our example.



Note: Those examples were based on the examples included in: Deitel's developer series C# 2010 for programmers.

Download the source code.
