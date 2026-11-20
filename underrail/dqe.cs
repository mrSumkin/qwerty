using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;

// Token: 0x0200036E RID: 878
public static class dqe
{
	// Token: 0x06001883 RID: 6275 RVA: 0x0007D6B4 File Offset: 0x0007B8B4
	public static bool a(efk A_0)
	{
		if (A_0 != null && A_0.Gear.l().Item != null && A_0.Gear.l().Item.Definition.ba() != null && A_0.Gear.l().Item.Definition.ba().Value > 0 && (A_0.Gear.l().Item.Definition.bd() || !A_0.IsInCombat) && A_0.Gear.l().Item.Battery / (double)A_0.Gear.l().Item.Definition.ba().Value <= 0.1)
		{
			return Enumerable.Any<coh>(A_0.Bag.z2(), new Func<coh, bool>(dqe.a.a.a));
		}
		return false;
	}

	// Token: 0x06001884 RID: 6276 RVA: 0x0007D7D0 File Offset: 0x0007B9D0
	public static cst a(efk A_0, amc A_1)
	{
		cgk cgk = A_0.Gear.l().Item;
		if (A_0 == null || cgk == null || cgk.Definition.ba() == null || cgk.Definition.ba().Value <= 0)
		{
			return null;
		}
		List<coh> list = Enumerable.ToList<coh>(Enumerable.Where<coh>(A_0.Bag.z2(), new Func<coh, bool>(dqe.a.a.b)));
		if (list.Count > 0)
		{
			List<coh> list2 = Enumerable.ToList<coh>(Enumerable.Distinct<coh>(list, coh.DistinctCodeComparer));
			double num = (double)cgk.Definition.ba().Value - cgk.Battery;
			coh coh = null;
			double num2 = 0.0;
			foreach (coh coh2 in list2)
			{
				sz sz = coh2.Definition as sz;
				if (sz != null)
				{
					int? primitivePropertyValue = sz.a7().GetPrimitivePropertyValue<int>("Power", null);
					if (primitivePropertyValue != null)
					{
						double num3 = Math.Abs(num - (double)primitivePropertyValue.Value);
						if (coh == null || num3 < num2)
						{
							num2 = num3;
							coh = coh2;
						}
					}
				}
			}
			if (coh != null)
			{
				a25 a = dgk.Get<a25>();
				if (a != null)
				{
					eu7 eu = ecf.a(a, new eru(new EntityAspectReference<amc, amc>(A_1)), coh) as eu7;
					if (eu != null && eu.yw())
					{
						return cp.b(eu, A_1.a8(), cgk);
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0200036F RID: 879
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06001887 RID: 6279 RVA: 0x0007D9BC File Offset: 0x0007BBBC
		internal bool a(coh A_0)
		{
			return A_0.Definition.GetType() == typeof(sz);
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0007D9D8 File Offset: 0x0007BBD8
		internal bool b(coh A_0)
		{
			return A_0.Definition.GetType() == typeof(sz);
		}

		// Token: 0x04000E50 RID: 3664
		public static readonly dqe.a a = new dqe.a();

		// Token: 0x04000E51 RID: 3665
		public static Func<coh, bool> b;

		// Token: 0x04000E52 RID: 3666
		public static Func<coh, bool> c;
	}
}
