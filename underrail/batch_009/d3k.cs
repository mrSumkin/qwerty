using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000379 RID: 889
public static class d3k
{
	// Token: 0x060018AB RID: 6315 RVA: 0x0007F66C File Offset: 0x0007D86C
	public static bool b(efk A_0)
	{
		d3k.b b = new d3k.b();
		b.a = A_0.Offense.u();
		if (eub.a(b.a))
		{
			int? num = b.a.Definition.ba();
			int num2 = 0;
			if (!(num.GetValueOrDefault() > num2 & num != null))
			{
				return false;
			}
		}
		if (b.a.TypedDefinition.ak() != AmmoType.Bolts && (b.a.TypedDefinition.ak() != AmmoType.Energy || b.a.TypedDefinition.k() != 0.0))
		{
			if (b.a.TypedDefinition.ak() == AmmoType.Energy)
			{
				return (b.a.Battery < b.a.TypedDefinition.k() || (!A_0.IsInCombat && b.a.Battery < (double)(b.a.MaxBattery / 2))) && eub.a(A_0, b.a.TypedDefinition);
			}
			int? num = b.a.Definition.ba();
			int num2 = 0;
			if (num.GetValueOrDefault() > num2 & num != null)
			{
				double num3 = b.a.Battery;
				num = b.a.Definition.ba();
				double? num4 = (num != null) ? new double?((double)num.GetValueOrDefault() * 0.25) : null;
				if (num3 < num4.GetValueOrDefault() & num4 != null)
				{
					return eub.a(A_0);
				}
			}
			if (b.a.LoadedAmmo.Count == 0)
			{
				return eub.a(A_0, b.a.TypedDefinition);
			}
			return !A_0.IsInCombat && b.a.LoadedAmmo.Count < b.a.TypedDefinition.f() / 2 && Enumerable.Any<dng>(Enumerable.OfType<dng>(A_0.Bag.z2()), new Func<dng, bool>(b.a));
		}
		return false;
	}

	// Token: 0x060018AC RID: 6316 RVA: 0x0007F8A8 File Offset: 0x0007DAA8
	public static cst a(efk A_0, amc A_1)
	{
		d3k.c c = new d3k.c();
		c.a = A_0.Offense.u();
		if (eub.a(c.a))
		{
			int? num = c.a.Definition.ba();
			int num2 = 0;
			if (!(num.GetValueOrDefault() > num2 & num != null))
			{
				goto IL_A3;
			}
		}
		if (c.a.TypedDefinition.ak() != AmmoType.Bolts && (c.a.TypedDefinition.ak() != AmmoType.Energy || c.a.TypedDefinition.k() != 0.0))
		{
			if (c.a.TypedDefinition.ak() != AmmoType.Energy)
			{
				int? num = c.a.Definition.ba();
				int num2 = 0;
				if (!(num.GetValueOrDefault() > num2 & num != null))
				{
					dng dng;
					if (c.a.LoadedAmmo.Count == 0)
					{
						dng = Enumerable.FirstOrDefault<dng>(Enumerable.Where<dng>(Enumerable.OfType<dng>(A_0.Bag.z2()), new Func<dng, bool>(c.a)));
					}
					else
					{
						dng = Enumerable.FirstOrDefault<dng>(Enumerable.Where<dng>(Enumerable.OfType<dng>(A_0.Bag.z2()), new Func<dng, bool>(c.b)));
					}
					if (dng != null)
					{
						dg4 dg = dgk.Get<dg4>();
						if (dg != null)
						{
							eu7 eu = ecf.a(dg, new eru(new EntityAspectReference<amc, amc>(A_1)), dng) as eu7;
							if (eu != null && eu.yw())
							{
								return cp.b(eu, A_1.a8(), A_1.a8());
							}
						}
					}
					return null;
				}
			}
			List<coh> list = Enumerable.ToList<coh>(Enumerable.Where<coh>(A_0.Bag.z2(), new Func<coh, bool>(d3k.a.a.a)));
			if (list.Count > 0)
			{
				List<coh> list2 = Enumerable.ToList<coh>(Enumerable.Distinct<coh>(list, coh.DistinctCodeComparer));
				double num3 = (double)c.a.MaxBattery - c.a.Battery;
				coh coh = null;
				double num4 = 0.0;
				foreach (coh coh2 in list2)
				{
					sz sz = coh2.Definition as sz;
					if (sz != null)
					{
						int? primitivePropertyValue = sz.a7().GetPrimitivePropertyValue<int>("Power", null);
						if (primitivePropertyValue != null)
						{
							double num5 = Math.Abs(num3 - (double)primitivePropertyValue.Value);
							if (coh == null || num5 < num4)
							{
								num4 = num5;
								coh = coh2;
							}
						}
					}
				}
				if (coh != null)
				{
					az2 az = dgk.Get<az2>();
					if (az != null)
					{
						eu7 eu2 = ecf.a(az, new eru(new EntityAspectReference<amc, amc>(A_1)), coh) as eu7;
						if (eu2 != null && eu2.yw())
						{
							return cp.b(eu2, A_1.a8(), A_1.a8());
						}
					}
				}
			}
			return null;
		}
		IL_A3:
		return null;
	}

	// Token: 0x060018AD RID: 6317 RVA: 0x0007FBE0 File Offset: 0x0007DDE0
	public static bool e(efk A_0, bool A_1 = false)
	{
		bool flag = !d3k.a(A_0, A_0.Offense.b(WeaponKey.Primary), A_1);
		bool flag2 = !d3k.a(A_0, A_0.Offense.b(WeaponKey.Secondary), A_1);
		return flag && flag2;
	}

