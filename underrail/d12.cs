using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Items;

// Token: 0x020003E9 RID: 1001
[fe("facelessDoctor")]
public class d12 : b5g
{
	// Token: 0x06001ACD RID: 6861 RVA: 0x00091300 File Offset: 0x0008F500
	public d12(bm6 A_0) : base(A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new byh("HealAllyOrSelf", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(d12.a.a.a), null)
		{
			e = false
		});
		base.a(list);
	}

	// Token: 0x06001ACE RID: 6862 RVA: 0x00091374 File Offset: 0x0008F574
	private object a(amc A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		if (euf.f(A_0.aa()) < 0.85f)
		{
			return A_0.a8();
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() == null || A_0.a8().t.b == null)
		{
			return null;
		}
		bzv bzv = new bzv(A_0.a8().t.b.y6());
		amc amc = null;
		double num = double.MaxValue;
		bool flag = false;
		foreach (blk blk in bzv.b())
		{
			if (blk.a().f() == cem.d && blk.e() != null && (A_0.aa().a(serviceOrThrow.aqu().ac(), blk.e().aa().FactionId) == global::h.e || A_0.aa().FactionId == blk.e().aa().FactionId) && euf.f(blk.e().aa()) <= 0.65f && !blk.e().aa().b(d8o.e))
			{
				double num2 = aw1.b(A_0.a8(), blk.e().a8());
				bool flag2 = euf.f(blk.e().aa()) < 0.4f && blk.e().aa().StatusEffects.a(c6h.a);
				if (amc == null || num2 < num || (flag2 && !flag))
				{
					num = num2;
					amc = blk.e();
					flag = flag2;
				}
			}
		}
		if (amc == null)
		{
			return null;
		}
		return amc.a8();
	}

	// Token: 0x06001ACF RID: 6863 RVA: 0x00091580 File Offset: 0x0008F780
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		if (base.h().aa().SpecialStates.l)
		{
			return false;
		}
		ItemSlot<coh> itemSlot = base.h().aa().Gear.d()[0];
		if (itemSlot.Enabled && itemSlot.Item != null)
		{
			foreach (aia aia in itemSlot.Item.Definition.a2())
			{
				if (aia != null && aia.Value is b2v)
				{
					eu7 eu = ecf.a(aia.Value, new eru(new EntityAspectReference<amc, amc>(base.h())), itemSlot.Item) as eu7;
					return eu != null && eu.yw() && this.a(base.h()) != null;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06001AD0 RID: 6864 RVA: 0x00091698 File Offset: 0x0008F898
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		ItemSlot<coh> itemSlot = base.h().aa().Gear.d()[0];
		if (itemSlot.Enabled && itemSlot.Item != null)
		{
			foreach (aia aia in itemSlot.Item.Definition.a2())
			{
				if (aia != null && aia.Value is b2v)
				{
					eu7 eu = ecf.a(aia.Value, new eru(new EntityAspectReference<amc, amc>(base.h())), itemSlot.Item) as eu7;
					object obj = this.a(base.h());
					if (eu != null && eu.yw() && obj != null)
					{
						return cp.b(eu, this.Subject.a8(), obj);
					}
				}
			}
		}
		return null;
	}

	// Token: 0x020003EA RID: 1002
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001AD3 RID: 6867 RVA: 0x000917C0 File Offset: 0x0008F9C0
		internal float a(bool A_0)
		{
			if (!A_0)
			{
				return 1.09f;
			}
			return 100f;
		}

		// Token: 0x04000EFD RID: 3837
		public static readonly d12.a a = new d12.a();

		// Token: 0x04000EFE RID: 3838
		public static Func<bool, float> b;
	}
}
