using System;
using System.Runtime.Serialization;

// Token: 0x02000C81 RID: 3201
[eiz("RRSDE")]
[Serializable]
public sealed class cql : d4
{
	// Token: 0x06004855 RID: 18517 RVA: 0x001DA010 File Offset: 0x001D8210
	private cql(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetString("RRSDE:LN");
	}

	// Token: 0x06004856 RID: 18518 RVA: 0x001DA02C File Offset: 0x001D822C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RRSDE:LN", this.b);
	}

	// Token: 0x06004857 RID: 18519 RVA: 0x001DA048 File Offset: 0x001D8248
	public string a()
	{
		return this.b;
	}

	// Token: 0x06004858 RID: 18520 RVA: 0x001DA050 File Offset: 0x001D8250
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06004859 RID: 18521 RVA: 0x001DA05C File Offset: 0x001D825C
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(5.0);
	}

	// Token: 0x0600485A RID: 18522 RVA: 0x001DA06C File Offset: 0x001D826C
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600485B RID: 18523 RVA: 0x001DA07C File Offset: 0x001D827C
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600485C RID: 18524 RVA: 0x001DA08C File Offset: 0x001D828C
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600485D RID: 18525 RVA: 0x001DA09C File Offset: 0x001D829C
	public cql() : base(cql.a)
	{
	}

	// Token: 0x0600485E RID: 18526 RVA: 0x001DA0AC File Offset: 0x001D82AC
	public cql(string A_0) : base(cql.a)
	{
		this.b = A_0;
	}

	// Token: 0x0600485F RID: 18527 RVA: 0x001DA0C0 File Offset: 0x001D82C0
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0);
	}

	// Token: 0x06004860 RID: 18528 RVA: 0x001DA0D4 File Offset: 0x001D82D4
	protected override void gg(cyt A_0)
	{
		if (this.b == "cvw21")
		{
			A_0.a(new bw0(this.b, new dmk(), 1));
			return;
		}
		A_0.a(new bw0(this.b, new dof(), 1));
	}

	// Token: 0x04001CB3 RID: 7347
	public new static readonly string a = "removeRaidedShipsDelayed";

	// Token: 0x04001CB4 RID: 7348
	private string b;
}
