using System;
using Microsoft.Xna.Framework;

// Token: 0x02000746 RID: 1862
public sealed class eul : km
{
	// Token: 0x06002FC3 RID: 12227 RVA: 0x00121934 File Offset: 0x0011FB34
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		els els = A_3 as els;
		if (els != null && new Random(A_0.d() * els.GetHashCode()).NextDouble() < (double)els.Stacks * 0.15)
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
