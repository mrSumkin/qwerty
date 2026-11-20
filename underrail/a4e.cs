using System;
using System.Collections.Generic;

// Token: 0x020007EE RID: 2030
public sealed class a4e : el4
{
	// Token: 0x06003305 RID: 13061 RVA: 0x0013E600 File Offset: 0x0013C800
	public override bool fk()
	{
		return true;
	}

	// Token: 0x06003306 RID: 13062 RVA: 0x0013E604 File Offset: 0x0013C804
	protected override esj a3()
	{
		return new esj(5, 5);
	}

	// Token: 0x06003307 RID: 13063 RVA: 0x0013E610 File Offset: 0x0013C810
	public override string a4()
	{
		return "LUX_MS";
	}

	// Token: 0x06003308 RID: 13064 RVA: 0x0013E618 File Offset: 0x0013C818
	public override string a5()
	{
		return "Midsummer";
	}

	// Token: 0x06003309 RID: 13065 RVA: 0x0013E620 File Offset: 0x0013C820
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		if (!base.e2(A_0, A_1, A_2))
		{
			return false;
		}
		DateTime t = new DateTime(DateTime.Now.Year, 6, 19);
		DateTime t2 = new DateTime(DateTime.Now.Year, 6, 25);
		return DateTime.Today >= t && DateTime.Today <= t2;
	}

	// Token: 0x0600330A RID: 13066 RVA: 0x0013E688 File Offset: 0x0013C888
	public override double ke()
	{
		return e3a.e;
	}

	// Token: 0x0600330B RID: 13067 RVA: 0x0013E690 File Offset: 0x0013C890
	protected override int? g2()
	{
		return new int?(7);
	}

	// Token: 0x0600330C RID: 13068 RVA: 0x0013E698 File Offset: 0x0013C898
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x0600330D RID: 13069 RVA: 0x0013E69C File Offset: 0x0013C89C
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x0600330E RID: 13070 RVA: 0x0013E6B4 File Offset: 0x0013C8B4
	public a4e() : base(new string[]
	{
		ega.a,
		ega.b
	})
	{
	}

	// Token: 0x0600330F RID: 13071 RVA: 0x0013E6D8 File Offset: 0x0013C8D8
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		d9m d9m = new d9m();
		d9m.a(2200);
		List<cze> list = d9m.c();
		egx egx = new egx();
		egx.b(true);
		egx.a("::Вы слышите смех... женский смех.");
		list.Add(egx);
		d9m.ym(A_0.v().b(), null, null);
	}
}
