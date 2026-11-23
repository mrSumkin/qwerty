using System;
using Microsoft.Xna.Framework;

// Token: 0x02000761 RID: 1889
public sealed class cyl : km
{
	// Token: 0x06002FFC RID: 12284 RVA: 0x00123314 File Offset: 0x00121514
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = A_1.b(A_0, "Effects\\Fear", new Point(0, 0), null, true);
		if (a2f != null && a2f.d != null)
		{
			a2f.j = new Vector2(-36f, -10f);
			a2f.h = new float?(0.85f);
			Random random = new Random(A_0.d() + A_3.GetHashCode());
			eyc.a(a2f, A_2, 1.0);
			a2f.j += new Vector2((float)(-3 + random.Next(6)), (float)(-3 + random.Next(6)));
			a2f a2f2 = a2f.f5();
			random = new Random(A_0.d() - 1 + A_3.GetHashCode());
			a2f2.j += new Vector2((float)(-3 + random.Next(6)), (float)(-3 + random.Next(6)));
			a2f2.h = new float?(0.35f);
			A_2.b.a(a2f);
			A_2.b.a(a2f2);
		}
	}
}
