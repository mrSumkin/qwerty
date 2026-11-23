using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001ECB RID: 7883
[ayj("rend")]
public sealed class cgb : bon
{
	// Token: 0x0600B24B RID: 45643 RVA: 0x00404578 File Offset: 0x00402778
	public override string y8()
	{
		return "Разрывание";
	}

	// Token: 0x0600B24C RID: 45644 RVA: 0x00404580 File Offset: 0x00402780
	public override string os()
	{
		return "rend";
	}

	// Token: 0x0600B24D RID: 45645 RVA: 0x00404588 File Offset: 0x00402788
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B24E RID: 45646 RVA: 0x0040458C File Offset: 0x0040278C
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600B24F RID: 45647 RVA: 0x00404590 File Offset: 0x00402790
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B250 RID: 45648 RVA: 0x00404594 File Offset: 0x00402794
	public cgb()
	{
		this.c = new List<string>();
		this.c.Add(d7f.a);
		this.c.Add("SAt.Rend");
	}

	// Token: 0x0600B251 RID: 45649 RVA: 0x004045C8 File Offset: 0x004027C8
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B252 RID: 45650 RVA: 0x004045CC File Offset: 0x004027CC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B253 RID: 45651 RVA: 0x004045D0 File Offset: 0x004027D0
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600B254 RID: 45652 RVA: 0x004045DC File Offset: 0x004027DC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.Rend", cgb.b, false, false));
		return list;
	}

	// Token: 0x0600B255 RID: 45653 RVA: 0x00404628 File Offset: 0x00402828
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B256 RID: 45654 RVA: 0x00404630 File Offset: 0x00402830
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B257 RID: 45655 RVA: 0x00404638 File Offset: 0x00402838
	protected override int hi(cnm A_0)
	{
		return base.hi(A_0) + 10;
	}

	// Token: 0x0400414F RID: 16719
	private new const string a = "SAt.Rend";

	// Token: 0x04004150 RID: 16720
	public static readonly int b = 15000;

	// Token: 0x04004151 RID: 16721
	private List<string> c;
}
