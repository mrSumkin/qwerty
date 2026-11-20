using System;
using System.Runtime.Serialization;

// Token: 0x02000C85 RID: 3205
[eiz("DASTDE")]
[Serializable]
public sealed class bet : cd2
{
	// Token: 0x06004883 RID: 18563 RVA: 0x001DA418 File Offset: 0x001D8618
	private bet(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("DASTDE:LN");
		this.b = A_0.GetBoolean("DASTDE:I");
	}

	// Token: 0x06004884 RID: 18564 RVA: 0x001DA444 File Offset: 0x001D8644
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DASTDE:LN", this.a);
		info.AddValue("DASTDE:I", this.b);
	}

	// Token: 0x06004885 RID: 18565 RVA: 0x001DA470 File Offset: 0x001D8670
	public string b()
	{
		return this.a;
	}

	// Token: 0x06004886 RID: 18566 RVA: 0x001DA478 File Offset: 0x001D8678
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004887 RID: 18567 RVA: 0x001DA484 File Offset: 0x001D8684
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06004888 RID: 18568 RVA: 0x001DA48C File Offset: 0x001D868C
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06004889 RID: 18569 RVA: 0x001DA498 File Offset: 0x001D8698
	public override TimeSpan ge()
	{
		if (this.b)
		{
			return TimeSpan.FromMinutes(0.0);
		}
		return TimeSpan.FromMinutes(20.0);
	}

	// Token: 0x0600488A RID: 18570 RVA: 0x001DA4C4 File Offset: 0x001D86C4
	public override TimeSpan gf()
	{
		if (this.b)
		{
			return TimeSpan.FromMinutes(0.0);
		}
		return TimeSpan.FromMinutes(5.0);
	}

	// Token: 0x0600488B RID: 18571 RVA: 0x001DA4F0 File Offset: 0x001D86F0
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600488C RID: 18572 RVA: 0x001DA500 File Offset: 0x001D8700
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x0600488D RID: 18573 RVA: 0x001DA510 File Offset: 0x001D8710
	public bet(string A_0, bool A_1) : base(bet.c)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x0600488E RID: 18574 RVA: 0x001DA52C File Offset: 0x001D872C
	public bet() : base(bet.c)
	{
	}

	// Token: 0x0600488F RID: 18575 RVA: 0x001DA53C File Offset: 0x001D873C
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0);
	}

	// Token: 0x06004890 RID: 18576 RVA: 0x001DA550 File Offset: 0x001D8750
	protected override void gg(cyt A_0)
	{
		if (this.a == "xpbl_g3" || this.a == "xpbl_f3" || this.a == "xpbl_e3")
		{
			A_0.a(new bw0("xpbl_g2", new cog(), 1));
			A_0.a(new bw0("xpbl_f2", new cog(), 1));
			A_0.a(new bw0("xpbl_e3", new cog(), 1));
			return;
		}
		A_0.a(new bw0(this.a, new cog(), 1));
	}

	// Token: 0x04001CB9 RID: 7353
	private new string a;

	// Token: 0x04001CBA RID: 7354
	private bool b;

	// Token: 0x04001CBB RID: 7355
	public static readonly string c = "despawnAegisSecTroopers";
}
