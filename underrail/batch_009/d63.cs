using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EAC RID: 7852
[ayj("GiantSpiderLeapAttack")]
public sealed class d63 : bon
{
	// Token: 0x0600B0A0 RID: 45216 RVA: 0x00400404 File Offset: 0x003FE604
	public override string y8()
	{
		return "Giant Spider Leap Attack";
	}

	// Token: 0x0600B0A1 RID: 45217 RVA: 0x0040040C File Offset: 0x003FE60C
	public override string os()
	{
		return "GiantSpiderLeapAttack";
	}

	// Token: 0x0600B0A2 RID: 45218 RVA: 0x00400414 File Offset: 0x003FE614
	public override string c1()
	{
		return "Удар в прыжке";
	}

	// Token: 0x0600B0A3 RID: 45219 RVA: 0x0040041C File Offset: 0x003FE61C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B0A4 RID: 45220 RVA: 0x00400420 File Offset: 0x003FE620
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600B0A5 RID: 45221 RVA: 0x00400424 File Offset: 0x003FE624
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B0A6 RID: 45222 RVA: 0x00400428 File Offset: 0x003FE628
	public d63()
	{
		this.c = new List<string>();
		this.c.Add(d7f.a);
		this.c.Add("SAt.GiantSpiderLeapAttack");
	}

	// Token: 0x0600B0A7 RID: 45223 RVA: 0x0040045C File Offset: 0x003FE65C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B0A8 RID: 45224 RVA: 0x00400460 File Offset: 0x003FE660
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B0A9 RID: 45225 RVA: 0x00400464 File Offset: 0x003FE664
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600B0AA RID: 45226 RVA: 0x00400470 File Offset: 0x003FE670
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.GiantSpiderLeapAttack", d63.b, false, false));
		return list;
	}

	// Token: 0x0600B0AB RID: 45227 RVA: 0x004004BC File Offset: 0x003FE6BC
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B0AC RID: 45228 RVA: 0x004004C4 File Offset: 0x003FE6C4
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x040040E4 RID: 16612
	private new const string a = "SAt.GiantSpiderLeapAttack";

	// Token: 0x040040E5 RID: 16613
	public static readonly int b = 15000;

	// Token: 0x040040E6 RID: 16614
	private List<string> c;
}
