# Description 

## Abstract factory is a creational pattern which let you to produce families of related objects without specifying the concrete class.

###### consider a factory with tree differnet product 
* sofa
* chair
* table

###### with varient styles 
* art deco
* victorian
* modern

###### which creates bellow matrice

| # | modern | victorian | art deco |
| --- | --- | --- | --- |
| sofa | modern sofa | victorian sofa | art deco sofa | 
| --- | --- | --- | --- |
| chair | modern chair | victorian chair | art deco chair |
| --- | --- | --- | --- |
| table | modern table | vctorian table | art deco table |

consider the vendors won change their catalog often and developers neither wnat to change the source code each time.

### :bulb: Solution

The idea which `Abstract factory` provides is to explicity Create interface for each category of products()
then we can make all those variants of products to implement those interfaces

For example all different type of chairs can implement the chair interface all tables can implement table interface and so on ...

|    IChair    |
| :---		   |
| HasLength()  |
| :---		   |
|   SitOn()    |


|VictorainChair|
| --- |
|    .....     |
| --- |
| HasLength()  |
| --- |
|   SitOn()    |


|  ModernChair |
| --- |
|    .....     |
| --- |
| HasLength()  |
| --- |
|   SitOn()    |

The next move is to declare abstract factory an interface with a list of creation methods for all products that are part of the product family(`CreateChair()`,
`CreateSof()`,`CreateCoffeTable()`)

These method must return `abstract` product types reperesented by the interfaces we expeted previously: `chair`,`sofa`,`coffe table` and so on.

For each variant of product we create a seprate factory class based on the `AbstractFactory` interface.
The client code most work with each different factories through their provided interfaces 
this let you change the type of factroy that pass to a client code as well as the product variant that the cliet code receives, without breaking the client code.

If the client code is only exposed to the abstract interfaces, what creates the actual factory objects?
usualy the application creates a `concrete factory` object at the initialization stage.
just before that the applicaation most select the factory base on the configurations or environment settings.

### pseudo code

```

interface GUIFactory{
	createButton(): Button

	createCheckbox(): Checkbox
}

class WinFactory : GUIFactory{
	createButton(){
		return new WindowsButton();
	}

	createCheckbox(){
		return new WindowsCheckbox();
	}
}

class LinuxFactory : GUIFactory{
	createButton(){
		return new LinuxButton();
	}

	createCheckbox(){
		return new LinuxCheckbox();
	}
}

interface Button{
	onClick(): event

	print(): void
}

interface Checkbox{
	onClick(): event

	print(): void
}

class WindowsButton : Button{
	onClick(){
		/// implementations
	}

	print(){
		/// implementations
	}
}

class WindowsCheckbox : Checkbox{
	onClick(){
		/// implementations
	}

	print(){
		/// implementations
	}
}

class LinuxButton : Button{
	onClick(){
		/// implementations
	}

	print(){
		/// implementations
	}
}

class LinuxCheckbox : Checkbox{
	onClick(){
		/// implementations
	}

	print(){
		/// implementations
	}
}

```

### the client code be likes

```
class ApplicationConfiguration{
	method main(){
		configuration = readApplicationConfiguration();

		GUIFactory factory;

		if(configuration.Os.IsWindows()){
			factory = new WindowsFactory();
		}
		if(configuration.Os.IsLinux()){
			factory = new LinuxFactory();
		}
		else{
			raise Error("The os is not supported");
		}
		return factory;
	}
}

class Application{
	private field _factory : GUIFactory;
	private field _button : Button;
	private field _checkbox : Checkbox;

	ctor(factory : Factory){
		this._factory = factory;
	}

	createUI(){
		this._button = factory.createButton();
		this._button.print();

		this._checkbox = factory.createcheckBox();
		this._checkBox.print();
	}

	buttonOnClick(){
		this._button.onClick();
	}

	checkboxOnClick(){
		this._checkbox.onClick();
	}
}

```

<!-- ## the source also contains a Source code as sample -->