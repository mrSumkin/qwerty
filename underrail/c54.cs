using System;
using System.Runtime.Serialization;

// Token: 0x02001B32 RID: 6962
[eiz("F17")]
[Serializable]
public sealed class c54 : els, ISerializable
{
	// Token: 0x0600968F RID: 38543 RVA: 0x003AE11C File Offset: 0x003AC31C
	private c54(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009690 RID: 38544 RVA: 0x003AE12C File Offset: 0x003AC32C
	public c54() : base(c54.a, "Эмиссия силы", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "Psi.ForceEmission";
		base.Stacking = axm.b;
		base.VisualEffects.Add(new ud(this, "Pulsating"));
	}

	// Token: 0x06009691 RID: 38545 RVA: 0x003AE17C File Offset: 0x003AC37C
	public override string cb(ll A_0)
	{
		return qv.a("Psi/ForceEmission", new object[]
		{
			e5o.a(A_0.a()).a(true),
			new e5o().a(new eoj(A_0.a(), null, null))
		});
	}

	// Token: 0x040039EC RID: 14828
	public new static readonly string a = "forceEmission";
}
