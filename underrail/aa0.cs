using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E6B RID: 7787
[ayj("Vanish")]
public sealed class aa0 : m0
{
	// Token: 0x0600ACFD RID: 44285 RVA: 0x003FAC24 File Offset: 0x003F8E24
	public override string y8()
	{
		return "Исчезновение";
	}

	// Token: 0x0600ACFE RID: 44286 RVA: 0x003FAC2C File Offset: 0x003F8E2C
	public override string os()
	{
		return "Vanish";
	}

	// Token: 0x0600ACFF RID: 44287 RVA: 0x003FAC34 File Offset: 0x003F8E34
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600AD00 RID: 44288 RVA: 0x003FAC38 File Offset: 0x003F8E38
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.i,
			d = new int?(60)
		};
	}

	// Token: 0x0600AD01 RID: 44289 RVA: 0x003FAC58 File Offset: 0x003F8E58
	public override bool hl()
	{
		return false;
	}

	// Token: 0x0600AD02 RID: 44290 RVA: 0x003FAC5C File Offset: 0x003F8E5C
	public aa0()
	{
		this.d = new List<string>();
		this.d.Add("SA.Vanish");
	}

	// Token: 0x0600AD03 RID: 44291 RVA: 0x003FAC80 File Offset: 0x003F8E80
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x0600AD04 RID: 44292 RVA: 0x003FAC88 File Offset: 0x003F8E88
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600AD05 RID: 44293 RVA: 0x003FAC8C File Offset: 0x003F8E8C
	public override string bo(cnm A_0)
	{
		return qv.b("Items\\Utilities/Vanish");
	}

	// Token: 0x0600AD06 RID: 44294 RVA: 0x003FAC98 File Offset: 0x003F8E98
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600AD07 RID: 44295 RVA: 0x003FACA4 File Offset: 0x003F8EA4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.Vanish", aa0.b * d0u.b, false, false)
		};
	}

	// Token: 0x0600AD08 RID: 44296 RVA: 0x003FACC8 File Offset: 0x003F8EC8
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600AD09 RID: 44297 RVA: 0x003FACD0 File Offset: 0x003F8ED0
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600AD0A RID: 44298 RVA: 0x003FACD4 File Offset: 0x003F8ED4
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && !A_0.b8().SpecialStates.b) && !A_0.b8().SpecialStates.g;
	}

	// Token: 0x0600AD0B RID: 44299 RVA: 0x003FAD2C File Offset: 0x003F8F2C
	protected override int hi(cnm A_0)
	{
		return aa0.c;
	}

	// Token: 0x04004062 RID: 16482
	private new const string a = "SA.Vanish";

	// Token: 0x04004063 RID: 16483
	public static readonly int b = 10;

	// Token: 0x04004064 RID: 16484
	public static readonly int c = 10;

	// Token: 0x04004065 RID: 16485
	private List<string> d;
}
