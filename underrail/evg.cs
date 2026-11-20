using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020006A8 RID: 1704
[eiz("RFDS")]
[Serializable]
public sealed class evg : ISerializable
{
	// Token: 0x06002C21 RID: 11297 RVA: 0x000FD6FC File Offset: 0x000FB8FC
	private evg(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a(A_0.GetValue("RFDS:F", typeof(List<b58>)) as List<b58>);
	}

	// Token: 0x06002C22 RID: 11298 RVA: 0x000FD730 File Offset: 0x000FB930
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("RFDS:F", this.a());
	}

	// Token: 0x06002C23 RID: 11299 RVA: 0x000FD744 File Offset: 0x000FB944
	public List<b58> a()
	{
		return this.a;
	}

	// Token: 0x06002C24 RID: 11300 RVA: 0x000FD74C File Offset: 0x000FB94C
	public void a(List<b58> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002C25 RID: 11301 RVA: 0x000FD758 File Offset: 0x000FB958
	public evg()
	{
	}

	// Token: 0x0400191F RID: 6431
	private List<b58> a = new List<b58>();
}
