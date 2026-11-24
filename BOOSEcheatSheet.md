# BOOSE Cheat Sheet

## Core syntax

```boose
* comment
int radius = 50
real length = 15.5
array int nums 10
```

## Drawing

```boose
moveto 100,100
pen 255,0,0
circle 50
rect 100,50
write "£" + 10
```

## Variables and assignment

```boose
int width
width = 2 * radius
height = height - 15
real pi = 3.14159
```

## Arrays

```boose
array int nums 10
poke nums 5 = 99
int x
peek x = nums 5
```

## Conditionals

```boose
if control < 10
    pen 255,0,0
    circle 20
else
    pen 0,255,0
    circle 100
end if
```

## Loops

```boose
while height > 50
    circle height
    height = height - 15
end while

for count = 1 to 20 step 2
    circle count * 10
end for
```

## Methods

```boose
method int testMethod int one, int two
  testMethod = one * two
end method

call testMethod 10 15
```

## Common commands

- `int name [= value]` — integer variable
- `real name [= value]` — real variable
- `array int name size` — integer array
- `array real name size` — real array
- `poke name index = value` — write array slot
- `peek var = name index` — read array slot
- `moveto x,y` — move position
- `pen r,g,b` — set pen colour
- `circle radius` — draw circle
- `rect width,height` — draw rectangle
- `write expr` — print value
- `if condition` … `else` … `end if` — conditional
- `while condition` … `end while` — loop
- `for var = start to end step n` … `end for` — counted loop
- `method type name params` … `end method` — define method
- `call name args` — invoke method

## Quick example

```boose
int radius = 50
int width
width = 2 * radius
pen 0,0,255
moveto 100,100
circle radius
rect width, 100
```
