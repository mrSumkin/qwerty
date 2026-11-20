using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A9F RID: 6815
[eiz("BP01")]
[Serializable]
public sealed class vs : els, ISerializable, dl2
{
	// Token: 0x060093E1 RID: 37857 RVA: 0x003A422C File Offset: 0x003A242C
	private vs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060093E2 RID: 37858 RVA: 0x003A4238 File Offset: 0x003A2438
	public vs(efk A_0, int A_1, int A_2) : base(vs.a, "Яд (слепитель)", ci8.c)
	{
		base.Duration = A_1;
		base.Icon = "Status.Poison";
		base.MaxStacks = ezx.n;
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		base.Power = A_2;
		cwt cwt = new cwt();
		cwt.i = new ap9("Poison", (A_0 != null) ? A_0.FactionId : null);
		cwt.f.Add(new csk(DamageType.Bio, base.Power * base.Stacks));
		cwt.l = true;
		cwt.p = true;
		cwt.r = true;
		cwt.b = true;
		cwt.w = true;
		cwt.ag = true;
		base.DynamicEffects.Add(new vf(cwt, cwt, null));
		base.StaticEffects.Add(new ax6("Perception", -base.Stacks * ezx.m));
	}

	// Token: 0x060093E3 RID: 37859 RVA: 0x003A4334 File Offset: 0x003A2534
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/BlindingPoison", new object[]
		{
			base.Power * base.Stacks,
			base.Stacks * ezx.m
		});
	}

	// Token: 0x060093E4 RID: 37860 RVA: 0x003A437C File Offset: 0x003A257C
	protected override void c8()
	{
		vf vf = (vf)base.DynamicEffects[0];
		vf.DynamicTickAttack.f[0] = new csk(DamageType.Bio, base.Power * base.Stacks);
		vf.TurnTickAttack = vf.DynamicTickAttack;
		((ax6)base.StaticEffects[0]).a(-base.Stacks * ezx.m);
	}

	// Token: 0x040038D2 RID: 14546
	public new static readonly string a = "poison:blinding";
}
