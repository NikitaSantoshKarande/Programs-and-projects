// 5. Accept number of rows and number of columns from user and display
// below pattern.
// Input : iRow = 4 iCol = 4
// Output :
//  1 2 3 4
//  2 3 4 5
//  3 4 5 6
//  4 5 6 7
#include<stdio.h>
int no = 1;
int main()
{
    int No1 = 0, No2 = 0, i = 0, j = 0;
    printf("Enter the rows:");
    scanf("%d", &No1);

    printf("Enter the coloumn:");
    scanf("%d", &No2);

    for (i = 1; i <= No1; i++)
    {
        for (j = 1; j <= No2; j++)
        {
            printf("%d ", no);
            no++;
        }
        no=i+1;
        printf("\n");
    }
    return 0;
}