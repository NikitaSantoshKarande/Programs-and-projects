/*3. Accept N numbers from user check whether
 that numbers contains 11 in it or not.
Input :  N :   6
  Elements : 85 66 11 80 93 88
Output : 11 is present
Input :  N :   6
  Elements : 85 66 3 80 93 88
Output : 11 is absent */
#include<stdio.h>
int main()
{
    int a=0,*p=NULL,i=0,count=0;
    printf("Enter the number of elements \n");
    scanf("%d",&a);

    p=(int*)malloc(a*sizeof(int));

    printf("enter the element\n");
     for(i=0;i<a;i++)
     {
         scanf("%d",p+i);
     }
     funcall(p,a);
     free(p);
}
int funcall(int arr[],int a)
{
    int i=0,count=0;
    for(i=0;i<a;i++)
    {
        if(arr[i]==11)
        {
            count++;
        }
    }
    if(count>0)
    {
        printf("11 is present");
    }
    else
    {
        printf("11 is absent");
    }

}
