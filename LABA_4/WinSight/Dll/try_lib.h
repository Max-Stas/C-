#ifndef TRY_LIB_H
#define TRY_LIB_H

#include <string>
#include <iostream>
#include <cstring>
#include <cstdlib>
#include <cstdio>
#include <array>

#ifdef __cplusplus
    extern "C" {
#endif

#ifdef TRY 
    #define TRY_LIB __declspec(dllexport)
#else 
    #define TRY_LIB __declspec(dllimport)
#endif

void TRY_LIB Message(const char *str);
void TRY_LIB LMessage(const char *str);
int TRY_LIB InputInt();
int TRY_LIB Add(int x, int y);
void TRY_LIB Swap(int *x, int *y);
int TRY_LIB Max(int x, int y);
int TRY_LIB Min(int x, int y);

#ifdef __cplusplus
    }
#endif

#endif