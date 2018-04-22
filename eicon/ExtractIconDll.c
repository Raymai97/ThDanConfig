#include "ExtractIconDll.h"
#include <ShlObj.h>
#include <shellapi.h>
#include "ExtractIconDll_EXTEND.h"

#define MY_CheckHrAndAssert(x) \
	if (FAILED(hr)) goto eof; \
	if (!(x)) { hr = E_UNEXPECTED; goto eof; }

#define MY_SafeFree(p, fn) \
	if (p) { fn(p); (p) = NULL; }

#define MY_SafeFreeCOM(p) \
	if (p) { (p)->lpVtbl->Release(p); (p) = NULL; }


static HRESULT MyExtractOne(
	LPCTSTR pszPath,
	int icoIndex,
	UINT icoSize,
	HICON *phIco)
{
	HRESULT hr = 0;
	BOOL coinit = FALSE;
	IShellLink *pSL = NULL;
	LPITEMIDLIST pidl = NULL;
	IShellFolder *pSF = NULL;
	IExtractIconn *pEI = NULL;
	HICON hIcoL = NULL, hIcoS = NULL;

	hr = CoInitialize(NULL);
	if (FAILED(hr)) goto eof;
	coinit = TRUE;

	hr = CoCreateInstance(&CLSID_ShellLink, NULL, CLSCTX_INPROC_SERVER,
		&IID_IShellLink, (void**)&pSL);
	MY_CheckHrAndAssert(pSL);

	hr = pSL->lpVtbl->SetPath(pSL, pszPath);
	if (FAILED(hr)) goto eof;
	hr = pSL->lpVtbl->GetIDList(pSL, &pidl);
	if (FAILED(hr)) goto eof;

	hr = CoCreateInstance(&CLSID_ShellDesktop, NULL, CLSCTX_INPROC_SERVER,
		&IID_IShellFolder, (void**)&pSF);
	MY_CheckHrAndAssert(pSF);

	hr = pSF->lpVtbl->GetUIObjectOf(pSF, NULL, 1, (LPCITEMIDLIST*)&pidl,
		&IID_IExtractIcon, NULL, (void**)&pEI);
	MY_CheckHrAndAssert(pEI);

	hr = pEI->lpVtbl->Extract(pEI, pszPath, icoIndex,
		&hIcoL, &hIcoS, icoSize);
	if (hr == S_FALSE) {
		hr = HRESULT_FROM_WIN32(ERROR_NOT_FOUND); goto eof;
	}
	*phIco = hIcoL;
eof:
	MY_SafeFree(hIcoS, DeleteObject);
	MY_SafeFreeCOM(pEI);
	MY_SafeFreeCOM(pSF);
	MY_SafeFree(pidl, CoTaskMemFree);
	MY_SafeFreeCOM(pSL);
	if (coinit) { CoUninitialize(); }
	return hr;
}

EXTERN_C
BOOL APIENTRY
DllMain(
	HINSTANCE hinstDLL,
	DWORD fdwReason,
	LPVOID lpvReserved)
{
	hinstDLL; fdwReason; lpvReserved;
	return TRUE;
}

EXTERN_C
HRESULT __stdcall
ExtractIconDll_ExtractOne(
	LPCTSTR pszPath,
	int icoIndex,
	UINT icoSize,
	HICON *phIco)
{
	HRESULT hr = 0;
	BOOL coinit = FALSE;
	HICON hIco = NULL;
	hr = CoInitialize(NULL);
	if (FAILED(hr)) goto eof;
	coinit = TRUE;
	hr = MyExtractOne(pszPath, icoIndex, icoSize, &hIco);
	if (FAILED(hr)) goto eof;
	*phIco = hIco;
eof:
	if (coinit) { CoUninitialize(); }
	return hr;
}
