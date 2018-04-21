#include "ExtractIconDll.h"
#include <ShlObj.h>
#include <commoncontrols.h>

#ifndef UNICODE
#define A_W(apiName)	apiName "A"
#else
#define A_W(apiName)	apiName "W"
#endif

static HRESULT My_SHGetFileInfo(
	LPCTSTR pszPath, DWORD dwFileAttr,
	SHFILEINFO *pFI, UINT cbFI, UINT uFlags,
	DWORD_PTR *pRet)
{
	typedef DWORD_PTR(WINAPI *fn_t)(LPCTSTR, DWORD, SHFILEINFO*, UINT, UINT);
	fn_t fn = (fn_t)GetProcAddress(LoadLibraryA("shell32"),
		A_W("SHGetFileInfo"));
	if (fn) {
		DWORD_PTR ret = fn(pszPath, dwFileAttr, pFI, cbFI, uFlags);
		*pRet = ret;
		return ret ? S_OK : E_FAIL;
	}
	return E_NOTIMPL;
}

static HRESULT My_SHGetImageList(
	int shil, IID const *pIID, void **ppIL)
{
	typedef HRESULT(WINAPI *fn_t)(int, IID const*, void**);
	fn_t fn = (fn_t)GetProcAddress(LoadLibraryA("shell32"),
		"SHGetImageList");
	if (fn) {
		return fn(shil, pIID, ppIL);
	}
	return E_NOTIMPL;
}

static HRESULT MyShGetImageListIcon(
	int iIco, int shil, HICON *phIcon)
{
	HRESULT hr = 0;
	IImageList *pIL = NULL;
	HICON hIco = NULL;
	hr = My_SHGetImageList(shil, &IID_IImageList, (void**)&pIL);
	if (FAILED(hr)) goto eof;
	if (!pIL) {
		hr = E_UNEXPECTED; goto eof;
	}
	hr = pIL->lpVtbl->GetIcon(pIL, iIco, ILD_TRANSPARENT, &hIco);
	if (FAILED(hr)) goto eof;
	if (!hIco) {
		hr = E_UNEXPECTED; goto eof;
	}
	*phIcon = hIco;
eof:
	if (pIL) { pIL->lpVtbl->Release(pIL); }
	return hr;
}

static HRESULT MyShGetIconSysIndex(
	LPCTSTR pszPath, int *pico)
{
	HRESULT hr = 0;
	SHFILEINFO fi = { 0 };
	DWORD_PTR gfi = 0;
	hr = My_SHGetFileInfo(pszPath, 0, &fi, sizeof(fi),
		SHGFI_SYSICONINDEX, &gfi);
	if (SUCCEEDED(hr)) {
		*pico = fi.iIcon;
	}
	return hr;
}

static HRESULT MyShGetFileIcon(
	LPCTSTR pszPath, BOOL wantLarge, HICON *phIcon)
{
	HRESULT hr = 0;
	SHFILEINFO fi = { 0 };
	DWORD_PTR gfi = 0;
	hr = My_SHGetFileInfo(pszPath, 0, &fi, sizeof(fi),
		(wantLarge ? SHGFI_LARGEICON : SHGFI_SMALLICON) |
		SHGFI_ICON, &gfi);
	if (FAILED(hr)) goto eof;
	*phIcon = fi.hIcon;
eof:
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
GetIconOfFile(
	LPCTSTR pszPath,
	UINT desiredSize,
	HICON *phIcon)
{
	HRESULT hr = 0;
	BOOL coinit = FALSE;
	HICON hIcon = NULL;
	int iIco = 0;

	hr = CoInitialize(NULL);
	if (FAILED(hr)) goto eof;
	coinit = TRUE;

	switch (desiredSize)
	{
	case 256:
	case 48:
		hr = MyShGetIconSysIndex(pszPath, &iIco);
		if (FAILED(hr)) goto eof;
		hr = MyShGetImageListIcon(iIco,
			desiredSize == 256 ? SHIL_JUMBO : SHIL_EXTRALARGE,
			&hIcon);
		break;
	case 32:
	case 16:
		hr = MyShGetFileIcon(pszPath,
			desiredSize == 32,
			&hIcon);
		break;
	default:
		hr = E_NOTIMPL;
	}
	if (FAILED(hr)) goto eof;
	*phIcon = hIcon;
eof:
	if (coinit) { CoUninitialize(); }
	return hr;
}


