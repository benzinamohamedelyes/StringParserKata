# Parse String Algorithm

## Overview

This project is designed to implement an algorithm in C# that counts the number of occurrences of a substring (`StringRecherche`) within another string (`StringATester`). It also provides an example and discusses alternative approaches.

---

## Problem Statement

### Goal:
Create a method that takes two strings as inputs:
1. `StringRecherche`: The substring to search for.
2. `StringATester`: The string in which to find occurrences.

The method returns the number of times `StringRecherche` appears in `StringATester`.

### Example:
```csharp
string StringRecherche = "abc";
string StringATester = "aabcjabgabc";
int nb = ParseString(StringRecherche, StringATester);
Console.WriteLine(nb);
// Output: 2