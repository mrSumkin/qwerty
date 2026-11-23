using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020016E9 RID: 5865
[eiz("LABA")]
[Serializable]
public sealed class bo0 : a6k, ISerializable
{
	// Token: 0x06007F80 RID: 32640 RVA: 0x0035FFA0 File Offset: 0x0035E1A0
	private bo0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F81 RID: 32641 RVA: 0x0035FFAC File Offset: 0x0035E1AC
	public bo0()
	{
	}

	// Token: 0x06007F82 RID: 32642 RVA: 0x0035FFB4 File Offset: 0x0035E1B4
	protected override dc4 dt()
	{
		return base.dt();
	}

	// Token: 0x06007F83 RID: 32643 RVA: 0x0035FFBC File Offset: 0x0035E1BC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		bool flag = c2h.a(base.vg().e());
		string a_;
		string text;
		if (flag)
		{
			a_ = "RustingAcidBlob";
			text = "RustingAcidSplash";
		}
		else
		{
			a_ = "AcidBlob";
			text = "acidSplash";
		}
		b0b b0b;
		dvv item = es2.a(base.vg().q(), c5x, a_, 0.5f, null, out b0b, true, 0.5f);
		if (b0b != null && b0b.Zone != null)
		{
			bfq a_2 = new bfq("AcidBlob");
			qy.ad().Add(new a4s(a_2, null, new ar7(base.vg().q()), null));
			qy.ad().Add(item);
			c7 item2 = new c7(b0b, false, false, true, false);
			qy.ad().Add(item2);
			bfq a_3 = new bfq("AcidBlobBigHit");
			qy.ad().Add(new a4s(a_3, null, new ar7(c5x), null));
			bfq a_4 = new bfq("AcidFizz");
			qy.ad().Add(new a4s(a_4, null, new ar7(c5x), null));
			c5x a_5 = c5x;
			string a_6 = text;
			int a_7 = 1;
			double maxValue = double.MaxValue;
			bool a_8 = true;
			bool a_9 = true;
			float? a_10 = dz6.b();
			a7j item3 = new a7j(a_5, a_6, a_7, maxValue, a_8, a_9, null, null, null, a_10, false, null);
			qy.ad().Add(item3);
			ak1 ak = c5x.Area.a(c5x.aj().a());
			if (ak != null)
			{
				if (flag)
				{
					qy.ad().Add(new a4s(new amg(new edx(ak), new EntityAspectReference<amc, amc>(base.vg().q().h.b)), null, null, null));
				}
				else
				{
					qy.ad().Add(new a4s(new dku(new edx(ak), new EntityAspectReference<amc, amc>(base.vg().q().h.b), false, true, false), null, null, null));
				}
			}
			awq.a(qy, base.vg().q(), c5x, true, true);
			bool flag2 = bo0.a(base.vg().e().b8(), c5x.h.b.aa());
			cwt cwt = new cwt();
			cwt.i = new ap9(base.vg().e().b8());
			cwt.b = flag2;
			cwt.e = (flag2 && cuo.a.NextDouble() < 0.05);
			cwt.h = ImpactSpeed.VeryLow;
			cwt.f.Add(euf.a(byc.b(base.vg().e()), (double)(cwt.e ? 2 : 1)));
			if (flag)
			{
				cwt.x = AmmoType.Vial_Acid_Rusting;
			}
			if (flag)
			{
				cwt.k = "Сгусток кислоты";
			}
			else
			{
				cwt.k = "Сгусток кислотой ржавчины";
			}
			qy.ad().Add(new akg(base.vg().q().h.b, c5x.h.b, cwt, null, false));
			if (flag2 && flag)
			{
				qy.ad().Add(new amd(c5x.h.b, new els[]
				{
					new ce(ce.b * d0u.b)
				}));
			}
			if (c5x.h.b.aa().d(CharacterImmunities.Root))
			{
				etm a_11 = new etm(new ap9(c5x.h.b.aa()), "обездвиживанию");
				bey.a(a_11, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
				anw item4 = new anw(a_11);
				b8p item5 = new b8p(c5x, new ba0());
				qy.ad().Add(item4);
				qy.ad().Add(item5);
			}
			else if (flag2 && !euf.k(c5x.h.b.aa()))
			{
				els els;
				if (flag)
				{
					int num = byc.c(base.vg().e());
					if (c5x.h.b.aa().b(d8o.e))
					{
						num = Convert.ToInt32((double)num * (1.0 + d9b.a));
					}
					els = new bgv(base.vg().e().b8(), byc.a(base.vg().e()), num);
				}
				else
				{
					els = new e32(base.vg().e().b8(), byc.a(base.vg().e()), byc.c(base.vg().e()));
				}
				amd item6 = new amd(c5x.h.b, new els[]
				{
					els
				});
				qy.ad().Add(item6);
				vr a_12 = new vr(new ap9(c5x.h.b.aa()), new ap9(base.vg().e().b8()), "{0}: опутывание.", new Color?(adi.j), null);
				bey.a(a_12, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
				anw item7 = new anw(a_12);
				qy.ad().Add(item7);
			}
			else
			{
				bjq a_13 = new bjq(new ap9(c5x.h.b.aa()), new ap9(base.vg().e().b8()), "кислотного опутывания");
				bey.a(a_13, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
				anw item8 = new anw(a_13);
				qy.ad().Add(item8);
			}
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06007F84 RID: 32644 RVA: 0x00360658 File Offset: 0x0035E858
	private static bool a(efk A_0, efk A_1)
	{
		return !euf.b(byc.a(A_0), A_1);
	}
}
