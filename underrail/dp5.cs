using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020015EB RID: 5611
[eiz("SGJLGA")]
[Serializable]
public sealed class dp5 : a6k, ISerializable
{
	// Token: 0x06007B9B RID: 31643 RVA: 0x0033B700 File Offset: 0x00339900
	private dp5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007B9C RID: 31644 RVA: 0x0033B70C File Offset: 0x0033990C
	public dp5()
	{
	}

	// Token: 0x06007B9D RID: 31645 RVA: 0x0033B718 File Offset: 0x00339918
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		CharacterState characterState = CharacterState.Custom4;
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.Area == null || c5x.h.b == null || base.vg().q() == null || base.vg().q().i.b == null || base.vg().q().h.b == null || base.vg().q().h.b.aa().Vehicle == null)
		{
			return dc4.e;
		}
		base.vg().i();
		b0b b0b = null;
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		for (int i = 0; i < ba3.d; i++)
		{
			dvv item = es2.a(base.vg().q(), c5x, "RedLaser", 0.5f, null, out b0b, true, 0.85f);
			if (b0b == null || b0b.Zone == null)
			{
				return dc4.e;
			}
			((c5x)b0b).ae = new float?(0f);
			characterState = ((characterState == CharacterState.Custom4) ? CharacterState.Custom5 : CharacterState.Custom4);
			base.vg().q().h.b.aa().Vehicle.h((double)ba3.e);
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			awx.b(false);
			awx.c(false);
			awx.ad().Add(new e4t(base.vg().q().h.b, characterState, dz6.b(100), 0, null, 1));
			dtb dtb2 = new dtb();
			dtb2.b(false);
			dtb2.c(false);
			List<auv> list = dtb2.ad();
			ch3 ch = new ch3();
			ch.a(null);
			list.Add(new a4s(ch, null, new ar7(b0b), null));
			dtb2.ad().Add(new a4s(new bfq("LaserShoot"), null, new ar7(base.vg().q()), null));
			dtb2.ad().Add(item);
			double a_ = aw1.b(base.vg().q(), c5x);
			cmn a_2 = new cmn();
			bg3 bg = euf.a(base.vg().e().b8(), c5x.h.b.aa(), a_, c5x.l(), base.vg().e().b8().Darkvision, AmmoType.None, false, 1.0, a_2, ba3.a(base.vg().e()), new int?(euf.a(base.vg().e().b8(), false)));
			cwt cwt = new cwt();
			cwt.b = (cuo.a.NextDouble() < bg.a);
			cwt.e = (!c5x.h.b.aa().d(CharacterImmunities.CriticalHits) && cuo.a.NextDouble() < 0.05);
			cwt.f.AddRange(ba3.a(base.vg().e(), (double)(cwt.e ? 2 : 1)));
			cwt.x = AmmoType.Energy;
			cwt.i = new ap9(base.vg().e().b8());
			cwt.j = new ap9(c5x.h.b.aa());
			cwt.h = ImpactSpeed.VeryHigh;
			cwt.k = "Лазерное оружие";
			string a_3 = null;
			string a_4 = null;
			string a_5 = null;
			string a_6 = null;
			float a_7 = 0f;
			float a_8 = 0f;
			awq.a(c5x.h.b, new esu?(esu.g), out a_3, out a_4, out a_5, out a_6, out a_7, out a_8, null, false);
			kg a_9 = new kg(null, a_3, a_4, a_5, a_6, a_7, a_8);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			dtb2.ad().Add(c);
			akg item2 = new akg(base.vg().q().h.b, c5x.h.b, cwt, a_9, false);
			dtb2.ad().Add(item2);
			awq.a(dtb2, base.vg().q(), c5x, true, true);
			dtb.ad().Add(new ew9(new EntityAspectReference<ny, ny>(base.vg().q().i.b), awx, atp.a));
			dtb.ad().Add(new bm3(dz6.b(200)));
			dtb.ad().Add(new ew9(new EntityAspectReference<ny, ny>(base.vg().q().i.b), dtb2, atp.a));
			dtb.ad().Add(new bm3(dz6.b(200)));
		}
		base.vg().q().i.b.b(dtb, atp.a);
		return dc4.c;
	}
}
