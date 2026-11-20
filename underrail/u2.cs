using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x02001310 RID: 4880
[eiz("VEEA")]
[Serializable]
public abstract class u2 : Aspect<c5x>, bp1, ISerializable
{
	// Token: 0x06006D61 RID: 28001 RVA: 0x002DBAD4 File Offset: 0x002D9CD4
	protected u2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006D62 RID: 28002 RVA: 0x002DBAE0 File Offset: 0x002D9CE0
	protected u2(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006D63 RID: 28003
	public abstract List<ud> xw();

	// Token: 0x06006D64 RID: 28004 RVA: 0x002DBAEC File Offset: 0x002D9CEC
	public void mx()
	{
		base.a8().g |= e2b.c;
	}

	// Token: 0x06006D65 RID: 28005 RVA: 0x002DBB04 File Offset: 0x002D9D04
	public void my()
	{
		base.a8().g &= ~e2b.c;
	}
}
