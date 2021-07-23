# 9. Write a program which accept number from user and return number of
# digits in that number.
# Input : 5187934
# Output : 7
def DigitCont(No):
     iCnt=0
     while No!=0:
       iCnt = iCnt + 1
       No=No//10
     return iCnt
def Main():
   No=0
   iRet=0
   print("Enter the one number:")
   No=int(input())
   iRet=DigitCont(No)
   print("Your Digit count is: ",iRet)
if __name__ == "__main__":
   Main()