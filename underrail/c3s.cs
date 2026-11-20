using System;

// Token: 0x0200071F RID: 1823
public static class c3s
{
	// Token: 0x06002F63 RID: 12131 RVA: 0x0011F11C File Offset: 0x0011D31C
	public static dm6 a(c5x A_0)
	{
		if ((A_0.s.b == null || !A_0.s.b.j) && (A_0.h.b == null || A_0.h.b.aa().Dead || A_0.h.b.aa().Ethereal))
		{
			if (A_0.o.b is a9g)
			{
				float? num = A_0.o.b.d;
				float num2 = 0f;
				if (!(num.GetValueOrDefault() == num2 & num != null))
				{
					num = A_0.ae;
					num2 = 0f;
					if (!(num.GetValueOrDefault() == num2 & num != null))
					{
						return dm6.c;
					}
				}
			}
			return dm6.a;
		}
		if (A_0.h.b == null && pp.a != null && pp.a.aku() && dz6.e())
		{
			return dm6.a;
		}
		return dm6.b;
	}
}
