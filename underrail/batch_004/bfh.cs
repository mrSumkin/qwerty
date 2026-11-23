using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

// Token: 0x020000CA RID: 202
public static class bfh
{
	// Token: 0x06000475 RID: 1141 RVA: 0x000144A0 File Offset: 0x000126A0
	public static bool a(this IDictionary A_0, object A_1, object A_2, ReaderWriterLock A_3, int A_4)
	{
		bool result = false;
		if (A_3 != null)
		{
			A_3.AcquireWriterLock(A_4);
		}
		try
		{
			if (!A_0.Contains(A_1))
			{
				result = true;
			}
			A_0[A_1] = A_2;
		}
		finally
		{
			if (A_3 != null)
			{
				A_3.ReleaseWriterLock();
			}
		}
		return result;
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x000144F8 File Offset: 0x000126F8
	public static bool a(this IDictionary A_0, object A_1, object A_2, ReaderWriterLock A_3)
	{
		return A_0.a(A_1, A_2, A_3, -1);
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x00014504 File Offset: 0x00012704
	public static T SafeGet<T>(this IDictionary dictionary, object key, ReaderWriterLock rwLock, int timeout)
	{
		if (rwLock != null)
		{
			rwLock.AcquireReaderLock(timeout);
		}
		T result;
		try
		{
			if (dictionary.Contains(key))
			{
				if (dictionary[key] is T)
				{
					result = (T)((object)dictionary[key]);
				}
				else
				{
					result = default(T);
				}
			}
			else
			{
				result = default(T);
			}
		}
		finally
		{
			if (rwLock != null)
			{
				rwLock.ReleaseReaderLock();
			}
		}
		return result;
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x0001458C File Offset: 0x0001278C
	public static T SafeGet<T>(this IDictionary dictionary, object key, ReaderWriterLock rwLock = null)
	{
		return dictionary.SafeGet(key, rwLock, -1);
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00014598 File Offset: 0x00012798
	public static object a(this IDictionary A_0, object A_1, ReaderWriterLock A_2, int A_3)
	{
		if (A_2 != null)
		{
			A_2.AcquireWriterLock(A_3);
		}
		object result;
		try
		{
			if (A_0.Contains(A_1))
			{
				object obj = A_0[A_1];
				A_0.Remove(A_1);
				result = obj;
			}
			else
			{
				result = null;
			}
		}
		finally
		{
			if (A_2 != null)
			{
				A_2.ReleaseWriterLock();
			}
		}
		return result;
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x000145F8 File Offset: 0x000127F8
	public static T SafeRemove<T>(this IDictionary dictionary, object key, ReaderWriterLock rwLock, int timeout)
	{
		return (T)((object)dictionary.a(key, rwLock, timeout));
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x00014608 File Offset: 0x00012808
	public static object a(this IDictionary A_0, object A_1, ReaderWriterLock A_2)
	{
		return A_0.a(A_1, A_2, -1);
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x00014614 File Offset: 0x00012814
	public static T SafeRemove<T>(this IDictionary dictionary, object key, ReaderWriterLock rwLock)
	{
		return dictionary.SafeRemove(key, rwLock, -1);
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00014624 File Offset: 0x00012824
	public static bool QuickGet<T>(this Dictionary<string, object> dict, string key, out T val)
	{
		czh.a(dict, "dict");
		czh.a(key, "key");
		object obj;
		if (dict.TryGetValue(key, out obj) && obj is T)
		{
			val = (T)((object)obj);
			return true;
		}
		val = default(T);
		return false;
	}
}
