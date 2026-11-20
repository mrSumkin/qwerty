using System;
using Microsoft.Xna.Framework;

// Token: 0x02000735 RID: 1845
public sealed class b56 : km
{
	// Token: 0x06002F9D RID: 12189 RVA: 0x0012036C File Offset: 0x0011E56C
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = A_1.b(A_0, "Effects\\HeadCage", new Point(0, 0), null, true);
		if (a2f != null && a2f.d != null)
		{
			a2f.h = new float?(0.75f);
			Random random = new Random(A_0.d() + A_3.GetHashCode());
			a2f.j += new Vector2((float)(-3 + random.Next(6)), (float)(-3 + random.Next(6)));
			eyc.a(a2f, A_2, 0.4);
			a2f a2f2 = a2f.f5();
			random = new Random(A_0.d() - 1 + A_3.GetHashCode());
			a2f2.j += new Vector2((float)(-3 + random.Next(6)), (float)(-3 + random.Next(6)));
			a2f2.h = new float?(0.35f);
			A_2.b.a(a2f);
			A_2.b.a(a2f2);
		}
	}
}
