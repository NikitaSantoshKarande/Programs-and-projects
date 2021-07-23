# 4.Write a program which accept N numbers from user and store it into List.
# Accept one another number from user and return frequency of that number from List.
# Input : Number of elements : 11
# Input Elements : 13 5 45 7 4 56 5 34 2 5 65
# Element to search : 5
# Output : 3
def Min(arr,No):
    iCnt=0
    for i in range(len(arr)):
        if No==arr[i]:
            iCnt=iCnt+1
    return iCnt
def main():
    size=0
    arr=[]
    i=0
    No=0
    print("Enter the number of element:")
    size=int(input())
    print("Enter the elements:")
    for i in range(size):
        arr.append(int(input()))
    print("Enter the what element find:")
    No=int(input())
    ret=Min(arr,No);
    print("Count same elements is:",ret)
if __name__=="__main__":
    main()