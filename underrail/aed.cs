using System;
using Microsoft.Xna.Framework;

// Token: 0x02000768 RID: 1896
public sealed class aed : km
{
	// Token: 0x0600300B RID: 12299 RVA: 0x00123AC0 File Offset: 0x00121CC0
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		int num = A_0.d() % 5;
		int x = (num == 0) ? 4 : (num - 1);
		a2f a2f = A_1.b(A_0, "Effects\\Stunned", new Point(num, 0), null, true);
		if (a2f != null && a2f.d != null)
		{
			a2f.j = new Vector2(-3f, -10f);
			a2f.h = new float?(0.7f);
			A_2.b.a(a2f);
			eyc.a(a2f, A_2, 1.0);
			a2f a2f2 = A_1.b(A_0, "Effects\\Stunned", new Point(x, 0), null, true);
			a2f2.h = new float?(0.4f);
			a2f2.j = a2f.j;
			A_2.b.a(a2f2);
		}
	}
}
