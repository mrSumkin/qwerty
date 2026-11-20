using System;
using System.Runtime.Serialization;

// Token: 0x020018DD RID: 6365
[eiz("F5")]
[Serializable]
public sealed class aca : d76
{
	// Token: 0x060086DC RID: 34524 RVA: 0x0037DBD4 File Offset: 0x0037BDD4
	private aca(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060086DD RID: 34525 RVA: 0x0037DBDC File Offset: 0x0037BDDC
	public aca()
	{
	}

	// Token: 0x060086DE RID: 34526 RVA: 0x0037DBE4 File Offset: 0x0037BDE4
	public double m1(coh A_0)
	{
		int value = A_0.Definition.a7().GetPrimitivePropertyValue<int>("power", new int?(0)).Value;
		return (double)(180 + value * 110);
	}

	// Token: 0x04003449 RID: 13385
	private const int a = 180;

	// Token: 0x0400344A RID: 13386
	private const int b = 110;
}
