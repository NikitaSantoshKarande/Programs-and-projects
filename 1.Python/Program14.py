#2. Write a program which accept one number and display below pattern.
# Input :  5
#Output :  * * * * *
#          * * * * *
#          * * * * *
#          * * * * *
#          * * * * *

def Pattern(No):
   iCnt=1
   for iCnt in range(No):
      for iCnt in range(No):
         print("*",end=' ')
      print()
def Main():
   No=0;
   print("Enter the one number:")
   No=int(input())
   Pattern(No)
if __name__=="__main__":
   Main()