using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013B5 RID: 5045
[eiz("AYZ1")]
[bs6("HFX:incendiaryIgnite")]
[Serializable]
public sealed class b9y : cpl, ISerializable
{
	// Token: 0x060071BD RID: 29117 RVA: 0x002FC0B0 File Offset: 0x002FA2B0
	private b9y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071BE RID: 29118 RVA: 0x002FC0BC File Offset: 0x002FA2BC
	public b9y()
	{
	}

	// Token: 0x060071BF RID: 29119 RVA: 0x002FC0C8 File Offset: 0x002FA2C8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (!base.agw().b)
		{
			return dc4.c;
		}
		awq.a(base.b(), true);
		if (!base.b().aa().Passive)
		{
			if (base.b().aa().d(CharacterImmunities.Burning) || base.b().aa().Defense.af()[DamageType.Heat].c() >= 1.0)
			{
				etm a_ = new etm(new ap9(base.b().aa()), "burning");
				bey.a(a_, base.agw(), base.b());
				a7v.a(a_);
				bmj.a(base.b().a8(), new ba0());
			}
			else
			{
				a1q a_2 = bm9.a(base.agu());
				int num = bm9.b(base.agu());
				int a_3 = (int)Math.Max(1.0, (double)euf.a(a_2, 1.0).Amount * Math.Max(0.0, 1.0 - base.b().aa().Defense.af()[DamageType.Heat].c()) / (double)(num / d0u.b));
				base.b().aa().StatusEffects.a(new bk9(base.a().aa(), num, a_3, false), false, false, false);
				dd5.a(base.b().aa());
				vr a_4 = new vr(new ap9(base.b().aa()), (base.a() != null) ? new ap9(base.a().aa()) : null, "{0} горит.", new Color?(adi.j), null);
				bey.a(a_4, base.agw(), base.b());
				a7v.a(a_4);
				if (base.a().a8().IsPlayer && !base.b().a8().IsPlayer)
				{
					cxc.a(eyy.b1);
				}
			}
		}
		return dc4.c;
	}
}
