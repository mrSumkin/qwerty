using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B31 RID: 6961
[eiz("P02")]
[Serializable]
public sealed class c2b : els, ISerializable, dl2
{
	// Token: 0x0600968A RID: 38538 RVA: 0x003ADF04 File Offset: 0x003AC104
	private c2b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("P02:P", typeof(vf)) as vf);
		this.b = A_0.GetString("P02:N");
	}

	// Token: 0x0600968B RID: 38539 RVA: 0x003ADF40 File Offset: 0x003AC140
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("P02:P", this.a);
		info.AddValue("P02:N", this.b);
	}

	// Token: 0x0600968C RID: 38540 RVA: 0x003ADF6C File Offset: 0x003AC16C
	public c2b(efk A_0, string A_1, string A_2, int A_3, int A_4, int A_5) : base("poison:" + A_1, string.Format("Яд ({0})", A_2), ci8.c)
	{
		this.b = A_2;
		base.Duration = A_3;
		base.Icon = "Status.Poison";
		base.MaxStacks = A_5;
		base.Stacking = axm.b;
		base.Power = A_4;
		base.TickPeriod = d0u.b;
		cwt cwt = new cwt();
		cwt.i = new ap9("Poison", (A_0 != null) ? A_0.FactionId : null);
		cwt.f.Add(new csk(DamageType.Bio, base.Power * base.Stacks));
		cwt.l = true;
		cwt.p = true;
		cwt.r = true;
		cwt.b = true;
		cwt.w = true;
		cwt.ag = true;
		this.a = new vf(cwt, cwt, null);
		base.DynamicEffects.Add(this.a);
	}

	// Token: 0x0600968D RID: 38541 RVA: 0x003AE064 File Offset: 0x003AC264
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Poison", new object[]
		{
			(this.b != null) ? this.b.ToLowerInvariant() : "неизвестный яд",
			base.Power * base.Stacks
		});
	}

	// Token: 0x0600968E RID: 38542 RVA: 0x003AE0BC File Offset: 0x003AC2BC
	protected override void c8()
	{
		this.a.DynamicTickAttack.f[0] = new csk(DamageType.Bio, base.Power * base.Stacks);
		this.a.TurnTickAttack.f[0] = new csk(DamageType.Bio, base.Power * base.Stacks);
	}

	// Token: 0x040039EA RID: 14826
	private new vf a;

	// Token: 0x040039EB RID: 14827
	private string b;
}
