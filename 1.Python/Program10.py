# 8. Write a program which accept number from user and print that number
# of “*” on screen.
# Input : 5
# Output : * * * * *

def main():
   No=0
   iCnt=0
   print("Enter number:")
   No=int(input())

   for iCnt in range(No):
       print("*")

if __name__=="__main__":
   main()