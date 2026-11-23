using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001ED8 RID: 7896
[ayj("PickUpThrownSpear")]
public sealed class bmb : c0z
{
	// Token: 0x0600B336 RID: 45878 RVA: 0x004064B4 File Offset: 0x004046B4
	public override string y8()
	{
		return "Подхват оружия";
	}

	// Token: 0x0600B337 RID: 45879 RVA: 0x004064BC File Offset: 0x004046BC
	public override string os()
	{
		return "PickUpThrownSpear";
	}

	// Token: 0x0600B338 RID: 45880 RVA: 0x004064C4 File Offset: 0x004046C4
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B339 RID: 45881 RVA: 0x004064C8 File Offset: 0x004046C8
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B33A RID: 45882 RVA: 0x004064CC File Offset: 0x004046CC
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.j
		};
	}

	// Token: 0x0600B33B RID: 45883 RVA: 0x004064E0 File Offset: 0x004046E0
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600B33C RID: 45884 RVA: 0x004064E4 File Offset: 0x004046E4
	public bmb()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600B33D RID: 45885 RVA: 0x004064F8 File Offset: 0x004046F8
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.23";
	}

	// Token: 0x0600B33E RID: 45886 RVA: 0x00406500 File Offset: 0x00404700
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B33F RID: 45887 RVA: 0x00406504 File Offset: 0x00404704
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAbilities/PickUpThrownSpear");
	}

	// Token: 0x0600B340 RID: 45888 RVA: 0x00406510 File Offset: 0x00404710
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600B341 RID: 45889 RVA: 0x00406518 File Offset: 0x00404718
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600B342 RID: 45890 RVA: 0x00406520 File Offset: 0x00404720
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B343 RID: 45891 RVA: 0x00406524 File Offset: 0x00404724
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x04004190 RID: 16784
	private new List<string> a;
}
