# 10. Write a program which accept number from user and return addition
# of digits in that number.
# Input : 5187934   Output : 37
def DigitAdd(No):
     iCnt=0
     iSum=0
     while No!=0:
       iRem=No%10
       iSum = iSum + iRem
       No=No//10
     return iSum
def Main():
   No=0
   iRet=0
   print("Enter the one number:")
   No=int(input())
   iRet=DigitAdd(No)
   print("Your Digit count is: ",iRet)
if __name__ == "__main__":
   Main()