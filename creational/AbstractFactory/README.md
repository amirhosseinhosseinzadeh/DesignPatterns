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

	|   #  |  modern  |  victorian  | art deco  |
	|------|----------|-------------|-----------|
	|      |modern    |  victorian  | art deco  |
	|sofa  |sofa      |  sofa       | sofa      |
	|      |	  |	        |	    |
	|------|----------|-------------|-----------|
	|      |modern    |  victorian  | art deco  |
	|chair |chair     |  chair      | chair	    |
	|      |          |             |	    |
	|------|----------|-------------|-----------|
	|      |modern    |  victorian  | art deco  |
	|table |table     |  table      | table	    |
	|      |          |             |	    |

consider the vendors won change their catalog often and developers neither wnat to change the source code each time.

### :bulb: Solution

The idea which `Abstract factory` provides is to explicity Create interface for each category of products()
then we can make all those variants of products to implement those interfaces

For example all different type of chairs can implement the chair interface all tables can implement table interface and so on ...

|    IChair    |
|--------------|
|	HasLeh()   |
|--------------|
|   SitOn()    |


|VictorainChair|
|--------------|
|    .....     |
|--------------|
|	HasLeh()   |
|--------------|
|   SitOn()    |


|VictorainChair|
|--------------|
|    .....     |
|--------------|
|	HasLeh()   |
|--------------|
|   SitOn()    |


