# 6. Write a program which accept one number and display below pattern. Input :  5
# Output :  * * * * *
#           * * * *
#           * * *
#           * *
#           *
def Pattern(No):
     i=0
     j=0
     for i in range(No+1):
         for j in range(No+1):
             if i<j:
                 print("*",end=' ')
         print()

def Main():
   No=0
   print("Enter the one number:")
   No =int(input())
   Pattern(No)

if __name__ == "__main__":
   Main()