namespace System.Management
{
	internal enum tag_WBEM_COMPARISON_FLAG
	{
		WBEM_COMPARISON_INCLUDE_ALL = 0,
		WBEM_FLAG_IGNORE_QUALIFIERS = 1,
		WBEM_FLAG_IGNORE_OBJECT_SOURCE = 2,
		WBEM_FLAG_IGNORE_DEFAULT_VALUES = 4,
		WBEM_FLAG_IGNORE_CLASS = 8,
		WBEM_FLAG_IGNORE_CASE = 16,
		WBEM_FLAG_IGNORE_FLAVOR = 32
	}
}