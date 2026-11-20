using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020006AA RID: 1706
[eiz("RFP")]
[Serializable]
public abstract class ap : ISerializable
{
	// Token: 0x06002C2A RID: 11306 RVA: 0x000FD7B8 File Offset: 0x000FB9B8
	protected ap(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("RFP:N");
	}

	// Token: 0x06002C2B RID: 11307 RVA: 0x000FD7D4 File Offset: 0x000FB9D4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("RFP:N", this.a);
	}

	// Token: 0x06002C2C RID: 11308 RVA: 0x000FD7E8 File Offset: 0x000FB9E8
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002C2D RID: 11309 RVA: 0x000FD7F0 File Offset: 0x000FB9F0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002C2E RID: 11310 RVA: 0x000FD7FC File Offset: 0x000FB9FC
	protected ap()
	{
	}

	// Token: 0x06002C2F RID: 11311 RVA: 0x000FD804 File Offset: 0x000FBA04
	public override string ToString()
	{
		return this.a;
	}

	// Token: 0x06002C30 RID: 11312
	public abstract object j1(Random A_0);

	// Token: 0x06002C31 RID: 11313 RVA: 0x000FD80C File Offset: 0x000FBA0C
	public static void a(cyt A_0, string A_1, IEnumerable<ap> A_2)
	{
		foreach (ap ap in A_2)
		{
			string name = A_1 + ap.c();
			object value = ap.j1(A_0.aj);
			A_0.r()[name] = value;
		}
	}

	// Token: 0x04001920 RID: 6432
	private string a;
}
