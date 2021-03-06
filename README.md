  # Design Patterns Library
Demo implementations of various design patterns based on the Pluralsight course Design Patterns Library 

Introduction
===

## What are they? 

Design patterns are generic solutions to commonly occurring problems that arise during software construction. These problems span many different areas of software development and solve problems at varying levels of abstraction.

Design patterns and reusable code, while they share common aspects, are two distinct elements and should not be treated as one in the same. While a design pattern my allow for instance of reuse the primary objective of design patterns isn't to increase the reusable across a system. 

Also design  patterns are not based in the implementation of algorithms such as quick sort. Patterns are more concerned with the formatting and relationships between classes to address commonly occurring problems.

These are given specific names based on what problem they solve. This helps to give a common language between developers to help communicate problems in design and the patterns used in their solution. These patterns deal with both high level system design as well as dealing with problems at a lower level of implementation. 

While patterns define parts of a pattern to be given certain names like "View" or "Model" these names are abstractions and in a real implementation can be called anything. What matters is the structure of these classes have in relation to one another and the interfaces they use to talk to one another.

Collaborators are classes that either interact directly with the pattern or are contained within the pattern. It is also possible for a collaborator in a design pattern to be another design pattern. For example, a use of the Connection Pool pattern will also often be using the singleton pattern as a connection pool has its value reduced if it isn’t the only instance of such an item in the system. 

Finally design patterns do not give a direct solution to the problems faced by programmers. They instead focus on giving a template to the solution so that the implementation can be filled out and the actual problem solved. 

## Design pattern categorization

The core design patterns, or those defined by the gang of four, can be given one of three distinct categories.

- Creational
- Structural
- Behavioural

However, these were developed long ago when the craft of software engineering was nowhere near as mature as it is today. Now that we have been solving these issues for much longer, we have a much more expanded list of categories. Some of which are,

- Security
- Concurrency
- Sql
- User Interface
- Relational
- Social
- Distributed

It should be noted that this is not an exhaustive list and is also not static, patterns are being added as well as new categories of patterns being found as the craft continues to mature. 

Why they matter
---

Design patterns matter as they give the craft of software engineering a common language to use. All crafts that have a high level of maturity such as building, and architecture have a common language whereby people within the profession can use common terms within the craft to more succinctly communicate ideas and solutions more effectively to other people within the profession. 

Design patterns also reduce the need for reinventing the wheel, this helps to reduce the amount of time a developer spends solving the same issue which in turn speeds up the velocity of development.

Lastly, they help in improving the system and application design. By adhering to common design patterns, we can be assured that the implementations of the solutions can be easily understood by other developers as well as knowing that the solution we used has been effectively peer reviewed, as the pattern is a commonly agreed upon solution to the problem. 

## Criticisms 

Unnecessary duplication

weak points in languages
    Patterns are workarounds for missing language features. 

Same as other abstractions

# Adapter Pattern

## What is it?

The adapter pattern is useful for ensuring that a client object with an incompatible interface with another object can use functionality in that incompatible object. 

The commonly used analogue example of this is the use of different travel adapters with foreign power outlets. Where a NZ plug my not fit a UK outlet. Using a travel adapter as a middleman, they can be use together. 

![alt text](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/AdapterPattern.JPG "Logo Title Text 1")

This diagram shows the relationship between all collaborators within the adapter pattern. The two incompatible classes are the Client and the Adaptee. The client wishes to use the adaptee's method AdaptedOperation(), however is unable to due to Client expecting the interface being exposed to be just Operation().

This is fixed by introducing the adapter pattern as shown by the Adapter interface and the Concrete Adapter class. The interface exposes the correct methods that the Client is expecting, in this case Operation. And the Concrete Adapter is implementing that method by calling the adapted operation. Thus, the client is effectively calling the Adaptee function and getting the functionality it needs while also retaining its interface it expects to conform to. 

# Bridge Pattern

The bridge pattern can be a tricky pattern to master as well as being difficult to spot within a code base. The bridge patterns intent is to decouple and abstraction from its implementation. This is so that both parts can be changed independently of one another. 

