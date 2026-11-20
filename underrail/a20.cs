using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Common.Data;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Comm;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000FEF RID: 4079
public static class a20
{
	// Token: 0x06005403 RID: 21507 RVA: 0x00252ADC File Offset: 0x00250CDC
	public static bool a(amc A_0)
	{
		return A_0 != null && A_0.aa().b(d8o.b);
	}

	// Token: 0x06005404 RID: 21508 RVA: 0x00252AFC File Offset: 0x00250CFC
	public static void a(c5x A_0, ap9 A_1, params CombatSpeakEvent[] A_2)
	{
		if (bpo.GetServiceOrThrow<cnk>().aq1().c().g() && A_2 != null && A_2.Length != 0)
		{
			if (A_1 != null && (A_1.g & d8o.s) != d8o.a)
			{
				return;
			}
			if (A_0 != null && A_0.h.b != null && !A_0.h.b.aa().Dead && A_0.t.b != null && A_0.t.b.a(A_1, A_2, -a20.a, false))
			{
				a20.a += 0.15;
			}
		}
	}

	// Token: 0x06005405 RID: 21509 RVA: 0x00252BBC File Offset: 0x00250DBC
	public static void a(double A_0)
	{
		if (a20.a > 0.0)
		{
			a20.a = Math.Max(0.0, a20.a - A_0 * 5E-05);
		}
	}

