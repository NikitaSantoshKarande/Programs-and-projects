#   2. Write a program which contains one function named as ChkNum()
#   which accept one parameter as number.
#   If number is even then it should display “Even number” otherwise
#   display “Odd number” on console.
#   Input : 11
#   Output : Odd Number
#   Input : 8
#   Output : Even Number
def ChkNum(No):
       if No%2==0:
           print("Even number")
       else:
           print("Odd number")
def main():
    No=0
    print("Enter the one number:")
    No=int(input())
    ChkNum(No)
if __name__=="__main__":
    main()