using System;
using System.Runtime.Serialization;

// Token: 0x020018E0 RID: 6368
[eiz("HXIVF")]
[Serializable]
public sealed class bxj : d76
{
	// Token: 0x060086E5 RID: 34533 RVA: 0x0037DCB8 File Offset: 0x0037BEB8
	private bxj(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060086E6 RID: 34534 RVA: 0x0037DCC0 File Offset: 0x0037BEC0
	public bxj()
	{
	}

	// Token: 0x060086E7 RID: 34535 RVA: 0x0037DCCC File Offset: 0x0037BECC
	public double m1(coh A_0)
	{
		int value = A_0.Definition.a7().GetPrimitivePropertyValue<int>("HackingBonus", new int?(0)).Value;
		return (double)(100 + value * 25);
	}

	// Token: 0x0400344F RID: 13391
	private const int a = 100;

	// Token: 0x04003450 RID: 13392
	private const int b = 25;
}