We know that by default an abstraction and its implementation are tightly coupled. For example, given an interface as the abstraction and a class that implements this abstraction as the implementation, we get a relationship as shown below. 

![Tightly coupled abstraction with its implementation](https://github.com/ThomasMicol/DesignPatterns/blob/master/Diagrams/AbstractionWithoutBridge.jpg "Tightly coupled abstraction with its implementation")

This is problematic as the implementation directly calls its abstraction and these couldn't be independently swapped out as needed. 

Consider this table of possible equipment purchases from the latest catalogue released from Fictitious Contractor Supplies Ltd

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

Now consider that the higher ups at Fictitious Contractor Supplies Ltd notice that they sell related items together frequently, so they wish to offer deals based on these related items. 

Being the lazy software developer, you are, you have done no DIY ever and have no idea what any of these items could be related to one another. 

Firstly, let’s look at what could happen should the bridge pattern not be used to solve this solution. As items are added to the catalogue, the number of possible combo options becomes exponential. 

Firstly, the higher ups decide that they want to provide package deals based on our current catalogue. If we listed all the combinations out it would look something like this. 

![Here are a few items](https://github.com/ThomasMicol/DesignPatterns/blob/master/Diagrams/Illustrative/AFewItems.jpg "A few item packages.")

This is simple there are only four package deals, and we can easily represent this through inheritance. However, the higher up decide that they want to start import steel tools because they realized that they were more durable that gold tools. 

![Here are a few more items](https://github.com/ThomasMicol/DesignPatterns/blob/master/Diagrams/Illustrative/AFewMoreItems.jpg "A few more item packages.")

Okay this is fine, it only added two more packages to our inheritance hierarchy. We are starting to get a little bit more code duplication but nothing too terrible. Then you receive an email, they are going to start offering hardhat options with all their package deals. This is going to completely break the system; the items now look like this. 

![Here are a lot more items](https://github.com/ThomasMicol/DesignPatterns/blob/master/Diagrams/Illustrative/ALotMoreItems.JPG "A lot more item packages.")

Oh no this has doubled the amount of item packages we have and now our entire system is on fire. But it isn’t realistic to enumerate all these out like this. A more realistic way to model these items would be to group the common items together. In this case, it would be easier to lump the primary items in the combo with the secondary combo items. The diagram above would become more simplified with the below diagram.

![Here are a lot more items in a simplified manner](https://github.com/ThomasMicol/DesignPatterns/blob/master/Diagrams/Illustrative/TooManyItemsSimplified.JPG "A lot more items in a more simplified manner")

This is much easier to map and includes the expanded possibilities of people wanting to get screw packs with their primary hammer purchase and vice versa. To bring this back to code if we were to make a combo deal, we wouldn’t need to make complex inheritance trees with the need to add multiple classes for every new item in the system. Instead we have a primary object. In the example this might be a golden hammer. In the bridge pattern this becomes our refined abstraction which has an abstraction class of Tool. This base class know of an abstraction of the implementor which is our combo deal through use of composition in the base class. This implementor implements the details of the combo deal.

To bring this full circle, the class diagram would then look something like this,

![Here is a complex class diagram of the bridge pattern.](https://github.com/ThomasMicol/DesignPatterns/blob/master/Diagrams/BridgeComplex.JPG "Here is a complex class diagram of the bridge pattern.")

Now if we hop into the code, we can instantiate a Hammer and Nails combo and output its contents to the screen by simply instantiating the object and giving it a combo item then calling the print combo items method on the abstraction.

![Here is a complex class diagram of the bridge pattern.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Bridge%20Pattern/Hammer%20Instantiation.JPG "Here is a complex class diagram of the bridge pattern.")

# Builder Pattern

The builder pattern is used to simplify the construction of complex object into a standardized interface. This allows for the same construction process to create different representations. 

This solves three primary issues,
 * too many parameters - Often when objects have complex constructions steps the state of such a complex object is passed into the constructor as parameters. This is an issue as you must pass these parameters in at every instantiation, which can cause the code to break should the types or data passed into the constructor change. 
* Order Dependant - These parameters are also order dependent. Therefore, should the order of the parameters change, the code will break in all locations the construction of that object is used. For lesser used objects this can be fine but in cases where the object is used many times in multiple locations throughout the system, this can become a nightmare.
* Different constructions - Often you will want there to be different results of a construction process given different data. By abstracting the construction from the data, we can do this. 

By abstracting away the implementation details of the construction of complex objects, we can decouple the client code from the object it would otherwise need to execute to get the same product of the construction process. 

Consider the example code; The example follows a businessman who wishes to be able to spin up many different businesses to quickly expand his portfolio. He decides it will be faster and less stressful to just hire an executive business maker to spin up businesses for him so that he can sit on a beach in the Bahamas. 

![Here is a snippet of the businessman class.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Builder%20Pattern/BusinessManSnippet.PNG "Here is a snippet of the businessman class")

The above picture displays the simple implementation of the businessman class. We can see how little responsibility the businessman has in the construction of the businesses he owns All he knows is the business list he has that is returned from the executive maker.

![Here is a snippet of the business maker class.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Builder%20Pattern/BusinessMakerSnippet.PNG "Here is a snippet of the business maker class")

The above code snippet shows the implementation of the business maker class. This class defines the order in which the construction process of the products happens which happens in Build Business method. The maker component of the builder pattern also has a concrete builder object passed into it. In this case the concrete builder is our portfolio builder. This property is defined as being read only and is of type of the abstract business builder.

![Here is a snippet of the business builder class.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Builder%20Pattern/BusinessBuilderSnippet.PNG "Here is a snippet of the business builder class")

This snippet shows the business builder abstract class which defines the way in which the maker object should always be able to interact with concrete business builders. 

![Here is a snippet of the portfolio builder concrete class.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Builder%20Pattern/PortfolioSnippet.PNG "Here is a snippet of the portfolio builder concrete class")

Above is a code snippet of the portfolio builder which has a build portfolio method which is a set of business makers each with their own concrete business maker. In this case the website retail and hospitality businesses. When the portfolio builder class is asked for the portfolio the businesses are also built up and they are all stored in the portfolio builder _portfolio attribute ready to be returned when the get method is called.

![Here is a snippet of the concrete builder class.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Builder%20Pattern/ConcreteBuilderSnippet.PNG "Here is a snippet of the concrete builder class")

The above code is from one of the three concrete business builder classes. This is where the information about the actual products is kept. From the builder these methods are called in the order laid out in the maker object then returned to the client code. 

# Chain of Responsibility

The chain of Responsibility pattern is comprised of a set of senders and receivers who only know about the next sender/receiver in the chain. The pattern is used for setting up complex sets of check logic in chains of senders receivers so that the client code that starts the check doesn't need to know about what point in the chain the request got to, all that matters is that the response was returned.

A primary feature of the chain of responsibility is that the links in the chain only know about the next link in the sequence and the client code only calls the first link in the chain. For example, in a chain of 5 items, the fourth link may be the one to finally return the correct response. But the client code that initially called the first link didn’t even know that the fourth link existed. At the same time link four has no concept of it being the fourth call in a chain and only knows that should it fail it needs to pass the call onto link 5. But because the call didn’t reach the fifth and final link, the fifth link has no idea that the calls even happened.

The chain of Responsibility can easily be represented with a set of objects with references to one another in a chain. The below image illustrates the relationship between client and chain.

![Here is a simple diagram of the chain.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/Illustrative/CoR%20Relationships.JPG "Here is a simple diagram of the chain.")

Consider a standard chain of command in a large organization. For example, if worker wanted resource consent for something that was going to cost the company $12,000. Usually you would report to your direct boss in this case it might be an assistant manager. But as it turns out this is far too much money for the assistant manager to consent to, so they need to ask their direct boss. This loop of "send request to boss - boss can’t clear that much - pass request to next boss" might go on for a few iterations till the request hits a manager who is able to clear consent for $12,000. They will then run their logic on the request to see if it is a valid use of the company’s money. If it is, they will send back an approved response and if not, they will send back a declined response. 

All the while the original worker who filed the request doesn't know about the ever increasing status of his/her request as they simply fired it off to their manager and are expecting them to give them the response when they can, as is all the other intermediary managers in between.  

This is a good example of the CoR pattern as it is a clear real world parallel with how the pattern works. At each step we can see a primary check is done on the request as each manager isn’t going to run their consent logic on the request when they don’t have the consent authority to clear it anyway. So, they check if the request amount is less than their allowed resource consent limit. If it is, they run their complex self-contained consenting logic on the request and give back approved or declined. However, if they lack the consenting authority, they simply know who the next manager in the chain and they are pass the request to them.

## What it Solves

The chain of responsibility solves the issue of making many calls in an if statement when you want to change the method to call at run time. For example, we might not always know which method we will be wanting to run, so in a poor implementation of this there would be a set of if states for the conditions or perhaps a switch statement. This would be all in the client code and when there needs to be a new item added to these checks you need to find this switch or if statement block and add the required code. This breaks the open close principle and could also cause code duplication in multiple places making the code base less maintainable. By simply having a set of command items that are chainable we can simply make the chain in the client code. When we want to add more links, we need to make another class the implements the chainable interface and add this to where the chain is defined. This means there is less code to maintain in the client code and the logic for what you want to be conditionally executed is moved into granular classes for specifically the execution of that code.

# Command Pattern

The command pattern is a simple one, it simply has client code that calls a granular class that contains just the logic for the command to run. This allows complex business logic to be wrapped in a self-contained class that uses a uniform interface. The command class is fully self-contained, meaning that when the class is constructed and the execute command is run, it does not need to gather state from other dependencies. 

## What it Solves

This pattern solves the issue of mixing in complex business logic in with client code that calls it. Often the client code that calls this business logic is smoothing the data out for the execution for the business logic, so it makes sense that these items can be separated. By doing this we can remove complex segments of logic from the client code and move them to their own classes with all the state they need to execute and nothing more. 

If we were to not use this pattern there would be large segments of the code that define complex business logic and are mixed in with the client code that uses the logic. In some cases, this logic might even be duplicated which is a very bad code smell when dealing with mission critical logic. By taking this logic and placing it within its own class we can keep the client loosely coupled from the business logic it uses. As far as we know the business logic might change and our system should be able to change with it. In the client code we can drop and replace command classes for whatever our requirements are, and we can make new classes should we need different functionality. If they all use the same interface the client code won’t care what it is calling.
    
## Implementation

The command pattern can be implemented by taking the complex code from the client, and placing it within its own class, that implements the ICommand or similarly named abstraction that provides the method signatures required. When the class is instantiated the state, the method requires to run can be passed through as constructor parameters and saved as read only private properties. Once the object is newed up we can simply call the Execute method on the class to run what would otherwise be complex implementation details mixed in with client code. 

Consider the following diagram.
![here is a simple diagram showing the basic implementation of a command pattern.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/CommandPattern.JPG "here is a simple diagram showing the basic implementation of a command pattern")

This is clearly one of the simpler design patterns but don’t underestimate the importance of a well-designed set of command patterns.

The client simply calls the abstraction of the ICommand interface which is implemented by the Concrete Command class. This is the class that will contain whatever complex business logic that is needed to be used by the client which is call this command. 

## Example run down

In my example I made I implemented a simple command line interface that allows the user to add and remove experience from a character in the system. In the example the commands that the user type into the interface are correlated with a command pattern class that executes the logic upon the character. 

![Here is a snippet of the program file.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Command%20Pattern/program.JPG "Here is a snippet of the program file")

this is the program method for the application. It simply enters a loop of getting commands from the user then executing those within the command parser object. 

![Here is a snippet of the command parser file.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Command%20Pattern/commandParser.JPG "Here is a snippet of the command parser file")

The code above is where the magic happens. When we make the object, we make a character object and a list of commands that the parser will operate on. You might notice something familiar about the way the commands are structured. These are laid out in a chain of responsibility pattern. so, when the command is sent from the interface into the parse command method, we send this command to the first link I the chain and then we forget about it. This is because we set the chain up in the constructor, so the commands know the pattern in which they need to be checked for. 

We also include a new pattern and that is the null object pattern. The final link in the chain is a set value of the EndOfChainItem. This is the object that when hit will not have a next link and will return the print value of "no command matching {command} was found". If we didn’t include this object the chain would break if it got to the end without finding a command match.

The command parser in this program can be considered the client of the pattern as the parse command method is calling the execute method on the ICommand objects.

![Here is a snippet of the command file.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Command%20Pattern/command.JPG "Here is a snippet of the command file")

Above is an example of one of the actual commands. This one is responsible for adding money to the user. So, the first interesting thing we notice looking at the class signature is that it implements two interfaces, the ICommand which is the Execute Command and the Ichainable which allows it to operate as a CoR class with the SetNext method. 

We can see that the string "add money" is set when the property is defined and in the execute method the calling command is compared against this to see if this is the command called. Should the incoming command be the same as the command string defined in the command class the business logic for that command is executed, otherwise the next link in the chain is called. 

By structuring the code in this way, we can avoid adding checks for command matching in the client code. Each command simply checks if it is the command that was intended to be called and if not, we are able to safely call the next link in the chain and forget about the request. 
x
## Other Notes

Another powerful feature of the command pattern is the ability to enforce implementations of related groups of functionalities. For example, if we were making a command pattern for database interactions where the commands were the queries that were run against the database. We might want to have both a command execute function. As well as a rollback functionality. To do this in the abstraction, be it an interface or an abstract base class, we add a second method called rollback. This way when the execute methods is implemented the interface will display a compile time error unless the rollback method is also implemented. 

# Composite Pattern

The composite pattern is used in programs to represent part/whole relationship items and gives both element of this a common interface so that they can be interacted with in the same way. A great example of this is the windows explorer. As you traverse down a file path a folder can have folders as well as files. Double clicking a folder will open this folder which in turn might also contain more folders and files, whereas the same action on a file will open the file in its default program. These are what is known as a composite (the folders) and a leaf (the file). The composite is identified by containing 0 to N of itself as well as 0 to N leaves. The leaf on the other hand is identified by being the end of the tree structure (hence the name) and having no more child objects.

## What it solves

The composite pattern solves issues that arise when dealing with part/whole structures. Often in computing tree structures like this can be difficult to programmatically handle and traverse through effectively. By implementing the composite pattern, we can set up a tree structure of N parent/children combos with any number of contained files. Then be able to use incredibly basic client code that interacts with these objects and leaves the composite objects to pass the interaction commands down through the tree structure. 

## Implementation

The implementation of the composite pattern is one of the simpler to understand patterns in the library. Consider the following diagram.

![here is a simple diagram showing the basic implementation of a composite pattern.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/composit.JPG "here is a simple diagram showing the basic implementation of a composite pattern")

The composite pattern is made of two concrete classes and an abstraction that lets client code treat them the same. The abstraction can either be an interface or an abstract base class that supplies common functionality to both the composite objects and leaf objects that will extend or implement it. The composite object contains a list of abstract types and implements the operations on the data in a way that the operation is passed down to all children of itself. Usually this is done by in the composite objects operation method it will loop over all elements in its array of children and call the operation on these objects. As far as the composite object is concerned all these elements are the same IComponent interface with the Operation method on them. 

These items could be either another composite with its own children, or it could be a leaf who will have a different implementation of the operation method. This implementation will be the "actual" work that you want to happen when calling the initial operation method as the leaf objects has the state that needs to be manipulated. 

## Example run down

In my example I used the example of a command line interface which allows you to create a party of groups and subgroups with their own adventurers inside the groups. Then using commands, you can give gold and experience to the party as a whole and the composite pattern takes care of the splits. Regarding the pattern components this example uses the class "Group" as the composite object. The class "Member" as the leaf, and IParty is the abstraction that ties them all together and lets the client code interact with all items in the tree the same.

This is by far the most complex example I have made up till this point as it includes many different moving parts and the implementation of a few different patterns to reach the goal of the application. However, using these patterns we have managed some nice abstractions throughout the system which will allow us to expand the systems in ways that would otherwise be quite painful, if we had implemented the systems in a less extensible manner. 

![here is the program file from the composite pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Composite%20Pattern/program.JPG "here is the program file from the composite pattern")

Firstly, here is a snippet of the program file. This starts off the same as the following command pattern with a few minor differences. When we instantiate the Command Parser object this time, we pass into it an AdventurerCommandsMaker. This is the first of many patterns utilized in this example. By passing in this maker, we see the start of a builder pattern take shape. We know at a glance that this maker object is probably going to be the one to handle orchestration of the builder objects. By knowing the shared language of patterns we know that if we were to pass in a different maker that supplies a different set of commands we would be able to completely alter the way in which the Command Parser operates as it would be functioning with a different set of commands. 

![here is the first part of the command parser file from the composite pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Composite%20Pattern/commandparser1.JPG "here is the first part of the command parser file from the composite pattern")

The command delegation is held mainly within the Command Parser object. We can see that it has a few private methods, being the maker object passed into the constructor form the program file, a list of commands that are returned from the maker object, and a data model object modelling the Party.

We can also see that there is a small amount of looping logic in the constructor. This is simply setting up our chain of responsibility without knowing the number of items in the chain. By doing this we can pass in a maker that returns a larger or smaller set of commands and be sure that all of these are added to the chain of responsibility, this is the second pattern we have seen here.

Less noticeable the command object has an isEndItem property. This is on the null item pattern that indicates the end of the chain without the system throwing an exception. By adding this flag to the chainable command objects and setting the flag to true on the null object pattern. We can be sure that the chain will end in a null object without causing the system blow up. We are also able to implement specific behaviour when no command match was found.

![here is the second part of the command parser file from the composite pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Composite%20Pattern/commandparser2.JPG "here is the second part of the command parser file from the composite pattern")

This is the second half of the command parser that defines how commands are parsed and passed through into the command chain. In this instance of a CLI example I have opted to make more complex commands abstracted with the IRegistedCommand interface. This is composed of two primary commands for example "add group" then N number of further parameters.

![here is a command file from the composite pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Composite%20Pattern/command.JPG "here is a command file from the composite pattern")

This is an instance of a command class. We can see that it inherits from the Base Chainable which allows for this to  operate within the CoR pattern we have setup for command parsing. It also implements the Icommand interface which is another of the previously described patterns. We can also see in the execute method that it fires the add group method on the repo that it has. In this case it is the PartyModel which implements the IParty interface seen below.

![here is an abstraction file from the composite pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Composite%20Pattern/abstraction.JPG "here is an abstraction file from the composite pattern")

This is the actual component of the composite pattern. This defines how the system should treat party objects. In our example a party class that implements this could be either a person or a group which contains people.

![here is a party model file from the composite pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Composite%20Pattern/partymodel.JPG "here is a party model file from the composite pattern")

IParty is firstly implemented by PartyModel. I don’t really need this cl ass as all it does is act as a root for the composite structure. I could just make a group named root and have this as the party model that is interacted with in the commands.

![here is a group file from the composite pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Composite%20Pattern/group.JPG "here is a group file from the composite pattern")

Above is the class definition for groups. we can see that it has a group name and a list of parties that can be either people or more groups. 

![here is a member file from the composite pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Composite%20Pattern/member.JPG "here is a member file from the composite pattern")

# Decorator

The decorator pattern allows developers to add functionality to existing classes without changing the base class that we need to add functionality. For example, in the real world we often want to be able to add functionality to legacy code. However, this doesn’t always go down so well with altering legacy code which is so old it is considered voodoo magic in its implementation. Because of this we don’t want to change the core implementation of this code as we know that it is getting the right values from its current set of functionality, we just want to be able to extend this and alter a few methods and maybe add a new method entirely. We can do this by wrapping the legacy code in a decorator which allows for the core legacy functionality to remain intact while also being able to implement new logic to interact with the underlying logic as well as implement new stuff on top of this.

## What it solves

The decorator pattern solves the issue of edit code to fit new requirements when current functionality is already working. There is inherit failings within development if code is being changed after the functionality of that component has be verified. To properly follow the O of the SOLID programming principles we should not being editing the original components (open/closed principle). 

## Implementation

The decorator pattern was one of the easier patterns to wrap my head around so far. The basic principle is that we have an object that needs its functionality changed or functionality added in some way. We can do this by putting the original object within a decorator class that implements the same interface. The Decorator Base class has a reference to a component object that it stores and calls its methods upon. This reference could be to the original core object or it could be another decorator if the use case needs multiple decorations of the same object.

Within the concrete decorators that extend the Decorator abstract base class we define out behaviour that we need to change or add. This can be done by overriding the implementation of the methods defined in the component abstraction. 

![here is a simple diagram showing the basic implementation of a decorator pattern.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/DecoratorPattern.JPG "here is a simple diagram showing the basic implementation of a decorator pattern")

This is the standard implementation of a decorator pattern. An interesting point here is that that loop back from the Decorator abstraction class, to the Component Abstraction class. This is very similar to the composite pattern just covered, as the decorator can have other decorators, or it could have a concrete component which would act as the leaf in the composite pattern.

## Example run down

![here is a program file from the decorator pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Decorator%20Pattern/program.JPG "here is a program file from the decorator pattern")

This shows the main method from the code example we can see a concrete gun get made of type UMP45. Then we instantiate the silencedGun and pass through the base gun. This then gets then goes a layer deeper and wraps the silences UMP45 with an FMJ rounds. The output for this looks like the below screenshots.

![here is for the first few decorated objects from the decorator pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Decorator%20Pattern/output.JPG "here is the output for the first few decorated objects from the decorator pattern")

![here is a gun abstract class file from the decorator pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Decorator%20Pattern/gun.JPG "here is a gun abstract class file from the decorator pattern")

This is the abstract Gun class that gets decorated with attachments.

![here is the first part of the concrete gun class file from the decorator pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Decorator%20Pattern/gunImp1.JPG "here is the first part of the concrete gun class file from the decorator pattern")

The first part of the concrete gun class that implements the abstraction of gun.

![here is the second part of the concrete gun class file from the decorator pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Decorator%20Pattern/gunImp2.JPG "here is the second part of the concrete gun class file from the decorator pattern")

The second part of the concrete gun class that implements the gun abstraction

![here is the abstract gun decorator file from the decorator pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Decorator%20Pattern/gunDec.JPG "here is the abstract gun decorator file from the decorator pattern")

Gun decorator abstraction that implements the gun abstract class but also is extended by the concrete decorator classes

![here is a concrete gun decorator class file from the decorator pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Decorator%20Pattern/silencer.JPG "here is a concrete gun decorator class file from the decorator pattern")

The concrete gun decorator. In this case the silencer. 

#  Event Aggregator

The event aggregator was a pattern I struggled with originally. Primarily because I lacked experience with the problem domain faced with creating pub/sub type relationships in a system of scale. The Event aggregator is a single source of truth when it comes to event registration and removes the need for publishing items to know about their subscribers and vice versa. This becomes more useful in large systems or systems with limited resources, as the low-level memory management that needs to be considered with standard pub/sub implementations is abstracted away.

## What it solves

As mentioned briefly in the previous section the pattern solves an issue faced in more typical pub/sub implementations where there is large risk for memory leaks if memory is not considered carefully. This is because each publisher knows about its subscribers and each subscriber knows about its publishers it is subscribed to. All these references can become very heavy and system slowdown is inevitable in larger systems or in environments where resources are scarce.

## Implementation

![here is a simple diagram showing the basic implementation of an event aggregator pattern.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/EventAggregator.JPG "here is a simple diagram showing the basic implementation of an event aggregator pattern")

This is a conceptual model of the how the event aggregator should look like from a high level. Using weak references, we keep subscribers up to date with any events that they are subscribed to. Also using weak references, we can publish events to the event aggregator and then the event aggregator handles sending these events out to the concrete classes that implement that specific interface<event>

![here is a simple diagram showing the basic implementation of an event aggregator pattern.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/EventAggregatorClassy.JPG "here is a simple diagram showing the basic implementation of an event aggregator pattern")

## Example run down

![here is the controller class from the event aggregator pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Event%20Aggregator/controller.JPG "here is the controller class from the event aggregator pattern")

![here is a concrete subscriber from the event aggregator pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Event%20Aggregator/subcThomas.JPG "here is a concrete subscriber from the event aggregator pattern")

![here is another concrete subscriber from the event aggregator pattern](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Code%20Snippets/Event%20Aggregator/subKris.JPG "here is a concrete subscriber from the event aggregator pattern")

# Facade Pattern

The facade pattern is an easy pattern to cover. It acts as one large abstraction to a system or set of subsystems. Say for example a large legacy back end service was needed for a customer facing app to work. The dev team managed to refactor completely the front end to use the latest and greatest technologies but was being bogged down by making old legacy calls to a backend service, a facade pattern might be of use. Instead of refactoring the legacy code, we can abstract away the entire system to a facade that only exposes certain functionality or provides orchestration for a single call to the facade to run sets of related functionalities.

## What it solves

The facade pattern is good for abstracting away large systems, complex systems, legacy systems or any combination of the three. This allows us to adhere to the open close principle as we will no longer need to change the functionality that is already working even if we want to change the overall interface it exposes. 

## Implementation

The implementation of the facade pattern is quite a basic one. Instead of having multiple references from the client code that link to the other various subsystems we can decouple the client code and tie it to a facade object which will in turn route through to the other subsystems instead. By doing this we can consolidate the interface of various classes and subsystems into a single functional interface. This also allows us to perform task orchestration as we can have a public method that defines groups of related functionalities. For example, if in the system we required the client code to create a user and to do this we needed to make multiple calls across the system to make this work. Instead of tying the client to these various parts of the system we can make a single call to the facade pattern which then handles calling these parts of the system without the client knowing.

![here is a simple diagram showing a bad implementation.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/badFacadePattern.JPG "here is a simple diagram showing a bad implementation")

Above is a diagram of a system that could make a good use case for a facade pattern. We can see that the client has hard ties to the other parts of the system. By introducing a facade object to handle these calls and route to the correct parts of the system we can avoid such tight coupling.

![here is a simple diagram showing the basic implementation of a facade pattern.](https://raw.githubusercontent.com/ThomasMicol/DesignPatterns/master/Diagrams/GoodFacadePattern.JPG "here is a simple diagram showing the basic implementation of a facade pattern")

This is the same diagram with a facade pattern introduced. Now the client code only needs to talk to the facade, and it doesn't need to know about any of the systems it requires to run.

## Example run down

[program method ss]

The facade pattern as shown in this example is quite basic. In the first screenshot we start with client code wanting to get a monster. A monster can have stats and a name randomly generated. To do this generation we pass the monster object to providers that allow for this functionality. 
In the first screenshot can see that the client code is having to orchestrate the construction of this monster itself even though the same steps are repeated when a new monster is wanted.

We can simplify this interface with the use of a facade. This is exactly what we do in the second screenshot. 

[FAcade objwct ss]

We can see here that we have simply moved the instantiation of the object and the passing to providers to a facade. This way the client code as shown below can just call a single method that handles the generation of the monster and returns a monster object with all the stats and the name already generated. 

We even added in the ability in the facade to do some dependency injection as it takes in an INamer and an IStateProvider which allows for us to decouple our facade implementation from the types of generator services it uses. We can now pass in different generator services that comply to the interface and the facade pattern will work without having to be changed. This allows us to adhere to the OCP of the SOLID principle set.

Here is the output of the explained code above.

[add output ss]

# Factory Pattern

The Factory Pattern is a creational pattern that allows us to remove the need to know what implementation of an abstraction at instantiation time. This is useful for when we have a set of concrete classes that implement an abstraction and we need one of these, but don’t know specifically which one.

This pattern is useful for refactoring out switch cases or large if else chains that only return an instantiation of an object and the logic is only used to decide which implementation should be needed.

By separating the object creation from the decision of which object needing to be created we can extend our system more freely without having to perform shotgun surgery to remove old concrete class instantiations.

## What it solves
This pattern solves the need for decoupling the creation of an object from the logic that decides the object to be created. by doing this we get the benefits of creating a more decoupled system such as being able to extend the implementation classes and include this into the factory with easy without having to set hard locations in the code where the concrete classes are instantiation.

By doing this we are also able to adhere to the Open/Close Principle and we are also able to store which objects are to be created outside of the system. For example, a database.

## Implementation
## Example run down
# Flyweight
## What it solves
## Implementation
## Example Run Down

