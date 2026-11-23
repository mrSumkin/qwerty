using System;
using System.Runtime.Serialization;

// Token: 0x02001B15 RID: 6933
[eiz("IFSE")]
[Serializable]
public sealed class edc : els, ISerializable
{
	// Token: 0x0600960D RID: 38413 RVA: 0x003AC5E4 File Offset: 0x003AA7E4
	private edc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600960E RID: 38414 RVA: 0x003AC5F0 File Offset: 0x003AA7F0
	public edc() : base(edc.b, "Инфузия: внимание", ci8.b)
	{
		base.Icon = "Status.103";
		base.StaticEffects.Add(new dpw("Psychokinesis", 20));
		base.StaticEffects.Add(new dpw("Thought Control", 20));
		base.StaticEffects.Add(new dpw("Metathermics", 20));
	}

	// Token: 0x0600960F RID: 38415 RVA: 0x003AC660 File Offset: 0x003AA860
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Infusion_Focus", new object[]
		{
			20
		});
	}

	// Token: 0x040039BC RID: 14780
	private new const int a = 20;

	// Token: 0x040039BD RID: 14781
	public static string b = "infusion_focus";
}
