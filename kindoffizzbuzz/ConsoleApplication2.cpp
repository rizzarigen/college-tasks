
#include <iostream>
#include <cmath>
using namespace std;

int l;
int s;

int main()
{
	int k;
	int n;


	cin >> k >> n;

	if (k <= 1000 && k >= 1) {
		if (n <= pow(10, 6) && n >= 1) {

			int *nums = new int[n];

			for (int i = 0; i < n; i++) {

				cin >> nums[i];

				if (nums[i] % 3 == 0) {
					s += 1;
				}
				if (nums[i] % 5 == 0) {
					l += 1;
				}

			}

			if (s == l) {
				cout << "Draw" << endl;
			}
			else if (s > l) {
				cout << "Sasha" << endl;
			}
			else {
				cout << "Lena" << endl;
			}

		}
	}
}