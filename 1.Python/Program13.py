# 1.Create on module named as Arithmetic which contains
# 4 functions as Add() for addition, Sub() for subtraction,
# Mult() for multiplication and Div() for division. All functions
# accepts two parameters as number and perform the operation.
# Write on python program which call all the functions from Arithmetic module
# by accepting the parameters from user.
import Arithmatic
def main():
   No1=0
   No2=0
   iAdd=0
   iSub=0
   iMult=0
   iDiv=0
   print("Enter first number:")
   No1=int(input())
   print("Enter Second number:")
   No2 = int(input())
   iAdd=Arithmatic.Add (No1,No2)
   iSub=Arithmatic.Sub(No1, No2)
   iMult=Arithmatic.Mult(No1, No2)
   iDiv= Arithmatic.Div(No1, No2)
   print("Your Addition is:",iAdd)
   print("Your Substraction is:",iSub)
   print("Your Multiplication is",iMult)
   print("Your Division is",iDiv)
if __name__=="__main__":
   main()


(Module->Arithmatic.py)

def Add(No1,No2):
   iRet=0
   iRet=No1+No2
   return iRet
def Sub(No1,No2):
   iRet = 0
   iRet = No1 - No2
   return iRet
def Mult(No1,No2):
   iRet = 0
   iRet = No1 * No2
   return iRet
def Div(No1,No2):
   iRet = 0
   iRet = No1 / No2
   return iRet