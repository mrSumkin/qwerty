using System;
using System.Collections.Generic;

// Token: 0x02000FF9 RID: 4089
public static class dc2
{
	// Token: 0x06005421 RID: 21537 RVA: 0x00253FE8 File Offset: 0x002521E8
	public static bool a(string A_0, int A_1)
	{
		DateTime d;
		return string.IsNullOrEmpty(A_0) || !dc2.a.TryGetValue(A_0, out d) || (DateTime.Now - d).TotalMilliseconds >= (double)A_1;
	}

	// Token: 0x06005422 RID: 21538 RVA: 0x00254030 File Offset: 0x00252230
	public static void a(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			dc2.a[A_0] = DateTime.Now;
		}
	}

	// Token: 0x06005423 RID: 21539 RVA: 0x00254050 File Offset: 0x00252250
	public static void b(ca4 A_0)
	{
		dc2.a(A_0.b);
	}

	// Token: 0x06005424 RID: 21540 RVA: 0x00254060 File Offset: 0x00252260
	public static bool a(ca4 A_0)
	{
		return dc2.a(A_0.b, A_0.c);
	}

	// Token: 0x0400225E RID: 8798
	private static Dictionary<string, DateTime> a = new Dictionary<string, DateTime>();
}
