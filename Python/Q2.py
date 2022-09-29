n = float(input("Put the number of terms of the GP: "))
a1 = float(input("Put the first term of the GP: "))
q = float(input("Put the ratio of the GP: "))

an = a1 * (q**(n-1))

print("The last term of the Geometric Progression is: ", an)