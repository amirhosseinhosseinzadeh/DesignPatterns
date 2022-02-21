Description => Abstract factory is a creational pattern which let you to produce families of related objects without specifying the concrete class.
---------------------------------------------------------------------------------------------
consider a factory with tree differnet product =>
{
	sofa,
	chair,
	table
}
with varient styles =>
{
	art deco,
	victorian,
	modern
}
which creates bellow matrice =>
{
	      |  modern  |  victorian  | art deco
	-------------------------------------------
	      |modern    |  victorian  | art deco
	sofa  |sofa      |  sofa       | sofa      
	      |		 |	       |
	------|------------------------------------
	      |modern    |  victorian  | art deco
	chair |chair     |  chair      | chair
	      |          |             |
	-------------------------------------------
	      |modern    |  victorian  | art deco
	table |table     |  table      | table
	      |          |             |
}
