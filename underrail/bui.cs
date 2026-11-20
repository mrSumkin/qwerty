using System;
using Microsoft.Xna.Framework;

// Token: 0x020018C9 RID: 6345
public static class bui
{
	// Token: 0x060086A6 RID: 34470 RVA: 0x0037CBFC File Offset: 0x0037ADFC
	public static double a(efk A_0, int A_1, int A_2, double A_3, double A_4, double A_5, double A_6, bool A_7)
	{
		double a_ = Math.Max(1.0, (double)A_2) / Math.Max(1.0, (double)A_1);
		double num = d05.b(aiy.cf, a_, aiy.cg);
		double num2 = bui.a(A_6, A_7);
		kl.a(A_0, ref num2);
		double num3 = bui.b(A_5);
		double x = (1.0 - Math.Max(0.0, A_3 - 1.0) / Math.Max(1.0, A_4)) * 10.0;
		double num4 = 9.0 * num * num2 * num3;
		return Math.Max((Math.Pow(x, 2.0) - num4) / 100.0, -aiy.b6);
	}

	// Token: 0x060086A7 RID: 34471 RVA: 0x0037CCCC File Offset: 0x0037AECC
	public static double b(double A_0)
	{
		if (A_0 > aiy.cc)
		{
			return aiy.ca;
		}
		if (A_0 > aiy.cb)
		{
			return aiy.b9;
		}
		return aiy.b8;
	}

	// Token: 0x060086A8 RID: 34472 RVA: 0x0037CCF8 File Offset: 0x0037AEF8
	public static bool a(double A_0)
	{
		return A_0 > aiy.cc;
	}

	// Token: 0x060086A9 RID: 34473 RVA: 0x0037CD04 File Offset: 0x0037AF04
	private static double a(double A_0, bool A_1)
	{
		if (!A_1 && A_0 < aiy.ce)
		{
			return 1.0 + (aiy.ce - A_0) / aiy.ce * aiy.cd;
		}
		return 1.0;
	}

	// Token: 0x060086AA RID: 34474 RVA: 0x0037CD40 File Offset: 0x0037AF40
	public static double a(Color A_0)
	{
		Vector3 vector = A_0.ToVector3();
		return (double)((vector.X + vector.Y + vector.Z) / 3f);
	}

	// Token: 0x060086AB RID: 34475 RVA: 0x0037CD70 File Offset: 0x0037AF70
	public static bool a(int A_0, int A_1)
	{
		return A_0 - A_1 >= 15 && (double)A_1 / (double)Math.Max(1, A_0) <= 0.4;
	}
}
