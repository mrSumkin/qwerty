using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x02001277 RID: 4727
[eiz("PCTOEA")]
[Serializable]
public abstract class c5i : Aspect<c5x>, ISerializable
{
	// Token: 0x0600669F RID: 26271 RVA: 0x002B9F30 File Offset: 0x002B8130
	protected c5i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060066A0 RID: 26272 RVA: 0x002B9F3C File Offset: 0x002B813C
	protected c5i(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060066A1 RID: 26273
	public abstract string g1();
}
