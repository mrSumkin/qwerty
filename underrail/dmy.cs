using System;
using System.Runtime.Serialization;

// Token: 0x02001B42 RID: 6978
[eiz("SMSE")]
[Serializable]
public sealed class dmy : els, ISerializable
{
	// Token: 0x060096EA RID: 38634 RVA: 0x003AF6E4 File Offset: 0x003AD8E4
	private dmy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(dmy);
		}
	}

	// Token: 0x060096EB RID: 38635 RVA: 0x003AF710 File Offset: 0x003AD910
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060096EC RID: 38636 RVA: 0x003AF720 File Offset: 0x003AD920
	public dmy() : base("stealthMode", "Режим скрытности", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "Abilities.0";
		base.Stacking = axm.b;
		base.TickPeriod = aiy.bx;
		base.StaticEffects.Add(new df());
		base.StaticEffects.Add(new dfy());
		base.DynamicEffects.Add(new xt());
		base.VisualEffects.Add(new ud(this, "Stealth"));
	}

	// Token: 0x060096ED RID: 38637 RVA: 0x003AF7A8 File Offset: 0x003AD9A8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/StealthMode", new object[]
		{
			Convert.ToInt32(e5b.b((A_0 != null) ? A_0.a() : null) * 100.0),
			e5b.a(A_0.a())
		});
	}
}
