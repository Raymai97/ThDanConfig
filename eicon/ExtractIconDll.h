#pragma once
#include <windows.h>

EXTERN_C
HRESULT __stdcall
GetIconOfFile(
	LPCTSTR pszPath,
	UINT desiredSize,
	HICON *phIcon
);
