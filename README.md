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

![Here is a snippet of the businessman class.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Builder%20Pattern/BusinessManSnippet.PNG "Here is a snippet of the businessman class")

The above picture displayes the simple implementation of the businessman class. We can see how little responsibility the business man has in he construction of the businesses he owns All he knows is the business list he has that is returned from the executive maker.

![Here is a snippet of the business maker class.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Builder%20Pattern/BusinessMakerSnippet.PNG "Here is a snippet of the business maker class")

The above code snippet, shows the implementation of the business maker class. This class defines the order in which the construction process of the products happens which happens in BuildBsuiness method. The maker component of the builder pattern also has a concrete builder object passed into it. In this case the concrete builder is our portfolio builder. This property is defined as being readonly and is of type of the abstract business builder.

![Here is a snippet of the business builder class.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Builder%20Pattern/BusinessBuilderSnippet.PNG "Here is a snippet of the business builder class")

This snippet shows the business builder abstract class which defines the way in which the maker object should always be able to interact with concrete business builders. 

![Here is a snippet of the portfolio builder concrete class.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Builder%20Pattern/PortfolioSnippet.PNG "Here is a snippet of the portfolio builder concrete class")

Above is a code snippet of the portfolio builder which has a build portfolio method which is a set of business makers each with their own concrete business maker. In this case the website retail and hospitality businesses. When the portfolio builder class is asked for the portfolio the businesses are also built up and they are all stored in the portfolio builder _portfolio attribute ready to be returned back when the get method is called.

![Here is a snippet of the concrete builder class.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Builder%20Pattern/ConcreteBuilderSnippet.PNG "Here is a snippet of the concrete builder class")

The above code is from one of the three concrete business builder classes. This is where the information about the actual products is kept. From the builder these methods are called in the order laid out in the maker object then returned back to the client code. 

# Chain of Responsibility

The chain of Responsibility pattern is comprised of a set of senders and receivers who only know about the next sender/receiver in the chain. The pattern is used for setting up complex sets of check logic in chains of senders receivers so that the client code that starts the check doesn't need to know about what point in the chain the request got to, all that matters is that the response was returned.

A primary feature of the chain of responsibility is that the links in the chain only know about the next link in the sequence and the client code only calls the first link in the chain. For example in a chain of 5 items, the fourth link may be the one to finally return the correct response. But the client code that initially called the first link didnt even know that the fourth link existed. At the same time link four has no concept of it being the fourth call in a chain and only knows that should it fail it needs to pass the call onto link 5. But because the call didnt reach the fifth and final link, the fifth link has no idea that the calls even happened.

The chain of Responsibility can easily be represented with a set of objects with references to one another in a chain. The below image illustrates the relationship between client and chain.

![Here is a simple diagram of the chain.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/Illustrative/CoR%20Relationships.JPG "Here is a simple diagram of the chain.")

Consider a standard chain of command in a large organization. For example if worker wanted resource consent for something that was going to cost the company $12,000. Usually you would report to your direct boss in this case it might be an assistant manager. But as it turns out this is far too much money for the assistant manager to consent to so they need to ask their direct boss. This loop of "send request to boss - boss cant clear that much - pass request to next boss" might go on for a few iterations till the request hits a manager who is able to clear consent for $12,000. They will then run their logic on the request to see if it is a valid use of the companies money. If it is they will send back an approved response and if not they will send back a declined response. 

All the while the original worker who filed the request doesn't know about the ever increasing status of his/her request as they simply fired it off to their manager and are expecting them to give them the response when they can, as is all the other intermediary managers inbetween.  

This is a good example of the CoR pattern as it is a clear real world parallel with how the pattern works. At each step we can see a primary check is done on the request as each manager isnt going to run their consent logic on the request when they dont have the consent authority to clear it anyway. So they check if the request amount is less than their allowed resource consent limit. If it is they run their complex self contained consenting logic on the request and give back approved or declined. However, if they lack the consenting authority, they simply know who is the next manager in the chain and they pass the request to them.

