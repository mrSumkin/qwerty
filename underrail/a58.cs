using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020004DB RID: 1243
[eiz("PGC")]
[Serializable]
public sealed class a58 : dnh
{
	// Token: 0x06001FFA RID: 8186 RVA: 0x000AEA7C File Offset: 0x000ACC7C
	private a58(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Gender)A_0.GetValue("PGC:G", typeof(Gender));
	}

	// Token: 0x06001FFB RID: 8187 RVA: 0x000AEAA8 File Offset: 0x000ACCA8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PGC:G", this.a);
	}

	// Token: 0x06001FFC RID: 8188 RVA: 0x000AEAC8 File Offset: 0x000ACCC8
	public Gender a()
	{
		return this.a;
	}

	// Token: 0x06001FFD RID: 8189 RVA: 0x000AEAD0 File Offset: 0x000ACCD0
	public void a(Gender A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001FFE RID: 8190 RVA: 0x000AEADC File Offset: 0x000ACCDC
	public a58()
	{
	}

	// Token: 0x06001FFF RID: 8191 RVA: 0x000AEAE4 File Offset: 0x000ACCE4
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v().Gender == this.a;
	}

	// Token: 0x040013F4 RID: 5108
	private Gender a;
}
