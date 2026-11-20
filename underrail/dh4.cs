using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x020000D2 RID: 210
public static class dh4
{
	// Token: 0x06000494 RID: 1172 RVA: 0x00014934 File Offset: 0x00012B34
	public static byte[] a()
	{
		return dh4.c(dh4.c);
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00014944 File Offset: 0x00012B44
	public static byte[] c(long A_0)
	{
		dh4.b.EnterWriteLock();
		byte[] result;
		try
		{
			long num = dh4.b(A_0);
			List<byte[]> list;
			dh4.a.TryGetValue(num, out list);
			if (list != null && list.Count > 0)
			{
				byte[] array = list[list.Count - 1];
				list.RemoveAt(list.Count - 1);
				result = array;
			}
			else
			{
				result = new byte[num];
			}
		}
		finally
		{
			dh4.b.ExitWriteLock();
		}
		return result;
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x000149D0 File Offset: 0x00012BD0
	public static void a(byte[] A_0)
	{
		dh4.b.EnterWriteLock();
		try
		{
			long key = dh4.a((long)A_0.Length);
			List<byte[]> list;
			dh4.a.TryGetValue(key, out list);
			if (list == null)
			{
				list = new List<byte[]>();
				dh4.a[key] = list;
			}
			list.Add(A_0);
		}
		finally
		{
			dh4.b.ExitWriteLock();
		}
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00014A40 File Offset: 0x00012C40
	private static long b(long A_0)
	{
		double num = Math.Log((double)A_0, 2.0);
		return (long)Math.Pow(2.0, (double)((int)Math.Ceiling(num)));
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00014A78 File Offset: 0x00012C78
	private static long a(long A_0)
	{
		double d = Math.Log((double)A_0, 2.0);
		return (long)Math.Pow(2.0, (double)((int)Math.Floor(d)));
	}

	// Token: 0x0400044D RID: 1101
	private static Dictionary<long, List<byte[]>> a = new Dictionary<long, List<byte[]>>();

	// Token: 0x0400044E RID: 1102
	private static ReaderWriterLockSlim b = new ReaderWriterLockSlim();

	// Token: 0x0400044F RID: 1103
	private static readonly long c = 20971520L;
}
