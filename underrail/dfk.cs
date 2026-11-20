using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F8F RID: 8079
[ayj("ThirdEyeConsumation")]
public sealed class dfk : awn
{
	// Token: 0x0600BDAE RID: 48558 RVA: 0x00417FF0 File Offset: 0x004161F0
	public override string y8()
	{
		return "Третий глаз";
	}

	// Token: 0x0600BDAF RID: 48559 RVA: 0x00417FF8 File Offset: 0x004161F8
	public override string os()
	{
		return "ThirdEyeConsumation";
	}

	// Token: 0x0600BDB0 RID: 48560 RVA: 0x00418000 File Offset: 0x00416200
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BDB1 RID: 48561 RVA: 0x00418004 File Offset: 0x00416204
	public override IList<string> bi()
	{
		return this.f;
	}

	// Token: 0x0600BDB2 RID: 48562 RVA: 0x0041800C File Offset: 0x0041620C
	public dfk()
	{
		this.f = new List<string>();
		this.f.Add("thirdEye");
	}

	// Token: 0x0600BDB3 RID: 48563 RVA: 0x00418030 File Offset: 0x00416230
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("thirdEye", 5 * d0u.b, false, false)
		};
	}

	// Token: 0x0600BDB4 RID: 48564 RVA: 0x00418050 File Offset: 0x00416250
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BDB5 RID: 48565 RVA: 0x00418054 File Offset: 0x00416254
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BDB6 RID: 48566 RVA: 0x0041805C File Offset: 0x0041625C
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/ThirdEye", new object[]
		{
			(int)(dfk.c * 100.0),
			dfk.d,
			l4.a(dfk.a, false)
		});
	}

	// Token: 0x04004433 RID: 17459
	public new static readonly int a = 15;

	// Token: 0x04004434 RID: 17460
	private const int b = 5;

	// Token: 0x04004435 RID: 17461
	public static readonly double c = 0.3;

	// Token: 0x04004436 RID: 17462
	public static readonly int d = 3;

	// Token: 0x04004437 RID: 17463
	private new const string e = "thirdEye";

	// Token: 0x04004438 RID: 17464
	private List<string> f;
}
