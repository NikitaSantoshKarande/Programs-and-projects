/*
1. Write a java program which accepts 2 strings from user and concat N characters of second string after first string.Value of N should be accepted from user. Note : If third parameter is greater than the size of second string then concat whole string after first string.
Input :
“Marvellous Infosystems”
“Logic Building”
5
Output :  “Marvellous Infosystems Logic”
 */
import java.lang.*;
import java.util.*;
class DemoString
{
    void Pattern(String str1,String str2,int iNo)
    {
        char arr1[]=str1.toCharArray();
        char arr2[]=str2.toCharArray();

       String ConStr="";
       ConStr=str1;
       int i=0;

       while (iNo>0)
       {
          ConStr=(ConStr)+ str2.charAt(i);
          i++;
          iNo--;
      }
      System.out.println("Your Reserse string is:" + ConStr);
    }
}
class Demo
{
    public static void main(String arg[])
    {

        Scanner sobj=new Scanner(System.in);
        System.out.println("Enter the first String:");
        String str1=sobj.nextLine();

        System.out.println("Enter the Secound String:");
        String str2=sobj.nextLine();

        System.out.println("Enter the Number:");
        int iNo=sobj.nextInt();

        DemoString dobj=new DemoString();
        dobj.Pattern(str1,str2,iNo);

    }
}