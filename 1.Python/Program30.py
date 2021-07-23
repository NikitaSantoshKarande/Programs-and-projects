# 3.Write a program which contains filter(), map() and reduce() in it.
# Python application which contains one list of numbers.
# List contains the numbers which are accepted from user. Filter should filter
# out all such numbers which greater than or equal to 70 and less than or
# equal to 90. Map function will increase each number by 10. Reduce will
# return product of all that numbers.
# Input List = [4, 34, 36, 76, 68, 24, 89, 23, 86, 90, 45, 70]
# List after filter = [76, 89, 86, 90, 70]
# List after map = [86, 99, 96, 100, 80]
# Output of reduce = 6538752000
import functools
def GretLess(arr):
    return(arr>=70 and arr<=90)
def Increment(arr):
    return(arr+10)
def Product(a,b):
    return a*b
def main():
    size=0
    arr=[]
    print("Enter the size:")
    size=int(input())
    print("Enter the elements")
    for i in range(size):
        arr.append(int(input()))

    GreterLessarr=list(filter(GretLess,arr))
    print("Data after filter:",GreterLessarr)

    IncrementArr=list(map(Increment,GreterLessarr))
    print("Data after mapping",IncrementArr)


    ProductArr=functools.reduce(Product,IncrementArr)
    print("Data after reduce:",ProductArr)

if __name__=="__main__":
    main()