num = int(input("Type a number with 4 digits: "))

digit1 = int(num/1000)
digit2 = int(num/100) - digit1 * 10
digit3 = int(num/10) - digit1 * 100 - digit2 * 10
digit4 = num - digit1 * 1000 - digit2 * 100 - digit3 * 10

if digit1 == digit4 and digit2 == digit3:
    print(f"\nThe number {num} is a palindrome :>")

else:
    print(f"\nThe number {num} isnt a palindrome :<")
