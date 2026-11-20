using System;
using Microsoft.Xna.Framework;

// Token: 0x0200075A RID: 1882
public sealed class ahe : km
{
	// Token: 0x06002FED RID: 12269 RVA: 0x00122CFC File Offset: 0x00120EFC
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = A_1.b(A_0, "Effects\\Rage", new Point(0, 0), null, true);
		a2f a2f2 = A_1.b(A_0, "Effects\\Rage", new Point(1, 0), null, true);
		if (a2f != null && a2f.d != null)
		{
			a2f.j = new Vector2(-30f, -5f);
			a2f.h = new float?(0.85f);
			a2f2.j = new Vector2(-30f, -5f);
			a2f2.h = new float?(0.5f);
			Random random = new Random(A_0.d() + A_3.GetHashCode());
			a2f.j += new Vector2((float)(-3 + random.Next(6)), (float)(-3 + random.Next(6)));
			eyc.a(a2f, A_2, 1.0);
			a2f2.j = a2f.j;
			a2f a2f3 = a2f.f5();
			a2f a2f4 = a2f2.f5();
			random = new Random(A_0.d() - 1 + A_3.GetHashCode());
			a2f3.j += new Vector2((float)(-3 + random.Next(6)), (float)(-3 + random.Next(6)));
			a2f4.j = a2f3.j;
			a2f3.h = new float?(0.35f);
			a2f4.h = new float?(0.2f);
			A_2.b.a(a2f);
			A_2.b.a(a2f2);
			A_2.b.a(a2f3);
			A_2.b.a(a2f4);
		}
	}
}
