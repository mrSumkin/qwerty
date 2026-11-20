using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x0200191E RID: 6430
public static class e7a
{
	// Token: 0x0600888F RID: 34959 RVA: 0x00387E18 File Offset: 0x00386018
	public static List<d5o> a(this IEnumerable<coh> A_0, string A_1, int A_2)
	{
		e7a.a a = new e7a.a();
		a.a = A_1;
		czh.a(A_0, "itemPool");
		List<d5o> list = new List<d5o>();
		if (A_2 > 0)
		{
			int num = A_2;
			Func<coh, bool> func;
			if ((func = a.b) == null)
			{
				func = (a.b = new Func<coh, bool>(a.a));
			}
			foreach (coh coh in Enumerable.Where<coh>(A_0, func))
			{
				d5o d5o = new d5o(coh, Math.Min(num, coh.Stacks));
				num -= d5o.StackPortion;
				list.Add(d5o);
				if (num == 0)
				{
					break;
				}
			}
		}
		return list;
	}

	// Token: 0x06008890 RID: 34960 RVA: 0x00387EEC File Offset: 0x003860EC
	public static int a(IEnumerable<coh> A_0, HashSet<string> A_1, float A_2)
	{
		double num = 0.0;
		if (A_0 != null)
		{
			foreach (coh coh in A_0)
			{
				if (coh.Definition != null && coh.Definition.a5() != null && A_1.Contains(coh.Definition.a5()))
				{
					num += (double)coh.ItemValue;
				}
				else if (coh.Definition != null && coh.Definition.a7().GetPrimitivePropertyValue<bool>(dii.e, new bool?(false)).Value)
				{
					num += (double)coh.ItemValue;
				}
				else
				{
					num += (double)((float)coh.ItemValue * A_2);
				}
			}
		}
		return (int)Math.Ceiling(num);
	}

	// Token: 0x06008891 RID: 34961 RVA: 0x00387FE0 File Offset: 0x003861E0
	public static coh a(this dbi A_0, string A_1, int A_2)
	{
		coh coh = null;
		foreach (d5o d5o in A_0.z2().a(A_1, A_2))
		{
			if (coh == null)
			{
				coh = d5o.Item.fy();
				coh.Stacks = 0;
			}
			coh.Stacks += Math.Min(d5o.StackPortion, d5o.Item.Stacks);
			if (d5o.StackPortion < d5o.Item.Stacks)
			{
				d5o.Item.Stacks -= d5o.StackPortion;
			}
			else
			{
				A_0.z5(d5o.Item);
			}
		}
		return coh;
	}

	// Token: 0x06008892 RID: 34962 RVA: 0x003880BC File Offset: 0x003862BC
	public static void a(ref List<coh> A_0)
	{
		A_0 = new List<coh>(Enumerable.OrderBy<coh, coh>(A_0, new Func<coh, coh>(e7a.b.a.a), e7a.c.a));
	}

	// Token: 0x0200191F RID: 6431
	private class c : IComparer<coh>
	{
		// Token: 0x06008893 RID: 34963 RVA: 0x003880F4 File Offset: 0x003862F4
		public int Compare(coh x, coh y)
		{
			if (x.Definition is a54)
			{
				if (y.Definition is a54)
				{
					return y.Stacks.CompareTo(x.Stacks);
				}
				return -1;
			}
			else
			{
				if (y.Definition is a54)
				{
					return 1;
				}
				if (x.Definition is a54 && !(y.Definition is a54))
				{
					return -1;
				}
				if (x.Definition.yi() != y.Definition.yi())
				{
					return x.Definition.yi().CompareTo(y.Definition.yi());
				}
				if (x.Definition.tv() != y.Definition.tv())
				{
					return x.Definition.tv().CompareTo(y.Definition.tv());
				}
				a1k a1k = x.Definition as a1k;
				a1k a1k2 = y.Definition as a1k;
				if (a1k != null && a1k2 != null && a1k.i() != a1k2.i())
				{
					return a1k.i().CompareTo(a1k2.i());
				}
				if (x.Definition.az() != y.Definition.az())
				{
					return x.Definition.az().CompareTo(y.Definition.az());
				}
				if (x.SingleItemValue != y.SingleItemValue)
				{
					return x.SingleItemValue.CompareTo(y.SingleItemValue);
				}
				return x.Stacks.CompareTo(y.Stacks);
			}
		}

		// Token: 0x04003680 RID: 13952
		public static e7a.c a = new e7a.c();
	}

	// Token: 0x02001920 RID: 6432
	[CompilerGenerated]
	[Serializable]
	private sealed class b
	{
		// Token: 0x06008898 RID: 34968 RVA: 0x003882D8 File Offset: 0x003864D8
		internal coh a(coh A_0)
		{
			return A_0;
		}

		// Token: 0x04003681 RID: 13953
		public static readonly e7a.b a = new e7a.b();

		// Token: 0x04003682 RID: 13954
		public static Func<coh, coh> b;
	}

	// Token: 0x02001921 RID: 6433
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x0600889A RID: 34970 RVA: 0x003882E4 File Offset: 0x003864E4
		internal bool a(coh A_0)
		{
			return A_0.Definition != null && A_0.Definition.a5() == this.a;
		}

		// Token: 0x04003683 RID: 13955
		public string a;

		// Token: 0x04003684 RID: 13956
		public Func<coh, bool> b;
	}
}
