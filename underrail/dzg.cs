using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020016C6 RID: 5830
[eiz("SLPCA")]
[Serializable]
public sealed class dzg : a6k, ISerializable
{
	// Token: 0x06007F09 RID: 32521 RVA: 0x0035BA80 File Offset: 0x00359C80
	private dzg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F0A RID: 32522 RVA: 0x0035BA8C File Offset: 0x00359C8C
	public dzg()
	{
	}

	// Token: 0x06007F0B RID: 32523 RVA: 0x0035BA98 File Offset: 0x00359C98
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.Area == null || c5x.h.b == null || base.vg().q() == null || base.vg().q().i.b == null || base.vg().q().h.b == null || base.vg().q().h.b.aa().Vehicle == null)
		{
			return dc4.e;
		}
		base.vg().i();
		b0b b0b = null;
		dvv item = es2.a(base.vg().q(), c5x, "Plasma", 0.5f, null, out b0b, true, 0.5f);
		if (b0b != null && b0b.Zone != null)
		{
			((c5x)b0b).ae = new float?(0f);
			CharacterState characterState = (base.vg().e().b8().CustomProperties.GetPrimitivePropertyValue<CharacterState>("LastPlasmaLeviatorAttackAnim", new CharacterState?(CharacterState.Custom4)).Value == CharacterState.Custom4) ? CharacterState.Custom5 : CharacterState.Custom4;
			base.vg().e().b8().CustomProperties["LastPlasmaLeviatorAttackAnim"] = characterState;
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			awx.b(false);
			awx.c(false);
			awx.ad().Add(new e4t(base.vg().q().h.b, characterState, dz6.b(100), 0, null, 1));
			base.vg().q().i.b.b(awx, atp.a);
			base.vg().q().h.b.aa().Vehicle.h((double)b0o.f);
			dtb dtb = new dtb();
			dtb.b(false);
			dtb.c(false);
			dtb.ad().Add(new bm3(dz6.b(200)));
			List<auv> list = dtb.ad();
			ch3 ch = new ch3();
			ch.a(null);
			list.Add(new a4s(ch, null, new ar7(b0b), null));
			dtb.ad().Add(new a4s(new bfq("PlasmaShoot"), null, new ar7(base.vg().q()), null));
			dtb.ad().Add(item);
			double a_ = aw1.b(base.vg().q(), c5x);
			cmn a_2 = new cmn();
			bg3 bg = euf.a(base.vg().e().b8(), c5x.h.b.aa(), a_, c5x.l(), base.vg().e().b8().Darkvision, AmmoType.None, false, 1.0, a_2, b0o.a(base.vg().e()), new int?(euf.a(base.vg().e().b8(), true)));
			cwt cwt = new cwt();
			cwt.b = (cuo.a.NextDouble() < bg.a);
			cwt.e = (!c5x.h.b.aa().d(CharacterImmunities.CriticalHits) && cuo.a.NextDouble() < 0.05);
			cwt.f.AddRange(b0o.a(base.vg().e(), (double)(cwt.e ? 2 : 1)));
			cwt.x = AmmoType.Energy;
			cwt.i = new ap9(base.vg().e().b8());
			cwt.j = new ap9(c5x.h.b.aa());
			cwt.h = ImpactSpeed.VeryHigh;
			cwt.k = "Плазменная пушка";
			string a_3 = null;
			string a_4 = null;
			string a_5 = null;
			string a_6 = null;
			float a_7 = 0f;
			float a_8 = 0f;
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
