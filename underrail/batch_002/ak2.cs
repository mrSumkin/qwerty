using System;
using System.Runtime.Serialization;

// Token: 0x02001A9B RID: 6811
[eiz("BVS")]
[Serializable]
public sealed class ak2 : els, ISerializable
{
	// Token: 0x060093D1 RID: 37841 RVA: 0x003A3F90 File Offset: 0x003A2190
	private ak2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060093D2 RID: 37842 RVA: 0x003A3FA0 File Offset: 0x003A21A0
	public ak2(int A_0) : base("BlurredVision", "Размытое зрение", ci8.c)
	{
		base.Duration = A_0;
		base.TickPeriod = 0;
		base.Icon = "Status.BlurredVision";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new ax6("Perception", -ak2.a));
		base.StaticEffects.Add(new d0d(-(float)ak2.b)
		{
			Priority = int.MaxValue
		});
	}

	// Token: 0x060093D3 RID: 37843 RVA: 0x003A401C File Offset: 0x003A221C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/BlurredVision", new object[]
		{
			ak2.a,
			(int)(ak2.b * 100.0)
		});
	}

	// Token: 0x040038CE RID: 14542
	public new static readonly int a = 5;

	// Token: 0x040038CF RID: 14543
	public static readonly double b = 0.5;
}
