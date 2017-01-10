#include <stdio.h>
#include <time.h>
#include <stdlib.h>

int changeColorTap(int n){
	int tapBackColor[][3] = {{0x17, 0x17, 0x17}, 
							 {0x3B, 0x6D, 0xFE}, 
							 {0x38, 0xFF, 0x6B},
							 {0xFF, 0x84, 0},
							 {0xF7, 0x81, 0xBE},
							 {0xF3, 0xF7, 0x81}};
	printf("%d\n", tapBackColor[n][0]);
	printf("%d\n", tapBackColor[n][1]);
	printf("%d\n", tapBackColor[n][2]);
	return 0;

}

int changeColorPress(int n){
	char setAllColor[][7] = { "Black", "Blue", "Green", "Orange", "Pink", "Yellow", "Purple" };
	printf("%s\n", setAllColor[n]);
}

int main(){
	int number, cases, min, max;
	scanf("%d", &cases);
	if (cases == 1 || cases == 2)
	{
		scanf("%d", &number);
		changeColorPress(number);
	}
	else if (cases == 3)
	{
		scanf("%d", &number);
		changeColorTap(number);
	}
	
	
	
}





