using System;
using System.Runtime.Serialization;

// Token: 0x02000658 RID: 1624
[eiz("TRNFO")]
[Serializable]
public sealed class eaj : ISerializable
{
	// Token: 0x0600293C RID: 10556 RVA: 0x000EB2D4 File Offset: 0x000E94D4
	private eaj(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetBoolean("TRNFO:E");
		this.b = A_0.GetBoolean("TRNFO:S");
	}

	// Token: 0x0600293D RID: 10557 RVA: 0x000EB300 File Offset: 0x000E9500
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("TRNFO:E", this.a);
		info.AddValue("TRNFO:S", this.b);
	}

	// Token: 0x0600293E RID: 10558 RVA: 0x000EB324 File Offset: 0x000E9524
	public eaj()
	{
	}

	// Token: 0x04001688 RID: 5768
	public bool a;

	// Token: 0x04001689 RID: 5769
	public bool b;
}
