using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000F9F RID: 3999
[ayj("MotionConsumation")]
public sealed class ejo : awn
{
	// Token: 0x060051B3 RID: 20915 RVA: 0x0024C03C File Offset: 0x0024A23C
	public override string y8()
	{
		return "Движение";
	}

	// Token: 0x060051B4 RID: 20916 RVA: 0x0024C044 File Offset: 0x0024A244
	public override string os()
	{
		return "MotionConsumation";
	}

	// Token: 0x060051B5 RID: 20917 RVA: 0x0024C04C File Offset: 0x0024A24C
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x060051B6 RID: 20918 RVA: 0x0024C050 File Offset: 0x0024A250
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x060051B7 RID: 20919 RVA: 0x0024C054 File Offset: 0x0024A254
	public ejo()
	{
		this.a = new List<string>();
	}

	// Token: 0x060051B8 RID: 20920 RVA: 0x0024C068 File Offset: 0x0024A268
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x060051B9 RID: 20921 RVA: 0x0024C06C File Offset: 0x0024A26C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x060051BA RID: 20922 RVA: 0x0024C070 File Offset: 0x0024A270
	public override string bo(cnm A_0)
	{
		return "Приводит кота в движение.";
	}

	// Token: 0x060051BB RID: 20923 RVA: 0x0024C078 File Offset: 0x0024A278
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x060051BC RID: 20924 RVA: 0x0024C080 File Offset: 0x0024A280
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x060051BD RID: 20925 RVA: 0x0024C088 File Offset: 0x0024A288
	protected override int ma(cnm A_0)
	{
		return ejo.b;
	}

	// Token: 0x060051BE RID: 20926 RVA: 0x0024C090 File Offset: 0x0024A290
	protected override int mb(cnm A_0)
	{
		return ejo.b / ejo.c;
	}

	// Token: 0x04002188 RID: 8584
	private new List<string> a;

	// Token: 0x04002189 RID: 8585
	public static readonly int b = 10000;

	// Token: 0x0400218A RID: 8586
	public static readonly int c = 10;
}
