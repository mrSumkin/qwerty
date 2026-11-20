using System;
using Microsoft.Xna.Framework;

// Token: 0x0200074D RID: 1869
public sealed class hd : km
{
	// Token: 0x06002FD2 RID: 12242 RVA: 0x00121F1C File Offset: 0x0012011C
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		if (A_3 != null)
		{
			int hashCode = A_3.GetHashCode();
			for (int i = 0; i < 30; i++)
			{
				bm4 bm = new bm4(hashCode * i);
				int num = (bm.b() + A_0.d()) % 30;
				if (num < 10)
				{
					int num2 = -30 + bm.a(60);
					int num3 = Math.Max(10, 30 - Math.Abs(num2));
					int num4 = -num3 + bm.a(num3 * 2);
					a2f a2f = A_1.b(A_0, "Effects\\xpbl_eye", new Point(num, 0), null, true);
					if (a2f == null || a2f.d == null)
					{
						return;
					}
					a2f.h = new float?(0.5f - 0.05f * (float)num);
					eyc.a(a2f, A_2, 0.8);
					a2f.j += new Vector2((float)num2, (float)num4);
					A_2.b.a(a2f);
				}
			}
		}
	}
}
