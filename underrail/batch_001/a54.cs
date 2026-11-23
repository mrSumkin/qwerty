using System;
using System.Runtime.Serialization;

// Token: 0x02001910 RID: 6416
[elw(typeof(d48))]
[eiz("C00")]
[Serializable]
public sealed class a54 : dj3, ISerializable
{
	// Token: 0x06008842 RID: 34882 RVA: 0x00386754 File Offset: 0x00384954
	private a54(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008843 RID: 34883 RVA: 0x00386760 File Offset: 0x00384960
	public override string tv()
	{
		return "Деньги";
	}

	// Token: 0x06008844 RID: 34884 RVA: 0x00386768 File Offset: 0x00384968
	public a54()
	{
	}

	// Token: 0x06008845 RID: 34885 RVA: 0x00386774 File Offset: 0x00384974
	public override bk3 tw()
	{
		a54 a = new a54();
		this.ai7(a);
		return a;
	}
}
