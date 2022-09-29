birthDay = int(input("Put the day of your birth: "))
birthMon = int(input("Put the month of your birth: "))
birthYear = int(input("Put the year of your birth: "))

day = int(input("\nPut the current day: "))
mon = int(input("Put the current month: "))
year = int(input("Put the current year: "))

if year > birthYear:
    if mon > birthMon:
        age = year - birthYear
        print(f"\nAge: {age} years old\n")

    elif mon == birthMon:
        if day >= birthDay:
            age = year - birthYear
            print(f"\nAge: {age} years old\n")

        else:
            age = year - birthYear - 1
            print(f"\nAge: {age} years old\n")
    
    else:
        age = year - birthYear - 1
        print(f"\nAge: {age} years old\n")

elif year == birthYear:
    if mon > birthMon:
        age = year - birthYear
        print(f"\nAge: {age} years old\n")

    elif mon == birthMon:
        if day >= birthDay:
            age = year - birthYear
            print(f"\nAge: {age} years old\n")

        else:
            print(f"\nThis date isnt valid!\n")
    
    else:
        print(f"\nThis date isnt valid!\n")

else:
    print("\nThe year isnt valid!\n")