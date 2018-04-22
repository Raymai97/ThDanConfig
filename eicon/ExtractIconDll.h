#pragma once
#include <windows.h>

EXTERN_C
HRESULT __stdcall
ExtractIconDll_ExtractOne(
	LPCTSTR pszPath,
	int icoIndex,
	UINT icoSize,
	HICON *phIco
);
