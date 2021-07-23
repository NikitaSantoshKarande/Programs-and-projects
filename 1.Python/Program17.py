# 5.Write a program which accept one number for user and check whether number is prime or not.
# Input :  5
# Output : It is Prime Number
def PrimeChk(No):
     iCnt=1
     if No>1:
         for iCnt in range(2, No):
            if (No % iCnt) == 0:
                return False
         else:
            return True
     else:
         return False
def Main():

   No=0
   bRet=0

   print("Enter the one number:")
   No =int(input())

   bRet=PrimeChk(No)
   if bRet==True:
       print("It is Prime Number")
   else:
       print("It is not Prime Number")

if __name__ == "__main__":
   Main()