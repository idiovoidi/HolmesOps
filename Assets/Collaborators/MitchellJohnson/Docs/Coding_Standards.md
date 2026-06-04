Coding Standards

General Rules

There can be no spaces or special characters in names or identifiers. This includes Variables, Functions, Classes, Structs and any other identifiers.
Avoid vague or misleading naming conventions.
Only make variables and functions public if they are required to be accessed by another class.
If a variable needs to be accessed in the Unity Inspector but not by other classes mark it is [SerializeField] rather than making it public.

Variables

Use lower camel case for Variable names
Use short, sensible names when creating a variable.
Example variable declaration for the movement speed going left and right:
[SerializeField] private int horizontalSpeed;

Functions, Classes and Methods

Use upper camel case for functions, methods and classes.
Use short, sensible names with no special characters or numbers.
Example class declaration for script that selects inventory items:
public class ItemSelector : Monobehaviour

Commenting Code

When introducing a new function, make sure to comment its purpose on the line above.
When creating a public variable or function that can be accessed by another class, give it a description.
