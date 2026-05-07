```mermaid
---
title: AnimalKingdom
---
classDiagram

Animal : Sound()
Animal <|-- Dog
Animal <|-- Cat
Animal <|-- Bat
Animal <|-- Bee

class IMammal <<interface>>
IMammal : int NumberOfNipples
IMammal <|.. Dog
IMammal <|.. Cat
IMammal <|.. Bat

class ICanFly <<interface>>
ICanFly : int NumberOfWings
ICanFly <|.. Bat
ICanFly <|.. Bee
````