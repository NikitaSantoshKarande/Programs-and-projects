# 4.Write a program which accept one number form user and return addition
# of its factors.
# Input :  12
# Output : 16  (1+2+3+4+6)
def AddFactors(No):
     iCnt=1
     iSum=0
     for iCnt in range(1, No, 1):
        if No % iCnt == 0:
           iSum=iSum+iCnt
     return iSum

def Main():

   No=0
   iRet=0

   print("Enter the one number:")
   No =int(input())

   iRet=AddFactors(No)
   print("Your addition of factors is: ", iRet)

if __name__ == "__main__":
   Main()