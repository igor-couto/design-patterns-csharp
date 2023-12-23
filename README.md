# Design Patterns in C#

## Facade
_gof_
It Provides a simplified interface to a complex system of classes, library, or framework. A Facade is used when an easier or simpler interface to an underlying object is desired. It typically involves a single wrapper class that contains a set of members required by the client. These members access the system on behalf of the facade client and hide the implementation details.

What problems can the Facade design pattern solve?

- To make a complex subsystem easier to use, a simple interface should be provided for a set of interfaces in the subsystem.
- The dependencies on a subsystem should be minimized.