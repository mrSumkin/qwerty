using System;

// Token: 0x020008C2 RID: 2242
public abstract class b1s : el4
{
	// Token: 0x060037DF RID: 14303 RVA: 0x0014D038 File Offset: 0x0014B238
	protected override esj a3()
	{
		return new esj(1, 1);
	}

	// Token: 0x060037E0 RID: 14304 RVA: 0x0014D044 File Offset: 0x0014B244
	public override string a4()
	{
		return "CC_MUG" + this.a.ToString();
	}

	// Token: 0x060037E1 RID: 14305 RVA: 0x0014D05C File Offset: 0x0014B25C
	public override string a5()
	{
		return "Core City Muggers " + this.a.ToString();
	}

	// Token: 0x060037E2 RID: 14306 RVA: 0x0014D074 File Offset: 0x0014B274
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060037E3 RID: 14307 RVA: 0x0014D078 File Offset: 0x0014B278
	public override bool fl()
	{
		return true;
	}

	// Token: 0x060037E4 RID: 14308 RVA: 0x0014D07C File Offset: 0x0014B27C
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(30.0));
	}

	// Token: 0x060037E5 RID: 14309 RVA: 0x0014D094 File Offset: 0x0014B294
	public b1s(int A_0) : base(new string[]
	{
		ega.an
	})
	{
		this.a = A_0;
	}

	// Token: 0x04001B8F RID: 7055
	private new int a;
}
