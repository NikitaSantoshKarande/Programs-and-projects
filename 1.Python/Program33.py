#2. Write a recursive program which display below pattern.
#Input :   5
#Output :   1 2 3 4 5
i=1
def Recu(No):
    global i
    if(No!=0):
        No=No-1
        print(i,end=' ')
        i = i + 1
        Recu(No)
def main():
    size=0
    print("Enter the size:")
    size=int(input())
    Recu(size)
if __name__=="__main__":
    main()