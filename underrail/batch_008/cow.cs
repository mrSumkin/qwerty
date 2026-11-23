using System;
using System.Runtime.Serialization;

// Token: 0x02000C71 RID: 3185
[eiz("CCFEDE")]
[Serializable]
public sealed class cow : cd2
{
	// Token: 0x060047B8 RID: 18360 RVA: 0x001D7CB0 File Offset: 0x001D5EB0
	private cow(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("CCFEDE:GP");
	}

	// Token: 0x060047B9 RID: 18361 RVA: 0x001D7CCC File Offset: 0x001D5ECC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCFEDE:GP", this.a);
	}

	// Token: 0x060047BA RID: 18362 RVA: 0x001D7CE8 File Offset: 0x001D5EE8
	public string a()
	{
		return this.a;
	}

	// Token: 0x060047BB RID: 18363 RVA: 0x001D7CF0 File Offset: 0x001D5EF0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060047BC RID: 18364 RVA: 0x001D7CFC File Offset: 0x001D5EFC
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(30.0);
	}

	// Token: 0x060047BD RID: 18365 RVA: 0x001D7D0C File Offset: 0x001D5F0C
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(30.0);
	}

	// Token: 0x060047BE RID: 18366 RVA: 0x001D7D1C File Offset: 0x001D5F1C
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(1.0);
	}

	// Token: 0x060047BF RID: 18367 RVA: 0x001D7D2C File Offset: 0x001D5F2C
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(1.0);
	}

	// Token: 0x060047C0 RID: 18368 RVA: 0x001D7D3C File Offset: 0x001D5F3C
	public cow() : base(cow.b)
	{
	}

	// Token: 0x060047C1 RID: 18369 RVA: 0x001D7D4C File Offset: 0x001D5F4C
	public cow(string A_0) : base(cow.b)
	{
		this.a = A_0;
	}

	// Token: 0x060047C2 RID: 18370 RVA: 0x001D7D60 File Offset: 0x001D5F60
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0);
	}

	// Token: 0x060047C3 RID: 18371 RVA: 0x001D7D74 File Offset: 0x001D5F74
	protected override void gg(cyt A_0)
	{
		A_0.r()[this.a] = true;
	}

	// Token: 0x04001CA2 RID: 7330
	private new string a;

	// Token: 0x04001CA3 RID: 7331
	public static readonly string b = "cc_ForgersEndingDelayedEvent";
}
