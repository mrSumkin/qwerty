using System;
using Microsoft.Xna.Framework;

// Token: 0x02000763 RID: 1891
public sealed class by5 : km
{
	// Token: 0x06003000 RID: 12288 RVA: 0x001234F8 File Offset: 0x001216F8
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		int num = A_0.d() % 9;
		int x = (num == 0) ? 8 : (num - 1);
		a2f a2f = A_1.b(A_0, "Effects\\BigSparkles", new Point(num, 0), null, true);
		if (a2f != null && a2f.d != null)
		{
			a2f.h = new float?(0.7f);
			a2f.e = new Color?(Color.Yellow);
			a2f.j.Y = 0f;
			A_2.b.a(a2f);
			eyc.a(a2f, A_2, 1.0);
			a2f a2f2 = A_1.b(A_0, "Effects\\BigSparkles", new Point(x, 0), null, true);
			a2f2.h = new float?(0.4f);
			a2f.e = new Color?(Color.Yellow);
			a2f2.j = a2f.j;
			A_2.b.a(a2f2);
		}
	}
}
