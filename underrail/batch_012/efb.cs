using System;
using System.Runtime.Serialization;

// Token: 0x02001B2F RID: 6959
[eiz("P14")]
[Serializable]
public sealed class efb : els, ISerializable
{
	// Token: 0x06009681 RID: 38529 RVA: 0x003ADD30 File Offset: 0x003ABF30
	private efb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009682 RID: 38530 RVA: 0x003ADD3C File Offset: 0x003ABF3C
	public efb(int A_0, int A_1, coh A_2, double A_3) : base("personalCloaking", "Персональное маскировочное поле", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "Items.CloakingDevice";
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		base.ControllerName = "P14c";
		base.StaticEffects.Add(new dpw("Stealth", A_0));
		base.StaticEffects.Add(new dpw("Evasion", A_1));
		base.DynamicEffects.Add(new ead(A_2, A_3));
		base.VisualEffects.Add(new ud(this, "Displacement"));
	}

	// Token: 0x06009683 RID: 38531 RVA: 0x003ADDE0 File Offset: 0x003ABFE0
	public override string cb(ll A_0)
	{
		int num = ((dpw)base.StaticEffects[0]).c();
		int num2 = ((dpw)base.StaticEffects[1]).c();
		return qv.a("StatusEffects/PersonalCloaking", new object[]
		{
			num,
			num2
		});
	}
}
