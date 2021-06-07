import math
def main():
    iCount=0
    iRem=0
    iSum=0
    No=0
    iCopy=0

    print("Enter the number:")
    No=int(input())

    iCopy=No
    while iCopy!=0:
        iCount+=1
        iCopy=math.floor(iCopy/10)

    iCopy=No

    while iCopy!=0:
        iRem=iCopy%10
        iSum+=pow(iRem,iCount)
        iCopy=math.floor(iCopy/10)

    if No==iSum:
        print("Armstrong")
    else:
        print("Not Armstrong")

if __name__ =="__main__":
    main()