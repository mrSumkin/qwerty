using System;
using System.Runtime.Serialization;

// Token: 0x02001443 RID: 5187
[eiz("NACB")]
[Serializable]
public sealed class e29 : enp, ISerializable
{
	// Token: 0x060074A3 RID: 29859 RVA: 0x003177A0 File Offset: 0x003159A0
	private e29(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("NACB:M", typeof(enp)) as enp);
		this.b = (A_0.GetValue("NACB:I", typeof(enp)) as enp);
	}

	// Token: 0x060074A4 RID: 29860 RVA: 0x003177F4 File Offset: 0x003159F4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("NACB:M", this.a);
		info.AddValue("NACB:I", this.b);
	}

	// Token: 0x060074A5 RID: 29861 RVA: 0x00317818 File Offset: 0x00315A18
	public e29(enp A_0, enp A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x060074A6 RID: 29862 RVA: 0x00317830 File Offset: 0x00315A30
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (this.a != null)
		{
			this.a.af(A_0, A_1, A_2, A_3);
		}
		if (this.b != null)
		{
			this.b.af(A_0, A_1, A_2, A_3);
		}
	}

	// Token: 0x04002FA7 RID: 12199
	private enp a;

	// Token: 0x04002FA8 RID: 12200
	private enp b;
}
