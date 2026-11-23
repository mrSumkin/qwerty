using System;

// Token: 0x02000810 RID: 2064
public abstract class m2 : el4
{
	// Token: 0x0600341B RID: 13339 RVA: 0x00142F20 File Offset: 0x00141120
	protected override esj a3()
	{
		return new esj(1, 1);
	}

	// Token: 0x0600341C RID: 13340 RVA: 0x00142F2C File Offset: 0x0014112C
	public override string a4()
	{
		return "Xpbl_LC_" + this.b + this.a.ToString();
	}

	// Token: 0x0600341D RID: 13341 RVA: 0x00142F4C File Offset: 0x0014114C
	public override string a5()
	{
		return "Lemurian Lost Container " + this.b + this.a.ToString();
	}

	// Token: 0x0600341E RID: 13342 RVA: 0x00142F6C File Offset: 0x0014116C
	public override string ix()
	{
		return "xpbl";
	}

	// Token: 0x0600341F RID: 13343 RVA: 0x00142F74 File Offset: 0x00141174
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x06003420 RID: 13344 RVA: 0x00142F78 File Offset: 0x00141178
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x06003421 RID: 13345 RVA: 0x00142F7C File Offset: 0x0014117C
	protected override TimeSpan? a8()
	{
		return null;
	}

	// Token: 0x06003422 RID: 13346 RVA: 0x00142F94 File Offset: 0x00141194
	public override bool a9()
	{
		return true;
	}

	// Token: 0x06003423 RID: 13347 RVA: 0x00142F98 File Offset: 0x00141198
	protected m2(int A_0, string A_1) : base(new string[]
	{
		ega.ba
	})
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06003424 RID: 13348 RVA: 0x00142FBC File Offset: 0x001411BC
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2);
	}

	// Token: 0x06003425 RID: 13349 RVA: 0x00142FD0 File Offset: 0x001411D0
	protected override void iy(c5x A_0)
	{
		base.iy(A_0);
		if (this.b == "BOX")
		{
			alv aspect = A_0.GetAspect<alv>();
			if (aspect != null)
			{
				int num = cuo.a.Next(0, 3);
				if (num != 0)
				{
					aspect.a[0].b.X = num;
					aspect.a[1].b.X = num;
				}
			}
		}
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

	// Token: 0x04001B82 RID: 7042
	private new int a;

	// Token: 0x04001B83 RID: 7043
	private string b;
}
