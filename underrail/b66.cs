using System;
using Microsoft.Xna.Framework;

// Token: 0x0200072E RID: 1838
public sealed class b66 : km
{
	// Token: 0x06002F8F RID: 12175 RVA: 0x0011FEE0 File Offset: 0x0011E0E0
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = A_1.b(A_0, "Meta\\CompassMarker", new Point(0, 0), null, true);
		if (a2f != null && a2f.d != null)
		{
			int num = A_0.d() % 30;
			float num2;
			if (num > 15)
			{
				num2 = 1f - (float)(num - 15) / 15f;
			}
			else
			{
				num2 = (float)num / 15f;
			}
			a2f.j = new Vector2(0f, 100f);
			a2f.h = new float?(0.25f + 0.4f * num2);
			A_2.b.a(a2f);
		}
	}
}
