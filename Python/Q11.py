import math

x = float(input("Put a x valor here: "))

if x <= 1:
    y = math.log(x)

if 1 < x <= 2:
    y = math.log10(x) * x + math.sqrt(x)

if 2 < x <= 5:
    y = x * x + math.exp(x)

if x > 5:
    y = x ** (x/2) + math.log2(x)

print(f"The image of the function is: {y}")