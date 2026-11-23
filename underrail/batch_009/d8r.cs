using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x02001298 RID: 4760
[eiz("HEA77")]
[Serializable]
public abstract class d8r : Aspect<c5x>, ISerializable
{
	// Token: 0x060067FA RID: 26618 RVA: 0x002C0300 File Offset: 0x002BE500
	protected d8r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060067FB RID: 26619 RVA: 0x002C030C File Offset: 0x002BE50C
	public d8r(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060067FC RID: 26620
	public abstract void tt(int A_0, bool A_1);
}
