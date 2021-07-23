# 3.Write a program which accept N numbers from user and store it into List.
# Return Minimum number from that List.
# Input : Number of elements : 4
# Input Elements : 13 5 45 7
# Output : 5
def Min(arr):
    MinNo=arr[0]
    for i in range(len(arr)):
        if MinNo>arr[i]:
            MinNo=arr[i]
    return MinNo
def main():
    size=0
    arr=[]
    i=0
    print("Enter the number of element:")
    size=int(input())
    print("Enter the elements:")
    for i in range(size):
        arr.append(int(input()))
    ret=Min(arr);
    print("Minimum is:",ret)
if __name__=="__main__":
    main()