oddCount, oddSum = 0, 0

num1 = int(input("Type the first number here: "))
num2 = int(input("Type the second number here: "))
num3 = int(input("Type the third number here: "))
num4 = int(input("Type the fourth number here: "))

oddSum += num1*(num1%2)
oddSum += num2*(num2%2)
oddSum += num3*(num3%2)
oddSum += num4*(num4%2)

evenSum = num1 + num2 + num3 + num4 - oddSum

oddCount += num1%2
oddCount += num2%2
oddCount += num3%2
oddCount += num4%2

evenCount = 4 - oddCount

oddAvr = oddSum / oddCount
evenAvr = evenSum / evenCount

print(f"\nEven Numbers: \nSum: {evenSum} \nAverage: {evenAvr}")
print(f"\n\nOdd Numbers: \nSum: {oddSum} \nAverage: {oddAvr}")