using System;
using System.Runtime.Serialization;

// Token: 0x020006AC RID: 1708
[eiz("RFDP")]
[Serializable]
public sealed class dg0 : ap
{
	// Token: 0x06002C43 RID: 11331 RVA: 0x000FDAC4 File Offset: 0x000FBCC4
	private dg0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002C44 RID: 11332 RVA: 0x000FDAD0 File Offset: 0x000FBCD0
	public dg0()
	{
	}

	// Token: 0x06002C45 RID: 11333 RVA: 0x000FDAD8 File Offset: 0x000FBCD8
	public override string ToString()
	{
		return string.Format("{0}: >=0.0 && <1.0", base.c());
	}

	// Token: 0x06002C46 RID: 11334 RVA: 0x000FDAEC File Offset: 0x000FBCEC
	public override object j1(Random A_0)
	{
		return (A_0 ?? new Random()).NextDouble();
	}
}
