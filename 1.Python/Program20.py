# 8. Write a program which accept one number and display below pattern.
# Input :  5
# Output :  1
#           1 2
#           1 2 3
#           1 2 3 4
#           1 2 3 4 5
def Pattern(No):
     i=0
     j=0
     for i in range(1,No+1):
         for j in range(1,No+1):
             if i>=j:
                print(j,end=' ')
         print()

def Main():
   No=0
   print("Enter the one number:")
   No =int(input())
   Pattern(No)

if __name__ == "__main__":
   Main()