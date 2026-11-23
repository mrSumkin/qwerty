using System;
using Microsoft.Xna.Framework;

// Token: 0x02000739 RID: 1849
public sealed class es0 : km
{
	// Token: 0x06002FA5 RID: 12197 RVA: 0x00120794 File Offset: 0x0011E994
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		if (A_3 != null)
		{
			int x = (A_3.GetHashCode() + A_0.d()) % 16;
			a2f a2f = A_1.b(A_0, "Effects\\PsychosomaticPrey", new Point(x, 1), null, true);
			if (a2f == null || a2f.d == null)
			{
				return;
			}
			a2f.h = new float?(0.85f);
			a2f.f = 0.5f;
			eyc.a(a2f, A_2, 0.85);
			A_2.b.a(a2f);
		}
	}
}
