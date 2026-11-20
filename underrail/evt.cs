using System;

// Token: 0x02000FB8 RID: 4024
public static class evt
{
	// Token: 0x06005275 RID: 21109 RVA: 0x0024DD8C File Offset: 0x0024BF8C
	public static string a(bq8 A_0)
	{
		c5x c5x = A_0.get_Item(c49.a) as c5x;
		c5x c5x2 = A_0.get_Item(c49.b) as c5x;
		if (c5x != null && !c5x.IsPlayer && c5x.h.b != null)
		{
			return c5x.h.b.aa().Id;
		}
		if (c5x2 != null && !c5x2.IsPlayer && c5x2.h.b != null)
		{
			return c5x2.h.b.aa().Id;
		}
		return null;
	}
}
