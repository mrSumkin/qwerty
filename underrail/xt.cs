using System;
using System.Runtime.Serialization;

// Token: 0x02001A3E RID: 6718
[eiz("SSBAE")]
[Serializable]
public sealed class xt : wq, ISerializable
{
	// Token: 0x060091B4 RID: 37300 RVA: 0x0039D9AC File Offset: 0x0039BBAC
	private xt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060091B5 RID: 37301 RVA: 0x0039D9B8 File Offset: 0x0039BBB8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060091B6 RID: 37302 RVA: 0x0039D9C4 File Offset: 0x0039BBC4
	public override void dk(ll A_0, int A_1)
	{
	}

	// Token: 0x060091B7 RID: 37303 RVA: 0x0039D9C8 File Offset: 0x0039BBC8
	public override void dl(ll A_0, int A_1)
	{
	}

	// Token: 0x060091B8 RID: 37304 RVA: 0x0039D9CC File Offset: 0x0039BBCC
	public override wq dn()
	{
		xt xt = new xt();
		this.@do(xt);
		return xt;
	}

	// Token: 0x060091B9 RID: 37305 RVA: 0x0039D9E8 File Offset: 0x0039BBE8
	public xt()
	{
	}
}
