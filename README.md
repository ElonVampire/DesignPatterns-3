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

## What is it?

The adapater pattern is useful for ensuring that a client object with an incompatiable interface with another object is able to use functionality in that incompatible object. 

The commonly used analogue example of this is the use of different travel adapters with foreign power outlets. Where a NZ plug my not fit a UK outlet. Through the use of a travel adapter as a middleman, they are able to be use together. 

![alt text](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/AdapterPattern.JPG "Logo Title Text 1")

This diagram shows the relationship between all collaborators within the adapter pattern. The two incompatible classes are the Client and the Adaptee. The client wishes to use the adaptee's method AdaptedOperation(), however is unable to due to Client expecting the interface being exposed to be just Operation().

This is fixed by introducing the adpater pattern as shown by the Adapter interface and the Concrete Adapater class. The interface exposes the correct methods that the Client is expecting, in this case Operation. And the ConcreteAdapter is implementing that method by calling the adapted operation. Thus the client is effectively calling the adaptee function and getting the functionality it needs while also retaining its interface it expects to conform to. 

# Bridge Pattern

The bridge pattern can be a tricky pattern to master as well as being difficult to spot within a code base. The bridge patterns intent is to decouple and abstraction from its implementation. This is so that both parts are able to be changed independantly of one another. 

We know that by default an abstraction and its implementation are tightly coupled. For example given an interface as the abstraction and a class that implements this abstraction as the implementation we get a relationship as shown below. 

