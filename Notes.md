# Design Patterns

## Catalogue

- Creational Patterns
  - Singleton
  - Factory
  - Abstract Factory
  - Prototype
  - Builder
- Structural Patterns
  - Decorator
  - Adapter
  - Facade
  - Composite
  - Factory
- Behavioral Patterns
  - Observer
  - Command
  - Iterator
  - Strategy
  - State

## Design Principles

1. Identify the aspects of your application that vary and separate them from what stays the same.
2. Program to an interface, not an implementation.
3. Favor composition over inheritance.
4. Strive for loosely coupled designs between objects that interact.
5. Open-Closed Principle: Classes should be open for extension, but closed for modification.
6. Dependency Inversion Principle: Depend upon abstractions. Do not depend upon concrete classes.

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