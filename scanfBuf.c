#include <stdio.h>

int main()
{
	char string[20];
	char c;
	
	printf("���ڿ� �Է� : ");
	scanf("%s", string);
	printf("���� �Է� : "); 
	scanf("%c", &c);
	
	print("%s\n", string);
	printf("!!%c!!\n", c);
	
	return 0;
}
