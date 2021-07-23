# 5.Write a program which accept N numbers from user and store it into List.
# Return addition of all prime numbers from that List.
# Main python file accepts N numbers from user and pass each number to ChkPrime()
# function which is part of our user defined module named as MarvellousNum.
# Name of the function from main python file should be ListPrime().
# Input : Number of elements : 11
# Input Elements : 13 5 45 7 4 56 10 34 2 5 8
# Output : 32 (13 + 5 + 7 +2 + 5)
def ChkPrime(arr,No):
    
    MaxNo=max(arr)  #max value in array

    prime=[True for i in range(MaxNo+1)]
    prime[0]=False
    prime[1]=False
    for p in range(2,MaxNo+1):
        if(p*p>MaxNo):
            break

        if(prime[p]==True):

            for i in range(p*2,MaxNo+1,p):
                prime[i]=False
    sum=0
    for i in range(No):
        if(prime[arr[i]]):
            sum=sum+arr[i]
            
    return sum

def main():
    size=0
    arr=[]
    i=0
    print("Enter the number of element:")
    size=int(input())
    print("Enter the elements:")
    for i in range(size):
        arr.append(int(input()))
    n=len(arr)
    ret=ChkPrime(arr,n);
    print("prime number addition is:",ret)
if __name__=="__main__":
    main()