![Tightly coupled abstraction with its implementation](https://github.com/ThomasMicol/DesignPatterns/blob/master/Diagrams/AbstractionWithoutBridge.jpg "Tightly coupled abstraction with its implementation")

This is problematic as the implementation directly calls its abstraction and these couldn't be independantly swapped out as needed. 

Consider this table of possible equiptment purchases from the latest catalogue released from Fictitious Contractor Supplies Ltd

| Item                | Description            | Price |
|---------------------|:----------------------:|------:|
|Hammer               |Hits things just as well| $10   |
|Hammer (Golden)      |Hits things well| $10   | $500  |
|Screwdriver          |Turns screws well       | $8    |
|Screwdriver (Golden) |Hits things well| $10   | $500  |
|Screws (Philips)     |Turns well              | $5    |
|Screws (Flat)        |Turns just as well      | $5    |
|Nails                |sharp!                  | $3    |
|Nails (Golden)       |Sharp, shiny!           | $1000 |

Now consider that the higher ups at Fictitious Contractor Supplies Ltd notice that they sell related items together frequently so they wish to offer deals based on these related items. 

Being the lazy software developer you are, you have done no DIY ever and have no idea what any of these items could be related to one another. 

Firstly lets look at what could happen should the bridge pattern not be used to solve this solution. As items are added to the catalogue, the number of possible combo options becomes exponential. 

Firstly the higher ups decide that they want to provide package deals based on our current catalogue. If we listed all the combonations out it would look something like this. 

![Here are a few items](https://github.com/ThomasMicol/DesignPatterns/blob/master/Diagrams/Illustrative/AFewItems.jpg "A few item packages.")

This is fairly simple there are only four package deals, and we can easily represent this through inheritance. However the higher up decide that they want to start import steel tools because they realized that they were more durable that gold tools. 

![Here are a few more items](https://github.com/ThomasMicol/DesignPatterns/blob/master/Diagrams/Illustrative/AFewMoreItems.jpg "A few more item packages.")

Okay this is fine, it only added two more packages to our inheritanc hierachy. We are starting to get a little bit more code duplication but nothing too terrible. Then you receive an email, they are going to start offering hardhat options with all their package deals. This is going to completely break the system, the items now looks like this. 

![Here are a lot more items](https://github.com/ThomasMicol/DesignPatterns/blob/master/Diagrams/Illustrative/ALotMoreItems.JPG "A lot more item packages.")

Oh no this has doubled the amount of item packages we have and now our entire system is on fire. But it isnt realistic to enumerate all these out like this. A more realistic way to model these items would be to group the common items together. In this case, it would be easier to lump the primary items in the combo with the secondary combo items. The diagram above would become more simplified with the below diagram.

![Here are a lot more items in a simplified manner](https://github.com/ThomasMicol/DesignPatterns/blob/master/Diagrams/Illustrative/TooManyItemsSimplified.JPG "A lot more items in a more simplified manner")

This is much easier to map and includes the expanded possiblities of people wanting to get screw packs with their primary hammer purchase and vice versa. To bring this back to code if we were to make a combo deal we wouldnt need to make complex inheritance trees with the need to add multiple classes for every new item in the system. Instead we have a primary object. In the example this might be a golden hammer. In the bridge pattern this becomes our refined abstraction which has an abstraction class of Tool. This base class know of an abstraction of the implementator which is our combo deal through use of composition in the base class. This implementor implements the details of the combo deal.

To bring this full circle, the class diagram would then look something like this,

![Here is a complex class diagram of the bridge pattern.](https://github.com/ThomasMicol/DesignPatterns/blob/master/Diagrams/BridgeComplex.JPG "Here is a complex class diagram of the bridge pattern.")

Now if we hop into the code we can instantiate a Hammer and Nails combo and output its contents to the screen by simply instantiating the object and giving it a combo item then calling the print combo items method on the abstraction.

![Here is a complex class diagram of the bridge pattern.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Bridge%20Pattern/Hammer%20Instantiation.JPG "Here is a complex class diagram of the bridge pattern.")

# Builder Pattern

The builder pattern is used to simplify the construction of complex object into a standardized interface. This allows for the same construction process to create different representations. 

This solves three primary issues,
 * too many parameters - Often when objects have complex constructions steps the state of such a complex object is passed into the constructor as parameters. This is an issue as you have to pass these parameters in at every instantiation, which can cause the code to break should the types or data passed into the constructor change. 
* Order Dependant - These parameters are also order dependent. Therefore should the order of the parameters change, the code will break in all locations the construction of that object is used. For lesser used objects this can be fine but in cases where the object is used many times in multiple locations throughout the system, this can become a nightmare.
* Different constructions - Often you will want there to be differnt results of a construction process given different data. By abstracting the construction from the data we are able to do this. 

By abstracting away the implementation details of the construction of complex objects, we are able to decouple the client code from the object it would otherwise need to execute to get the same product of the construction process. 

Consider the example code; The example follows a businessman who wishes to be able to spin up many different business to quickly expand his portfolio. He decides it will be faster and less stressful to just hire an executive business maker to spin up businesses for him so that he can sit on a beach in the bahamas. 

![Here is a snippet of the businessman class.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Builder%20Pattern/BusinessmanSnippet.PNG "Here is a snippet of the businessman class")

The above picture displayes the simple implementation of the businessman class. We can see how little responsibility the business man has in he construction of the businesses he owns All he knows is the business list he has that is returned from the executive maker.

![Here is a snippet of the business maker class.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Builder%20Pattern/BusinessMakerSnippet.PNG "Here is a snippet of the business maker class")

The above code snippet, shows the implementation of the business maker class. This class defines the order in which the construction process of the products happens which happens in BuildBsuiness method. The maker component of the builder pattern also has a concrete builder object passed into it. In this case the concrete builder is our portfolio builder. This property is defined as being readonly and is of type of the abstract business builder.

![Here is a snippet of the business builder class.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Builder%20Pattern/BusinessBuilderSnippet.PNG "Here is a snippet of the business builder class")

This snippet shows the business builder abstract class which defines the way in which the maker object should always be able to interact with concrete business builders. 

![Here is a snippet of the portfolio builder concrete class.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Builder%20Pattern/PortfolioSnippet.PNG "Here is a snippet of the portfolio builder concrete class")

Above is a code snippet of the portfolio builder which has a build portfolio method which is a set of business makers each with their own concrete business maker. In this case the website retail and hospitality businesses. When the portfolio builder class is asked for the portfolio the businesses are also built up and they are all stored in the portfolio builder _portfolio attribute ready to be returned back when the get method is called.

![Here is a snippet of the concrete builder class.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Builder%20Pattern/ConcreteBuilderSnippet.PNG "Here is a snippet of the concrete builder class")

# Chain of Responsibility

The chain of Responsibility pattern is comprised of a set of senders and receivers who only know about the next sender/receiver in the chain. The pattern is used for setting up complex sets of check logic in chains of senders receivers so that the client code that starts the check doesn't need to know about what point in the chain the request got to, all that matters is that the response was returned.

A primary feature of the chain of responsibility is that the links in the chain only know about the next link in the sequence and the client code only calls the first link in the chain. For example in a chain of 5 items, the fourth link may be the one to finally return the correct response. But the client code that initially called the first link didnt even know that the fourth link existed. At the same time link four has no concept of it being the fourth call in a chain and only knows that should it fail it needs to pass the call onto link 5. But because the call didnt reach the fifth and final link, the fifth link has no idea that the calls even happened.

The chain of Responsibility can easily be represented with a set of objects with references to one another in a chain. The below image illustrates the relationship between client and chain.

![Here is a simple diagram of the chain.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/Illustrative/CoR%20Relationships.JPG "Here is a simple diagram of the chain.")

Consider a standard chain of command in a large organization. For example if worker wanted resource consent for something that was going to cost the company $12,000. Usually you would report to your direct boss in this case it might be an assistant manager. But as it turns out this is far too much money for the assistant manager to consent to so they need to ask their direct boss. This loop of "send request to boss - boss cant clear that much - pass request to next boss" might go on for a few iterations till the request hits a manager who is able to clear consent for $12,000. They will then run their logic on the request to see if it is a valid use of the companies money. If it is they will send back an approved response and if not they will send back a declined response. 

All the while the original worker who filed the request doesn't know about the ever increasing status of his/her request as they simply fired it off to their manager and are expecting them to give them the response when they can, as is all the other intermediary managers inbetween.  

This is a good example of the CoR pattern as it is a clear real world parallel with how the pattern works. At each step we can see a primary check is done on the request as each manager isnt going to run their consent logic on the request when they dont have the consent authority to clear it anyway. So they check if the request amount is less than their allowed resource consent limit. If it is they run their complex self contained consenting logic on the request and give back approved or declined. However, if they lack the consenting authority, they simply know who is the next manager in the chain and they pass the request to them.

## What it Solves


# Command Pattern

The command pattern is a simple one, it simple has client code that calls a granular class that contains just the logic for the command 

## What it Solves
