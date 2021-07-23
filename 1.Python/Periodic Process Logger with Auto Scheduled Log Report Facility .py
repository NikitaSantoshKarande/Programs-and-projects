import os
import time 
import psutil
from sys import*
import schedule

def ProcessDisplay(FolderName="Demo"):
    Data=[]

    if not os.path.exists(FolderName):
        os.mkdir(FolderName)
   
    File_Path=os.path.join(FolderName,"Demo%s.txt"%time.ctime())
    fd=open(File_Path,"w")

    for proc in psutil.process_iter():
        value=proc.as_dict(attrs=['pid','name','username'])
        Data.append(value)

    for element in Data:
        fd.write("%s\n"% element)

def main():
    print("Script title: "+argv[0])

    if(argv[1]=="-u")or(argv[1]=="-U"):
        print("üse:Application_Name Shedule time Directory_Name")
        exit()
    if(argv[1]=="-h")or(argv[1]=="-H"):
        print("help:It is used to create log file of running processes")
        exit()

    schedule.every(int(argv[1])).minutes.do(ProcessDisplay)

    while True:
        Shedule.run_pending()
        time.sleep(1)

if __name__ =="__main__":
    main()