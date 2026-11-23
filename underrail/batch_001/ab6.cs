using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001AD9 RID: 6873
[eiz("LPSE")]
[Serializable]
public sealed class ab6 : els, ISerializable, dl2
{
	// Token: 0x060094F5 RID: 38133 RVA: 0x003A827C File Offset: 0x003A647C
	private ab6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060094F6 RID: 38134 RVA: 0x003A8288 File Offset: 0x003A6488
	public ab6(efk A_0, int A_1, int A_2) : base(ab6.a, "Яд (прокажённый змей)", ci8.c)
	{
		base.Duration = A_1;
		base.Icon = "Status.Poison";
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		base.MaxStacks = ezx.s;
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
		e3r item = new e3r(DamageType.Mechanical, ezx.r);
		base.StaticEffects.Add(item);
	}

	// Token: 0x060094F7 RID: 38135 RVA: 0x003A836C File Offset: 0x003A656C
	public override string cb(ll A_0)
	{
		int num = ((vf)base.DynamicEffects[0]).TurnTickAttack.f[0].Amount;
		double num2 = ((e3r)base.StaticEffects[0]).Value;
		return qv.a("StatusEffects/LeperPoison", new object[]
		{
			num,
			(int)(num2 * 100.0)
		});
	}

	// Token: 0x060094F8 RID: 38136 RVA: 0x003A83E8 File Offset: 0x003A65E8
	protected override void c8()
	{
		base.c8();
		((vf)base.DynamicEffects[0]).TurnTickAttack.f[0] = new csk(DamageType.Bio, base.Power * base.Stacks);
		((e3r)base.StaticEffects[0]).Value = ezx.r * (double)base.Stacks;
	}

	// Token: 0x0400395C RID: 14684
	public new static string a = "poison:LeperPoison";
}
