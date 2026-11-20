using System;
using System.Runtime.Serialization;

// Token: 0x02001B2E RID: 6958
[eiz("P15")]
[Serializable]
public sealed class ame : els, ISerializable
{
	// Token: 0x0600967D RID: 38525 RVA: 0x003ADC94 File Offset: 0x003ABE94
	private ame(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600967E RID: 38526 RVA: 0x003ADCA0 File Offset: 0x003ABEA0
	public ame(coh A_0, double A_1) : base(ame.a, "Ночное видение", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "Status.Nightvision";
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		base.ControllerName = "P15c";
		base.StaticEffects.Add(new ar9());
		base.DynamicEffects.Add(new ead(A_0, A_1));
	}

	// Token: 0x0600967F RID: 38527 RVA: 0x003ADD10 File Offset: 0x003ABF10
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Nightvision", new object[0]);
	}

	// Token: 0x040039E8 RID: 14824
	public new static readonly string a = "nightvision";
}
