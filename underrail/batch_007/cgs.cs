using System;
using System.Runtime.Serialization;

// Token: 0x02001B1F RID: 6943
[eiz("CXX")]
[Serializable]
public sealed class cgs : els, ISerializable
{
	// Token: 0x06009639 RID: 38457 RVA: 0x003ACF8C File Offset: 0x003AB18C
	private cgs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (ax6)A_0.GetValue("CXX:E", typeof(ax6));
	}

	// Token: 0x0600963A RID: 38458 RVA: 0x003ACFB8 File Offset: 0x003AB1B8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CXX:E", this.a);
	}

	// Token: 0x0600963B RID: 38459 RVA: 0x003ACFD8 File Offset: 0x003AB1D8
	public cgs(int A_0) : base("crippled", "Слабость", ci8.c)
	{
		base.Duration = A_0;
		base.TickPeriod = 0;
		base.Icon = "SpecialAttack.CripplingStrike";
		base.MaxStacks = fz.d;
		base.Stacking = axm.b;
		this.a = new ax6("Strength", -fz.e);
		base.StaticEffects.Add(this.a);
	}

	// Token: 0x0600963C RID: 38460 RVA: 0x003AD048 File Offset: 0x003AB248
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Crippled", new object[]
		{
			-this.a.c()
		});
	}

	// Token: 0x0600963D RID: 38461 RVA: 0x003AD070 File Offset: 0x003AB270
	protected override void c8()
	{
		this.a.a(base.Stacks * -fz.e);
	}

	// Token: 0x040039D5 RID: 14805
	private new ax6 a;
}
