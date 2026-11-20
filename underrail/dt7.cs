using System;
using Microsoft.Xna.Framework;

// Token: 0x0200074F RID: 1871
public sealed class dt7 : km
{
	// Token: 0x06002FD6 RID: 12246 RVA: 0x00122224 File Offset: 0x00120424
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		els els = A_3 as els;
		if (els != null && new Random(A_0.d() * els.GetHashCode()).NextDouble() < (double)els.Stacks * 0.05)
		{
			int num = new Random(A_0.d() * els.GetHashCode()).Next() % 5;
			a2f a2f = A_1.b(A_0, "Effects\\StaticElectricity", new Point(num, 0), null, true);
			if (a2f != null && a2f.d != null)
			{
				a2f.h = new float?(0.5f);
				if (num % 2 == 0)
				{
					A_2.b.a(a2f);
					return;
				}
				A_2.b.a(0, a2f);
			}
		}
	}
}
