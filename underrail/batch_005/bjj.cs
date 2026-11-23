using System;
using Microsoft.Xna.Framework;

// Token: 0x02000737 RID: 1847
public sealed class bjj : km
{
	// Token: 0x06002FA1 RID: 12193 RVA: 0x001205E8 File Offset: 0x0011E7E8
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		Random random = new Random(A_0.d() / 3 + ((A_3 != null) ? A_3.GetHashCode() : 0));
		for (int i = 0; i < 3; i++)
		{
			int num = (A_0.d() + random.Next(10)) % 5 * 3;
			if (num < 6)
			{
				a2f a2f = A_1.b(A_0, "Effects\\MetallicSpark", new Point(num, 0), null, true);
				if (a2f != null && a2f.d != null)
				{
					a2f.j += new Vector2((float)(-10 + random.Next(20)), (float)(-15 + random.Next(30)));
					a2f.s = true;
					a2f.e = new Color?(new Color(110, 255, 255));
					a2f.h = new float?(0.25f);
					a2f.w = true;
					A_2.b.a(a2f);
					eyc.a(a2f, A_2, (double)(i + 1) * 0.2);
				}
			}
		}
	}
}
