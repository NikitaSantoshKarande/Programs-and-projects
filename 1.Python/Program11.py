# 9. Write a program which display first 10 even numbers on screen.
# Output :  2 4 6 8 10 12 14 16 18 20

def main():
   No=0
   iCnt=0
   iSum=0
   print("Enter number:")
   No=int(input())

   for iCnt in range(0,No,1):
       iSum=iSum+2;
       print(iSum)

if __name__=="__main__":
   main()