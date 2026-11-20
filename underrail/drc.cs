using System;
using Microsoft.Xna.Framework;

// Token: 0x02000752 RID: 1874
public sealed class drc : km
{
	// Token: 0x06002FDC RID: 12252 RVA: 0x00122414 File Offset: 0x00120614
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		int x = A_0.d() % 7;
		a2f a2f = A_1.b(A_0, "Effects\\ChargeShield", new Point(x, 0), null, true);
		if (a2f != null && a2f.d != null)
		{
			a2f.h = new float?(0.85f);
			A_2.b.a(a2f);
			eyc.a(a2f, A_2, 1.0);
		}
	}
}
