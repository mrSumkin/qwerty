using System;
using System.Runtime.Serialization;
using Ouroboros.Common;
using Ouroboros.Common.Data;

// Token: 0x0200068E RID: 1678
[eiz("PCR")]
[Serializable]
public sealed class dsx : TypedObjectReference<efk>, IProvider<efk>, ISerializable
{
	// Token: 0x06002AFF RID: 11007 RVA: 0x000F9708 File Offset: 0x000F7908
	private dsx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002B00 RID: 11008 RVA: 0x000F9714 File Offset: 0x000F7914
	public dsx()
	{
	}

	// Token: 0x06002B01 RID: 11009 RVA: 0x000F9720 File Offset: 0x000F7920
	protected override efk h4()
	{
		cnk cnk = ces.a();
		if (cnk != null && cnk.aqu() != null)
		{
			return cnk.aqu().v();
		}
		return null;
	}

	// Token: 0x06002B02 RID: 11010 RVA: 0x000F9754 File Offset: 0x000F7954
	efk IProvider<efk>.a()
	{
		return base.ao();
	}
}
