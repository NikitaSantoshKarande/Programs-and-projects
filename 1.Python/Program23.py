# 1.Write a program which accept N numbers from user and store it into List.
# Return addition of all elements from that List.
# Input : Number of elements : 6
# Input Elements : 13 5 45 7 4 56
# Output : 130
def Addition(arr):
    Add=0
    for i in range(len(arr)):
        Add=Add+arr[i]
    return Add
def main():
    size=0
    arr=[]
    i=0
    print("Enter the number of element:")
    size=int(input())
    for i in range(size):
        arr.append(int(input()))
    ret=Addition(arr);
    print("Addition is:",ret)
if __name__=="__main__":
    main()