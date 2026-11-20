using System;
using System.Runtime.Serialization;

// Token: 0x02000FBC RID: 4028
[eiz("C11")]
[Serializable]
public sealed class eba : dnh
{
	// Token: 0x06005292 RID: 21138 RVA: 0x0024E1D8 File Offset: 0x0024C3D8
	private eba(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005293 RID: 21139 RVA: 0x0024E1E8 File Offset: 0x0024C3E8
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		int value = A_1.GetPrimitivePropertyValue<int>(cc9.a, new int?(0)).Value;
		int value2 = A_1.GetPrimitivePropertyValue<int>(cc9.b, new int?(0)).Value;
		return value < value2;
	}

	// Token: 0x06005294 RID: 21140 RVA: 0x0024E22C File Offset: 0x0024C42C
	public eba()
	{
	}
}
