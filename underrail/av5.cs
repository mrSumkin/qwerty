using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F38 RID: 7992
[ayj("InsertSkerderGraveCrank")]
public sealed class av5 : m0
{
	// Token: 0x0600B9B0 RID: 47536 RVA: 0x004125E4 File Offset: 0x004107E4
	public override string y8()
	{
		return "InsertSkerderGraveCrank";
	}

	// Token: 0x0600B9B1 RID: 47537 RVA: 0x004125EC File Offset: 0x004107EC
	public override string os()
	{
		return "InsertSkerderGraveCrank";
	}

	// Token: 0x0600B9B2 RID: 47538 RVA: 0x004125F4 File Offset: 0x004107F4
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600B9B3 RID: 47539 RVA: 0x004125F8 File Offset: 0x004107F8
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600B9B4 RID: 47540 RVA: 0x004125FC File Offset: 0x004107FC
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600B9B5 RID: 47541 RVA: 0x00412610 File Offset: 0x00410810
	public override string c1()
	{
		return "Вставляет";
	}

	// Token: 0x0600B9B6 RID: 47542 RVA: 0x00412618 File Offset: 0x00410818
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600B9B7 RID: 47543 RVA: 0x0041261C File Offset: 0x0041081C
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600B9B8 RID: 47544 RVA: 0x00412624 File Offset: 0x00410824
	public av5()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600B9B9 RID: 47545 RVA: 0x00412638 File Offset: 0x00410838
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600B9BA RID: 47546 RVA: 0x0041263C File Offset: 0x0041083C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B9BB RID: 47547 RVA: 0x00412640 File Offset: 0x00410840
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.SkerderGraveMechanism;
	}

	// Token: 0x0600B9BC RID: 47548 RVA: 0x00412648 File Offset: 0x00410848
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600B9BD RID: 47549 RVA: 0x00412650 File Offset: 0x00410850
	public override string bp(cnm A_0)
	{
		return qv.b("Items\\Custom/InsertSkerderGraveCrank");
	}

	// Token: 0x0600B9BE RID: 47550 RVA: 0x0041265C File Offset: 0x0041085C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600B9BF RID: 47551 RVA: 0x00412664 File Offset: 0x00410864
	public override dsk cv(cnm A_0)
	{
		return dsk.a;
	}

	// Token: 0x0600B9C0 RID: 47552 RVA: 0x00412668 File Offset: 0x00410868
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B9C1 RID: 47553 RVA: 0x0041266C File Offset: 0x0041086C
	protected override int br(cnm A_0)
	{
		return 5000;
	}

	// Token: 0x04004392 RID: 17298
	private new List<string> a;
}
