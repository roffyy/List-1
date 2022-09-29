num = int(input("Type a number with 3 digits: "))

digit1 = int(num/100)
digit2 = int(num/10) - digit1 * 10
digit3 = num - digit1 * 100 - digit2 * 10

if digit1 < digit2 < digit3:
    print("The number is ascending :>")

else:
    print("The number isnt ascending :<")
