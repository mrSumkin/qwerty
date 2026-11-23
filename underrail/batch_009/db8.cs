using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02000375 RID: 885
public static class db8
{
	// Token: 0x060018A0 RID: 6304 RVA: 0x0007EDD0 File Offset: 0x0007CFD0
	public static ak1 b(c5x A_0)
	{
		List<ak1> list = db8.a(A_0);
		if (list != null && list.Count > 0)
		{
			return list[cuo.a.Next(list.Count)];
		}
		return null;
	}

	// Token: 0x060018A1 RID: 6305 RVA: 0x0007EE10 File Offset: 0x0007D010
	private static List<ak1> a(c5x A_0)
	{
		List<ak1> list = new List<ak1>();
		Point a_ = A_0.aj().a();
		Point point;
		Point point2;
		A_0.a(out point, out point2);
		for (int i = point.X - 1; i <= point2.X + 1; i++)
		{
			ak1 ak = A_0.Area.b(i, point.Y - 1);
			if (db8.a(ak, A_0, a_))
			{
				list.Add(ak);
			}
			ak1 ak2 = A_0.Area.b(i, point2.Y + 1);
			if (db8.a(ak2, A_0, a_))
			{
				list.Add(ak2);
			}
		}
		for (int j = point.Y; j <= point2.Y; j++)
		{
			ak1 ak3 = A_0.Area.b(point.X - 1, j);
			if (db8.a(ak3, A_0, a_))
			{
				list.Add(ak3);
			}
			ak1 ak4 = A_0.Area.b(point2.X + 1, j);
			if (db8.a(ak4, A_0, a_))
			{
				list.Add(ak4);
			}
		}
		return list;
	}

	// Token: 0x060018A2 RID: 6306 RVA: 0x0007EF2C File Offset: 0x0007D12C
	private static bool a(ak1 A_0, b0b A_1, Point A_2)
	{
		return A_0 != null && bnx.a(A_0.Location, A_2) <= 1.65f && !A_0.Formation.b(2L) && A_0.f(A_1) == 0L;
	}
}