## What it Solves

The chain of responsibility solves the issue of making many calls in a if statement when you want to change the method to call at run time. For example we might not always know which method we will be wanting to run, so in a poor implementation of this there would be a set of if states for the conditions or perhaps a switch statement. This would be all in the client code and when there needs to be a new item added to these checks you need to find this switch or if statement block and add the required code. This breaks the open close principle and could also cause code duplication in multiple places making the code base less maintainable. By simply having a set of command items that are chainable we can simply make the chain in the client code. When we want to add more links we need to make another class the implements the chainable interface and add this to where the chain is defined. This means there is less code to maintain in the client code and the logic for what you want to be conditionally executed is moved into granular classes for specifically the execution of that code.


# Command Pattern

The command pattern is a simple one, it simply has client code that calls a granular class that contains just the logic for the command to run. This allows complex business logic to be wrapped in a self contained class that uses a uniform interface. The command class is fully self contained, meaning that when the class is constructed and the execute command is run, it does not need to gather state from other dependancies. 

## What it Solves

This pattern solves the issue of mixing in complex business logic in with client code that calls it. Often times the client code that calls this business logic is smoothing the data out for the execution for the business logic, so it makes sense that these items can be seperated. By doing this we are able to remove complex segments of logic from the client code and move them to their own classes with all the state they need to execute and nothing more. 

If we were to not use this pattern there would be large segments of the code that define complex business logic and are mixed in with the client code that uses the logic. In some cases this logic might even be duplicated which is a very bad code smell when dealing with mission critical logic. By taking this logic and placing it within its own class we are able to keep the client loosely coupled from the business logic it uses. As far as we know the business logic might change and our system should be able to change with it. In the client code we are able to drop and replace command classes for whatever our requirements are and we can make new classes should we need differnt functionality. As long as they all use the same interface the client code wont care what it is calling.
    
## Implementation

The command pattern can be implemented by taking the complex code from the client, and placing it within its own class, that implements the ICommand or similarly named abstraction that provides the method signatures required. When the class is instantiated the state the method requires to run can be passed through as constructor parameters and saved as readonly private properties. Onces the object is newed up we can simply call the Execute method on the class to run what would otherwise be complex implementation details mixed in with client code. 

Consider the following diagram.
![here is a simple diagram showing the basic implementation of a command pattern.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/CommandPattern.JPG "here is a simple diagram showing the basic implementation of a command pattern")

This is clearly one of the more simple design patterns but dont underestimate the importance of a well designed set of command patterns.

The client simply calls the abstraction of the ICommand interface which is implemented by the ConcreteCommand class. This is the class that will contain whatever complex business logic that is needed to be used by the client which is call this command. 

## Example run down

In my example I made i implemented a simple command line interface that allows the user to add and remove experience from a character in the system. In the example the commands that the user type into the the interface are correlated with a command pattern class that executes the logic upon the character. 

![Here is a snippet of the program file.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Command%20Pattern/program.JPG "Here is a snippet of the program file")

this is the program method for the application. It simply enters a loop of getting commands from the user then executing those within the command parser object. 

![Here is a snippet of the command parser file.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Command%20Pattern/commandParser.JPG "Here is a snippet of the command parser file")

The code above is where the magic happens. When we make the object we make a character object and a list of commands that the parser will operate on. You might notice something familiar about the way the commands are structured. These are laid out in a chain of responsibility pattern. so when the command is sent from the interface into the parse command method, we send this command to the first link i the chain and then we forget about it. This is because we set the chain up in the constructor so the commands know the pattern in which they need to be checked for. 

We also include a new pattern and that is the null object pattern. The final link in the chain is a set value of the EndOfChainItem. This is the object that when hit will not have a next link and will return the print value of "no command matching {command} was found". If we didnt include this object the chain would break if it got to the end without finding a command match.

The command parser in this program can be considered the client of the pattern as the parse command method is calling the execute method on the ICommand objects.

