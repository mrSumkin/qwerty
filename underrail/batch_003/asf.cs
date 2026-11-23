using System;
using System.Runtime.Serialization;

// Token: 0x02000FE9 RID: 4073
[eiz("SDR")]
[Serializable]
public sealed class asf : ISerializable
{
	// Token: 0x060053E9 RID: 21481 RVA: 0x00251BA8 File Offset: 0x0024FDA8
	private asf(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (bt4)A_0.GetValue("SDR:L", typeof(bt4));
		this.b = (Guid)A_0.GetValue("SDR:C", typeof(Guid));
	}

	// Token: 0x060053EA RID: 21482 RVA: 0x00251BFC File Offset: 0x0024FDFC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SDR:L", this.a);
		info.AddValue("SDR:C", this.b);
	}

	// Token: 0x060053EB RID: 21483 RVA: 0x00251C28 File Offset: 0x0024FE28
	public asf()
	{
	}

	// Token: 0x060053EC RID: 21484 RVA: 0x00251C30 File Offset: 0x0024FE30
	public asf(Guid A_0, bt4 A_1)
	{
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x04002241 RID: 8769
	public bt4 a;

	// Token: 0x04002242 RID: 8770
	public Guid b;
}
