def main():
    No1=0
    No2=0
    temp=0
    print("Enter the one number\n");
    No1=int(input())

    print("Enter the second number\n");
    No2=int(input())
    
    print("before swap:No1={} No2={}\n".format(No1,No2))
    
    temp=No1
    No1=No2
    No2=temp

    print("After swap:No1={} No2={}".format(No1,No2))

if __name__ =="__main__":
    main()