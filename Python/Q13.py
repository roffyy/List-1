a = float(input("Put the value of the first side of the triangle: "))
b = float(input("Put the value of the second side of the triangle: "))
c = float(input("Put the value of the third side of the triangle: "))

if (b - c < a < b + c) or (a - c < b < a + c) or (a - b < c < a + b):
    print("\nThe measurements can form a triangle!\n")
    if a == b == c:
        print("The triangle is equilateral!\n")
    elif a != b != c:
        print("The triangle is scalene!\n")
    else:
        print("The triangle is isosceles!\n")
else:
    print("\nThe measurements cannot form a triangle!\n")