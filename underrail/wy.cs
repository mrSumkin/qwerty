using System;
using System.Runtime.Serialization;

// Token: 0x020018DC RID: 6364
[eiz("HM5")]
[Serializable]
public sealed class wy : d76
{
	// Token: 0x060086D9 RID: 34521 RVA: 0x0037DB84 File Offset: 0x0037BD84
	private wy(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060086DA RID: 34522 RVA: 0x0037DB8C File Offset: 0x0037BD8C
	public wy()
	{
	}

	// Token: 0x060086DB RID: 34523 RVA: 0x0037DB98 File Offset: 0x0037BD98
	public double m1(coh A_0)
	{
		int value = A_0.Definition.a7().GetPrimitivePropertyValue<int>("power", new int?(0)).Value;
		return (double)(200 + value * 125);
	}

	// Token: 0x04003447 RID: 13383
	private const int a = 200;

	// Token: 0x04003448 RID: 13384
	private const int b = 125;
}
