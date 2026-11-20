using System;

// Token: 0x020007ED RID: 2029
public sealed class a07 : el4
{
	// Token: 0x060032FB RID: 13051 RVA: 0x0013E550 File Offset: 0x0013C750
	protected override esj a3()
	{
		return new esj(1, 1);
	}

	// Token: 0x060032FC RID: 13052 RVA: 0x0013E55C File Offset: 0x0013C75C
	public override string a4()
	{
		return "GC_APRIL";
	}

	// Token: 0x060032FD RID: 13053 RVA: 0x0013E564 File Offset: 0x0013C764
	public override string a5()
	{
		return "Апрельские дурачки";
	}

	// Token: 0x060032FE RID: 13054 RVA: 0x0013E56C File Offset: 0x0013C76C
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		if (!base.e2(A_0, A_1, A_2))
		{
			return false;
		}
		DateTime d = new DateTime(DateTime.Now.Year, 4, 1);
		return DateTime.Today == d;
	}

	// Token: 0x060032FF RID: 13055 RVA: 0x0013E5AC File Offset: 0x0013C7AC
	public override double ke()
	{
		return e3a.e;
	}

	// Token: 0x06003300 RID: 13056 RVA: 0x0013E5B4 File Offset: 0x0013C7B4
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003301 RID: 13057 RVA: 0x0013E5B8 File Offset: 0x0013C7B8
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(20.0));
	}

	// Token: 0x06003302 RID: 13058 RVA: 0x0013E5D0 File Offset: 0x0013C7D0
	public override bool fk()
	{
		return true;
	}

	// Token: 0x06003303 RID: 13059 RVA: 0x0013E5D4 File Offset: 0x0013C7D4
	public override bool fl()
	{
		return true;
	}

	// Token: 0x06003304 RID: 13060 RVA: 0x0013E5D8 File Offset: 0x0013C7D8
	public a07() : base(new string[]
	{
		ega.ah,
		ega.ap,
		ega.ag
	})
	{
	}
}
