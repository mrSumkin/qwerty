using System;
using System.Runtime.Serialization;

// Token: 0x020018DF RID: 6367
[eiz("FGIVF")]
[Serializable]
public sealed class aga : d76
{
	// Token: 0x060086E2 RID: 34530 RVA: 0x0037DC6C File Offset: 0x0037BE6C
	private aga(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060086E3 RID: 34531 RVA: 0x0037DC74 File Offset: 0x0037BE74
	public aga()
	{
	}

	// Token: 0x060086E4 RID: 34532 RVA: 0x0037DC7C File Offset: 0x0037BE7C
	public double m1(coh A_0)
	{
		int value = A_0.Definition.a7().GetPrimitivePropertyValue<int>("power", new int?(0)).Value;
		return (double)(100 + value * 75);
	}

	// Token: 0x0400344D RID: 13389
	private const int a = 100;

	// Token: 0x0400344E RID: 13390
	private const int b = 75;
}
