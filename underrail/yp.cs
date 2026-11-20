using System;
using System.Runtime.Serialization;

// Token: 0x0200127E RID: 4734
[eiz("GGEA")]
[a(typeof(bim))]
[Serializable]
public sealed class yp : bim, ISerializable
{
	// Token: 0x060066DB RID: 26331 RVA: 0x002BB24C File Offset: 0x002B944C
	private yp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("GGEA:F");
	}

	// Token: 0x060066DC RID: 26332 RVA: 0x002BB268 File Offset: 0x002B9468
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GGEA:F", this.a);
	}

	// Token: 0x060066DD RID: 26333 RVA: 0x002BB284 File Offset: 0x002B9484
	public yp(c5x A_0, string A_1) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x060066DE RID: 26334 RVA: 0x002BB294 File Offset: 0x002B9494
	public yp(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x04002AA5 RID: 10917
	public new string a;
}
