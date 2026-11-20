using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001ED5 RID: 7893
[ayj("ShootingSpree")]
public sealed class bcq : c0z
{
	// Token: 0x0600B303 RID: 45827 RVA: 0x00405FAC File Offset: 0x004041AC
	public override string y8()
	{
		return "Весёлая стрельба";
	}

	// Token: 0x0600B304 RID: 45828 RVA: 0x00405FB4 File Offset: 0x004041B4
	public override string os()
	{
		return "ShootingSpree";
	}

	// Token: 0x0600B305 RID: 45829 RVA: 0x00405FBC File Offset: 0x004041BC
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B306 RID: 45830 RVA: 0x00405FC0 File Offset: 0x004041C0
	public override int e8()
	{
		return 2;
	}

	// Token: 0x0600B307 RID: 45831 RVA: 0x00405FC4 File Offset: 0x004041C4
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600B308 RID: 45832 RVA: 0x00405FC8 File Offset: 0x004041C8
	public bcq()
	{
		this.b = new List<string>();
		this.b.Add(bcq.a);
	}

	// Token: 0x0600B309 RID: 45833 RVA: 0x00405FEC File Offset: 0x004041EC
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.25";
	}

	// Token: 0x0600B30A RID: 45834 RVA: 0x00405FF4 File Offset: 0x004041F4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B30B RID: 45835 RVA: 0x00405FF8 File Offset: 0x004041F8
	public override string bo(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().GetSpecializationValue<ac6>(true) > 0)
		{
			return qv.b("SpecialAbilities/ShootingSpree2");
		}
		return qv.b("SpecialAbilities/ShootingSpree");
	}

	// Token: 0x0600B30C RID: 45836 RVA: 0x00406034 File Offset: 0x00404234
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		int num = elj.b;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= A_0.b8().GetSpecializationValue<b3t>(true) * b3t.a;
		}
		return new List<cfd>
		{
			new cfd(bcq.a, num * d0u.b, false, false)
		};
	}

	// Token: 0x0600B30D RID: 45837 RVA: 0x0040608C File Offset: 0x0040428C
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600B30E RID: 45838 RVA: 0x00406094 File Offset: 0x00404294
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B30F RID: 45839 RVA: 0x00406098 File Offset: 0x00404298
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0400417F RID: 16767
	public new static readonly string a = "SA.ShootingSpree";

	// Token: 0x04004180 RID: 16768
	private List<string> b;
}
