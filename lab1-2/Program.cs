int x = -7, y = -2;
int checkX = -4;
int checkY = -1;

bool popadaet = false;
if (checkX <= 0 && checkY <= 0)
{
	if (checkX >= x && checkY >= y)
	{
		popadaet = true;
	}
}

Console.WriteLine(popadaet);
