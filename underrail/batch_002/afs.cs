using System;
using System.Runtime.Serialization;

// Token: 0x020018E1 RID: 6369
[eiz("LIVF")]
[Serializable]
public sealed class afs : d76
{
	// Token: 0x060086E8 RID: 34536 RVA: 0x0037DD08 File Offset: 0x0037BF08
	private afs(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060086E9 RID: 34537 RVA: 0x0037DD10 File Offset: 0x0037BF10
	public afs()
	{
	}

	// Token: 0x060086EA RID: 34538 RVA: 0x0037DD1C File Offset: 0x0037BF1C
	public double m1(coh A_0)
	{
		int value = A_0.Definition.a7().GetPrimitivePropertyValue<int>("LockpickBonus", new int?(0)).Value;
		return (double)(15 + value * 3);
	}

	// Token: 0x04003451 RID: 13393
	private const int a = 15;

	// Token: 0x04003452 RID: 13394
	private const int b = 3;
}
