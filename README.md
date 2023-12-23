# Design Patterns in C#

## Facade
_gof_

It Provides a simplified interface to a complex system of classes, library, or framework. A Facade is used when an easier or simpler interface to an underlying object is desired. It typically involves a single wrapper class that contains a set of members required by the client. These members access the system on behalf of the facade client and hide the implementation details.

What problems can the Facade design pattern solve?

- To make a complex subsystem easier to use, a simple interface should be provided for a set of interfaces in the subsystem.
- The dependencies on a subsystem should be minimized.

## Adapter
_gof_

The Adapter pattern allows objects with incompatible interfaces to collaborate. It is often used to make existing classes work with others without modifying their source code.

The adapter design pattern solves problems like:

- How can a class be reused that does not have an interface that a client requires?
- How can classes that have incompatible interfaces work together?
- How can an alternative interface be provided for a class?