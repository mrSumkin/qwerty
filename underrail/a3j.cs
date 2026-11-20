using System;
using Microsoft.Xna.Framework;

// Token: 0x02000756 RID: 1878
public sealed class a3j : km
{
	// Token: 0x06002FE5 RID: 12261 RVA: 0x00122900 File Offset: 0x00120B00
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		int x = A_0.d() % 8;
		a2f a2f = A_1.b(A_0, "Effects\\Immobilize1", new Point(x, 0), null, true);
		if (a2f != null && a2f.d != null)
		{
			a2f.j = new Vector2(0f, -10f);
			a2f.h = new float?(0.75f);
			Random random = new Random(A_0.d() + A_3.GetHashCode());
			a2f.j += new Vector2((float)(-3 + random.Next(6)), (float)(-3 + random.Next(6)));
			eyc.a(a2f, A_2, 0.1);
			a2f a2f2 = a2f.f5();
			random = new Random(A_0.d() - 1 + A_3.GetHashCode());
			a2f2.j += new Vector2((float)(-3 + random.Next(6)), (float)(-3 + random.Next(6)));
			a2f2.h = new float?(0.35f);
			A_2.b.a(a2f);
			A_2.b.a(a2f2);
		}
	}
}
