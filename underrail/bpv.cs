using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001159 RID: 4441
public static class bpv
{
	// Token: 0x06005F17 RID: 24343 RVA: 0x00284B7C File Offset: 0x00282D7C
	public static c5x a(string A_0, double A_1, ak1 A_2, string A_3, bool A_4 = false, bool A_5 = false, double? A_6 = 1000.0)
	{
		p7 p = cx2.a(A_0);
		if (p != null && A_2 != null && p.aem(A_2))
		{
			bool flag = false;
			c5x c5x = bpv.a(A_2, A_0);
			if (c5x == null)
			{
				flag = true;
				c5x c5x2 = new c5x();
				c5x2.Location = A_2.Location.a();
				c5x2.Size = new Vector3(1f, 1f, 1f);
				c5x2.VisualPriority = -50;
				c5x2.Layer = aju.x;
				etz etz = new etz(c5x2);
				etz.a = "Effects\\" + (p.mq() ?? A_0);
				etz.c = p.vy();
				etz.d = new float?(p.mo());
				etz.g = p.afv();
				etz.a(0);
				etz.c(p.mr().GetValueOrDefault(12));
				etz.d(200);
				etz.b(1);
				etz.a(true);
				etz.b = new Point(0, (cuo.a.NextDouble() < 0.5) ? 0 : 2);
				List<cd0> list = p.afw(c5x2, true);
				if (list != null && list.Count > 0)
				{
					alv alv = new alv(c5x2);
					alv.a(etz);
					c5x2.SetAspect<alv>(alv);
					using (List<cd0>.Enumerator enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							cd0 a_ = enumerator.Current;
							alv.a(a_);
						}
						goto IL_1AB;
					}
				}
				c5x2.SetAspect<cd0>(etz);
				IL_1AB:
				a3f a3f = new a3f(c5x2);
				a3f.a()["GasEntityType"] = A_0;
				c5x2.SetAspect<a3f>(a3f);
				A_2.Area.a(c5x2);
				if (A_6 != null)
				{
					c5x2.ae = new float?(0f);
					qy qy = new qy();
					qy.ad().Add(new bm3(Convert.ToInt32(A_6 * 0.25)));
					List<auv> list2 = qy.ad();
					ad6 ad = new ad6(c5x2);
					ad.a(1.0 / (A_6.Value * 0.75));
					list2.Add(ad);
					A_2.Area.Zone.ActionManager.g9(qy, atp.a);
				}
				c5x = new c5x();
				c5x.Location = A_2.Location.a();
				c5x.Size = new Vector3(1f, 1f, 1f);
				c5x.VisualPriority = 50;
				c5x.Layer = aju.x;
				bjp bjp = p.ms();
				if (bjp != null)
				{
					c5x.TileFormationModifiers.c(bjp.b);
				}
				etz etz2 = new etz(c5x);
				etz2.a = "Effects\\" + (p.mq() ?? A_0);
				etz2.c = p.vy();
				etz2.d = new float?(p.mo());
				etz2.g = p.afv();
				etz2.a(0);
				etz2.c(p.mr().GetValueOrDefault(12));
				etz2.d(200);
				etz2.b(1);
				etz2.a(true);
				if (etz.b.Y == 2)
				{
					etz2.b = new Point(0, 1);
				}
				else
				{
					etz2.b = new Point(0, (cuo.a.NextDouble() < 0.5) ? 1 : 2);
				}
				List<cd0> list3 = p.afw(c5x, false);
				if (list3 != null && list3.Count > 0)
				{
					alv alv2 = new alv(c5x);
					alv2.a(etz2);
					c5x.SetAspect<alv>(alv2);
					using (List<cd0>.Enumerator enumerator = list3.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							cd0 a_2 = enumerator.Current;
							alv2.a(a_2);
						}
						goto IL_45B;
					}
				}
				c5x.SetAspect<cd0>(etz2);
				IL_45B:
				cry cry = p.mn(c5x, A_3, new Guid?(c5x2.qe()));
				cry.a(A_5);
				c5x.SetAspect<cry>(cry);
				a3f a3f2 = new a3f(c5x);
				a3f2.a()["GasEntityType"] = A_0;
				c5x.SetAspect<a3f>(a3f2);
				A_2.Area.a(c5x);
				if (A_6 != null)
				{
					c5x.ae = new float?(0f);
					qy qy2 = new qy();
					qy2.ad().Add(new bm3(Convert.ToInt32(A_6 * 0.25)));
					List<auv> list4 = qy2.ad();
					ad6 ad2 = new ad6(c5x);
					ad2.a(1.0 / (A_6.Value * 0.75));
					list4.Add(ad2);
					A_2.Area.Zone.ActionManager.g9(qy2, atp.a);
				}
				djd djd = new djd(c5x.GetAspect<cry>(), A_0);
				djd.Location = A_2.Location;
				djd.Size = new esj(1, 1);
				djd.Layer = aju.x;
				A_2.Area.b(djd);
			}
			cry aspect = c5x.GetAspect<cry>();
			if (aspect != null)
			{
				aspect.a(A_1);
				if (!flag && A_4)
				{
					aspect.a(A_4, new HashSet<Guid>());
				}
			}
			return c5x;
		}
		return null;
	}

	// Token: 0x06005F18 RID: 24344 RVA: 0x00285190 File Offset: 0x00283390
	public static void a(ak1 A_0, double A_1)
	{
		if (A_0 != null)
		{
			c5x c5x = bpv.a(A_0, "cryogas");
			if (c5x != null)
			{
				cry aspect = c5x.GetAspect<cry>();
				if (aspect != null)
				{
					aspect.b(A_1);
				}
			}
		}
	}

	// Token: 0x06005F19 RID: 24345 RVA: 0x002851CC File Offset: 0x002833CC
	public static c5x a(ak1 A_0, string A_1)
	{
		foreach (b0b b0b in A_0.c.Values)
		{
			c5x c5x = (c5x)b0b;
			cry aspect = c5x.GetAspect<cry>();
			if (aspect != null && !aspect.g() && aspect.gv() == A_1)
			{
				return c5x;
			}
		}
		return null;
	}

	// Token: 0x06005F1A RID: 24346 RVA: 0x00285258 File Offset: 0x00283458
	public static int a(c5x A_0)
	{
		int num = 0;
		foreach (ak1 ak in A_0.l)
		{
			if (ak.Formation.c(16384L))
			{
				foreach (b0b b0b in ak.c.Values)
				{
					cry aspect = ((c5x)b0b).GetAspect<cry>();
					if (aspect != null && !aspect.g() && aspect.gw())
					{
						num = Math.Max(num, aspect.f());
					}
				}
			}
		}
		return num;
	}

	// Token: 0x06005F1B RID: 24347 RVA: 0x00285344 File Offset: 0x00283544
	public static int a(ak1 A_0)
	{
		int num = 0;
		if (A_0.Formation.c(16384L))
		{
			foreach (b0b b0b in A_0.c.Values)
			{
				cry aspect = ((c5x)b0b).GetAspect<cry>();
				if (aspect != null && !aspect.g() && aspect.gw())
				{
					num = Math.Max(num, aspect.f());
				}
			}
		}
		return num;
	}

	// Token: 0x06005F1C RID: 24348 RVA: 0x002853E4 File Offset: 0x002835E4
	public static int a(amc A_0)
	{
		double num = A_0.aa().Defense.af()[DamageType.Bio].c();
		int num2 = A_0.aa().Defense.af()[DamageType.Bio].a();
		if (num >= 0.75 || num2 >= 40)
		{
			return 4;
		}
		float num3 = euf.f(A_0.aa());
		if (num > 0.2 || num2 > 5)
		{
			int val = (int)((num - 0.3) / 0.1);
			int val2 = (int)((num - 10.0) / 5.0);
			return Math.Max(val, val2);
		}
		if ((double)num3 < 0.2)
		{
			return 0;
		}
		return (int)((num3 - 0.2f) / 0.1f);
	}

	// Token: 0x040025D9 RID: 9689
	public static readonly double a = 5.0;

	// Token: 0x040025DA RID: 9690
	public static readonly double b = 1.0;

	// Token: 0x040025DB RID: 9691
	public static readonly double c = 0.24;
}
