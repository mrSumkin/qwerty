using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E82 RID: 7810
[ayj("taze")]
public sealed class c09 : m0
{
	// Token: 0x0600AE76 RID: 44662 RVA: 0x003FC298 File Offset: 0x003FA498
	public override string y8()
	{
		return "Taze";
	}

	// Token: 0x0600AE77 RID: 44663 RVA: 0x003FC2A0 File Offset: 0x003FA4A0
	public override string os()
	{
		return "taze";
	}

	// Token: 0x0600AE78 RID: 44664 RVA: 0x003FC2A8 File Offset: 0x003FA4A8
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AE79 RID: 44665 RVA: 0x003FC2AC File Offset: 0x003FA4AC
	public override bool cz()
	{
		return false;
	}

	// Token: 0x0600AE7A RID: 44666 RVA: 0x003FC2B0 File Offset: 0x003FA4B0
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.j
		};
	}

	// Token: 0x0600AE7B RID: 44667 RVA: 0x003FC2C4 File Offset: 0x003FA4C4
	public override bool q2()
	{
		return false;
	}

	// Token: 0x0600AE7C RID: 44668 RVA: 0x003FC2C8 File Offset: 0x003FA4C8
	public c09()
	{
		this.c = new List<string>();
		this.c.Add("taze");
	}

	// Token: 0x0600AE7D RID: 44669 RVA: 0x003FC2EC File Offset: 0x003FA4EC
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AE7E RID: 44670 RVA: 0x003FC2F0 File Offset: 0x003FA4F0
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Creature;
	}

	// Token: 0x0600AE7F RID: 44671 RVA: 0x003FC2F4 File Offset: 0x003FA4F4
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600AE80 RID: 44672 RVA: 0x003FC2FC File Offset: 0x003FA4FC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("taze", c09.b, false, false)
		};
	}

	// Token: 0x0600AE81 RID: 44673 RVA: 0x003FC31C File Offset: 0x003FA51C
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600AE82 RID: 44674 RVA: 0x003FC324 File Offset: 0x003FA524
	public static a1q a()
	{
		return new a1q(DamageType.Electricity, 8, 12);
	}

	// Token: 0x0600AE83 RID: 44675 RVA: 0x003FC330 File Offset: 0x003FA530
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600AE84 RID: 44676 RVA: 0x003FC338 File Offset: 0x003FA538
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x0400407A RID: 16506
	private new const string a = "taze";

	// Token: 0x0400407B RID: 16507
	public static readonly int b = 25000;

	// Token: 0x0400407C RID: 16508
	private List<string> c;
}
