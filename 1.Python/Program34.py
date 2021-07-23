#3.Write a recursive program which display below pattern.
#Input :   5
#Output :   5 4 3 2 1
def Recu(No):
    if(No!=0):
        print(No,end=' ')
        No = No - 1
        Recu(No)
def main():
    size=0
    print("Enter the size:")
    size=int(input())
    Recu(size)
if __name__=="__main__":
    main()