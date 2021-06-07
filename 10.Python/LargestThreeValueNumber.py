def main():
    No1=0
    No2=0
    No3=0
    print("Enter the number:")
    No1=int(input())
    print("Enter the number:")
    No2=int(input())
    print("Enter the number:")
    No3=int(input())

    if No1>No2 and No1>No3:
        print("Largest number is={}".format(No1));
    elif No2>No1 and No2>No3:
        print("Largest number is={}".format(No2));
    else:
        print("Largest number is={}".format(No3));
if __name__ =="__main__":
    main()