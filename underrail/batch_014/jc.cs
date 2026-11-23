using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200147F RID: 5247
[eiz("TAY")]
[Serializable]
public sealed class jc : a6k, ISerializable
{
	// Token: 0x0600765E RID: 30302 RVA: 0x00320D60 File Offset: 0x0031EF60
	private jc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600765F RID: 30303 RVA: 0x00320D6C File Offset: 0x0031EF6C
	public jc()
	{
	}

	// Token: 0x06007660 RID: 30304 RVA: 0x00320D78 File Offset: 0x0031EF78
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		a1q a_ = esn.b(base.vg().e());
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.i = new ap9(base.vg().e().b8());
		cwt.j = new ap9(c5x.h.b.aa());
		cwt.f = new List<csk>
		{
			euf.a(a_, 1.0)
		};
		cwt.l = true;
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.ad["IsEnergyWeapon"] = true;
		c5x a_2 = c5x;
		string a_3 = "Electricity";
		int maxValue = int.MaxValue;
		double a_4 = (double)dz6.b(300);
		bool a_5 = true;
		bool a_6 = true;
		float? a_7 = dz6.b();
		boj.a(a_2, a_3, maxValue, a_4, a_5, a_6, null, null, null, a_7, false);
		c5x.c().a(Guid.NewGuid().ToString(), "Tazer", 1f, c9z.a, false, false);
		eym.a(c5x, (double)aju.bf);
		cru cru = c5x.h.b.aa().Defense.a(cwt);
		awq.a(base.vg().q(), c5x, true, true, true, true, false, false);
		if (cru.a != null)
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(cru.a, new Func<csk, bool>(jc.a.a.a)), new Func<csk, int>(jc.a.a.b)) > 0)
			{
				if ((!c5x.h.b.aa().c(d8o.e) && !c5x.h.b.aa().d(CharacterImmunities.Stun)) || (c5x.h.b.aa().c(d8o.e) && !c5x.h.b.aa().d(CharacterImmunities.ShortCircuiting)))
				{
					if (c5x.h.b.aa().c(d8o.e) || jc.a(base.vg().q().h.b.aa(), c5x.h.b.aa()))
					{
						vr a_8;
						if (c5x.h.b.aa().c(d8o.e))
						{
							c5x.h.b.aa().StatusEffects.a(new clt(d0u.b * esn.c), false, false, false);
							a_8 = new vr(new ap9(c5x.h.b.aa()), new ap9(base.vg().e().b8()), "{0}: короткое замыкание.", new Color?(adi.j), null);
							if (base.vg().e().b8() is e3q && !(c5x.h.b.aa() is e3q))
							{
								cxc.a(eyy.bz);
							}
						}
						else
						{
							string str;
							els els = awq.a(c5x.h.b.aa(), d0u.b * esn.c, out str);
							c5x.h.b.aa().StatusEffects.a(els, false, false, false);
							a_8 = new vr(new ap9(c5x.h.b.aa()), new ap9(base.vg().e().b8()), "{0}: " + str + ".", new Color?(adi.j), null);
							if (base.vg().e().b8() is e3q && !(c5x.h.b.aa() is e3q) && els is ab3)
							{
								cxc.a(eyy.by);
							}
						}
						bey.a(a_8, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
						a7v.a(a_8);
					}
					else
					{
						c6f a_9 = new c6f(new ap9(c5x.h.b.aa()), new ap9(base.vg().e().b8()), "оглушению");
						bey.a(a_9, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
						a7v.a(a_9);
						bmj.a(c5x, new dym());
					}
				}
				else
				{
					etm a_10;
					if (c5x.h.b.aa().c(d8o.e))
					{
						a_10 = new etm(new ap9(c5x.h.b.aa()), "короткому замыканию");
					}
					else
					{
						a_10 = new etm(new ap9(c5x.h.b.aa()), "оглушению");
					}
					bey.a(a_10, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
					a7v.a(a_10);
					bmj.a(c5x, new ba0());
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x06007661 RID: 30305 RVA: 0x00321348 File Offset: 0x0031F548
	private static bool a(efk A_0, efk A_1)
	{
		return !A_1.Passive && !euf.l(A_1);
	}

	// Token: 0x02001480 RID: 5248
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007664 RID: 30308 RVA: 0x00321374 File Offset: 0x0031F574
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Electricity;
		}

		// Token: 0x06007665 RID: 30309 RVA: 0x00321380 File Offset: 0x0031F580
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x0400303F RID: 12351
		public static readonly jc.a a = new jc.a();

		// Token: 0x04003040 RID: 12352
		public static Func<csk, bool> b;

		// Token: 0x04003041 RID: 12353
		public static Func<csk, int> c;
	}
}
