#3. Write a program which accept one number from user and return its factorial.
# Input :  5
# Output : 120
def Fact(No):
     iCnt=1
     i=1
     for iCnt in range(1,No+1,1):
        i=i*iCnt
     return i

def Main():
   No=0
   iRet=0

   print("Enter the one number:")
   No =int(input())

   iRet=Fact(No)
   print("Your factorial is: ", iRet)

if __name__ == "__main__":
   Main()