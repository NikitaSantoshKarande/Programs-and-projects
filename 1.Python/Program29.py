# 2.Write a program which contains one lambda function which accepts two
# parameters and return its multiplication.
# Input : 4 3
# Output : 12
# Input : 6 3
# Output : 18

Sum=lambda No1,No2:No1*No2

def main():
    No1=0
    No2=0
    print("Enter the first value:")
    No1=int(input())
    print("Enter the second value:")
    No2 = int(input())
    ret=Sum(No1,No2)
    print("Multiplication is:",ret)

if __name__=="__main__":
    main()