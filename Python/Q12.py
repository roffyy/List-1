n = int(input("Put the number of sides of the polygon:"))
side = int(input("Put the side value: "))


if n >= 3 and n <= 5:
    if n == 3:
        per = n * side
        print("\nThe polygon is a triangle!")
        print(f"Perimeter value: {per}\n")
    
    if n == 4:
        area = side ** 2
        print("\nThe polygon is a square!")
        print(f"Area value: {area}\n")
    
    if n == 5:
        print("\nThe polygon is a pentagon!\n")

else:
    print("\nUnidentified polygon!\n")