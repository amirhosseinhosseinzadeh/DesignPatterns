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
| :---:| :---:| :---:| :---:|
| sofa | modern sofa | victorian sofa | art deco sofa |
| :---:| :---:| :---:| :---:|
| chair | modern chair | victorian chair | art deco chair |
| :---:| :---:| :---:| :---:|
| table | modern table | vctorian table | art deco table |

consider the vendors won change their catalog often and developers neither wnat to change the source code each time.

### :bulb: Solution

The idea which `Abstract factory` provides is to explicity Create interface for each category of products()
then we can make all those variants of products to implement those interfaces

For example all different type of chairs can implement the chair interface all tables can implement table interface and so on ...

|    IChair    |
| :---: |
| HasLength()  |
| :---: |
|   SitOn()    |


|VictorainChair|
| :---: |
|    .....     |
| :---: |
| HasLength()  |
| :---: |
|   SitOn()    |


|  ModernChair |
| :---: |
|    .....     |
| :---: |
| HasLength()  |
| :---: |
|   SitOn()    |

The next move is to declare abstract factory an interface with a list of creation methods for all products that are part of the product family(`CreateChair()`,
`CreateSof()`,`CreateCoffeTable()`)

These method must return `abstract` product types reperesened by the interfaces we expeted previously: `chair`,`sofa`,`coffe table` and so on.

