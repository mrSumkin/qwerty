using System;
using Microsoft.Xna.Framework;

// Token: 0x02000758 RID: 1880
public sealed class dhc : km
{
	// Token: 0x06002FE9 RID: 12265 RVA: 0x00122B58 File Offset: 0x00120D58
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		int num = A_0.d() % 5;
		int x = (num == 0) ? 4 : (num - 1);
		a2f a2f = A_1.b(A_0, "Effects\\Dazed", new Point(num, 0), null, true);
		if (a2f != null && a2f.d != null)
		{
			a2f.j = new Vector2(-3f, -10f);
			a2f.h = new float?(0.7f);
			A_2.b.a(a2f);
			eyc.a(a2f, A_2, 1.0);
			a2f a2f2 = A_1.b(A_0, "Effects\\Dazed", new Point(x, 0), null, true);
			a2f2.h = new float?(0.4f);
			a2f2.j = a2f.j;
			A_2.b.a(a2f2);
		}
	}
}
