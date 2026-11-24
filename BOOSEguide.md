# BOOSE Guide

This guide is based on the example programs in `BOOSEexamplePrograms/` and the BOOSE documentation in `api/`. It summarises the language features that appear in the programs and shows the typical syntax used in practice.

BOOSE is a small, imperative, drawing-oriented language. Programs contain commands that draw on a canvas, manipulate values, and control flow. Many BOOSE programs look like this:

```boose
int radius = 50
pen 255,0,0
moveto 100,100
circle radius
```

## 1. Basic syntax

- BOOSE is line-based.
- Each statement usually starts with a command keyword and then parameters.
- Comments begin with `*`, for example:

```boose
* this is a comment
```

- Variable names and method names are written in lowercase or camel-case style such as `radius`, `count`, `testMethod`.
- Numbers can be integer or real (`50`, `15.5`, `3.14159`).
- Expressions can use arithmetic such as `+`, `-`, `*`, `/` and comparisons such as `<`, `>`, `=`.
- String values are written in quotes, for example `"£" + y`.

## 2. Variable declarations

BOOSE supports integers, reals, and arrays.

### Integer variables

```boose
int radius = 50
int width
int height = 100
```

Use `int` for whole numbers.

### Real variables

```boose
real length = 15.5
real pi = 3.14159
```

Use `real` for floating-point numbers.

### Assignment

```boose
width = 2 * radius
height = height - 15
```

Assignments use `=`. Expressions are evaluated before being stored.

## 3. Drawing commands

These commands interact with the canvas.

### `moveto x,y`
Moves the pen or drawing position to a coordinate.

```boose
moveto 100,100
moveto 150,50
```

### `pen r,g,b`
Sets the current drawing colour.

```boose
pen 0,255,0
pen 255,0,0
pen 0,0,255
```

The colour values are red, green, blue integers between 0 and 255.

### `circle radius`
Draws a circle with the given radius.

```boose
circle 50
circle radius
```

### `rect width,height`
Draws a rectangle using the given width and height.

```boose
rect 50,100
rect width, height
```

### `write expression`
Prints a value or expression.

```boose
write 42
write length * width
write "£" + y
```

The examples use `write` to show variable values and calculations.

## 4. Arrays

BOOSE supports arrays of fixed size.

```boose
array int nums 10
array real prices 10
```

This creates an integer array and a real array with 10 slots.

### `poke arrayName index = value`
Stores a value in an array slot.

```boose
poke nums 5 = 99
poke prices 5 = 99.99
```

### `peek variable = arrayName index`
Reads a value from an array slot into a variable.

```boose
peek x = nums 5
peek y = prices 5
```

Example:

```boose
int x
real y
array int nums 10
poke nums 5 = 99
peek x = nums 5
circle x
```

## 5. Conditionals

BOOSE has `if`, `else`, and `end if`.

```boose
int control = 50
if control < 10
    pen 255,0,0
    circle 20
else
    pen 0,255,0
    circle 100
end if
```

The condition can use comparison operators such as:

- `<` less than
- `>` greater than
- `=` equality or assignment depending on context

The examples use a pattern like:

```boose
if height < 100
    pen 0,128,255
end if
```

Nested `if` statements are also allowed:

```boose
if control < 10
    if control < 5
        pen 255,0,0
    else
        pen 0,0,255
    end if
    circle 20
else
    pen 0,255,0
    circle 100
end if
```

## 6. Loops

### `while condition`
Runs while the condition is true.

```boose
int height = 150
while height > 50
    circle height
    height = height - 15
end while
```

### `for variable = start to end step increment`
Runs a loop with a counter.

```boose
for count = 1 to 20 step 2
    circle count * 10
end for
```

The step can be positive or negative:

```boose
for count = 20 to 1 step -2
    circle count * 10
end for
```

This is the basic BOOSE pattern for counted loops.

## 7. Methods and function-like commands

BOOSE supports method definitions and calls.

```boose
method int testMethod int one, int two
  testMethod = one * two
end method
```

A method definition has:

- `method` keyword
- return type (`int` in the example)
- name (`testMethod`)
- parameter list (`int one, int two`)
- body
- `end method`

Then it is called like this:

```boose
call testMethod 10 15
```

Example:

```boose
method int testMethod int one, int two
  testMethod = one * two
end method
int global = 55
call testMethod 10 15
write testMethod
circle testMethod
rect global, global
```

## 8. Expressions and arithmetic

The examples show several arithmetic expressions:

```boose
width = 2 * radius
height = height - 15
circle count * 10
real circ = 2 * pi * radius
```

Common operators:

- `+` add
- `-` subtract
- `*` multiply
- `/` divide
- `<` and `>` comparison

Expressions can be used in `write`, assignments, loops, and drawing commands.

## 9. Program structure and execution order

BOOSE programs execute from top to bottom, one command at a time. Drawing instructions and variable updates affect the state as the program runs.

Example:

```boose
int radius = 50
pen 255,0,0
moveto 100,100
circle radius
```

This declares a variable, changes the pen colour, moves to a coordinate, then draws a circle.

## 10. Restrictions and unrestricted mode

The BOOSE documentation describes a restricted and unrestricted runtime. In restricted mode, the system limits program size, number of variables, and the number of loop iterations. The example programs often include a comment such as:

```boose
*example of a while statement which will violate restrictions, you will need to replace the While class.
```

This means some example programs are intentionally written to require custom or unrestricted implementations of language features.

In short:

- Restricted programs stay within the built-in limits.
- Unrestricted programs rely on a replacement or unrestricted implementation of the runtime.
- The examples in `BOOSEexamplePrograms/` show both styles.

## 11. Full example

```boose
int radius = 50
int width
int height = 100
int red = 255
int green = 128
pen red,0,0
moveto 100,100
circle radius
rect width, height
pen red,0,0
moveto 150,150
circle radius
```

This example declares variables, sets a pen colour, moves the cursor, and draws shapes using computed values.

## 12. Quick command reference

- `int name [= value]` — declare integer variable
- `real name [= value]` — declare real variable
- `array int name size` — declare integer array
- `array real name size` — declare real array
- `poke name index = value` — assign to an array slot
- `peek variable = name index` — read from an array slot
- `moveto x,y` — move drawing position
- `pen r,g,b` — set pen colour
- `circle radius` — draw a circle
- `rect width,height` — draw a rectangle
- `write expression` — output data
- `if condition` … `else` … `end if` — conditional execution
- `while condition` … `end while` — loop while true
- `for var = start to end step n` … `end for` — counted loop
- `method type name params` … `end method` — define a method
- `call name params` — invoke a method

## 13. Summary

BOOSE is a lightweight language with:

- typed variables (`int`, `real`, `array`)
- canvas drawing commands
- arithmetic expressions
- conditionals and loops
- method definitions and calls

The example programs show the real-world syntax and how the commands are used together. If you are writing your own BOOSE program, start with a simple sequence of variables and drawing commands, then add conditionals, loops, and finally methods.
