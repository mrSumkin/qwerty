using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C4E RID: 7246
public abstract class ci4 : aw2
{
	// Token: 0x06009EFD RID: 40701
	public abstract PsiSchool gp();

	// Token: 0x06009EFE RID: 40702 RVA: 0x003E302C File Offset: 0x003E122C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009EFF RID: 40703 RVA: 0x003E3030 File Offset: 0x003E1230
	public ci4(string A_0) : base(A_0)
	{
	}

	// Token: 0x06009F00 RID: 40704 RVA: 0x003E303C File Offset: 0x003E123C
	public override string wn()
	{
		return "EmpoweredInvocation";
	}

	// Token: 0x06009F01 RID: 40705 RVA: 0x003E3048 File Offset: 0x003E1248
	public override object[] at()
	{
		return new object[]
		{
			this.gp().ToString().a(),
			Convert.ToInt32(cch.b * 100.0),
			l4.a(cch.c, false)
		};
	}

	// Token: 0x06009F02 RID: 40706 RVA: 0x003E30A4 File Offset: 0x003E12A4
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<cch>());
	}

	// Token: 0x06009F03 RID: 40707 RVA: 0x003E30B8 File Offset: 0x003E12B8
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<cch>());
	}

	// Token: 0x06009F04 RID: 40708 RVA: 0x003E30CC File Offset: 0x003E12CC
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		Type type = new axp().a(this.gp().ToString().a()).GetType();
		list.Add(new bap(100, new Type[]
		{
			type
		}));
		list.Add(new b4k(new Type[]
		{
			typeof(c3v)
		}));
		list.Add(new crf(base.GetType()));
		return list;
	}
}
