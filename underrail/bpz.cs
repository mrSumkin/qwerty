using System;
using System.Runtime.Serialization;

// Token: 0x020018DE RID: 6366
[eiz("HEGIVF")]
[Serializable]
public sealed class bpz : d76
{
	// Token: 0x060086DF RID: 34527 RVA: 0x0037DC20 File Offset: 0x0037BE20
	private bpz(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060086E0 RID: 34528 RVA: 0x0037DC28 File Offset: 0x0037BE28
	public bpz()
	{
	}

	// Token: 0x060086E1 RID: 34529 RVA: 0x0037DC30 File Offset: 0x0037BE30
	public double m1(coh A_0)
	{
		int value = A_0.Definition.a7().GetPrimitivePropertyValue<int>("power", new int?(0)).Value;
		return (double)(150 + value * 100);
	}

	// Token: 0x0400344B RID: 13387
	private const int a = 150;

	// Token: 0x0400344C RID: 13388
	private const int b = 100;
}
