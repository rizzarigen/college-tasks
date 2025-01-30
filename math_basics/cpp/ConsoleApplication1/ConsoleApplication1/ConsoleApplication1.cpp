
#define _USE_MATH_DEFINES

#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    int x;
    int y;

    cin >> x ; 
    
    cin >> y;



    double f = (((M_PI / 3) + log(x ^ 3)) / (3 * y - x)) + (x * sin(y ^ 2));

    double i = f;
    double j = floor(f);

    cout << i << endl;
    cout << j << endl;

}

