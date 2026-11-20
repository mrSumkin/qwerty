using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020014E8 RID: 5352
[eiz("TAVA")]
[Serializable]
public abstract class mo : a6k, ISerializable, enp
{
	// Token: 0x06007820 RID: 30752 RVA: 0x003257E8 File Offset: 0x003239E8
	protected mo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007821 RID: 30753 RVA: 0x003257F4 File Offset: 0x003239F4
	public mo()
	{
	}

	// Token: 0x06007822 RID: 30754 RVA: 0x00325800 File Offset: 0x00323A00
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.Area == null || c5x.Zone == null || c5x.h.b == null || base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		base.vg().i();
		cwt cwt = new cwt();
		double num = 1.0;
		double num2 = aw1.b(base.vg().q(), c5x);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		qy qy2 = qy;
		bg3 bg = euf.a(base.vg().e().b8(), c5x.h.b.aa(), Math.Min(num2, (double)base.vg().e().c(c5x)), c5x.l(), base.vg().e().b8().Darkvision, awq.f(base.vg().q().h.b), 1.0, c3u.a, 0.0);
		cwt.b = (cuo.a.NextDouble() < bg.a);
		if (!c5x.h.b.aa().d(CharacterImmunities.CriticalHits))
		{
			cwt.e = (cuo.a.NextDouble() < as3.a0);
		}
		else
		{
			cwt.e = false;
		}
		cwt.x = this.apb();
		cwt.i = new ap9(base.vg().e().b8());
		cwt.j = new ap9(c5x.h.b.aa());
		cwt.h = ImpactSpeed.Low;
		cwt.l = true;
		cwt.k = "колба с кислотой";
		csk item = euf.a(this.apa(), num * (true + (cwt.e > false)));
		cwt.f.Add(item);
		ak1 ak = c5x.Area.a(c5x.aj().a());
		if (!cwt.b)
		{
			int a_ = euf.c(base.vg().e().b8(), num2);
			ak = awq.a(this, ak, a_, false);
		}
		Vector3 vector = (ak != null) ? (ak.Location.a() + new Vector3(0.5f, 0.5f, 0f)) : (c5x.aj() * new Vector3(1f, 1f, 0f));
		b0b b0b;
		dvv item2;
		if (cwt.b)
		{
			item2 = es2.a(base.vg().q(), c5x, this.ao9(), 0.5f, null, out b0b, true, 0.5f);
		}
		else
		{
			item2 = es2.a(base.vg().q(), vector, this.ao9(), out b0b, null, null, true, 0.5f, null);
		}
		if (b0b != null && b0b.Zone != null)
		{
			qy2.ad().Add(new a4s(new bfq("throw", "KnifeThrow"), null, new ar7(base.vg().q()), null));
			qy2.ad().Add(item2);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			qy2.ad().Add(c);
			awq.a(qy2, base.vg().q(), c5x, true, true);
			akg item3 = new akg(base.vg().q().h.b, c5x.h.b, cwt, this, true);
			qy2.ad().Add(item3);
			qy2.ad().Add(new a4s(new bfq("VialBreak"), null, new ar7(c5x), null));
			qy2.ad().Add(new a4s(new bfq("AcidFizz"), null, new ar7(c5x), null));
			if (cwt.b)
			{
				List<auv> list = qy2.ad();
				c5x a_2 = c5x;
				string a_3 = this.ao8();
				int a_4 = 1;
				double maxValue = double.MaxValue;
				bool a_5 = true;
				bool a_6 = false;
				float? num3 = dz6.b();
				list.Add(new a7j(a_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, num3, false, null));
			}
			else
			{
				List<auv> list2 = qy2.ad();
				aud a_7 = c5x.Area;
				Vector3 a_8 = vector.a().a();
				string a_9 = this.ao8();
				int a_10 = 1;
				double maxValue2 = double.MaxValue;
				float? num3 = dz6.b();
				list2.Add(new au0(a_7, a_8, a_9, a_10, maxValue2, null, null, num3));
			}
			if (ak != null)
			{
				qy2.ad().Add(new a4s(this.apc(new edx(ak), new EntityAspectReference<amc, amc>(base.vg().q().h.b)), null, null, null));
			}
			b0b.Zone.ActionManager.g9(qy2, atp.a);
			dz6.a(qy2);
		}
		return dc4.c;
	}

	// Token: 0x06007823 RID: 30755 RVA: 0x00325D44 File Offset: 0x00323F44
	protected virtual AmmoType apb()
	{
		return AmmoType.Vial_Acid;
	}

	// Token: 0x06007824 RID: 30756
	protected abstract string ao8();

	// Token: 0x06007825 RID: 30757
	protected abstract string ao9();

	// Token: 0x06007826 RID: 30758
	protected abstract a1q apa();

	// Token: 0x06007827 RID: 30759
	protected abstract cze apc(edx A_0, EntityAspectReference<amc, amc> A_1);

	// Token: 0x06007828 RID: 30760 RVA: 0x00325D4C File Offset: 0x00323F4C
	public virtual void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
	}
}
