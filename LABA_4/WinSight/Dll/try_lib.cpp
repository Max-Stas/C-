#include "try_lib.h"

void Message(const char *str)
{
    std::cout << str;
}

void LMessage(const char *str)
{
    std::cout << str << std::endl;
}

int InputInt() 
{
    int x;
    std::cin >> x;
    return x;
}

int Add(int x, int y)
{
    return x + y;
}

void Swap(int *x, int *y)
{
    *x ^= *y;
    *y ^= *x;
    *x ^= *y;
}
int Max(int x, int y)
{
    return x ^ ((x ^ y) & - (x <y));
}
int Min(int x, int y)
{
    return y ^ ((x ^ y) & - (x < y));
}

