using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F3E RID: 7998
[ayj("placePsiAmplifier")]
public sealed class c1t : m0
{
	// Token: 0x0600BA18 RID: 47640 RVA: 0x0041298C File Offset: 0x00410B8C
	public override string y8()
	{
		return "placePsiAmplifier";
	}

	// Token: 0x0600BA19 RID: 47641 RVA: 0x00412994 File Offset: 0x00410B94
	public override string os()
	{
		return "placePsiAmplifier";
	}

	// Token: 0x0600BA1A RID: 47642 RVA: 0x0041299C File Offset: 0x00410B9C
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600BA1B RID: 47643 RVA: 0x004129A0 File Offset: 0x00410BA0
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600BA1C RID: 47644 RVA: 0x004129A4 File Offset: 0x00410BA4
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600BA1D RID: 47645 RVA: 0x004129B8 File Offset: 0x00410BB8
	public override string c1()
	{
		return "Устанавливает";
	}

	// Token: 0x0600BA1E RID: 47646 RVA: 0x004129C0 File Offset: 0x00410BC0
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600BA1F RID: 47647 RVA: 0x004129C4 File Offset: 0x00410BC4
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600BA20 RID: 47648 RVA: 0x004129CC File Offset: 0x00410BCC
	public c1t()
	{
		this.c = new List<string>();
		this.c.Add("PlacePsiAmplifier");
	}

	// Token: 0x0600BA21 RID: 47649 RVA: 0x004129F0 File Offset: 0x00410BF0
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600BA22 RID: 47650 RVA: 0x004129F4 File Offset: 0x00410BF4
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BA23 RID: 47651 RVA: 0x004129F8 File Offset: 0x00410BF8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BA24 RID: 47652 RVA: 0x004129FC File Offset: 0x00410BFC
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600BA25 RID: 47653 RVA: 0x00412A04 File Offset: 0x00410C04
	public override string bp(cnm A_0)
	{
		return qv.b("Items\\Custom/PlacePsiAmplifier");
	}

	// Token: 0x0600BA26 RID: 47654 RVA: 0x00412A10 File Offset: 0x00410C10
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("PlacePsiAmplifier", c1t.b, false, false)
		};
	}

	// Token: 0x0600BA27 RID: 47655 RVA: 0x00412A30 File Offset: 0x00410C30
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BA28 RID: 47656 RVA: 0x00412A34 File Offset: 0x00410C34
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0400439D RID: 17309
	private new const string a = "PlacePsiAmplifier";

	// Token: 0x0400439E RID: 17310
	public static readonly int b = 1000;

	// Token: 0x0400439F RID: 17311
	private List<string> c;
}
