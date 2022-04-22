Creational
{
	◙ Singleton pattern
	◙ Factory Pattern
	◙ Abstract factory Pattern
	◙ Builder pattern
	◙ Prototype Pattern
}
Structural
{
	◙ Adapter pattern
	◙ Composite pattern
	◙ Proxy pattern
	◙ Flyweghit pattern
	◙ Facade pattern
	◙ Bridge pattern
	◙ Decorator pattern
}
Behavioral
{
	◙ Template method pattern
	◙ Mediator pattern
	◙ Chain of responsibility pattern
	◙ Observer patterns
	◙ Strategy pattern
	◙ Command pattern
	◙ State pattern
	◙ Visitor pattern
	◙ Iterator pattern
	◙ Interpreter pattern
	◙ Memento pattern
	◙ Repository pattern
}

---------------------------------------------------------------------------------------------

Singleton pattern =>
{
	If you want a class have only one object , Then we use singleton pattern
	
	make object constructor private
	we create a private field from that type and create a method to check if field is null then initialize it and return that field
	then make initializer method static
	another way for initializing is property with encapsulation 
}

Factory pattern =>
{
	The idea is what kind of object must be created base on some kindof parameters
}

Template method pattern => 
{
	Subclass decide how to implement steps in an algorithm.
}

Adapter pattern => 
{
	Adapter pattern is a engineering pattern which allows us to use this structure 
	or interface of an existing class with another class which is considerably different and is not 
	compatible.
	Adapter pattern is most frequently used when we need to retrofit the classes created
	for a legacy system to be used with new classes which cannot be integrated directly with The
	legacy classes
	A real-world example can be of a video cable which can be used to convert a VGA output from a
	graphics card into a DVI input supported by monitor that we are using the final
	output is a video on the screen but the source video data is different 
	A code example can be of an older class whch has a function returning computational data
	which cannot be directly used wiht the new ouput requirements but it also be a waste of time and resources to 
	again write the computational logic or maybe copy it to a new class 
}

Facade pattern =>
{
	This design pattern will provide an unified and simplified interface in a subsystem 
	there for it hides the complexities of the subsystem from the client.
	It means if you have a client and a complex class than "FACADE" provides a simplified to a complex set of classes
	now instead of classes it can be complex or component or a group of component as well 
}

Prototype pattern =>
{
	The whole idea is base on the prototpye and what is this prototype refer to 
	First we need an interface or kind of abstract class to implement the copy/clone method
	So we configuring what we want to be create at run time thats the main differenc 
	between the factory where its kind of like at compile time ,we decide what we want 
	to create with passing some parameters although it not quite powerful as the prototype pattern
	There is two main way that we a use it 
	This approach saves costly resources and time, especially when object creation is a heavy process
	|	the first Just hving your application compose these prototypes and it really 
		dependent what your application does and we'll we're going to take look at it in a real world 
		example in the source code
	------------------------------------------------
	|	but anotherway that can be nore digestible at the moment is for example if we have factory and 
	 	and this factory may implement some kindof interface and if you have a big hierchy of objects
		that you may want to have you factory class create instead of creating the the identical
		amount of factories that could possbly create all types of combinations of all the 
		gardens that you want you can simply supply prototypes in to the factory is going to spit out the 
		appropriate seeds
}

Abstract factory =>
{
	Abstrct factory is similar to any other abstract class 
	This pattern is useful when the object must create so many times and we dont wqnt to write the intialization code 
	again and again.
	In this pattern we will create a class and it will use to hide the implementation code of object creation and 
	only expose methods which will rtun the created object
	In the case of factory pattern when we have to create two or more factory classes then we can use  
}

Builder pattern =>
{
	If you want to build a class which might have many subclasses it is wiser to it by methods and not by consttuctor parameters.
	The reason is that there wont be many empty parameters everytime creating a new object of the main class.
	In order to use this pattern, first create an interface of all the methods which needs to be implemented by the concrete builders.
	Then implement those methods by the specific builders. There can also be a director class which its job is to insure that the order of
	using the methods are correct.
}