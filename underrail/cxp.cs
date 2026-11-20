using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020006A1 RID: 1697
[eiz("LPI")]
[Serializable]
public sealed class cxp : ISerializable
{
	// Token: 0x06002BFD RID: 11261 RVA: 0x000FD1F0 File Offset: 0x000FB3F0
	private cxp(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (Version)A_0.GetValue("LPI:V", typeof(Version));
		this.b = (A_0.GetValue("LPI:A", typeof(HashSet<string>)) as HashSet<string>);
	}

	// Token: 0x06002BFE RID: 11262 RVA: 0x000FD250 File Offset: 0x000FB450
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("LPI:V", this.a);
		info.AddValue("LPI:A", this.b);
	}

	// Token: 0x06002BFF RID: 11263 RVA: 0x000FD274 File Offset: 0x000FB474
	public cxp(Version A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002C00 RID: 11264 RVA: 0x000FD290 File Offset: 0x000FB490
	public bool b(string A_0)
	{
		return this.b.Contains(A_0);
	}

	// Token: 0x06002C01 RID: 11265 RVA: 0x000FD2A0 File Offset: 0x000FB4A0
	public bool a(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0) && !this.b.Contains(A_0))
		{
			this.b.Add(A_0);
			return true;
		}
		return false;
	}

	// Token: 0x04001911 RID: 6417
	public Version a;

	// Token: 0x04001912 RID: 6418
	public HashSet<string> b = new HashSet<string>();
}
