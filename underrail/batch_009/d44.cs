using System;
using System.Runtime.Serialization;

// Token: 0x020004D0 RID: 1232
[eiz("MPPWBC")]
[Serializable]
public sealed class d44 : dnh, ISerializable
{
	// Token: 0x06001F98 RID: 8088 RVA: 0x000ADBA0 File Offset: 0x000ABDA0
	private d44(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MPPWBC:MV");
	}

	// Token: 0x06001F99 RID: 8089 RVA: 0x000ADBBC File Offset: 0x000ABDBC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MPPWBC:MV", this.a);
	}

	// Token: 0x06001F9A RID: 8090 RVA: 0x000ADBD8 File Offset: 0x000ABDD8
	public int a()
	{
		return this.a;
	}

	// Token: 0x06001F9B RID: 8091 RVA: 0x000ADBE0 File Offset: 0x000ABDE0
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001F9C RID: 8092 RVA: 0x000ADBEC File Offset: 0x000ABDEC
	public d44()
	{
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x000ADBF8 File Offset: 0x000ABDF8
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && c2h.c(serviceOrThrow.aqu().v()) >= this.a;
	}

	// Token: 0x040013D9 RID: 5081
	private int a;
}
