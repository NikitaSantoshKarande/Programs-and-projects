# 1.Write a program which contains one lambda function which accepts one
# parameter and return  power of two.
# Input : 4
# Output : 16
# Input : 6
# Output : 64

Sum=lambda No1:2**No1

def main():
    No1=0
    print("Enter the one value:")
    No1=int(input())
    ret=Sum(No1)
    print("Power of two is:",ret)

if __name__=="__main__":
    main()