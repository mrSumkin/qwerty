using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;

// Token: 0x02000377 RID: 887
public static class brf
{
	// Token: 0x060018A5 RID: 6309 RVA: 0x0007F418 File Offset: 0x0007D618
	public static bool a(efk A_0)
	{
		if (A_0 != null && A_0.Vehicle != null && A_0.Vehicle.g() <= 10.0)
		{
			if (Enumerable.Any<coh>(A_0.Bag.z2(), new Func<coh, bool>(brf.a.a.b)))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060018A6 RID: 6310 RVA: 0x0007F48C File Offset: 0x0007D68C
	public static cst a(efk A_0, amc A_1)
	{
		if (A_0 != null && A_0.Vehicle != null)
		{
			List<coh> list = Enumerable.ToList<coh>(Enumerable.Where<coh>(A_0.Bag.z2(), new Func<coh, bool>(brf.a.a.a)));
			if (list.Count > 0)
			{
				List<coh> list2 = Enumerable.ToList<coh>(Enumerable.Distinct<coh>(list, coh.DistinctCodeComparer));
				double num = (double)A_0.Vehicle.am() - A_0.Vehicle.g();
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
					bcl bcl = dgk.Get<bcl>();
					if (bcl != null)
					{
						eu7 eu = ecf.a(bcl, new eru(new EntityAspectReference<amc, amc>(A_1)), coh) as eu7;
						if (eu != null && eu.yw())
						{
							return cp.b(eu, A_1.a8(), A_1.a8());
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x02000378 RID: 888
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060018A9 RID: 6313 RVA: 0x0007F634 File Offset: 0x0007D834
		internal bool b(coh A_0)
		{
			return A_0.Definition.GetType() == typeof(sz);
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0007F650 File Offset: 0x0007D850
		internal bool a(coh A_0)
		{
			return A_0.Definition.GetType() == typeof(sz);
		}

		// Token: 0x04000E54 RID: 3668
		public static readonly brf.a a = new brf.a();

		// Token: 0x04000E55 RID: 3669
		public static Func<coh, bool> b;

		// Token: 0x04000E56 RID: 3670
		public static Func<coh, bool> c;
	}
}
