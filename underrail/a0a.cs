using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020006A4 RID: 1700
[eiz("RLEI")]
[Serializable]
public sealed class a0a : ISerializable
{
	// Token: 0x06002C08 RID: 11272 RVA: 0x000FD324 File Offset: 0x000FB524
	private a0a(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("RLEI:A", typeof(HashSet<string>)) as HashSet<string>);
		this.b = (A_0.GetValue("RLEI:N", typeof(TimeSpan?)) as TimeSpan?);
		if (ell.a() >= 446)
		{
			this.c = (A_0.GetValue("RLEI:O", typeof(HashSet<string>)) as HashSet<string>);
			return;
		}
		this.c = new HashSet<string>();
	}

	// Token: 0x06002C09 RID: 11273 RVA: 0x000FD3D0 File Offset: 0x000FB5D0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("RLEI:A", this.a);
		info.AddValue("RLEI:N", this.b);
		info.AddValue("RLEI:O", this.c);
	}

	// Token: 0x06002C0A RID: 11274 RVA: 0x000FD40C File Offset: 0x000FB60C
	public a0a()
	{
	}

	// Token: 0x04001919 RID: 6425
	public HashSet<string> a = new HashSet<string>();

	// Token: 0x0400191A RID: 6426
	public TimeSpan? b;

	// Token: 0x0400191B RID: 6427
	public HashSet<string> c = new HashSet<string>();
}
