using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200138E RID: 5006
[eiz("SMSOAA")]
[bs6("HFX:stunMeleeSingleOnAttack")]
[Serializable]
public sealed class cq7 : cpl, ISerializable
{
	// Token: 0x06007136 RID: 28982 RVA: 0x002F86D8 File Offset: 0x002F68D8
	private cq7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007137 RID: 28983 RVA: 0x002F86E4 File Offset: 0x002F68E4
	public cq7()
	{
	}

	// Token: 0x06007138 RID: 28984 RVA: 0x002F86F0 File Offset: 0x002F68F0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.a() == null || base.a().a8() == null || base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (!awq.a(base.a(), base.b().a8()))
		{
			return dc4.c;
		}
		if (base.b().aa().c(d8o.e) || base.b().aa().d(CharacterImmunities.Stun))
		{
			etm a_ = new etm(new ap9(base.b().aa()), "эффекту оглушения");
			bey.a(a_, base.agw(), base.b());
			a7v.a(a_);
			bmj.a(base.b().a8(), new ba0());
		}
		else if (euf.l(base.b().aa()))
		{
			c6f a_2 = new c6f(new ap9(base.b().aa()), (base.a() != null) ? new ap9(base.a().aa()) : null, "оглушению");
			bey.a(a_2, base.agw(), base.b());
			a7v.a(a_2);
			bmj.a(base.b().a8(), new dym());
		}
		else
		{
			string str;
			els els = awq.a(base.b().aa(), base.agu().Power * d0u.b, out str);
			base.b().aa().StatusEffects.a(els, false, false, false);
			vr a_3 = new vr(new ap9(base.b().aa()), (base.a() != null) ? new ap9(base.a().aa()) : null, "{0}: " + str + ".", new Color?(adi.j), null);
			base.b().a8().c().a(Guid.NewGuid().ToString(), "Stun", 1f, c9z.a, false, false);
			bey.a(a_3, base.agw(), base.b());
			a7v.a(a_3);
			if (base.a().aa() is e3q && !(base.b().aa() is e3q) && els is ab3)
			{
				cxc.a(eyy.by);
			}
		}
		return dc4.c;
	}
}
