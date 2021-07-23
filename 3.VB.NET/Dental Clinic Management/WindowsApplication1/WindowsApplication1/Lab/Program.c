
#include<stdio.h>
#include<stdlib.h>

int RemoveZeroes(int iArr[],int iSize)
{
    int i=0;

    for(i=0;i<iSize-1;i++)
    {
        if(iArr[i]==0)
        {
            iArr[i] = iArr[iSize-i];
	   i--;
            iSize--;
        }
        
    }
    if(iArr[iSize]==0)
    {
	i--;
         iSize--;
    }

    return iSize;
}
int main()
{
    int  iSize=0,iLen=0,i=0;
    printf("How many elements do you want to enter ?\n");
    scanf("%d",&iSize);
    
    int *ptr=(int *)malloc(4 * iSize);
    if(ptr==NULL)
    {
        printf("Unable to allocate memory");
        return -1;
    }
    printf("Enter %d elements\n",iSize);
    for(i=0;i<iSize;i++)
    {
        scanf("%d",&ptr[i]);
    }
    iLen=RemoveZeroes(ptr,iSize);
    printf("Array with non zeroes is \n");
    for(i=0;i<iLen;i++)
    {
        printf("%d",ptr[i]);
    }
    free(ptr);
   
  
    return 0;
}
