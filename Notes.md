# Design Principles

1. Strive for loosely coupled designs between objects that interact.

2. Open-Closed Principle: Classes should be open for extension, but closed for modification.

3. Dependency Inversion Principle: Depend upon abstractions. Do not depend upon concrete classes.

# Observer Pattern

The Observer Pattern defines a one to many dependency between objects so that when one objects changes state, all of its dependents are notified and updated automatically.

# Decorator Pattern

The Decorator Pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible
alternative to subclassing for extending functionality.

# Factory Pattern

## Definition

The Factory Method Pattern defines an interface for creating an object, but lets subclass decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

## Abstract Factory Pattern

The Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

## Difference between factory and abstract factory

An abstract factory is used whenever you have families of products you need to create and you want to make sure your clients create products that belong together.

A Factory Method is used to decouple your client code from the concrete classes you need to instantiate, or if you don’t know ahead of time all the concrete classes you are going to need. To use, just subclass factory and implement the create method!