![Here is a snippet of the command file.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Command%20Pattern/command.JPG "Here is a snippet of the command file")

Above is an example of one of the actual commands. This particular one is responsible for adding money to the user. So the first interesting thing we notice looking at the class signature is that it implements two interfaces, the ICommand which is the Execute Command and the Ichainable which allows it to operate as a CoR class with the SetNext method. 

We can see that the string "add money" is set when the property is defined and in the execute method the calling command is compared against this to see if this is the command called. Should the incoming command be the same as the command string defined in the command class the business logic for that command is executed, otherwise the next link in the chain is called. 

By structuring the code in this way we are able to avoid adding checks for command matching in the client code. Each command simply checks if it is the command that was intended to be called and if not we are able to safely call the next link in the chain and forget about the request. 
x
## Other Notes

Another powerful feature of the command pattern is the ability to enforce implementations of related groups of functionality. For example, if we were making a command pattern for database interactions where the commands were the queries that were run against the database. We might want to have both a command execute function. As well as a rollback functionality. To do this in the abstration, be it an interface or an abstract base class, we add a second method called rollback. This way when the execute methods is implemented the interface will display a compile time error unless the rollback method is also implemented. 

# Composite Pattern

The composite pattern is used in programs to represent part/whole relationship items, and gives both element of this a common interface so that they can be interacted with in the same way. A great example of this is the windows explorer. As you traverse down a file path a folder can have folders as well as files. Double clicking a folder will open this folder which in turn might also contain more folders and files, whereas the same action on a file will open the file in its default program. These are what is known as a composite (the folders) and a leaf (the file). The composite is identified by containing 0 to N of itself as well as 0 to N leaves. The leaf on the otherhand is identified by being the end of the tree structure (hence the name) and having no more child objects.

## What it solves

The composite pattern solves issues that arise when dealing with part/whole structures. Often in computing tree structures like this can be difficult to programmatically handle and traverse through effectively. By implementing the composite pattern we are able to set up a tree structure of N parent/children combos with any number of contained files. Then be able to use incredibly basic client code that interacts with these objects and leaves the composite objects to pass the interaction commands down through the tree structure. 

## Implementation

The implmentation of the composite pattern is one of the more simple to understand patterns in the library. Consider the following diagram.

![here is a simple diagram showing the basic implementation of a composite pattern.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/composit.JPG "here is a simple diagram showing the basic implementation of a composite pattern")

The composite pattern is made of two concrete classes and an abstraction that lets client code treat them the same. The abstraction can either be an interface or an abstract base class that supplies common functionality to both the composite objects and leaf objects that will extend or implement it. The composite object contains a list of abstract types, and implements the operations on the data in a way that the operation is passed down to all children of itself. Usually this is done by in the composite objects operation method it will loop over all elements in its array of children and call the operation on these objects. As far as the composite object is concerned all of these elements are a sime IComponent interface with the Operation method on them. These items could be either another composite with its own children, or it could be a leaf who will have a different implementation of the operation method. This implementation will be the "actual" work that you want to happen when calling the initial operation method as the leaf objects has the state that needs to be manipulated. 

The leaf object is what is the actual target of the calling code. When the call is passed down through the tree into the leaf object the implementation of the operation is different. 

## Example run down

In my example I used the example of a command line interface which allows you to create a party of groups and sub groups with their own adventurers inside the groups. Then using commands you are able to give gold and experience to the party as a whole and the composite pattern takes care of the splits. In regards to the pattern components this example uses the class "Group" as the composite object. The class "Member" as the leaf, and IParty is the abstraction that ties them all together, and lets the client code interact with all items in the tree the same.



# Decorator

## What it solves

## Imlementation

## Code Snippets

## Example run down

#  Event Aggregator

## What it solves

## Imlementation

## Code Snippets

## Example run down

# Facade Pattern

## What it solves

## Imlementation

## Code Snippets

## Example run down
