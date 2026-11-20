using System;
using Microsoft.Xna.Framework;

// Token: 0x02001FCA RID: 8138
public static class a2x
{
	// Token: 0x0600BF27 RID: 48935 RVA: 0x00422040 File Offset: 0x00420240
	public static void c(this euz A_0)
	{
		czh.a(A_0, "control");
		A_0.Size = a2x.a();
	}

	// Token: 0x0600BF28 RID: 48936 RVA: 0x00422058 File Offset: 0x00420258
	public static void b(this euz A_0)
	{
		czh.a(A_0, "control");
		esj esj = a2x.a();
		A_0.Location = new Point((esj.c - A_0.Size.c) / 2, (esj.d - A_0.Size.d) / 2);
	}

	// Token: 0x0600BF29 RID: 48937 RVA: 0x004220AC File Offset: 0x004202AC
	public static esj a()
	{
		return bpo.GetServiceOrThrow<bef>().k4();
	}

	// Token: 0x0600BF2A RID: 48938 RVA: 0x004220BC File Offset: 0x004202BC
	public static void a(euz A_0)
	{
		czh.a(A_0, "control");
		esj esj = bpo.GetServiceOrThrow<bef>().k4();
		Point point = A_0.at();
		if (point.X < 0)
		{
			point.X = 0;
		}
		if (point.Y < 0)
		{
			point.Y = 0;
		}
		int num = point.X + A_0.Size.c - esj.c;
		if (num > 0)
		{
			point.X -= num;
		}
		int num2 = point.Y + A_0.Size.d - esj.d;
		if (num2 > 0)
		{
			point.Y -= num2;
		}
		A_0.Location = point;
	}
}
