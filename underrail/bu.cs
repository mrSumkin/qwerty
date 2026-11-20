using System;
using Microsoft.Xna.Framework;

// Token: 0x02000760 RID: 1888
public sealed class bu : km
{
	// Token: 0x06002FFA RID: 12282 RVA: 0x00123240 File Offset: 0x00121440
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		int x = A_0.d() % 3;
		a2f a2f = A_1.b(A_0, "Effects\\Pulsating", new Point(x, 0), null, true);
		if (a2f != null && a2f.d != null)
		{
			a2f.s = true;
			a2f.h = new float?(0.2f);
			A_2.b.a(0, a2f);
			a2f = A_1.b(A_0, "Effects\\Pulsating", new Point(x, 1), null, true);
			a2f.h = new float?(0.15f);
			A_2.b.a(1, a2f);
			a2f = A_1.b(A_0, "Effects\\Pulsating", new Point(x, 2), null, true);
			a2f.h = new float?(0.1f);
			A_2.b.a(2, a2f);
		}
	}
}
