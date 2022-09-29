even, odd, evenCount, oddCount = 0, 0, 0, 0

num1 = int(input("Type the first number here: "))
num2 = int(input("Type the second number here: "))
num3 = int(input("Type the third number here: "))
num4 = int(input("Type the fourth number here: "))

numbers = [num1, num2, num3, num4]

for i in range(4):
    while numbers[i] % 2 == 0:
        even += numbers[i]
        evenCount += 1
        break

    while numbers[i] % 2 == 1:
        odd += numbers[i]
        oddCount += 1
        break

evenAvg = even/evenCount
oddAvg = odd/oddCount

print(f"Even sum: {even} \nOdd sum: {odd} \nEven Med: {evenAvg} \nOdd Med: {oddAvg}")