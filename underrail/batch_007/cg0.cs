using System;
using System.Runtime.Serialization;

// Token: 0x020004FB RID: 1275
[eiz("SMTPA")]
[Serializable]
public sealed class cg0 : esc, ISerializable
{
	// Token: 0x060020FD RID: 8445 RVA: 0x000B1044 File Offset: 0x000AF244
	private cg0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("SMTPA:M", typeof(cqh)) as cqh);
	}

	// Token: 0x060020FE RID: 8446 RVA: 0x000B1070 File Offset: 0x000AF270
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SMTPA:M", this.a);
	}

	// Token: 0x060020FF RID: 8447 RVA: 0x000B108C File Offset: 0x000AF28C
	public cqh a()
	{
		return this.a;
	}

	// Token: 0x06002100 RID: 8448 RVA: 0x000B1094 File Offset: 0x000AF294
	public void a(cqh A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002101 RID: 8449 RVA: 0x000B10A0 File Offset: 0x000AF2A0
	public cg0()
	{
	}

	// Token: 0x06002102 RID: 8450 RVA: 0x000B10A8 File Offset: 0x000AF2A8
	public override int d5(bq8 A_0, bq8 A_1)
	{
		return 0;
	}

	// Token: 0x04001439 RID: 5177
	private cqh a;
}
