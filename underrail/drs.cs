using System;
using Microsoft.Xna.Framework;

// Token: 0x02000734 RID: 1844
public sealed class drs : km
{
	// Token: 0x06002F9B RID: 12187 RVA: 0x0012029C File Offset: 0x0011E49C
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		Random random = new Random((A_3 != null) ? A_3.GetHashCode() : 0);
		for (int i = 0; i < 2; i++)
		{
			int num = (A_0.d() + i * 2 + random.Next(10)) % 3;
			if (num < 3)
			{
				a2f a2f = A_1.b(A_0, "Effects\\EmpBlast", new Point(num + 5, 0), null, true);
				if (a2f != null && a2f.d != null)
				{
					a2f.s = true;
					a2f.h = new float?(0.2f - 0.1f * (float)i);
					a2f.w = true;
					A_2.b.a(a2f);
					eyc.a(a2f, A_2, 0.15000000596046448);
				}
			}
		}
	}
}
