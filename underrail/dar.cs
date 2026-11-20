using System;
using System.Runtime.Serialization;

// Token: 0x02001E59 RID: 7769
[eiz("XMD")]
[Serializable]
public sealed class dar : ISerializable
{
	// Token: 0x0600AC3A RID: 44090 RVA: 0x003F92BC File Offset: 0x003F74BC
	private dar(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetDouble("XMD:D");
	}

	// Token: 0x0600AC3B RID: 44091 RVA: 0x003F92E4 File Offset: 0x003F74E4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("XMD:D", this.a);
	}

	// Token: 0x0600AC3C RID: 44092 RVA: 0x003F92F8 File Offset: 0x003F74F8
	public dar()
	{
	}

	// Token: 0x0400401B RID: 16411
	public double a = 1.0;
}
