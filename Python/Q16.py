year = int(input("Put a year: "))

a = year % 19
b = year % 4
c = year % 7

if year >= 1582 and year <= 1699:
    X = 22
    Y = 2
    d = (19 * a + X) % 30
    e = (2 * b + 4 * c + 6 * d + Y) % 7
    P = 22 + d + e
    P1 = d + e - 9
    P2 = P1 - 7
elif year >= 1700 and year <= 1799:
    X = 23
    Y = 3
    d = (19 * a + X) % 30
    e = (2 * b + 4 * c + 6 * d + Y) % 7
    P = 22 + d + e
    P1 = d + e - 9
    P2 = P1 - 7
elif year >= 1800 and year <= 1899:
    X = 23
    Y = 4
    d = (19 * a + X) % 30
    e = (2 * b + 4 * c + 6 * d + Y) % 7
    P = 22 + d + e
    P1 = d + e - 9
    P2 = P1 - 7
elif year >= 1900 and year <= 2099:
    X = 24
    Y = 5
    d = (19 * a + X) % 30
    e = (2 * b + 4 * c + 6 * d + Y) % 7
    P = 22 + d + e
    P1 = d + e - 9
    P2 = P1 - 7
elif year >= 2100 and year <= 2199:
    X = 24
    Y = 6
    d = (19 * a + X) % 30
    e = (2 * b + 4 * c + 6 * d + Y) % 7
    P = 22 + d + e
    P1 = d + e - 9
    P2 = P1 - 7
elif year >= 2200 and year <= 2299:
    X = 25
    Y = 0
    d = (19 * a + X) % 30
    e = (2 * b + 4 * c + 6 * d + Y) % 7
    P = 22 + d + e
    P1 = d + e - 9
    P2 = P1 - 7
elif year >= 2300 and year <= 2399:
    X = 26
    Y = 1
    d = (19 * a + X) % 30
    e = (2 * b + 4 * c + 6 * d + Y) % 7
    P = 22 + d + e
    P1 = d + e - 9
    P2 = P1 - 7
elif year >= 2400 and year <= 2499:
    X = 25
    Y = 1
    d = (19 * a + X) % 30
    e = (2 * b + 4 * c + 6 * d + Y) % 7
    P = 22 + d + e
    P1 = d + e - 9
    P2 = P1 - 7
else:
    print("Its not a valid year!")

if P <= 31:
    print(f"In the year {year} the easter will be in the {P} day of march")
elif P1 <= 25:
    print(f"In the year {year} the easter will be in the {P1} day of April")
else:
    print(f"In the year {year} the easter will be in the {P2} day of April")
