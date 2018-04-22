/*
	Win10 16299 SDK has incorrect definition of IExtractIcon
	when __cplusplus is not defined. IExtractIconn fixed it.
*/

typedef struct IExtractIconn IExtractIconn;
typedef struct IExtractIconnVtbl {
	HRESULT(__stdcall *QueryInterface)(
		IExtractIconn * This,
		IID const *riid,
		void **ppvObject);

	ULONG(__stdcall *AddRef)(
		IExtractIconn * This);

	ULONG(__stdcall *Release)(
		IExtractIconn * This);

	HRESULT(__stdcall *GetIconLocation)(
		IExtractIconn * This,
		UINT   uFlags,
		PTSTR  pszIconFile,
		UINT   cchMax,
		int   *piIndex,
		UINT  *pwFlags
		);

	HRESULT(__stdcall *Extract)(
		IExtractIconn * This,
		PCTSTR pszFile,
		UINT   nIconIndex,
		HICON  *phiconLarge,
		HICON  *phiconSmall,
		UINT   nIconSize
		);
} IExtractIconnVtbl;

struct IExtractIconn {
	IExtractIconnVtbl *lpVtbl;
};
