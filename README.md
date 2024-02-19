# Design Patterns

## Catalogue

- Creational Patterns
  - Singleton
  - Factory
  - Abstract Factory
  - Builder
- Structural Patterns
  - Decorator
  - Adapter
  - Facade
  - Composite
- Behavioral Patterns
  - Strategy
  - Observer
  - Command
  - Template
  - Iterator
  - State

## Design Principles

1. Identify the aspects of your application that vary and separate them from what stays the same.
2. Program to an interface, not an implementation.
3. Favor composition over inheritance.
4. Strive for loosely coupled designs between objects that interact.
5. Open-Closed Principle: Classes should be open for extension, but closed for modification.
6. Dependency Inversion Principle: Depend upon abstractions. Do not depend upon concrete classes.
7. Principle of Least Knowledge: talk only to your immediate friends.
8. The Hollywood Principle: With the Hollywood Principle, we allow low-level components to hook themselves into a system, but the high-level components determine when they are needed, and how. In other words, the high-level components give the low-level components the “don’t call us, we’ll call you” treatment.
9. Single Responsibility Principle: A class should have only one reason to change.

## Strategy Pattern

The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

## Observer Pattern

The Observer Pattern defines a one to many dependency between objects so that when one objects changes state, all of its dependents are notified and updated automatically.

## Decorator Pattern

The Decorator Pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

## Factory Pattern

### Definition

The Factory Method Pattern defines an interface for creating an object, but lets subclass decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

### Abstract Factory Pattern

The Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

### Difference between factory and abstract factory

An abstract factory is used whenever you have families of products you need to create and you want to make sure your clients create products that belong together.

A Factory Method is used to decouple your client code from the concrete classes you need to instantiate, or if you don’t know ahead of time all the concrete classes you are going to need. To use, just subclass factory and implement the create method!

## Singleton Pattern

The Singleton Pattern ensures a class has only one instance, and provides a global point of access to it.

## Command Pattern

The Command Pattern encapsulates a request as an object, thereby letting you parameterize other objects with different requests, queue or log requests, and support undoable operations.

## Adapter Pattern

The Adapter Pattern converts the interface of a class into another interface the clients expect. Adapter lets classes work together that couldn’t otherwise because of incompatible interfaces.

## Facade Pattern

The Facade Pattern provides a unified interface to a set of interfaces in a subsystem. Facade defines a higherlevel interface that makes the subsystem easier to use.

### Decorator vs Adapter vs Facade

- Decorator extends responsibility or behaviours to the existing objects without modifying the interface or type. They can be applied multiple times as well.
- Adapter converts the interface of the object that they wrap into one interface that a client is expecting.
- A facade on the other hand simplifies an interface (although it also gives a new interface like adapter) and it also decouples a client from a subsystem of components.

## Template Pattern

The Template Method Pattern defines the skeleton of an algorithm in a method, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm’s structure.

### Template vs Strategy vs Factory

- Template: Subclasses decide how to implement steps in an algorithm. This happens at compile-time.
- Strategy: Encapsulate interchangeable behaviors and use delegation to decide which behavior to use. This happens at runtime.
- Factory: Subclasses decide which concrete classes to instantiate.

## Iterator Pattern

The Iterator Pattern provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

## Composite Pattern

The Composite Pattern allows you to compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.

## State Pattern

The State Pattern allows an object to alter its behavior when its internal state changes. The object will appear to change its class.

### Strategy vs State Pattern

- These both use composition and delegation to incorportate different behaviors.
- Both change behavior at runtime.
- Strategy intents to have plugin behaviors. State pattern moves object into different defined state. In other words, strategy encapsulates behavior and state encapsulates states.
- Strategy is defined by the client but state is done by context or state itself.

## Builder Pattern

Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

### Builder vs Factory vs Decorator

- Builder does step by step creation of complex objects.  If you have a class with many constructors, and every constructor has a high number of parameters, also known as the Telescoping Constructor Pattern, you can use Builder to create an object more easily.
- Factory creates objects without specifying the exact class of object that will be created in one go. Factory may have params though.
- Decorator is also used to add functionality to existing objects but a decorator may not know about the other decorator. This is less flexible while builder provides more flexiblity.
