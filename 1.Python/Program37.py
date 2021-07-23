"""1.Write a program which contains one class named as Demo. 
Demo class contains two instance variables as no1 ,no2. 
That class contains one class variable as Value. 
There are two instance methods of class as Fun and Gun which displays values of instance 
variables. 
Initialise instance variable in init method by accepting the values from user. 
 
After creating the class create the two objects of Demo class as 
Obj1 = Demo(11,21) 
Obj2 = Demo(51,101) 
Now call the instance methods as 
Obj1.Fun() 
Obj2.Fun() 
Obj1.Gun() 
Obj2.Gun() """
class Demo():
	Value=0
	def __init__(self,i,j):
		self.No1=i
		self.No2=j
	def Fun(self):
		print("Inside fun instance variable i= :",self.No1)
		print("Inside fun instance variable j= :",self.No2)
	def Gun(self):
		print("Inside Gun instance variable i= :",self.No1)
		print("Inside Gun instance variable j= :",self.No2)
def main():
	Obj1 = Demo(11,21) 
	Obj2 = Demo(51,101)

	Obj1.Fun() 
	Obj2.Fun() 
	Obj1.Gun() 
	Obj2.Gun()
if __name__=="__main__":
	main()