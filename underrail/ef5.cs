using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001AD6 RID: 6870
[eiz("HBPSE")]
[Serializable]
public sealed class ef5 : els, ISerializable, dl2
{
	// Token: 0x060094E6 RID: 38118 RVA: 0x003A7EE0 File Offset: 0x003A60E0
	private ef5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060094E7 RID: 38119 RVA: 0x003A7EEC File Offset: 0x003A60EC
	public override bool as2()
	{
		return false;
	}

	// Token: 0x060094E8 RID: 38120 RVA: 0x003A7EF0 File Offset: 0x003A60F0
	public ef5(efk A_0, int A_1, int A_2) : base(ef5.a, "Яд (сердцеед)", ci8.c)
	{
		base.Duration = A_1;
		base.Icon = "Status.Poison";
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		base.MaxStacks = ezx.x;
		base.ExpiredAction = "HeartbreakPoisonExpiresAction";
		base.Power = A_2;
		cwt cwt = new cwt();
		cwt.i = new ap9("Poison", (A_0 != null) ? A_0.FactionId : null);
		cwt.f.Add(new csk(DamageType.Bio, A_2));
		cwt.l = true;
		cwt.p = true;
		cwt.r = true;
		cwt.b = true;
		cwt.w = true;
		cwt.ag = true;
		base.DynamicEffects.Add(new vf(cwt, cwt, null));
	}

	// Token: 0x060094E9 RID: 38121 RVA: 0x003A7FC8 File Offset: 0x003A61C8
	public override string cb(ll A_0)
	{
		int num = ((vf)base.DynamicEffects[0]).TurnTickAttack.f[0].Amount;
		double num2 = (double)cl5.a(base.Power, base.Stacks);
		return qv.a("StatusEffects/HeartbreakPoison", new object[]
		{
			num,
			num2
		});
	}

	// Token: 0x060094EA RID: 38122 RVA: 0x003A8034 File Offset: 0x003A6234
	protected override void c8()
	{
		base.c8();
		((vf)base.DynamicEffects[0]).TurnTickAttack.f[0] = new csk(DamageType.Bio, base.Power * base.Stacks);
	}

	// Token: 0x04003959 RID: 14681
	public new static string a = "poison:HeartbreakPoison";
}
