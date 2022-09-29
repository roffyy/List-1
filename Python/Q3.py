minutes = int(input("Type the total time spent on the run (in min): "))
km = int(input("Type the distance traveled (in km): "))

average = minutes/km
minInt = int(average)
Seconds = int((average - minInt) * 60)

print(f"Average runner pace: {minInt}:{Seconds} min/km")