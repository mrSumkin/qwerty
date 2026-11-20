using System;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x02000767 RID: 1895
public static class eyc
{
	// Token: 0x06003009 RID: 12297 RVA: 0x00123950 File Offset: 0x00121B50
	public static void a(mv A_0, bym A_1, Color A_2)
	{
		int num;
		if (A_0 != null)
		{
			num = A_0.d() % 11;
		}
		else
		{
			num = 3;
		}
		byte b;
		if (num <= 5)
		{
			b = (byte)(num * 40);
		}
		else
		{
			b = (byte)(240 - (num - 5) * 40);
		}
		foreach (a2f a2f in Enumerable.ToList<a2f>(A_1.a))
		{
			if (a2f != null)
			{
				a2f a2f2 = a2f.f5();
				a2f2.e = new Color?(A_2 * ((float)b / 255f));
				A_1.a(a2f2);
			}
		}
	}

	// Token: 0x0600300A RID: 12298 RVA: 0x00123A10 File Offset: 0x00121C10
	public static void a(a2f A_0, b3u A_1, double A_2 = 1.0)
	{
		c5x c5x = A_1.b.b as c5x;
		if (c5x != null && c5x.h.b != null && c5x.h.b.g != null && c5x.h.b.g.f != 0)
		{
			A_0.j.Y = A_0.j.Y + (float)((int)((double)c5x.h.b.g.f * A_2));
			return;
		}
		A_0.j.Y = A_0.j.Y + c5x.Size.Z * 59f;
	}
}
