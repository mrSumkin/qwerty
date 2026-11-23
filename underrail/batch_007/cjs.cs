using System;
using Microsoft.Xna.Framework;

// Token: 0x0200074C RID: 1868
public sealed class cjs : km
{
	// Token: 0x06002FD0 RID: 12240 RVA: 0x00121DA8 File Offset: 0x0011FFA8
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		if (A_3 != null)
		{
			int num = -1;
			for (int i = 0; i < A_2.b.a.Count; i++)
			{
				if (A_2.b.a[i].a == "b")
				{
					A_2.b.a[i].e = new Color?(new Color(8, 218, 176));
					A_2.b.a[i].h = new float?(0.5f);
					num = i;
					break;
				}
			}
			if (num != -1)
			{
				int x = A_0.d() % 17;
				a2f a2f = A_1.b(A_0, "Effects\\xpbl_StasisLoop", new Point(x, 0), null, true);
				a2f a2f2 = A_1.b(A_0, "Effects\\xpbl_StasisLoop", new Point(x, 1), null, true);
				if (a2f != null && a2f.d != null)
				{
					a2f2.h = new float?(0.75f);
					a2f2.e = new Color?(Color.White);
					A_2.b.a.Insert(num + 1, a2f2);
					a2f.h = new float?(0.75f);
					a2f.e = new Color?(Color.White);
					A_2.b.a.Insert(num, a2f);
				}
			}
		}
	}
}
