using System;
using System.Runtime.Serialization;

// Token: 0x02001B17 RID: 6935
[eiz("ISSE")]
[Serializable]
public sealed class bta : els, ISerializable
{
	// Token: 0x06009615 RID: 38421 RVA: 0x003AC714 File Offset: 0x003AA914
	private bta(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009616 RID: 38422 RVA: 0x003AC720 File Offset: 0x003AA920
	public bta() : base(bta.b, "Инфузия: сила", ci8.b)
	{
		base.Icon = "Status.101";
		base.StaticEffects.Add(new ax6("Strength", 5));
	}

	// Token: 0x06009617 RID: 38423 RVA: 0x003AC760 File Offset: 0x003AA960
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Infusion_Strength", new object[]
		{
			5
		});
	}

	// Token: 0x040039C0 RID: 14784
	private new const int a = 5;

	// Token: 0x040039C1 RID: 14785
	public static string b = "infusion_strength";
}
