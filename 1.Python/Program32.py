#1. Write a recursive program which display below pattern.
#Input :   5
#Output :   * * * * *
import functools
def Recu(No):
    if(No!=0):
        No=No-1
        print("*",end=' ')
        Recu(No)
def main():
    size=0
    print("Enter the size:")
    size=int(input())
    Recu(size)
if __name__=="__main__":
    main()