using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000395 RID: 917
[fe("exodoc")]
public class eol : b5g
{
	// Token: 0x06001963 RID: 6499 RVA: 0x00085E54 File Offset: 0x00084054
	public eol(bm6 A_0) : base(A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new byh("HealAllyOrSelf", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(eol.a.a.a), null)
		{
			e = false
		});
		base.a(list);
	}

	// Token: 0x06001964 RID: 6500 RVA: 0x00085EC8 File Offset: 0x000840C8
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

	// Token: 0x06001965 RID: 6501 RVA: 0x000860D4 File Offset: 0x000842D4
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

	// Token: 0x06001966 RID: 6502 RVA: 0x000861EC File Offset: 0x000843EC
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

	// Token: 0x02000396 RID: 918
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001969 RID: 6505 RVA: 0x00086314 File Offset: 0x00084514
		internal float a(bool A_0)
		{
			if (!A_0)
			{
				return 1.09f;
			}
			return 100f;
		}

		// Token: 0x04000E7F RID: 3711
		public static readonly eol.a a = new eol.a();

		// Token: 0x04000E80 RID: 3712
		public static Func<bool, float> b;
	}
}
