using System;
using System.Runtime.Serialization;

// Token: 0x020004DD RID: 1245
[eiz("PCH1")]
[Serializable]
public sealed class efy : dnh, ISerializable
{
	// Token: 0x06002008 RID: 8200 RVA: 0x000AEC08 File Offset: 0x000ACE08
	private efy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("PCH1:M");
		this.b = A_0.GetSingle("PCH1:X");
	}

	// Token: 0x06002009 RID: 8201 RVA: 0x000AEC40 File Offset: 0x000ACE40
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PCH1:M", this.a);
		info.AddValue("PCH1:X", this.b);
	}

	// Token: 0x0600200A RID: 8202 RVA: 0x000AEC6C File Offset: 0x000ACE6C
	public float b()
	{
		return this.a;
	}

	// Token: 0x0600200B RID: 8203 RVA: 0x000AEC74 File Offset: 0x000ACE74
	public void b(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600200C RID: 8204 RVA: 0x000AEC80 File Offset: 0x000ACE80
	public float a()
	{
		return this.b;
	}

	// Token: 0x0600200D RID: 8205 RVA: 0x000AEC88 File Offset: 0x000ACE88
	public void a(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600200E RID: 8206 RVA: 0x000AEC94 File Offset: 0x000ACE94
	public efy()
	{
	}

	// Token: 0x0600200F RID: 8207 RVA: 0x000AECA8 File Offset: 0x000ACEA8
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			float num = serviceOrThrow.aqu().v().Defense.q().zo() / Math.Max(1f, serviceOrThrow.aqu().v().Defense.q().zm());
			return num >= this.a && num <= this.b;
		}
		return false;
	}

	// Token: 0x040013F7 RID: 5111
	private float a;

	// Token: 0x040013F8 RID: 5112
	private float b = 1f;
}