	// Token: 0x060018AE RID: 6318 RVA: 0x0007FC1C File Offset: 0x0007DE1C
	public static bool d(efk A_0, bool A_1 = false)
	{
		cd1 a_ = A_0.Offense.u();
		return !d3k.a(A_0, a_, A_1);
	}

	// Token: 0x060018AF RID: 6319 RVA: 0x0007FC40 File Offset: 0x0007DE40
	public static bool a(efk A_0, cd1 A_1, bool A_2 = false)
	{
		if (eub.a(A_1) || (A_1.TypedDefinition.ak() == AmmoType.Energy && A_1.TypedDefinition.k() == 0.0))
		{
			return true;
		}
		if (A_1.TypedDefinition.ak() == AmmoType.Bolts)
		{
			return (A_2 && eub.d(A_0)) || eub.a(A_0, A_1.TypedDefinition);
		}
		if (A_1.TypedDefinition.ak() == AmmoType.Energy)
		{
			if (A_1.Battery < A_1.TypedDefinition.k())
			{
				return eub.a(A_0, A_1.TypedDefinition);
			}
		}
		else if (A_1.LoadedAmmo.Count == 0)
		{
			return eub.a(A_0, A_1.TypedDefinition);
		}
		return true;
	}

	// Token: 0x060018B0 RID: 6320 RVA: 0x0007FD14 File Offset: 0x0007DF14
	public static bool c(efk A_0, bool A_1)
	{
		return d3k.b(A_0, A_1) != null;
	}

	// Token: 0x060018B1 RID: 6321 RVA: 0x0007FD24 File Offset: 0x0007DF24
	public static cd1 b(efk A_0, bool A_1)
	{
		double num = euf.a(A_0, A_0.Offense.u().TypedDefinition.e(), !A_1);
		double num2 = euf.d(A_0.Offense.u());
		double num3 = euf.e(A_0.Offense.u());
		cd1 result = null;
		foreach (cd1 cd in Enumerable.OfType<cd1>(A_0.Bag.z2()))
		{
			double num4 = euf.a(A_0, cd.TypedDefinition.e(), !A_1);
			if (num4 > num && d3k.a(A_0, cd, false))
			{
				double num5 = euf.e(cd);
				double num6 = euf.d(cd);
				if (num6 > num2 + 0.5 || num5 * (1.0 + num6) > num3 * (1.0 + num2))
				{
					result = cd;
					num3 = num5;
					num = num4;
					num2 = num6;
				}
			}
		}
		return result;
	}

	// Token: 0x060018B2 RID: 6322 RVA: 0x0007FE4C File Offset: 0x0007E04C
	public static bool a(efk A_0, bool A_1)
	{
		if (d3k.a(A_0, A_0.Offense.q(), false) && !euf.o(A_0.Offense.q()))
		{
			double num = euf.a(A_0, A_0.Offense.u().TypedDefinition.e(), !A_1);
			double num2 = euf.e(A_0.Offense.u());
			double num3 = euf.d(A_0.Offense.u());
			double num4 = euf.a(A_0, A_0.Offense.q().TypedDefinition.e(), !A_1);
			double num5 = euf.e(A_0.Offense.q());
			double num6 = euf.d(A_0.Offense.q());
			if (num4 > num && num6 >= num3)
			{
				return true;
			}
			if (num6 > num3 + 0.5)
			{
				return true;
			}
			if (num4 == num && num5 * (1.0 + num6) > num2 * (1.0 + num3))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060018B3 RID: 6323 RVA: 0x0007FF5C File Offset: 0x0007E15C
	public static bool a(efk A_0)
	{
		foreach (cd1 a_ in new cd1[]
		{
			A_0.Offense.u(),
			A_0.Offense.q()
		})
		{
			if (!euf.o(a_) && !euf.n(a_))
			{
				return true;
			}
		}
		foreach (ItemSlot<coh> itemSlot in A_0.Gear.d())
		{
			if (itemSlot.Enabled && itemSlot.Item != null && itemSlot.Item.Definition != null)
			{
				if (itemSlot.Item.Definition is dxw)
				{
					return true;
				}
				foreach (aia aia in itemSlot.Item.Definition.a2())
				{
					if (aia != null && !string.IsNullOrEmpty(aia.CapabilityFullTypeName))
					{
						c3n c3n = dgk.a(aia.CapabilityFullTypeName);
						if (c3n != null)
						{
							if (c3n is a0y)
							{
								return true;
							}
							if (c3n is ew2)
							{
								return true;
							}
							if (c3n is esn)
							{
								return true;
							}
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0200037A RID: 890
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060018B6 RID: 6326 RVA: 0x000800FC File Offset: 0x0007E2FC
		internal bool a(coh A_0)
		{
			return A_0.Definition.GetType() == typeof(sz);
		}

		// Token: 0x04000E57 RID: 3671
		public static readonly d3k.a a = new d3k.a();

		// Token: 0x04000E58 RID: 3672
		public static Func<coh, bool> b;
	}

	// Token: 0x0200037B RID: 891
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x060018B8 RID: 6328 RVA: 0x00080120 File Offset: 0x0007E320
		internal bool a(dng A_0)
		{
			return A_0.TypedDefinition.b() == this.a.LoadedAmmo[0];
		}

		// Token: 0x04000E59 RID: 3673
		public cd1 a;
	}

	// Token: 0x0200037C RID: 892
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x060018BA RID: 6330 RVA: 0x00080158 File Offset: 0x0007E358
		internal bool a(dng A_0)
		{
			return eub.g(A_0.TypedDefinition.b()) == this.a.TypedDefinition.ak();
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00080188 File Offset: 0x0007E388
		internal bool b(dng A_0)
		{
			return A_0.TypedDefinition.b() == this.a.LoadedAmmo[0];
		}

		// Token: 0x04000E5A RID: 3674
		public cd1 a;
	}
}