	// Token: 0x06005406 RID: 21510 RVA: 0x00252BF8 File Offset: 0x00250DF8
	public static ad7 a(azm A_0, ap9 A_1, CombatSpeakEvent A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0.b() != null)
		{
			a20.a a = new a20.a();
			bq8 a_ = serviceOrThrow.aqu().e();
			PropertyCollection propertyCollection = new PropertyCollection();
			propertyCollection["combatSpeakEvent"] = A_2;
			propertyCollection["otherParty"] = A_1;
			List<a20.c> list = new List<a20.c>();
			a.a = int.MinValue;
			foreach (d55 d in A_0.b().PossibleNextSteps)
			{
				ad7 ad = d as ad7;
				if (ad != null && ad.CausingCondition != null && ad.CausingCondition.cw(a_, propertyCollection))
				{
					d3o d3o = a20.a(ad.CausingCondition);
					if (d3o != null)
					{
						a.a = Math.Max(a.a, d3o.b());
						list.Add(new a20.c(ad, d3o.b()));
					}
				}
			}
			if (list.Count > 0)
			{
				List<ad7> list2 = new List<ad7>(Enumerable.Select<a20.c, ad7>(Enumerable.Where<a20.c>(list, new Func<a20.c, bool>(a.a)), new Func<a20.c, ad7>(a20.b.a.a)));
				if (list2.Count > 0)
				{
					return list2[cuo.a.Next(list2.Count)];
				}
			}
		}
		return null;
	}

	// Token: 0x06005407 RID: 21511 RVA: 0x00252D98 File Offset: 0x00250F98
	public static void a(amc A_0, amc A_1)
	{
		if (A_0 != null)
		{
			CombatSpeakEvent[] array = a20.a(A_0.aa().Offense.u());
			if (array != null && array.Length != 0)
			{
				ap9 a_ = null;
				if (A_1 != null)
				{
					a_ = new ap9(A_1.aa());
				}
				a20.a(A_0.a8(), a_, array);
			}
		}
	}

	// Token: 0x06005408 RID: 21512 RVA: 0x00252DF0 File Offset: 0x00250FF0
	public static CombatSpeakEvent[] a(cd1 A_0)
	{
		HashSet<CombatSpeakEvent> hashSet = new HashSet<CombatSpeakEvent>();
		hashSet.Add(CombatSpeakEvent.Battlecry_General);
		if (A_0.TypedDefinition.e() == btz.g)
		{
			hashSet.Add(CombatSpeakEvent.Battlecry_Melee);
		}
		if (euf.k(A_0))
		{
			hashSet.Add(CombatSpeakEvent.Battlecry_Shotgun);
		}
		if (euf.i(A_0))
		{
			hashSet.Add(CombatSpeakEvent.Battlecry_GrenadeLauncher);
		}
		if (euf.m(A_0) && !euf.k(A_0))
		{
			hashSet.Add(CombatSpeakEvent.Battlecry_SingleFirearm);
		}
		if (euf.n(A_0) || euf.o(A_0))
		{
			hashSet.Add(CombatSpeakEvent.Battlecry_Fists);
		}
		if (A_0.TypedDefinition.ak() == AmmoType.Energy)
		{
			hashSet.Add(CombatSpeakEvent.Battlecry_EnergyWeapon);
		}
		if (A_0.TypedDefinition.ak() == AmmoType.Vial_Acid)
		{
			hashSet.Add(CombatSpeakEvent.Battlecry_ChemicalWeapon);
		}
		WeaponSubtype? weaponSubtype = euf.d(A_0.TypedDefinition);
		if (weaponSubtype != null)
		{
			if (weaponSubtype.GetValueOrDefault() == WeaponSubtype.Crossbow)
			{
				hashSet.Add(CombatSpeakEvent.Battlecry_Crossbow);
			}
			if (weaponSubtype.GetValueOrDefault() == WeaponSubtype.Sledgehammer)
			{
				hashSet.Add(CombatSpeakEvent.Battlecry_Hammer);
			}
			if (weaponSubtype.GetValueOrDefault() == WeaponSubtype.Knife || weaponSubtype.GetValueOrDefault() == WeaponSubtype.Dagger || weaponSubtype.GetValueOrDefault() == WeaponSubtype.SerratedKnife)
			{
				hashSet.Add(CombatSpeakEvent.Battlecry_Knife);
			}
			if (weaponSubtype.GetValueOrDefault() == WeaponSubtype.Spear)
			{
				hashSet.Add(CombatSpeakEvent.Battlecry_Spear);
			}
			if (weaponSubtype.GetValueOrDefault() == WeaponSubtype.Sword || weaponSubtype.GetValueOrDefault() == WeaponSubtype.Machete_Straight || weaponSubtype.GetValueOrDefault() == WeaponSubtype.Machete_Curved)
			{
				hashSet.Add(CombatSpeakEvent.Battlecry_Sword);
			}
		}
		return Enumerable.ToArray<CombatSpeakEvent>(hashSet);
	}

	// Token: 0x06005409 RID: 21513 RVA: 0x00252FA8 File Offset: 0x002511A8
	private static d3o a(dnh A_0)
	{
		d3o d3o = A_0 as d3o;
		if (d3o != null)
		{
			return d3o;
		}
		cma cma = A_0 as cma;
		if (cma != null)
		{
			foreach (dnh a_ in cma.a())
			{
				d3o d3o2 = a20.a(a_);
				if (d3o2 != null)
				{
					return d3o2;
				}
			}
		}
		return null;
	}

	// Token: 0x0400224C RID: 8780
	private static double a;

	// Token: 0x02000FF0 RID: 4080
	private class c
	{
		// Token: 0x0600540A RID: 21514 RVA: 0x00253030 File Offset: 0x00251230
		public c(ad7 A_0, int A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x0400224D RID: 8781
		public ad7 a;

		// Token: 0x0400224E RID: 8782
		public int b;
	}

	// Token: 0x02000FF1 RID: 4081
	[CompilerGenerated]
	[Serializable]
	private sealed class b
	{
		// Token: 0x0600540D RID: 21517 RVA: 0x0025305C File Offset: 0x0025125C
		internal ad7 a(a20.c A_0)
		{
			return A_0.a;
		}

		// Token: 0x0400224F RID: 8783
		public static readonly a20.b a = new a20.b();

		// Token: 0x04002250 RID: 8784
		public static Func<a20.c, ad7> b;
	}

	// Token: 0x02000FF2 RID: 4082
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x0600540F RID: 21519 RVA: 0x0025306C File Offset: 0x0025126C
		internal bool a(a20.c A_0)
		{
			return A_0.b == this.a;
		}

		// Token: 0x04002251 RID: 8785
		public int a;
	}
}
