/*4. Accept two numbers from user and
 display first number in second number of times. */
 /*
Input :  12 5
Output : 12 12 12 12 12
Input :  -2 3
Output : -2 -2 -2
Input :  21 -3
Output : 21 21 21
Input :  -2 0
Output : */
#include<stdio.h>
int main()
{
    int iValue=0;
    int iCount=0;
    printf("Enter the number\n");
    scanf("%d",&iValue);

    printf("Enter the frequency\n");
    scanf("%d",&iCount);
    Display(iValue,iCount);
    return 0;
}
int Display(int iNo,int ifrequency)
{
    int cnt=0;
    for(iNo;1<=ifrequency;ifrequency--)
    {
        printf("%d ",iNo);
    }
}
