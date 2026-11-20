using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200136F RID: 4975
[bs6("HFX:dazeSelfOnAttack")]
[eiz("DSOAHEA")]
[Serializable]
public sealed class aci : cpl, ISerializable
{
	// Token: 0x060070C9 RID: 28873 RVA: 0x002F5954 File Offset: 0x002F3B54
	private aci(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060070CA RID: 28874 RVA: 0x002F5960 File Offset: 0x002F3B60
	public aci()
	{
	}

	// Token: 0x060070CB RID: 28875 RVA: 0x002F5968 File Offset: 0x002F3B68
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.agu() == null || base.a() == null || base.a().aa() == null || base.a().aa().Dead)
		{
			return dc4.e;
		}
		if (base.a().aa().Passive || base.a().aa().c(d8o.e) || base.a().aa().d(CharacterImmunities.Daze))
		{
			etm a_ = new etm(new ap9(base.a().aa()), "дезориентации");
			bey.a(a_, base.agw(), base.a());
			a7v.a(a_);
			bmj.a(base.a().a8(), new ba0());
		}
		else if (euf.l(base.a().aa()))
		{
			c6f a_2 = new c6f(new ap9(base.a().aa()), (base.a() != null) ? new ap9(base.a().aa()) : null, "дезориентации");
			bey.a(a_2, base.agw(), base.a());
			a7v.a(a_2);
			bmj.a(base.a().a8(), new dym());
		}
		else
		{
			base.a().aa().StatusEffects.a(new eok(base.agu().Power * d0u.b), false, false, false);
			vr a_3 = new vr(new ap9(base.a().aa()), null, "{0}: дезориентация.", new Color?(adi.j), null);
			base.a().a8().c().a(Guid.NewGuid().ToString(), "Stun", 1f, c9z.a, false, false);
			bey.a(a_3, base.agw(), base.a());
			a7v.a(a_3);
		}
		return dc4.c;
	}
}
