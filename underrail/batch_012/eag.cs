using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F04 RID: 7940
[ayj("Pickpocket")]
public sealed class eag : c0z
{
	// Token: 0x0600B608 RID: 46600 RVA: 0x0040A8C8 File Offset: 0x00408AC8
	public override string y8()
	{
		return "Кража";
	}

	// Token: 0x0600B609 RID: 46601 RVA: 0x0040A8D0 File Offset: 0x00408AD0
	public override string os()
	{
		return "Pickpocket";
	}

	// Token: 0x0600B60A RID: 46602 RVA: 0x0040A8D8 File Offset: 0x00408AD8
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B60B RID: 46603 RVA: 0x0040A8DC File Offset: 0x00408ADC
	public override int bh()
	{
		return -2147483647;
	}

	// Token: 0x0600B60C RID: 46604 RVA: 0x0040A8E4 File Offset: 0x00408AE4
	public override bool ar4()
	{
		return false;
	}

	// Token: 0x0600B60D RID: 46605 RVA: 0x0040A8E8 File Offset: 0x00408AE8
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.Pickpocket);
	}

	// Token: 0x0600B60E RID: 46606 RVA: 0x0040A8F4 File Offset: 0x00408AF4
	public override string c1()
	{
		return "Кража";
	}

	// Token: 0x0600B60F RID: 46607 RVA: 0x0040A8FC File Offset: 0x00408AFC
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600B610 RID: 46608 RVA: 0x0040A900 File Offset: 0x00408B00
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600B611 RID: 46609 RVA: 0x0040A914 File Offset: 0x00408B14
	public override bool hl()
	{
		return false;
	}

	// Token: 0x0600B613 RID: 46611 RVA: 0x0040A920 File Offset: 0x00408B20
	public override string bm(cnm A_0)
	{
		return "Abilities.20";
	}

	// Token: 0x0600B614 RID: 46612 RVA: 0x0040A928 File Offset: 0x00408B28
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.HumanoidNotSelf;
	}

	// Token: 0x0600B615 RID: 46613 RVA: 0x0040A92C File Offset: 0x00408B2C
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAbilities/Pickpocket");
	}

	// Token: 0x0600B616 RID: 46614 RVA: 0x0040A938 File Offset: 0x00408B38
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.Pickpocket", 5000, false, false)
		};
	}

	// Token: 0x0600B617 RID: 46615 RVA: 0x0040A958 File Offset: 0x00408B58
	public override IList<string> bi()
	{
		return new List<string>
		{
			"SA.Pickpocket"
		};
	}

	// Token: 0x0600B618 RID: 46616 RVA: 0x0040A96C File Offset: 0x00408B6C
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B619 RID: 46617 RVA: 0x0040A970 File Offset: 0x00408B70
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B61A RID: 46618 RVA: 0x0040A974 File Offset: 0x00408B74
	protected override int br(cnm A_0)
	{
		return 4000;
	}

	// Token: 0x0600B61B RID: 46619 RVA: 0x0040A97C File Offset: 0x00408B7C
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600B61C RID: 46620 RVA: 0x0040A984 File Offset: 0x00408B84
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && !A_0.b8().IsInCombat && !bzl.a();
	}

	// Token: 0x0600B61D RID: 46621 RVA: 0x0040A9B0 File Offset: 0x00408BB0
	protected override float te(cnm A_0)
	{
		float num = 1f;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<b1w>())
		{
			num -= (float)((double)b1w.a + (double)A_0.b8().GetSpecializationValue<cdm>(true) * cdm.a);
		}
		return base.te(A_0) * num;
	}

	// Token: 0x0600B61E RID: 46622 RVA: 0x0040AA10 File Offset: 0x00408C10
	protected override float cl(cnm A_0)
	{
		float num = 1f;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<b1w>())
		{
			num -= (float)((double)b1w.a + (double)A_0.b8().GetSpecializationValue<cdm>(true) * cdm.a);
		}
		return base.cl(A_0) * num;
	}

	// Token: 0x0400423B RID: 16955
	private new const string a = "Pickpocket";

	// Token: 0x0400423C RID: 16956
	private const string b = "SA.Pickpocket";
}
