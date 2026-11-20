using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200190B RID: 6411
public static class ke
{
	// Token: 0x06008817 RID: 34839 RVA: 0x00385F64 File Offset: 0x00384164
	public static bool a(coh A_0)
	{
		return A_0.Definition != null && !A_0.Definition.a9() && A_0.Durability / (double)Math.Max(1, A_0.MaxDurability) < dwh.i;
	}

	// Token: 0x06008818 RID: 34840 RVA: 0x00385FAC File Offset: 0x003841AC
	public static void a(efk A_0, dbi A_1, bool A_2 = true, bool A_3 = false)
	{
		foreach (c1e c1e in Enumerable.Union<c1e>(A_0.Gear.d(), new c1e[]
		{
			A_0.Gear.l(),
			A_0.Gear.e(),
			A_0.Gear.f(),
			A_0.Gear.g(),
			A_0.Gear.h(),
			A_0.Gear.j()[WeaponKey.Primary],
			A_0.Gear.j()[WeaponKey.Secondary]
		}))
		{
			if (c1e.Value != null && !euf.o(c1e.Value as cd1) && (!A_2 || c1e.Value.Stealable))
			{
				A_1.z3(c1e.Value, false);
				c1e.po(null);
			}
		}
		foreach (coh coh in Enumerable.ToList<coh>(A_0.Bag.z2()))
		{
			if (!A_2 || coh.Stealable)
			{
				A_0.Bag.z5(coh);
				coh.Lootable = true;
				coh.Stealable = true;
				A_1.z3(coh, false);
			}
		}
	}

	// Token: 0x06008819 RID: 34841 RVA: 0x00386144 File Offset: 0x00384344
	public static void a(efk A_0, bool A_1 = false)
	{
		foreach (c1e c1e in Enumerable.Union<c1e>(A_0.Gear.d(), new c1e[]
		{
			A_0.Gear.l(),
			A_0.Gear.e(),
			A_0.Gear.f(),
			A_0.Gear.g(),
			A_0.Gear.h(),
			A_0.Gear.j()[WeaponKey.Primary],
			A_0.Gear.j()[WeaponKey.Secondary]
		}))
		{
			if (c1e.Value != null && !euf.o(c1e.Value as cd1) && !(c1e.Value is cgk) && !(c1e.Value is cjh) && (!A_1 || c1e.Value.Stealable))
			{
				A_0.Bag.z3(c1e.Value, false);
				c1e.po(null);
			}
		}
	}

	// Token: 0x0600881A RID: 34842 RVA: 0x00386280 File Offset: 0x00384480
	public static bool a(efk A_0, coh A_1)
	{
		return A_1 == null || A_1.Definition == null || ke.a(A_0, A_1.Definition);
	}

	// Token: 0x0600881B RID: 34843 RVA: 0x003862A4 File Offset: 0x003844A4
	public static bool a(efk A_0, bk3 A_1)
	{
		if (A_1 != null)
		{
			c6m c6m = A_1 as c6m;
			if (c6m != null)
			{
				List<brl> list = c6m.j0();
				if (list != null)
				{
					using (List<brl>.Enumerator enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (!enumerator.Current.oh(A_0))
							{
								return false;
							}
						}
					}
					return true;
				}
			}
		}
		return true;
	}
}
