#5. Write a recursive program which accept number from user and return its factorial.
#Input :  5
# Output : 120
i=1
iCount=1
def Recu(No):
    global iCount
    global i
    if(No!=0):
        i=i*iCount;
        iCount=iCount+1
        No=No-1
        Recu(No)
    return i
def main():
    size=0
    ret=0
    print("Enter the size:")
    size=int(input())
    ret=Recu(size)
    print(ret)
if __name__=="__main__":
    main()