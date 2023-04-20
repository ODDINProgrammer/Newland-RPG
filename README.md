# Newland-RPG
 
Stupid name, dont figured out what the game will look like, so I dont have a specific name currently. 

This is ought to be my most complex project yet, which main objective is to demonstrate as much coding practice undrestanding as I can. SOLID principles, state machine patterns for enemy behaviours etc. 

About SOLID principles:
Currently, I consider this project to follow them as closely as I can understand them. 
* Scripts are separated as much as possible, following Single responsibility principle. 
* Abstract classes are used to make extendable and easy to use objects. As of 20/04/2023 abstract item class is implemented. There are abstract item class, which contains fields for name and value/price of the item, as I consider that all items will have them. Then I have abstract weapon class, which inherits from item class inhancing it with damage field, as all weapons will need one. Also IUsableItem interface has been implemented and assigned to weapon class, as all weapons will be usable and it provides an easy usability from other classes. Why not using IUsableItem on Item base class, you might ask? The answer is easy, I consider that there will be items that wont be usable at all. Finally, we have a sword class, which inherits from weapon class. Currently you can override Attack function, as I currently am thinking that different weapons will have their own attack logic. 
* Interface segregation is followed, as project currently has small interfaces with related methods, e.g. ICanMove makes objects which suppose to be able to move to implement Move() in some way. Also, this way we can segregate future enemy types further, by making ones moveable and others stationary, without any changes to base classes. 
