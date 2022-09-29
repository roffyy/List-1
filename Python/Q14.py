print("Runner 1: ")
c1Hours = int(input("Hours: "))
c1Minutes = int(input("Minutes: "))
c1Seconds = int(input("Seconds: "))

print("\nRunner 2: ")
c2Hours = int(input("Hours: "))
c2Minutes = int(input("Minutes: "))
c2Seconds = int(input("Seconds: "))

c1time = c1Seconds + c1Minutes * 60 + c1Hours * 60 ** 2
c2time = c2Seconds + c2Minutes * 60 + c2Hours * 60 ** 2

if c1time > c2time:
    print("\nThe winner is runner 2!")
    diff = c1time - c2time
    diffMin = int(diff / 60)
    diffHours = int(diffMin / 60)
    minutes = diffMin - diffHours * 60
    seconds = diff - minutes * 60 - diffHours * 60 ** 2
    print(f"Difference: {diffHours} Hours {minutes} Minutes and {seconds} Seconds")


elif c1time < c2time:
    print("\nThe winner is runner 1!")
    diff = c2time - c1time
    diffMin = int(diff / 60)
    diffHours = int(diffMin / 60)
    minutes = diffMin - diffHours * 60
    seconds = diff - minutes * 60 - diffHours * 60 ** 2
    print(f"Difference: {diffHours} Hours {minutes} Minutes and {seconds} Seconds")

else:
    print("\nThe 2 runners arrived at the same time!")
