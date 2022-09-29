# List 1
## Exercise List
### Question 1:
Write a program that receives (reads) a temperature in degrees Fahrenheit, calculates and writes the
corresponding value in degrees Celsius, using the formula below:
```python
C = (F − 32) / 1.8
```

### Question 2:
Develop a program that reads the number n, the first term (a1) and the ratio (q) from a Geometric Progression. Your algorithm must calculate and print the (n)th term of this progression using the formula:
```python
an = a1 * q ^ (n−1)
```

### Question 3:
Write a program that reads the total time spent in a race and the distance traveled by the runner.
Then print his average pace (in min/km) during his run. Consider that time and the distance will be natural values.

### Question 4:
Being the variables a = 2, b = 4 and c = 6, tell if each of the following conditions is true
or false:
```python
a) a == 4 or b > 2
b) 6 <= c and a > 3
c) 1 != b and c != 3
d) a >= -1 or a <= b
e) not (a > 2)
```

### Question 5:
Without using conditional structures (if - else), write a program that reads 4 integers
and calculate the sum and the average of the even numbers and the sum and average of the odd numbers.

### Question 6:
A palindromic number is a number that remains the same when its digits are reversed:
```
11
242
20002
324567765423
123456789987654321
135792468864297531
123456789135792468864297531987654321
```
Write a program that reads an integer between [1000, 9999] (four-digit numbers) and
check if it is palindrome or not.

### Question 7:
A natural number is ascending if each of its digits is strictly higher than any of the digits to its left. For example, the number 358 (3 < 5 < 8) is rising. Write a program that reads an integer (n) from the range [100, 999] and tells if n is or not.

### Question 8:
The following code was written without the use correct indentation. Rewrite the code and use the proper indentation conventions.
```python
if media >= 9.0
print("A")
else:
if media >= 8.0
print("B")
else:
if media >= 7.0
print("C")
else:
if media >= 6.0
print("D")
else:
print("R")
```

### Question 9:
Rewrite the code from the previous exercise using the (if - elif - else) statements.

### Question 10:
Write a program that reads a student's three test scores. Then calculate the average and
check if the student passed (average ≥ 7.0) or if he/she is in the final exam. If you're in the final exam,
read his score in the final exam and print if he get approved or not (final average ≥ 5.0).

### Question 11:
Write a program that reads the value of x, and calculates and prints (using the math library) the value of f(x):
```
ln x, if x ≤ 1
log10 x + √x, if 1 < x ≤ 2
x2 + e ^ (x), if 2 < x ≤ 5
x ^ (x/2) + log2 x, if x > 5
```

### Question 12:
Write a program to read the number of sides of a regular polygon and the length of the side. Then it should calculate and print the following steps:

• If the number of sides is equal to 3, write Triangle and the value of the perimeter;

• If the number of sides is equal to 4, write Square and the value of the area;

• If the number of sides is equal to 5, write Pentagon;

• In any other situation write Unidentified Polygon.

### Question 13:
Write a program that reads the valor (a, b, and c) of the sides of a triangle and writes if these
measurements can form a triangle. If so, tell if the triangle is equilateral, isosceles or
scalene.

Condition of existence of a triangle:

• |b − c| < a < b + c

• |a − c| < b < a + c

• |a − b| < c < a + b

Observation:

• Equilateral triangle: 3 equal sides;

• Isosceles triangle: 2 equal sides;

• Scalene triangle: 3 different sides.

### Question 14:
Write a program that reads the time spent (in hours, minutes and seconds) by two runners, inform who was the winner and calculate the difference between them.

### Question 15:
Write a program that reads two dates (inputs: day, month and year): the date of someone birth and the other is the current date. Then the program should print the person's age.

### Question 16:
To calculate the day of Easter (Sunday), the formula below is used, where the YEAR must be entered
with 4 digits and X and Y are given by the following table.
```python
a = YEAR % 19
b = YEAR % 4
c = YEAR % 7
d = (19 × a + X) % 30
e = (2 × b + 4 × c + 6 × d + Y ) % 7
```
Then:

• Calculate the value of P given by ```P = (22 + d + e)```. If P is less than or equal to 31, Easter
It will be on the P of March. 

Otherwise:

• Calculate ```P1 = (d + e − 9)```. If P1 is less than or equal to 25, Easter will be on P1 in April.

Otherwise:

• Calculate ```P2 = (P1 − 7)``` and Easter will be on P2 of April, as it cannot be celebrated in
date after the 25th of April.
