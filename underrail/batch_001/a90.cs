using System;
using System.Runtime.Serialization;

// Token: 0x020004ED RID: 1261
[eiz("C33")]
[Serializable]
public sealed class a90 : esc, ISerializable
{
	// Token: 0x06002091 RID: 8337 RVA: 0x000B0184 File Offset: 0x000AE384
	private a90(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetString("C33:QN");
		this.a = A_0.GetBoolean("C33:PE");
	}

	// Token: 0x06002092 RID: 8338 RVA: 0x000B01B8 File Offset: 0x000AE3B8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("C33:QN", this.b);
		info.AddValue("C33:PE", this.a);
	}

	// Token: 0x06002093 RID: 8339 RVA: 0x000B01E4 File Offset: 0x000AE3E4
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06002094 RID: 8340 RVA: 0x000B01EC File Offset: 0x000AE3EC
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002095 RID: 8341 RVA: 0x000B01F8 File Offset: 0x000AE3F8
	public string a()
	{
		return this.b;
	}

	// Token: 0x06002096 RID: 8342 RVA: 0x000B0200 File Offset: 0x000AE400
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002097 RID: 8343 RVA: 0x000B020C File Offset: 0x000AE40C
	public override int d5(bq8 A_0, bq8 A_1)
	{
		bpo.GetServiceOrThrow<cnk>().aqz().atc(this.a(), this.a);
		return 0;
	}

	// Token: 0x06002098 RID: 8344 RVA: 0x000B022C File Offset: 0x000AE42C
	public a90()
	{
	}

	// Token: 0x06002099 RID: 8345 RVA: 0x000B023C File Offset: 0x000AE43C
	public override bool h5(string A_0, bool A_1)
	{
		return !base.h5(A_0, A_1) && !string.IsNullOrEmpty(this.b) && this.b.IndexOf(A_0, A_1 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1;
	}

	// Token: 0x0400141C RID: 5148
	private bool a = true;

	// Token: 0x0400141D RID: 5149
	private string b;
}
