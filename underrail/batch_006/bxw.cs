using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020016B8 RID: 5816
[eiz("HYA0")]
[Serializable]
public sealed class bxw : a6k, ISerializable
{
	// Token: 0x06007ED8 RID: 32472 RVA: 0x0035962C File Offset: 0x0035782C
	private bxw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007ED9 RID: 32473 RVA: 0x00359638 File Offset: 0x00357838
	public bxw()
	{
	}

	// Token: 0x06007EDA RID: 32474 RVA: 0x00359644 File Offset: 0x00357844
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h == null || c5x.h.b == null)
		{
			return dc4.e;
		}
		if (base.vg().e().b8().Gear.g().Value == null && base.vg().e().b8().Gear.g().Value.Battery >= (double)aoa.f)
		{
			return dc4.e;
		}
		base.vg().e().b8().Gear.g().Value.Battery -= (double)aoa.f;
		if (!c5x.h.b.aa().Passive && !c5x.h.b.aa().b(d8o.e))
		{
			boj.a(c5x, "Hypnotize", 1, double.MaxValue, true, true, new Vector3?(new Vector3(0f, 0f, c5x.Size.Z * 0.4f)), null, null, null, false);
			c5x.c().a("Hypnotize");
			awq.a(base.vg().q(), c5x, true, true, true, true, false, false);
		}
		if (c5x.h.b.aa().Passive || c5x.h.b.aa().b(d8o.e) || !c5x.h.b.aa().b(d8o.b | d8o.c) || c5x.h.b.aa().d(CharacterImmunities.MindAffecting | CharacterImmunities.Incapacitation | CharacterImmunities.MindControl))
		{
			etm a_ = new etm(new ap9(c5x.h.b.aa()), "hypnotization");
			bey.a(a_, base.vg().q().h.b.aa(), c5x.h.b.aa(), c5x.h.b);
			a7v.a(a_);
			bmj.a(c5x, new ba0());
		}
		else
		{
			double num = aoa.a(base.vg().q().h.b.aa(), c5x.h.b.aa());
			if (cuo.a.NextDouble() < num)
			{
				cjy a_2 = new cjy(aoa.b * d0u.b);
				c5x.h.b.aa().StatusEffects.a(a_2, false, false, false);
				if (c5x != null && c5x.t.b != null)
				{
					c5x.t.b.ah();
				}
				if (base.vg().q().IsPlayer && !c5x.IsPlayer)
				{
					cxc.a(eyy.b0);
				}
			}
			else
			{
				c6f a_3 = new c6f(new ap9(c5x.h.b.aa()), new ap9(base.vg().q().h.b.aa()), "hypnotization");
				bey.a(a_3, base.vg().q().h.b.aa(), c5x.h.b.aa(), c5x.h.b);
				a7v.a(a_3);
				bmj.a(c5x, new dym());
			}
		}
		return dc4.c;
	}
}
