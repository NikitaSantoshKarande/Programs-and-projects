# 6.Write a program which accept number from user and check whether that number
# is positive or negative or zero.
# Input : 11
# Output : Positive Number
# Input : -8
# Output : Negative Number
# Input : 0
# Output : Zero
def main():
   No1=0
   print("Enter number to check:")
   No1=int(input())
   if No1==0:
       print("Zero")
   elif No1>0:
       print("Positive Number")
   else:
       print("Negative Number")
if __name__=="__main__":
   main()