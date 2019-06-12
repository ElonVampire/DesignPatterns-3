# Design Patterns Library
Demo implementations of various design patterns based on the pluralsight course Design Patterns Library 

Introduction
===

## What are they? 

Design patterns are generic solutions to commonly occuring problems that arise during software construction. These problems span many different areas of software development and solve problems at varying levels of abstraction.

Design patterns and reusable code, while they share common aspects,are two distinct elements and should not be treated as one in the same. While a design pattern my allow for instance of reuse the primary objective of design patterns isn't to increase the reuseable across a system. 

Also design  patterns are not based in the implementation of algorithms such as quick sort. Patterns are more concerned with the formatting and relationships between classes to address commonly occuring problems.

These are given specific names based on what problem they solve. This helps to give a common language between developers to help communicate problems in design and the patterns used in their solution. These patterns deal with both high level system design as well as dealing with problems at a lower level of implementation. 

While patterns define parts of a pattern to be given certain names like "View" or "Model" these names are abstractions and in a real implementation can be called anything. What matters is the structure of these classes have in relation to one another and the interfaces they use to talk to one another.

Collaborators are classes that either interact directly with the pattern or are contained within the pattern. It is also possible for a collaborator in a design pattern to be another design pattern. For example a use of the Connection Pool pattern will also often be using the singleton pattern as a connection pool has its value reduced if it isnt the only instance of such an item in the system. 

Finally design patterns do no give a direct solution to the problems faced by programmers. They instead focus on giving a template to the solution so that the implementation can be filled out and the actual problem solved. 


## Design pattern categorization

The core design patterns, or those defined by the gang of four, can be given one of three distinct catagories.

- Creational
- Structural
- Behavioral

However these were developed long ago when the craft of software engineering was nowhere near as mature as it is today. Now that we have been solving these issues for much longer we have a much more expanded list of catagories. Some of which are,

- Security
- Concurrency
- Sql
- User Interface
- Relational
- Social
- Distributed

It should be noted that this is not an exhaustive list and is also not static, patterns are being added as well as new catagories of patterns being found as the craft continues to mature. 

Why they matter
---

Design patterns matter as they give the craft of software engineering a common language to use. All crafts that have a high level of maturity such as building and architecture have a common language whereby people within the profession can use common terms within the craft to more succinctly communicate ideas and solutions more effectively to other people within the profession. 

Design patterns also reduce the need for reinventing the wheel, this helps to reduce the amount of time a developer spends solving the same issue which in turn speeds up the velocity of development.

Lastly they help in improving the system and application design. By adhering to common design patterns we can be assured that the implementations of the solutions can be easily understood by other developers as well as knowing that the solution we used has been effectively peer reviewed, as the pattern is a commonly agreed upon solution to the problem. 

## Criticisms 

Unnecessary duplication

weak points in languages
    Patterns are workarounds for missing language features. 

Same as other abstractions

# Adapter Pattern
===

## What is it?

The adapater pattern is useful for ensuring that a client object with an incompatiable interface with another object is able to use functionality in that incompatible object. 

The commonly used analogue example of this is the use of different travel adapters with foreign power outlets. Where a NZ plug my not fit a UK outlet. Through the use of a travel adapter as a middleman, they are able to be use together. 

![alt text](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/AdapterPattern.JPG "Logo Title Text 1")

This diagram shows the relationship between all collaborators within the adapter pattern. The two incompatible classes are the Client and the Adaptee. The client wishes to use the adaptee's method AdaptedOperation(), however is unable to due to Client expecting the interface being exposed to be just Operation().

This is fixed by introducing the adpater pattern as shown by the Adapter interface and the Concrete Adapater class. The interface exposes the correct methods that the Client is expecting, in this case Operation. And the ConcreteAdapter is implementing that method by calling the adapted operation. Thus the client is effectively calling the adaptee function and getting the functionality it needs while also retaining its interface it expects to conform to. 

#Bridge Pattern

The bridge pattern can be a tricky pattern to master as well as being difficult to spot within a code base. The bridge patterns intent is to decouple and abstraction from its implementation. This is so that both parts are able to be changed independantly of one another. 

We know that by default an abstraction and its implementation are tightly coupled. For example given an interface as the abstraction and a class that implements this abstraction as the implementation we get a relationship as shown below. 

![Tightly coupled abstraction with its implementation](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/TightlyCoupledAbs.JPG "Tightly coupled abstraction with its implementation")

This is problematic as the implementation directly calls its abstraction and these couldn't be independantly swapped out as needed. 

Consider this table of possible equiptment purchases from the latest catalogue released from Fictitious Contractor Supplies Ltd

| Item           | Description      | Price |
|----------------|:----------------:|------:|
|Hammer          |Hits things well  | $10   |
|Screwdriver     |Turns screws well | $8    |
|Screws (Philips)|Turns well        | $5    |
|Screws (Flat)   |Turns just as well| $5    |
|Nails           |sharp!            | $3    |
|Nails (Golden)  |Sharp, shiny!     | $1000 |

Now consider that the higher ups at Fictitious Contractor Supplies Ltd notice that they sell related items together frequently so they wish to offer deals based on these related items. 

Being the lazy software developer you are, you have done no DIY ever and have no idea what any of these items could be related to one another. 

Firstly lets look at what could happen should the bridge pattern not be used to solve this solution. As items are added to the catalogue, the number of possible combo options becomes exponential. 



#Builder Pattern
