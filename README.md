# Explore .NET and C#

Our goal today is to create some dotnet console applications, getting our C# code running in a single file.

## Specific Objectives

- install tools required to work with a new language
- explore basic syntax (variables, types, data structures, loops, conditionals, functions) of new language
- solve logic problems in a new language


There won't be a lot of information here on exactly what you code to write: the intention is for to practice learning new technology on your own.

You should work through this assignment yourself, but check in with your group as you go to share what you are learning, useful resources, and ask questions.

## .NET vs. C#

**.NET is a _framework_ and _runtime_ that works with the C# language.** When researching .NET, you may often come across documentation that refers to both .NET and C#. For the purposes of this assignment, you can consider these two terms 
to be part of one same single technology.

See https://stackoverflow.com/q/2724864/830030

## VSCode

While there are many different code editors which work well with .NET and C#, please continue to use VSCode.

---

## Install Dotnet 6

You will need to install .NET and get it up and running on your computer. Please install version 6.x!

Google is your friend for this assignment! For example, try searching for:

- _Install .net mac_
- _.net getting started_
- _.net hello world tutorial_

>NOTE: If you have M1 you will want the ARM64 installer, and if you have intel you'll want x64 installer!

## "Hello World" and the Basics

It is a programming convention to always start learning a new technology by creating a _Hello World_ application: this is a program that logs the string `"Hello World"` to your terminal. In other words, it's the simplest possible thing you can make, but enough to prove that you can execute code in that language.

Our goal here is to understand the basic syntax and structure of .NET and C#, including:

- Variables, numbers, and data types
- Conditionals
- Loops and arrays (aka "lists")
- Data structures (arrays, lists, enums)
- Functions

**Think of this like a super-compressed version of Tier 1, for C#!**

Microsoft has some great places to get started with the language and runtime:

- [MS Docs Hello World](https://dotnet.microsoft.com/en-us/learn/dotnet/hello-world-tutorial/intro)
- [MS Docs First Steps with C#](https://docs.microsoft.com/en-us/learn/paths/csharp-first-steps/?WT.mc_id=dotnet-35129-website)
- [MS C# Lang Docs](https://learn.microsoft.com/en-us/dotnet/csharp/)

---

## Assignment

Our end goals is to be able to complete a few [code "katas"](https://en.wikipedia.org/wiki/Kata_(programming)). These are small coding exercises to help you build up skills in a language. 

To get there, here is a checklist of things you can make sure you can do! Show your exploration and work in your `hello-world.cs` program.

### BASE
- [x] Make a string
- [x] Make a number (what kind? There are multiple!)
- [x] Make a boolean
- [x] Make an `if / else if / else` block
- [x] Make a `switch` block
- [x] Make an array of strings
- [x] Make a for loop
  - [x] Log each item
- [x] Use a `foreach` loop
- [x] Use a `List` instead of an array ([HINT](https://www.tutorialsteacher.com/csharp/csharp-list))


### STRETCH
- [x] Make a class (object structure)
  - [x] Instantiate a class (make a new object)
- [x] Make a method (a function inside a class)
  - [x]  Return a value
  - [x]  Call from instance of class
- [x] Make an array of objects
- [x] Loop over array of objects


## Code Katas

For this assignment you will need to complete the following katas from [codewars.com](https://www.codewars.com):

- [Opposites attracts](https://www.codewars.com/kata/555086d53eac039a2a000083/train/csharp) (numbers and conditionals)
- [You only need one](https://www.codewars.com/kata/57cc975ed542d3148f00015b/train/csharp) (lists and loops)
- [Sum of positives](https://www.codewars.com/kata/5715eaedb436cf5606000381/train/csharp) (lists, conditionals, numbers)

You may solve these online on codewars.com, but please copy your solutions into new files in your repo. 

### STRETCH

Find and complete 2-3 additional code katas on codewars.com:

https://www.codewars.com/kata/search/csharp?q=&r[]=-8&beta=false&order_by=popularity%20desc