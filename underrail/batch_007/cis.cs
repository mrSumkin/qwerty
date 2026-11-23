using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001421 RID: 5153
[bs6("CrawlerPoisonExpiresAction")]
[eiz("CPEAX")]
[Serializable]
public sealed class cis : bhv, ISerializable
{
	// Token: 0x06007393 RID: 29587 RVA: 0x0030BD4C File Offset: 0x00309F4C
	private cis(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007394 RID: 29588 RVA: 0x0030BD58 File Offset: 0x00309F58
	public cis()
	{
	}

	// Token: 0x06007395 RID: 29589 RVA: 0x0030BD60 File Offset: 0x00309F60
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x0().a() != null && base.x2() != null && base.x2().a8() != null)
		{
			if (base.x2().aa().c(d8o.e) || base.x2().aa().d(CharacterImmunities.Stun))
			{
				etm a_ = new etm(new ap9(base.x2().aa()), "эффекту оглушения");
				bey.a(a_, base.x2().aa(), base.x2());
				a7v.a(a_);
				bmj.a(base.x2().a8(), new ba0());
			}
			else if (euf.l(base.x2().aa()))
			{
				c6f a_2 = new c6f(new ap9(base.x2().aa()), null, "оглушению");
				bey.a(a_2, base.x2().aa(), base.x2());
				a7v.a(a_2);
				bmj.a(base.x2().a8(), new dym());
			}
			else
			{
				string str;
				els els = awq.a(base.x2().aa(), ezx.f * d0u.b, out str);
				base.x2().aa().StatusEffects.a(els, false, false, false);
				vr a_3 = new vr(new ap9(base.x2().aa()), null, "{0}: " + str + ".", new Color?(adi.j), null);
				base.x2().a8().c().a(Guid.NewGuid().ToString(), "Stun", 1f, c9z.a, false, false);
				bey.a(a_3, base.x2().aa(), base.x2());
				a7v.a(a_3);
				ddr ddr = base.xy() as ddr;
				if (ddr != null)
				{
					vf vf = Enumerable.FirstOrDefault<vf>(Enumerable.OfType<vf>(ddr.DynamicEffects));
					if (els is ab3 && vf != null && vf.TurnTickAttack != null && vf.TurnTickAttack.i != null && vf.TurnTickAttack.i.b == asp.a)
					{
						cxc.a(eyy.by);
					}
				}
			}
		}
		return dc4.c;
	}
}
