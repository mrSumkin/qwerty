using System;

// Token: 0x0200084F RID: 2127
public abstract class cez : el4
{
	// Token: 0x060034AE RID: 13486 RVA: 0x00143CF8 File Offset: 0x00141EF8
	public override string a4()
	{
		return "RB_PT" + this.a.ToString();
	}

	// Token: 0x060034AF RID: 13487 RVA: 0x00143D10 File Offset: 0x00141F10
	public override string a5()
	{
		return "Robot Patrol " + this.a.ToString();
	}

	// Token: 0x060034B0 RID: 13488 RVA: 0x00143D28 File Offset: 0x00141F28
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060034B1 RID: 13489 RVA: 0x00143D2C File Offset: 0x00141F2C
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x060034B2 RID: 13490 RVA: 0x00143D44 File Offset: 0x00141F44
	protected override int? g2()
	{
		return this.b;
	}

	// Token: 0x060034B3 RID: 13491 RVA: 0x00143D4C File Offset: 0x00141F4C
	protected override int? ox()
	{
		return this.c;
	}

	// Token: 0x060034B4 RID: 13492 RVA: 0x00143D58 File Offset: 0x00141F58
	public cez(int A_0, int? A_1 = null, int? A_2 = null) : base(new string[]
	{
		ega.h,
		ega.g,
		ega.e,
		ega.bw
	})
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x04001B89 RID: 7049
	private new int a;

	// Token: 0x04001B8A RID: 7050
	private int? b;

	// Token: 0x04001B8B RID: 7051
	private new int? c;
}
