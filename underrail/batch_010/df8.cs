using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators.Items;

// Token: 0x0200070E RID: 1806
[eiz("IRG")]
[Serializable]
public sealed class df8 : y8
{
	// Token: 0x06002ED3 RID: 11987 RVA: 0x00108CA8 File Offset: 0x00106EA8
	public ItemRange b()
	{
		return this.a;
	}

	// Token: 0x06002ED4 RID: 11988 RVA: 0x00108CB0 File Offset: 0x00106EB0
	public void a(ItemRange A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002ED5 RID: 11989 RVA: 0x00108CBC File Offset: 0x00106EBC
	public df8()
	{
	}

	// Token: 0x06002ED6 RID: 11990 RVA: 0x00108CC4 File Offset: 0x00106EC4
	public df8(ItemRange A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002ED7 RID: 11991 RVA: 0x00108CD4 File Offset: 0x00106ED4
	protected override List<coh> a2()
	{
		if (this.b == null)
		{
			this.b = this.a();
		}
		List<coh> list = new List<coh>();
		int num = 20;
		do
		{
			list.Clear();
			if (num-- <= 0)
			{
				break;
			}
			List<bmd> list2 = this.b.c();
			if (list2 != null)
			{
				list.AddRange(Enumerable.Select<bmd, coh>(list2, new Func<bmd, coh>(df8.a.a.a)));
			}
		}
		while (this.a(list));
		return list;
	}

	// Token: 0x06002ED8 RID: 11992 RVA: 0x00108D5C File Offset: 0x00106F5C
	public override aw4 a1()
	{
		df8 df = new df8(this.a);
		this.rg(df);
		return df;
	}

	// Token: 0x06002ED9 RID: 11993 RVA: 0x00108D80 File Offset: 0x00106F80
	public override string ToString()
	{
		return "Item Range Generator: " + this.a.ToString();
	}

	// Token: 0x06002EDA RID: 11994 RVA: 0x00108DA0 File Offset: 0x00106FA0
	protected override void aj5(out int A_0, out int A_1)
	{
		base.aj5(out A_0, out A_1);
		if (this.a == ItemRange.Food && A_0 == 1 && A_1 == 1)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				A_1 = serviceOrThrow.aqu().h().BaseLevel;
			}
		}
	}

	// Token: 0x06002EDB RID: 11995 RVA: 0x00108DF8 File Offset: 0x00106FF8
	private bool a(List<coh> A_0)
	{
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aqu() != null)
		{
			for (int i = A_0.Count - 1; i >= 0; i--)
			{
				coh coh = A_0[i];
				if (coh != null && coh.Definition != null && !string.IsNullOrEmpty(coh.Definition.a5()) && coh.Definition.bc() >= cr1.e)
				{
					if (service.aqu().ad().Contains(coh.Definition.a5()))
					{
						return true;
					}
					service.aqu().ad().Add(coh.Definition.a5());
				}
			}
		}
		return false;
	}

	// Token: 0x06002EDC RID: 11996 RVA: 0x00108EB4 File Offset: 0x001070B4
	private c9y a()
	{
		int a_;
		int a_2;
		this.aj5(out a_, out a_2);
		List<ezv> list = dtf.a(this.a, a_, a_2);
		c9y c9y = new c9y();
		if (list != null)
		{
			float num = Enumerable.Sum<ezv>(list, new Func<ezv, float>(df8.a.a.a));
			foreach (ezv ezv in list)
			{
				xs xs = new xs();
				xs.Generator = ezv.a;
				y8 a_3 = xs.Generator as y8;
				base.a(a_3);
				xs.Chance = 1f / (float)ezv.b / num;
				xs.Amount = ezv.c;
				xs.SubGroup = 1;
				c9y.g().Add(xs);
			}
			if (c9y.g().Count > 0)
			{
				float num2 = Enumerable.Sum<xs>(c9y.g(), new Func<xs, float>(df8.a.a.a));
				if (num2 >= 0.999999f && num2 < 1f)
				{
					c9y.g()[c9y.g().Count - 1].Chance += 1E-06f;
				}
			}
		}
		return c9y;
	}

	// Token: 0x06002EDD RID: 11997 RVA: 0x0010903C File Offset: 0x0010723C
	private df8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (ItemRange)A_0.GetValue("IRG:IR", typeof(ItemRange));
	}

	// Token: 0x06002EDE RID: 11998 RVA: 0x00109068 File Offset: 0x00107268
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("IRG:IR", this.a);
	}

	// Token: 0x04001A03 RID: 6659
	private new ItemRange a;

	// Token: 0x04001A04 RID: 6660
	[NonSerialized]
	private c9y b;

	// Token: 0x0200070F RID: 1807
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06002EE1 RID: 12001 RVA: 0x0010909C File Offset: 0x0010729C
		internal coh a(bmd A_0)
		{
			return A_0.Item;
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x001090A4 File Offset: 0x001072A4
		internal float a(ezv A_0)
		{
			return 1f / (float)A_0.b;
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x001090B4 File Offset: 0x001072B4
		internal float a(xs A_0)
		{
			return A_0.Chance;
		}

		// Token: 0x04001A05 RID: 6661
		public static readonly df8.a a = new df8.a();

		// Token: 0x04001A06 RID: 6662
		public static Func<bmd, coh> b;

		// Token: 0x04001A07 RID: 6663
		public static Func<ezv, float> c;

		// Token: 0x04001A08 RID: 6664
		public static Func<xs, float> d;
	}
}
