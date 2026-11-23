using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x02001263 RID: 4707
[eiz("BEA77")]
[Serializable]
public abstract class ce1 : Aspect<c5x>, ISerializable
{
	// Token: 0x060065FA RID: 26106 RVA: 0x002B62CC File Offset: 0x002B44CC
	protected ce1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060065FB RID: 26107 RVA: 0x002B62D8 File Offset: 0x002B44D8
	public ce1(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060065FC RID: 26108
	public abstract void n3(int A_0);
}
