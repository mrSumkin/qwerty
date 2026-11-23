using System;
using System.Collections.Generic;

// Token: 0x02000376 RID: 886
public static class dan
{
	// Token: 0x060018A3 RID: 6307 RVA: 0x0007EF6C File Offset: 0x0007D16C
	public static List<csd> a(bm6 A_0, c5x A_1, int A_2 = 10)
	{
		double num = aw1.b(A_1, A_0.a8());
		HashSet<string> hashSet = new HashSet<string>();
		foreach (b0b b0b in A_0.a8().a().ab4(new string[]
		{
			"primeTentacle"
		}))
		{
			c5x c5x = (c5x)b0b;
			if (c5x != A_0.a8() && c5x.i.b != null && c5x.i.b.a() != null && c5x.i.b.a().Name != null)
			{
				hashSet.Add(c5x.i.b.a().Name);
			}
		}
		List<csd> list = new List<csd>();
		d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
		foreach (csd csd in A_0.a8().Zone.Waypoints)
		{
			if (csd.Name != null && csd.Name.StartsWith("tentacle") && !hashSet.Contains(csd.Name) && csd.Location != A_0.a8().Location && csd.Tile != null && csd.Area != null)
			{
				bool flag = false;
				foreach (b0b b0b2 in csd.Tile.c.Values)
				{
					c5x c5x2 = (c5x)b0b2;
					if (!c5x2.IsFloor && (c5x2.o.b == null || !(c5x2.o.b.a == "Objects\\LargeMachines\\TchortPart\\TentacleHole")) && c5x2.TileFormationModifiers.c(2L))
					{
						flag = true;
						break;
					}
					a3f aspect = c5x2.GetAspect<a3f>();
					if (aspect != null && aspect.a().GetClassPropertyValue<string>("CorpseSourceName") == "Tentacle")
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					if (serviceOrThrow.ahg() && A_1.t.b != null)
					{
						HashSet<r0> hashSet2 = A_1.t.b.b(serviceOrThrow);
						if (hashSet2 != null)
						{
							r0 r = new r0(csd.Area.c(), csd.Location.b());
							if (!hashSet2.Contains(r))
							{
								continue;
							}
						}
					}
					double num2 = aw1.a(A_1, csd.Tile);
					if ((serviceOrThrow.ahg() || num2 < num) && num2 < (double)A_2)
					{
						list.Add(csd);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x060018A4 RID: 6308 RVA: 0x0007F2CC File Offset: 0x0007D4CC
	public static bool a(c5x A_0)
	{
		if (!A_0.h.b.aa().SpecialStates.g || A_0.h.b.aa().Skills.Get<a2n>().g() < 50)
		{
			return true;
		}
		d60 d = A_0.a();
		if (d != null)
		{
			foreach (b0b b0b in d.ab4(new string[]
			{
				"primeTentacle",
				"tchort",
				"tchortlingSurger"
			}))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.h.b.aa().IsInControl && c5x.t.b != null && c5x.t.b.a(A_0.h.b))
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}
}
