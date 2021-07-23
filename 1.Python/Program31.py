# 4.Write a program which contains filter(), map() and reduce() in it.
# Python application which contains one list of numbers.
# List contains the numbers which are accepted from user.
# Filter should filter out all such numbers which are even.
# Map function will calculate its square.
# Reduce will return addition of all that numbers.
# Input List = [5, 2, 3, 4, 3, 4, 1, 2, 8, 10]
# List after filter = [2, 4, 4, 2, 8, 10]
# List after map = [4, 16, 16, 4, 64, 100]
# Output of reduce = 204
import functools

def Even(arr):
    return(arr%2==0)
def Squar(arr):
    return(arr*arr)
def Addition(a,b):
    return a+b
def main():
    size=0
    arr=[]
    print("Enter the size:")
    size=int(input())
    print("Enter the elements")
    for i in range(size):
        arr.append(int(input()))

    Evenarr=list(filter(Even,arr))
    print("Data after filter:",Evenarr)

    SquarArr=list(map(Squar,Evenarr))
    print("Data after mapping",SquarArr)


    AdditionArr=functools.reduce(Addition,SquarArr)
    print("Data after reduce:",AdditionArr)

if __name__=="__main__":
    main()