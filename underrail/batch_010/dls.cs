using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EB8 RID: 7864
[ayj("CrawlerSting")]
public sealed class dls : bon
{
	// Token: 0x0600B145 RID: 45381 RVA: 0x00401D78 File Offset: 0x003FFF78
	public override string y8()
	{
		return "Жало краулера";
	}

	// Token: 0x0600B146 RID: 45382 RVA: 0x00401D80 File Offset: 0x003FFF80
	public override string os()
	{
		return "CrawlerSting";
	}

	// Token: 0x0600B147 RID: 45383 RVA: 0x00401D88 File Offset: 0x003FFF88
	public override string c1()
	{
		return "Жалит";
	}

	// Token: 0x0600B148 RID: 45384 RVA: 0x00401D90 File Offset: 0x003FFF90
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B149 RID: 45385 RVA: 0x00401D94 File Offset: 0x003FFF94
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600B14A RID: 45386 RVA: 0x00401D98 File Offset: 0x003FFF98
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B14B RID: 45387 RVA: 0x00401D9C File Offset: 0x003FFF9C
	public dls()
	{
		this.c = new List<string>();
		this.c.Add(d7f.a);
		this.c.Add("SAt.CrawlerSting");
	}

	// Token: 0x0600B14C RID: 45388 RVA: 0x00401DD0 File Offset: 0x003FFFD0
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B14D RID: 45389 RVA: 0x00401DD4 File Offset: 0x003FFFD4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B14E RID: 45390 RVA: 0x00401DD8 File Offset: 0x003FFFD8
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600B14F RID: 45391 RVA: 0x00401DE0 File Offset: 0x003FFFE0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.CrawlerSting", dls.b, false, false));
		return list;
	}

	// Token: 0x0600B150 RID: 45392 RVA: 0x00401E2C File Offset: 0x0040002C
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B151 RID: 45393 RVA: 0x00401E34 File Offset: 0x00400034
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B152 RID: 45394 RVA: 0x00401E3C File Offset: 0x0040003C
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0400410D RID: 16653
	private new const string a = "SAt.CrawlerSting";

	// Token: 0x0400410E RID: 16654
	public static readonly int b = 15000;

	// Token: 0x0400410F RID: 16655
	private List<string> c;
}
