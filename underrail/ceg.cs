using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EAA RID: 7850
[ayj("consumingBite")]
public sealed class ceg : bon
{
	// Token: 0x0600B07B RID: 45179 RVA: 0x0040001C File Offset: 0x003FE21C
	public override string y8()
	{
		return "Consuming Bite";
	}

	// Token: 0x0600B07C RID: 45180 RVA: 0x00400024 File Offset: 0x003FE224
	public override string os()
	{
		return "consumingBite";
	}

	// Token: 0x0600B07D RID: 45181 RVA: 0x0040002C File Offset: 0x003FE22C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B07E RID: 45182 RVA: 0x00400030 File Offset: 0x003FE230
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600B07F RID: 45183 RVA: 0x00400034 File Offset: 0x003FE234
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B080 RID: 45184 RVA: 0x00400038 File Offset: 0x003FE238
	public override string c1()
	{
		return "Кусает";
	}

	// Token: 0x0600B081 RID: 45185 RVA: 0x00400040 File Offset: 0x003FE240
	public ceg()
	{
		this.c = new List<string>();
		this.c.Add(d7f.a);
		this.c.Add("SAt.ConsumingBite");
	}

	// Token: 0x0600B082 RID: 45186 RVA: 0x00400074 File Offset: 0x003FE274
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B083 RID: 45187 RVA: 0x00400078 File Offset: 0x003FE278
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.LivingCreatureNotSelf;
	}

	// Token: 0x0600B084 RID: 45188 RVA: 0x0040007C File Offset: 0x003FE27C
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600B085 RID: 45189 RVA: 0x00400088 File Offset: 0x003FE288
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.ConsumingBite", ceg.b, false, false));
		return list;
	}

	// Token: 0x0600B086 RID: 45190 RVA: 0x004000D4 File Offset: 0x003FE2D4
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B087 RID: 45191 RVA: 0x004000DC File Offset: 0x003FE2DC
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B088 RID: 45192 RVA: 0x004000E4 File Offset: 0x003FE2E4
	protected override int hi(cnm A_0)
	{
		return base.hi(A_0) + 10;
	}

	// Token: 0x040040E0 RID: 16608
	private new const string a = "SAt.ConsumingBite";

	// Token: 0x040040E1 RID: 16609
	public static readonly int b = 15000;

	// Token: 0x040040E2 RID: 16610
	private List<string> c;
}
