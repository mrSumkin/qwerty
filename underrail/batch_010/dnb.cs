using System;
using System.Runtime.Serialization;

// Token: 0x02000FB5 RID: 4021
[eiz("MESE")]
[Serializable]
public sealed class dnb : els, ISerializable
{
	// Token: 0x0600526E RID: 21102 RVA: 0x0024DC00 File Offset: 0x0024BE00
	private dnb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600526F RID: 21103 RVA: 0x0024DC0C File Offset: 0x0024BE0C
	public dnb() : base(dnb.a, "Электроактивная гибкость", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "Xpbl_Abilities.31";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new caz(-eus.a)
		{
			Priority = 1073741813
		});
		base.TickPeriod = d0u.b;
		this.z = "MetallineEnergizationJoblets_Tick";
		base.VisualEffects.Add(new ud(this, "MetallineEnergization"));
	}

	// Token: 0x06005270 RID: 21104 RVA: 0x0024DC90 File Offset: 0x0024BE90
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/MetallineEnergization", new object[]
		{
			eus.f,
			Convert.ToInt32(eus.a)
		});
	}

	// Token: 0x040021C8 RID: 8648
	public new static readonly string a = "metallineEnergization";
}
