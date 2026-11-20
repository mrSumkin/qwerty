using System;
using Microsoft.Xna.Framework;

// Token: 0x02000733 RID: 1843
public sealed class bvp : km
{
	// Token: 0x06002F99 RID: 12185 RVA: 0x001201E4 File Offset: 0x0011E3E4
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		int num = 0;
		els els = A_3 as els;
		if (els != null)
		{
			num = els.Stacks;
		}
		int x = A_0.d() % 12;
		a2f a2f = A_1.b(A_0, "Effects\\StarGlitterStatus", new Point(x, 0), null, true);
		if (a2f != null && a2f.d != null)
		{
			a2f a2f2 = a2f;
			a2f2.j.Y = a2f2.j.Y - 50f;
			a2f.f = 0.8f;
			a2f.h = new float?(0.5f + 0.1f * (float)num);
			A_2.b.a(a2f);
			eyc.a(a2f, A_2, 1.0);
		}
	}
}
