using System;
using Microsoft.Xna.Framework;

// Token: 0x0200074B RID: 1867
public sealed class d7g : km
{
	// Token: 0x06002FCD RID: 12237 RVA: 0x00121C48 File Offset: 0x0011FE48
	public override bool ib()
	{
		return true;
	}

	// Token: 0x06002FCE RID: 12238 RVA: 0x00121C50 File Offset: 0x0011FE50
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		if (A_3 != null)
		{
			Random random = new Random(A_3.GetHashCode());
			int x = A_0.d() % 8;
			int num = -40 + random.Next(80);
			int maxValue = Math.Max(10, 40 - Math.Abs(num));
			int num2 = random.Next(maxValue);
			a2f a2f = A_1.b(A_0, "Effects\\xpbl_TempDist2", new Point(x, 0), null, true);
			a2f a2f2 = A_1.b(A_0, "Effects\\xpbl_TempDist2", new Point(x, 1), null, true);
			if (a2f == null || a2f.d == null)
			{
				return;
			}
			a2f.h = new float?(0.75f);
			a2f2.h = new float?(0.75f);
			a2f.e = new Color?(Color.White);
			a2f2.e = new Color?(Color.White);
			eyc.a(a2f, A_2, 0.8);
			eyc.a(a2f2, A_2, 0.8);
			a2f.j += new Vector2((float)num, (float)num2);
			a2f2.j += new Vector2((float)num, (float)num2);
			A_2.b.a(a2f);
			A_2.b.a(a2f2);
		}
	}
}
