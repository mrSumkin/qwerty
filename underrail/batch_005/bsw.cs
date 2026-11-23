using System;
using Microsoft.Xna.Framework;

// Token: 0x02000755 RID: 1877
public sealed class bsw : km
{
	// Token: 0x06002FE3 RID: 12259 RVA: 0x00122774 File Offset: 0x00120974
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		alf alf = A_3 as alf;
		if (alf != null)
		{
			a2f a2f = null;
			int num = 0;
			for (int i = 0; i < A_2.b.a.Count; i++)
			{
				a2f a2f2 = A_2.b.a[i];
				if (a2f2.a == "b")
				{
					a2f = a2f2;
					num = i;
					break;
				}
			}
			if (a2f != null)
			{
				Random random = new Random(A_2.b.b.GetHashCode());
				for (int j = 0; j < alf.Stacks; j++)
				{
					a2f a2f3 = a2f.f5();
					by8 by = a2f3.d as by8;
					if (by != null)
					{
						by.a();
					}
					a2f3.e = new Color?(new Color(128, 255, 255, 100));
					a2f3.q = false;
					a2f3.s = true;
					a2f3.a = "d";
					a2f3.h = new float?(0.6f);
					Vector2 vector = new Vector2((float)(-30 + random.Next(60)), (float)(-30 + random.Next(60)));
					a2f3.a(vector);
					if (vector.Y > 0f)
					{
						A_2.b.a(num, a2f3);
						num++;
					}
					else
					{
						A_2.b.a(num + 1, a2f3);
					}
				}
			}
		}
	}

	// Token: 0x04001A40 RID: 6720
	private const int a = 30;
}
