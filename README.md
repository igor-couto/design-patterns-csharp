# Design Patterns in C#
[![Build](https://github.com/igor-couto/design-patterns-csharp/actions/workflows/build.yml/badge.svg)](https://github.com/igor-couto/design-patterns-csharp/actions/workflows/build.yml)

## Facade
_gof_, _structural_

It Provides a simplified interface to a complex system of classes, library, or framework. A Facade is used when an easier or simpler interface to an underlying object is desired. It typically involves a single wrapper class that contains a set of members required by the client. These members access the system on behalf of the facade client and hide the implementation details.

What problems can the Facade design pattern solve?

- To make a complex subsystem easier to use, a simple interface should be provided for a set of interfaces in the subsystem.
- The dependencies on a subsystem should be minimized.

## Adapter
_gof_, _structural_

The Adapter pattern allows objects with incompatible interfaces to collaborate. It is often used to make existing classes work with others without modifying their source code.

The adapter design pattern solves problems like:

- How can a class be reused that does not have an interface that a client requires?
- How can classes that have incompatible interfaces work together?
- How can an alternative interface be provided for a class?


## Decorator
_gof_, _structural_ 

The Decorator pattern allows behavior to be added to individual objects, either statically or dynamically, without affecting the behavior of other objects from the same class.

What problems can it solve?

- Responsibilities should be added to (and removed from) an object dynamically at run-time.
- A flexible alternative to subclassing for extending functionality should be provided.

The Decorator pattern is particularly useful for adhering to the Open/Closed Principle, one of the SOLID principles, which states that software entities should be open for extension but closed for modification.

## Singleton
_gof_, _creational_

The singleton pattern restricts the instantiation of a class to a singular instance. It is useful when exactly one object is needed to coordinate actions across a system.
Singletons are often preferred to global variables because they do not pollute the global namespace (or their containing namespace). Additionally, they permit lazy allocation and initialization, whereas global variables in many languages will always consume resources

The singleton pattern allows objects to:
- Ensure they only have one instance
- Provide easy access to that instance
- Control their instantiation (for example, hiding the constructors of a class)