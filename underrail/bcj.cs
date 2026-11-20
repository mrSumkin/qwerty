using System;
using System.Collections.Generic;

// Token: 0x020000A4 RID: 164
public class bcj
{
	// Token: 0x060003B2 RID: 946 RVA: 0x00011C08 File Offset: 0x0000FE08
	public static long a(IEnumerable<byte> A_0)
	{
		long num = 0L;
		if (A_0 != null)
		{
			foreach (byte a_ in A_0)
			{
				bcj.c(a_);
				long num2 = bcj.a(a_);
				num |= num2;
			}
		}
		return num;
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00011C6C File Offset: 0x0000FE6C
	public static long a(params byte[] A_0)
	{
		return bcj.a(A_0);
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00011C74 File Offset: 0x0000FE74
	public static long a(IEnumerable<long> A_0)
	{
		long num = 0L;
		foreach (long num2 in A_0)
		{
			num |= num2;
		}
		return num;
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00011CC8 File Offset: 0x0000FEC8
	public static long a(params long[] A_0)
	{
		return bcj.a(A_0);
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x00011CD0 File Offset: 0x0000FED0
	public static bool a(long A_0, byte A_1)
	{
		bcj.c(A_1);
		long num = bcj.a(A_1);
		return (A_0 & num) == num;
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00011CF0 File Offset: 0x0000FEF0
	public static bool b(long A_0, long A_1)
	{
		return (A_0 & A_1) == A_1;
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x00011CF8 File Offset: 0x0000FEF8
	public static bool a(long A_0, long A_1)
	{
		return (A_0 & A_1) != 0L;
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00011D04 File Offset: 0x0000FF04
	public static void c(byte A_0)
	{
		if (A_0 > 64)
		{
			throw new ArgumentOutOfRangeException("Code must be a value between 0 and " + 64.ToString() + ".");
		}
	}

	// Token: 0x060003BA RID: 954 RVA: 0x00011D38 File Offset: 0x0000FF38
	public static bool b(byte A_0)
	{
		return A_0 <= 64;
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00011D44 File Offset: 0x0000FF44
	private static long a(byte A_0)
	{
		return (long)Math.Pow(2.0, (double)A_0);
	}

	// Token: 0x0400041F RID: 1055
	public const byte a = 64;
}
