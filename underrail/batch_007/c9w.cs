using System;
using System.Runtime.Serialization;

// Token: 0x0200009A RID: 154
[eiz("BIVE")]
[Serializable]
public class c9w : Exception, ISerializable
{
	// Token: 0x06000385 RID: 901 RVA: 0x000105E8 File Offset: 0x0000E7E8
	protected c9w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("BIVE:I");
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00010604 File Offset: 0x0000E804
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("BIVE:I", this.a);
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00010620 File Offset: 0x0000E820
	public string a()
	{
		return this.a;
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00010628 File Offset: 0x0000E828
	public c9w()
	{
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00010630 File Offset: 0x0000E830
	public c9w(string A_0, string A_1) : base(string.Format("Bulk item validation failed. Item: {0}. Error: {1}.", A_1, A_0))
	{
		this.a = A_1;
	}

	// Token: 0x0600038A RID: 906 RVA: 0x0001064C File Offset: 0x0000E84C
	public c9w(string A_0, string A_1, Exception A_2) : base(string.Format("Bulk item validation failed. Item: {0}. Error: {1}.", A_1, A_0), A_2)
	{
		this.a = A_1;
	}

	// Token: 0x04000412 RID: 1042
	private string a;
}
