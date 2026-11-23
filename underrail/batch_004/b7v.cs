using System;
using System.Runtime.Serialization;

// Token: 0x020000DA RID: 218
[eiz("DEI")]
[Serializable]
internal sealed class b7v : ISerializable
{
	// Token: 0x060004C3 RID: 1219 RVA: 0x000159EC File Offset: 0x00013BEC
	public b7v()
	{
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x000159F8 File Offset: 0x00013BF8
	private b7v(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("DEI:MN");
		this.b = A_0.GetValue("DEI:T", typeof(object));
		this.c = di7.a("DEI:DT", A_0);
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00015A48 File Offset: 0x00013C48
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("DEI:MN", this.a);
		info.AddValue("DEI:T", this.b);
		di7.a("DEI:DT", this.c, info);
	}

	// Token: 0x04000465 RID: 1125
	public string a;

	// Token: 0x04000466 RID: 1126
	public object b;

	// Token: 0x04000467 RID: 1127
	public Type c;
}
