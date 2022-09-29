num1 = int(input("Type the first number here: "))
num2 = int(input("Type the second number here: "))
num3 = int(input("Type the third number here: "))
num4 = int(input("Type the fourth number here: "))

sum = [0, 0]
size = [0, 0]

sum[num1 % 2] += num1
size[num1 % 2] += 1

sum[num2 % 2] += num2
size[num2 % 2] += 1

sum[num3 % 2] += num3
size[num3 % 2] += 1

sum[num4 % 2] += num4
size[num4 % 2] += 1

evenAvg = sum[0]/size[0]
oddAvg = sum[1]/size[1]

print(f"\nThe sum of even numbers is: {sum[0]} \nThe average of the even numbers is: {evenAvg}")
print(f"\nThe sum of odd numbers is: {sum[1]} \nThe average of the odd numbers is: {oddAvg}")