/*1.Write a program which accept number
 from user and display its digits in reverse order.
Input :  2395
Output :  5
          9
          3
          2
Input :  1018
Output :  8
          1
          0
          1
Input :  -1018
Output :  8
          1
          0
          1
Input :  9000
Output :  0
          0
          0
          9   */
#include<stdio.h>
int main()
{
    int x=0;
    printf("Enter the number:");
    scanf("%d",&x);
    displaydigit(x);
    return 0;
}
void displaydigit(int x)
{
    int r=0,y=0;
    while(x!=0)
    {
        r=x%10;
        y=y*10+r;
        x=x/10;
    }
      printf("%d\n",y);

}
