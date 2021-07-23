#4.Write a recursive program which accept number from user and return summation of its digits.
#Input :  879
#Output :  24
iSum=0
def Recu(No):
    iRem=0
    global iSum
    if(No!=0):
        iRem=No%10
        iSum=iSum+iRem
        No=No//10
        Recu(No)
    return iSum
def main():
    size=0
    ret=0
    print("Enter the size:")
    size=int(input())
    ret=Recu(size)
    print(ret)
if __name__=="__main__":
    main()