using System;

// Token: 0x0200080E RID: 2062
public abstract class eg7 : el4
{
	// Token: 0x06003407 RID: 13319 RVA: 0x00142934 File Offset: 0x00140B34
	protected override esj a3()
	{
		return new esj(1, 1);
	}

	// Token: 0x06003408 RID: 13320 RVA: 0x00142940 File Offset: 0x00140B40
	public override string a4()
	{
		return "LC_PT" + this.a.ToString();
	}

	// Token: 0x06003409 RID: 13321 RVA: 0x00142958 File Offset: 0x00140B58
	public override string a5()
	{
		return "Lost Container " + this.a.ToString();
	}

	// Token: 0x0600340A RID: 13322 RVA: 0x00142970 File Offset: 0x00140B70
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x0600340B RID: 13323 RVA: 0x00142974 File Offset: 0x00140B74
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x0600340C RID: 13324 RVA: 0x0014297C File Offset: 0x00140B7C
	protected override TimeSpan? a8()
	{
		return null;
	}

	// Token: 0x0600340D RID: 13325 RVA: 0x00142994 File Offset: 0x00140B94
	public override bool a9()
	{
		return true;
	}

	// Token: 0x0600340E RID: 13326 RVA: 0x00142998 File Offset: 0x00140B98
	protected eg7(int A_0) : base(new string[]
	{
		ega.g,
		ega.h,
		ega.e,
		ega.j
	})
	{
		this.a = A_0;
	}

	// Token: 0x0600340F RID: 13327 RVA: 0x001429D0 File Offset: 0x00140BD0
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2);
	}

	// Token: 0x06003410 RID: 13328 RVA: 0x001429E8 File Offset: 0x00140BE8
	protected override void iy(c5x A_0)
	{
		base.iy(A_0);
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bfc bfc = serviceOrThrow.aqu().h();
			if (bfc != null)
			{
				A_0 = d06.a(A_0, bfc);
			}
		}
	}

	// Token: 0x04001B80 RID: 7040
	private new int a;
}
