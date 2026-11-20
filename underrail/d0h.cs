using System;
using System.Runtime.Serialization;

// Token: 0x02001141 RID: 4417
[eiz("GPSI")]
[Serializable]
public sealed class d0h : ISerializable
{
	// Token: 0x06005E9C RID: 24220 RVA: 0x002810E0 File Offset: 0x0027F2E0
	private d0h(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (Guid)A_0.GetValue("GPSI:I", typeof(Guid));
		this.b = A_0.GetString("GPSI:A");
		this.c = A_0.GetBoolean("GPSI:N");
		this.d = A_0.GetString("GPSI:D");
	}

	// Token: 0x06005E9D RID: 24221 RVA: 0x00281148 File Offset: 0x0027F348
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("GPSI:I", this.a);
		info.AddValue("GPSI:A", this.b);
		info.AddValue("GPSI:N", this.c);
		info.AddValue("GPSI:D", this.d);
	}

	// Token: 0x06005E9E RID: 24222 RVA: 0x002811A0 File Offset: 0x0027F3A0
	public d0h()
	{
	}

	// Token: 0x06005E9F RID: 24223 RVA: 0x002811A8 File Offset: 0x0027F3A8
	public d0h(Guid A_0, string A_1, string A_2 = null, bool A_3 = false)
	{
		this.a = A_0;
		this.b = A_1;
		this.d = A_2;
		this.c = A_3;
	}

	// Token: 0x04002595 RID: 9621
	public Guid a;

	// Token: 0x04002596 RID: 9622
	public string b;

	// Token: 0x04002597 RID: 9623
	public bool c;

	// Token: 0x04002598 RID: 9624
	public string d;
}
