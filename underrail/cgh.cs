using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Items;

// Token: 0x020002A3 RID: 675
public static class cgh
{
	// Token: 0x060013B3 RID: 5043 RVA: 0x00051CE4 File Offset: 0x0004FEE4
	public static void b(c5x A_0)
	{
		if (A_0 != null && A_0.t.b != null)
		{
			cgh.a(A_0.t.b);
		}
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x00051D0C File Offset: 0x0004FF0C
	public static void a(bm6 A_0)
	{
		new bzv(A_0.y6()).h();
	}

	// Token: 0x060013B5 RID: 5045 RVA: 0x00051D20 File Offset: 0x0004FF20
	public static bgn a(cte A_0)
	{
		bm6 bm = A_0 as bm6;
		if (bm.a8().i.b != null)
		{
			return bm.a8().i.b.a() as ad5;
		}
		return null;
	}

	// Token: 0x060013B6 RID: 5046 RVA: 0x00051D68 File Offset: 0x0004FF68
	public static bool a(amc A_0, cte A_1)
	{
		return A_0 != null && A_0.a8().j == cgy.b && !A_0.aa().Dead && A_1.y6() != null && new bzv(A_1.y6()).a(A_0.a8().qe());
	}

	// Token: 0x060013B7 RID: 5047 RVA: 0x00051DC4 File Offset: 0x0004FFC4
	public static void a(c5x A_0, string A_1)
	{
		if (A_0 != null)
		{
			bm6 aspect = A_0.GetAspect<bm6>();
			if (aspect != null)
			{
				if (!string.IsNullOrEmpty(A_1))
				{
					aspect.y6()["GuardLoc"] = new bt4(A_1);
					return;
				}
				aspect.y6().RemoveProperty("GuardLoc");
			}
		}
	}

	// Token: 0x060013B8 RID: 5048 RVA: 0x00051E18 File Offset: 0x00050018
	public static List<csd> a(amc A_0, string A_1)
	{
		List<csd> list = new List<csd>();
		if (A_0 != null && A_0.a8().Zone != null)
		{
			string text = "_cover";
			if (!string.IsNullOrWhiteSpace(A_1))
			{
				text = text + "_" + A_1;
			}
			foreach (csd csd in A_0.a8().Zone.Waypoints)
			{
				if (csd.Name != null && csd.Name.StartsWith(text, StringComparison.OrdinalIgnoreCase))
				{
					list.Add(csd);
				}
			}
		}
		return list;
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x00051ED0 File Offset: 0x000500D0
	public static bool b(amc A_0, amc A_1, int A_2)
	{
		if (A_1.aa().SpecialStates.a)
		{
			return false;
		}
		double num = aw1.b(A_0.a8(), A_1.a8());
		bool flag = euf.b(A_1.aa().Offense.u().TypedDefinition) && euf.b(A_1.aa().Offense.q().TypedDefinition);
		double num2 = A_0.aa().Offense.u().TypedDefinition.aj();
		double num3 = (double)(A_1.aa().Offense.n() + A_1.aa().Offense.m()) / 10.0;
		if (num2 > 0.15 && flag)
		{
			if (A_1.aa().SpecialStates.b)
			{
				return false;
			}
			if (num <= num3 + 1.5)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060013BA RID: 5050 RVA: 0x00051FCC File Offset: 0x000501CC
	public static bool a(amc A_0, amc A_1, int A_2)
	{
		if (A_1.aa().SpecialStates.a)
		{
			return false;
		}
		int num = A_1.aa().Skills.Get<jk>().g();
		if (num <= 0)
		{
			return false;
		}
		if (!euf.b(A_1.aa().Offense.u().TypedDefinition) && !euf.b(A_1.aa().Offense.q().TypedDefinition))
		{
			return false;
		}
		bool flag = euf.b(A_1.aa().Offense.u().TypedDefinition) && euf.b(A_1.aa().Offense.q().TypedDefinition);
		int num2 = 0;
		if (!euf.b(A_1.aa().Offense.u().TypedDefinition))
		{
			num2 = (int)euf.a(A_1.aa(), A_1.aa().Offense.u().TypedDefinition.e(), false);
		}
		if (!euf.b(A_1.aa().Offense.q().TypedDefinition))
		{
			num2 = (int)Math.Max((double)num2, euf.a(A_1.aa(), A_1.aa().Offense.u().TypedDefinition.e(), false));
		}
		bool flag2 = false;
		int num3 = A_1.aa().Skills.Get<dei>().g();
		foreach (ItemSlot<coh> itemSlot in A_1.aa().Gear.d())
		{
			if (itemSlot.Item != null && itemSlot.Item.Definition.a2().Count > 0 && itemSlot.Item.Definition.a2()[0].Value is a0y)
			{
				flag2 = true;
				break;
			}
		}
		int num4 = 0;
		int num5 = (int)A_1.aa().Offense.aa().zo();
		if (A_1.aa().Feats.Contains<c3v>())
		{
			foreach (bas bas in A_1.aa().Offense.ag().Values)
			{
				num4 = Math.Max(num2, bas.b());
			}
		}
		if (!flag)
		{
			if (num2 > 0 && (double)num2 >= (double)num * 0.65)
			{
				return false;
			}
			if (num3 > 0 && (double)num3 >= (double)num * 0.65 && flag2)
			{
				return false;
			}
		}
		return num4 <= 0 || (double)num4 < (double)num * 0.65 || num5 < 15;
	}

	// Token: 0x060013BB RID: 5051 RVA: 0x000522D8 File Offset: 0x000504D8
	public static bool a(c5x A_0)
	{
		if (A_0 != null)
		{
			foreach (ak1 ak in A_0.l)
			{
				bool flag = false;
				foreach (b0b b0b in ak.c.Values)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.f && c5x.o.b != null && c5x.o.b.a == "Floor\\xpbl_BassaltFloor")
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}
}
