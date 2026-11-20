using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020016C5 RID: 5829
[eiz("SLSA")]
[Serializable]
public sealed class aa7 : a6k, ISerializable
{
	// Token: 0x06007F06 RID: 32518 RVA: 0x0035B570 File Offset: 0x00359770
	private aa7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F07 RID: 32519 RVA: 0x0035B57C File Offset: 0x0035977C
	public aa7()
	{
	}

	// Token: 0x06007F08 RID: 32520 RVA: 0x0035B588 File Offset: 0x00359788
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.Area == null || c5x.h.b == null || base.vg().q() == null || base.vg().q().i.b == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		base.vg().i();
		b0b b0b;
		dvv item = es2.a(base.vg().q(), c5x, "Plasma", 0.5f, out b0b, new Vector3(0f, 0f, -0.65f), null, true, 0.5f, null);
		if (b0b != null && b0b.Zone != null)
		{
			((c5x)b0b).ae = new float?(0f);
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			awx.b(false);
			awx.c(false);
			awx.ad().Add(new e4t(base.vg().q().h.b, CharacterState.Attack1, dz6.b(cux.m), 0, null, 1));
			base.vg().q().i.b.b(awx, atp.a);
			base.vg().q().h.b.aa().Offense.u().Battery = Math.Max(0.0, base.vg().q().h.b.aa().Offense.u().Battery - (double)es.f);
			dtb dtb = new dtb();
			dtb.b(false);
			dtb.c(false);
			dtb.ad().Add(new bm3(dz6.b(cux.m * 3)));
			List<auv> list = dtb.ad();
			ch3 ch = new ch3();
			ch.a(null);
			list.Add(new a4s(ch, null, new ar7(b0b), null));
			dtb.ad().Add(new a4s(new bfq("PlasmaShoot"), null, new ar7(base.vg().q()), null));
			dtb.ad().Add(item);
			double num = aw1.b(base.vg().q(), c5x);
			cmn a_ = new cmn();
			int? a_2 = null;
			if (num <= 2.0)
			{
				a_2 = new int?(base.vg().q().h.b.aa().Skills.Get<jk>().g());
			}
			bg3 bg = euf.a(base.vg().e().b8(), c5x.h.b.aa(), num, c5x.l(), base.vg().e().b8().Darkvision, AmmoType.None, false, 1.0, a_, es.a(base.vg().e()), a_2);
			cwt cwt = new cwt();
			cwt.b = (cuo.a.NextDouble() < bg.a);
			cwt.e = (!c5x.h.b.aa().d(CharacterImmunities.CriticalHits) && cuo.a.NextDouble() < 0.05);
			cwt.f.AddRange(es.a(base.vg().e(), (double)(cwt.e ? 2 : 1)));
			cwt.x = AmmoType.Energy;
			cwt.i = new ap9(base.vg().e().b8());
			cwt.j = new ap9(c5x.h.b.aa());
			cwt.h = ImpactSpeed.VeryHigh;
			cwt.k = "Плазменная пушка";
			string a_3;
			string a_4;
			string a_5;
			string a_6;
			float a_7;
			float a_8;
			awq.a(c5x.h.b, new esu?(esu.l), out a_3, out a_4, out a_5, out a_6, out a_7, out a_8, null, false);
			kg a_9 = new kg(null, a_3, a_4, a_5, a_6, a_7, a_8);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			dtb.ad().Add(c);
			akg item2 = new akg(base.vg().q().h.b, c5x.h.b, cwt, a_9, false);
			dtb.ad().Add(item2);
			awq.a(dtb, base.vg().q(), c5x, true, true);
			base.vg().q().i.b.b(dtb, atp.a);
			return dc4.c;
		}
		return dc4.e;
	}
}
