# 3. Write a program which contains one function named as Add()
# which accepts two numbers from user and return addition of that two numbers.
# Input : 11    5
# Output : 16
def Add(No1,No2):
    iRet=0
    iRet=No1+No2
    return iRet
def main():
    No1=0
    No2=0
    iRet=0
    print("Enter the first value:")
    No1=int(input())
    print("Enter the Seound value:")
    No2=int(input())
    iRet=Add(No1,No2)
    print("Your addition is:",iRet)
if __name__=="__main__":
   main()