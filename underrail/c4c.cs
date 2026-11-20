using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000FA8 RID: 4008
[ayj("JumpstarterBoost")]
public sealed class c4c : c0z
{
	// Token: 0x060051E8 RID: 20968 RVA: 0x0024C804 File Offset: 0x0024AA04
	public override string y8()
	{
		return "Jumpstarter Boost";
	}

	// Token: 0x060051E9 RID: 20969 RVA: 0x0024C80C File Offset: 0x0024AA0C
	public override string os()
	{
		return "JumpstarterBoost";
	}

	// Token: 0x060051EA RID: 20970 RVA: 0x0024C814 File Offset: 0x0024AA14
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x060051EB RID: 20971 RVA: 0x0024C818 File Offset: 0x0024AA18
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.j
		};
	}

	// Token: 0x060051EC RID: 20972 RVA: 0x0024C82C File Offset: 0x0024AA2C
	public override bool hl()
	{
		return true;
	}

	// Token: 0x060051ED RID: 20973 RVA: 0x0024C830 File Offset: 0x0024AA30
	public override bool bk()
	{
		return true;
	}

	// Token: 0x060051EE RID: 20974 RVA: 0x0024C834 File Offset: 0x0024AA34
	public override bool xc()
	{
		return true;
	}

	// Token: 0x060051EF RID: 20975 RVA: 0x0024C838 File Offset: 0x0024AA38
	public c4c()
	{
		this.e = new List<string>();
		this.e.Add("SA.JumpstarterBoost");
	}

	// Token: 0x060051F0 RID: 20976 RVA: 0x0024C85C File Offset: 0x0024AA5C
	public override string bm(cnm A_0)
	{
		return "Status.139";
	}

	// Token: 0x060051F1 RID: 20977 RVA: 0x0024C864 File Offset: 0x0024AA64
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x060051F2 RID: 20978 RVA: 0x0024C868 File Offset: 0x0024AA68
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Utilities/JumpstarterBoost", new object[]
		{
			c4c.d,
			l4.a(c4c.c, false)
		});
	}

	// Token: 0x060051F3 RID: 20979 RVA: 0x0024C898 File Offset: 0x0024AA98
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x060051F4 RID: 20980 RVA: 0x0024C8A4 File Offset: 0x0024AAA4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.JumpstarterBoost", c4c.b * d0u.b, false, false)
		};
	}

	// Token: 0x060051F5 RID: 20981 RVA: 0x0024C8C8 File Offset: 0x0024AAC8
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x060051F6 RID: 20982 RVA: 0x0024C8D0 File Offset: 0x0024AAD0
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x060051F7 RID: 20983 RVA: 0x0024C8D4 File Offset: 0x0024AAD4
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0400218D RID: 8589
	private new const string a = "SA.JumpstarterBoost";

	// Token: 0x0400218E RID: 8590
	public static readonly int b = 10;

	// Token: 0x0400218F RID: 8591
	public static readonly int c = 3;

	// Token: 0x04002190 RID: 8592
	public static readonly int d = 2;

	// Token: 0x04002191 RID: 8593
	private new List<string> e;
}
