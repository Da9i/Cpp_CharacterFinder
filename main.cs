#include<iostream>
using namespace std;
int main()
{
	bool found = false;
	char array[5];
	for (int i = 0; i < 5; ++i)
	{
		cout << "ENTER A CHARACTER : ";
		cin >> array[i];
	}
	char key;
	cout << "ENTER KEY CHARACTER : ";
	cin >> key;
	for (int j = 0; j < 5; ++j)
	{
		if (array[j] == key)
		{
			cout << "THE REQUIRED KEY CHARACTER FOUND ! ! !\n";
			cout << "THE REQUIRED ADDRESS OF THE KEY IS:" << j << endl;
			cout << &array + j << endl;
			found = true;
			break;
		}
	}
	if (found == false)
		cout << "KEY CHARACTER NOT FOUND ! ! !";
		system("pause>0");
}
