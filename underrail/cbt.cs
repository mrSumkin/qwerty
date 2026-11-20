using System;
using System.Collections.Generic;

// Token: 0x020001B3 RID: 435
public sealed class cbt : IComparer<ak1>
{
	// Token: 0x06000C71 RID: 3185 RVA: 0x00032EA4 File Offset: 0x000310A4
	public static cbt a()
	{
		if (cbt.a == null)
		{
			cbt.a = new cbt();
		}
		return cbt.a;
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x00032EC4 File Offset: 0x000310C4
	public int Compare(ak1 x, ak1 y)
	{
		int num = x.Location.X + x.Location.Y;
		int num2 = y.Location.X + y.Location.Y;
		if (num != num2)
		{
			return num.CompareTo(num2);
		}
		if (x.Location.X != y.Location.X)
		{
			return x.Location.X.CompareTo(y.Location.X);
		}
		return -1;
	}

	// Token: 0x0400075A RID: 1882
	private static cbt a;
}
