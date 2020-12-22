# week 1 - C\#

## bash

- cd = change directory
- mkdir = make directory
- pwd = print working directory, . current position, .. parent directory
- ls = list resources, -a --all all resources, -l all information
- touch = create a resource/file
- cat = read/display content of resource/file
- code = launch VS Code
- ssh-keygen =  generate ssh key, public and private keys, secure shell
- nano = command line editor
- sudo = root permission
- apt = advanced package tool, update check for updates, install install package, upgrade apply updates
- wget = download web resource

## dotnet

### commands

- dotnet new = create new resource (project, gitignore, solution), console(exe), classlib(dll), sln,  gitignore, xunit(test)
- dotnet build = code compilation
- dotnet test = run unit tests
- dotnet run = execute code, runtime [invoke dotnet build in the background]
- dotnet add = add package/reference to project
- dotnet sln = add add project to solution, remove remove project from solution

### platform

- compiler = conversion/translation tool, type checker, permission checker, high-level language to low-level language
- assembly = compiled code in intermediate language
- CLI, CIL, MSIL = Common Language Infastructure, Common Intermediate Language, Microsoft Intermediate Language
- CLR, BCL, CTS, VES, JIT = Common Language Runtime, Base Class Library, Common Type System, Virtual Execution System, Just In Time Compiler
- languages = C#, F#, VB.NET, JavaScript, Python, Java*

## git

- git init = create a .git directory to track changes (Distributed Version Control System)
- git add = select resources to track, git add README.md LICENSE, git add .
- git commit = save changes to .git directory with reference
- git log = list/display all recent commits
- git push = share .git directory with other nodes (remote/local nodes), -u --set-upstream
- git status = list/display current state of version history, including saved/unsaved changes
- git remote = setup/name connection to remote node

## oop

Object-Oriented Programming is defined as a structure of objects that contain their own state and behavior

- abstraction = exposing a set functionalities where specification is left to implementation
- encapsulation = controlling access to object data and/or functionality, given object is complete, data hiding
- inheritance = grouping functionality/data into a common structure/entity to reduce redundancy
- polymorphism = ability to change based on functionality but not on reference

## class

- field, backing field = variable at the class level, backing field is always private
- property = a backing field accessible via 2 distinct methods called get and set
- constructor = instantiation method
- method = block of code containing a set of functionality
- destructor = de-instantiation method

## design pattern

Recurring code structure, Reusable formal solution to a common problem

- singleton = limit instantiation to a single common instance for the application lifetime
- factory method = formalize the instantiation of objects using a common method


class Fred
{
  factory.makeComputer(); // concrete
  new computer();
  string s = "some text"; value has a type, container has a type
  var s = "some text"; container type is inferred by its value
  s = 10; // error

  public string Name {get; set;} // property

  private string name; // backing field
  getName(); // get method
  setName(); // set method
}

class Monica
{
  factory.makeComputer(); // concrete
  new computer(laptop);
}

class Computer
{
  computer(string type);
}

class Factory
{
  makeComputer() creator
  {
    new lotsOfPetaRam(); // abstract
  }
}

## questions

1. how do you define the C# Language = compiled, strongly typed, statically typed, .NET language
1. talk about the benefits of the CLR = portability, interoperability, performance, memory management
1. explain the compilation process = code is transformed into IL/Assembly transformed into Bytecode
1. how do you define the OOP Concept = refer up
1. how do you define a Design Pattern = refer up
1. what is the Singleton Design Pattern = refer up
1. what is the Factory Method Design Pattern = refer up
1. what is Unit Testing = ability to test a single functionality at a time, arrange/act/assert, xUnit
1. how have you tested your code = xUnit, reference the project to test, assert on the functionality
1. how do you handle errors in your code = implementing try/catch/finally, managing null values
1. what is your process to fix errors in your code = debugging, breakpoints
1. what is your understanding of Serialization = conversion of objects into xml, data transformation between systems
1. what is OUT keyword = ability to return more then 1 value from a method
1. what is casting = transformation from 1 object type to another object type, by reference
1. what is parsing = conversion from 1 primitive type to another primitive type, by value
1. difference between value vs reference = reference is a set of value types, value is part of the BCL
1. what is method overloading/overriding =
1. what is a generic = type placeholder with constraint
1. difference between array and list = array is static, list is dynamic
