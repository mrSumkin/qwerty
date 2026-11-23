using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F3F RID: 7999
[ayj("rigOldJunkyardCavern")]
public sealed class b9 : m0
{
	// Token: 0x0600BA2A RID: 47658 RVA: 0x00412A44 File Offset: 0x00410C44
	public override string y8()
	{
		return "rigOldJunkyardCavern";
	}

	// Token: 0x0600BA2B RID: 47659 RVA: 0x00412A4C File Offset: 0x00410C4C
	public override string os()
	{
		return "rigOldJunkyardCavern";
	}

	// Token: 0x0600BA2C RID: 47660 RVA: 0x00412A54 File Offset: 0x00410C54
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600BA2D RID: 47661 RVA: 0x00412A58 File Offset: 0x00410C58
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600BA2E RID: 47662 RVA: 0x00412A5C File Offset: 0x00410C5C
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600BA2F RID: 47663 RVA: 0x00412A70 File Offset: 0x00410C70
	public override string c1()
	{
		return "Устанавливает";
	}

	// Token: 0x0600BA30 RID: 47664 RVA: 0x00412A78 File Offset: 0x00410C78
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600BA31 RID: 47665 RVA: 0x00412A7C File Offset: 0x00410C7C
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600BA32 RID: 47666 RVA: 0x00412A84 File Offset: 0x00410C84
	public b9()
	{
		this.c = new List<string>();
		this.c.Add("RigOldJunkyardCavern");
	}

	// Token: 0x0600BA33 RID: 47667 RVA: 0x00412AA8 File Offset: 0x00410CA8
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600BA34 RID: 47668 RVA: 0x00412AAC File Offset: 0x00410CAC
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BA35 RID: 47669 RVA: 0x00412AB0 File Offset: 0x00410CB0
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BA36 RID: 47670 RVA: 0x00412AB4 File Offset: 0x00410CB4
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600BA37 RID: 47671 RVA: 0x00412ABC File Offset: 0x00410CBC
	public override string bp(cnm A_0)
	{
		return qv.b("Items\\Custom/RigOldJunkyardCavern");
	}

	// Token: 0x0600BA38 RID: 47672 RVA: 0x00412AC8 File Offset: 0x00410CC8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("RigOldJunkyardCavern", b9.b, false, false)
		};
	}

	// Token: 0x0600BA39 RID: 47673 RVA: 0x00412AE8 File Offset: 0x00410CE8
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BA3A RID: 47674 RVA: 0x00412AEC File Offset: 0x00410CEC
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600BA3B RID: 47675 RVA: 0x00412AF0 File Offset: 0x00410CF0
	protected override int br(cnm A_0)
	{
		return 5000;
	}

	// Token: 0x040043A0 RID: 17312
	private new const string a = "RigOldJunkyardCavern";

	// Token: 0x040043A1 RID: 17313
	public static readonly int b = 1000;

	// Token: 0x040043A2 RID: 17314
	private List<string> c;
}
