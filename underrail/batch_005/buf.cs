using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012BF RID: 4799
[eiz("NUEA")]
[Serializable]
public sealed class buf : Aspect<c5x>, ISerializable
{
	// Token: 0x060069D3 RID: 27091 RVA: 0x002C9C14 File Offset: 0x002C7E14
	private buf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060069D4 RID: 27092 RVA: 0x002C9C20 File Offset: 0x002C7E20
	public buf(c5x A_0) : base(A_0)
	{
	}
}
