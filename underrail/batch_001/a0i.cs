using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200148A RID: 5258
[eiz("TA9")]
[Serializable]
public sealed class a0i : a6k, ISerializable
{
	// Token: 0x06007684 RID: 30340 RVA: 0x00322484 File Offset: 0x00320684
	private a0i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007685 RID: 30341 RVA: 0x00322490 File Offset: 0x00320690
	public a0i()
	{
	}

	// Token: 0x06007686 RID: 30342 RVA: 0x0032249C File Offset: 0x0032069C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		a1q a_ = c09.a();
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
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(cru.a, new Func<csk, bool>(a0i.a.a.a)), new Func<csk, int>(a0i.a.a.b)) > 0)
			{
				if ((!c5x.h.b.aa().c(d8o.e) && !c5x.h.b.aa().d(CharacterImmunities.Stun)) || (c5x.h.b.aa().c(d8o.e) && !c5x.h.b.aa().d(CharacterImmunities.ShortCircuiting)))
				{
					if (c5x.h.b.aa().c(d8o.e) || a0i.a(base.vg().q().h.b.aa(), c5x.h.b.aa()))
					{
						vr a_8;
						if (c5x.h.b.aa().c(d8o.e))
						{
							c5x.h.b.aa().StatusEffects.a(new clt(d0u.b), false, false, false);
							a_8 = new vr(new ap9(c5x.h.b.aa()), new ap9(base.vg().e().b8()), "{0}: короткое замыкание.", new Color?(adi.j), null);
							if (base.vg().e().b8() is e3q && !(c5x.h.b.aa() is e3q))
							{
								cxc.a(eyy.bz);
							}
						}
						else
						{
							string str;
							els els = awq.a(c5x.h.b.aa(), d0u.b, out str);
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

	// Token: 0x06007687 RID: 30343 RVA: 0x00322A54 File Offset: 0x00320C54
	private static bool a(efk A_0, efk A_1)
	{
		return !A_1.Passive && !euf.l(A_1);
	}

	// Token: 0x0200148B RID: 5259
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600768A RID: 30346 RVA: 0x00322A80 File Offset: 0x00320C80
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Electricity;
		}

		// Token: 0x0600768B RID: 30347 RVA: 0x00322A8C File Offset: 0x00320C8C
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04003042 RID: 12354
		public static readonly a0i.a a = new a0i.a();

		// Token: 0x04003043 RID: 12355
		public static Func<csk, bool> b;

		// Token: 0x04003044 RID: 12356
		public static Func<csk, int> c;
	}
}
