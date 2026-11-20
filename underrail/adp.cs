using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02000744 RID: 1860
public sealed class adp : km
{
	// Token: 0x06002FBF RID: 12223 RVA: 0x0012153C File Offset: 0x0011F73C
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		els els = A_3 as els;
		if (els != null)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < 8; i++)
			{
				list.Add((new Random(els.GetHashCode() + i).Next() / 2 + A_0.d()) % 60);
			}
			int num = 0;
			for (int j = 0; j < A_2.b.a.Count; j++)
			{
				if (A_2.b.a[j].a == "b")
				{
					num = j;
					Vector2 j2 = A_2.b.a[j].j;
				}
			}
			for (int k = 0; k < list.Count; k++)
			{
				if (list[k] < 60)
				{
					Random random = new Random((new Random(els.GetHashCode() + k).Next() / 2 + A_0.d()) / 60);
					int y = random.Next(6);
					a2f a2f = A_1.b(A_0, "Effects\\xpbl_BlackSmoke", new Point(list[k] % 20, y), null, true);
					if (a2f != null)
					{
						a2f a2f2 = a2f;
						a2f2.j.Y = a2f2.j.Y + (float)(30 + random.Next(40));
						a2f a2f3 = a2f;
						a2f3.j.X = a2f3.j.X + (float)(-30 + random.Next(60));
						if (k % 2 == 0)
						{
							a2f.h = new float?(0.7f);
							A_2.b.a(num, a2f);
							num++;
						}
						else
						{
							a2f.h = new float?(0.5f);
							A_2.b.a(num + 1, a2f);
						}
						float num2 = 1f;
						if (list[k] < 20)
						{
							num2 = Math.Min(1f, (float)list[k] * 0.05f);
						}
						else if (list[k] >= 40)
						{
							num2 = Math.Max(0f, 1f - (float)(list[k] - 40) * 0.05f);
						}
						a2f.h *= num2;
						a2f.e = new Color?(Color.White * (float)(0.2 + 0.3 * random.NextDouble()));
					}
				}
			}
		}
	}
}
