using System;
using System.Runtime.Serialization;

// Token: 0x020018EA RID: 6378
[eiz("VHS")]
[Serializable]
public sealed class drm : ISerializable
{
	// Token: 0x06008714 RID: 34580 RVA: 0x0037E6F4 File Offset: 0x0037C8F4
	private drm(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("VHS:R");
		this.b = A_0.GetString("VHS:S");
		this.c = A_0.GetSingle("VHS:V");
	}

	// Token: 0x06008715 RID: 34581 RVA: 0x0037E748 File Offset: 0x0037C948
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("VHS:R", this.a);
		info.AddValue("VHS:S", this.b);
		info.AddValue("VHS:V", this.c);
	}

	// Token: 0x06008716 RID: 34582 RVA: 0x0037E780 File Offset: 0x0037C980
	public drm()
	{
	}

	// Token: 0x06008717 RID: 34583 RVA: 0x0037E794 File Offset: 0x0037C994
	public drm(string A_0, string A_1, float A_2)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x0400349C RID: 13468
	public string a;

	// Token: 0x0400349D RID: 13469
	public string b;

	// Token: 0x0400349E RID: 13470
	public float c = 1f;
}
