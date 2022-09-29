Test1 = float(input("Put the first test score: "))
Test2 = float(input("Put the second test score: "))
Test3 = float(input("Put the third test score: "))

Average = (Test1 + Test2 + Test3)/3

if Average >= 7:
    print(f"\nYou are approved! (Average: {Average})")

else:
    print(f"\nYou need to do the final exam! (Average: {Average})")

    FinalExam = float(input("\nPut your final exam score: "))

    FinalAverage = (Average + FinalExam)/2

    if FinalAverage >= 5:
        print(f"\nYou are approved! (Final Average: {FinalAverage})")
    
    else:
        print(f"\nYou are reproved! (Final Average: {FinalAverage})")

