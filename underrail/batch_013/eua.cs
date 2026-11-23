using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EC4 RID: 7876
[ayj("AutoAttack")]
public sealed class eua : bon
{
	// Token: 0x0600B1DE RID: 45534 RVA: 0x0040337C File Offset: 0x0040157C
	public override string y8()
	{
		return "Атака";
	}

	// Token: 0x0600B1DF RID: 45535 RVA: 0x00403384 File Offset: 0x00401584
	public override string os()
	{
		return "AutoAttack";
	}

	// Token: 0x0600B1E0 RID: 45536 RVA: 0x0040338C File Offset: 0x0040158C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B1E1 RID: 45537 RVA: 0x00403390 File Offset: 0x00401590
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600B1E2 RID: 45538 RVA: 0x00403394 File Offset: 0x00401594
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B1E3 RID: 45539 RVA: 0x00403398 File Offset: 0x00401598
	public override int bh()
	{
		return int.MinValue;
	}

	// Token: 0x0600B1E4 RID: 45540 RVA: 0x004033A0 File Offset: 0x004015A0
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.Attack);
	}

	// Token: 0x0600B1E5 RID: 45541 RVA: 0x004033A8 File Offset: 0x004015A8
	public override bool j7()
	{
		return true;
	}

	// Token: 0x0600B1E7 RID: 45543 RVA: 0x004033B8 File Offset: 0x004015B8
	public override string bm(cnm A_0)
	{
		if (A_0 != null)
		{
			return A_0.b8().Offense.u().Definition.a3();
		}
		return "Misc.0";
	}

	// Token: 0x0600B1E8 RID: 45544 RVA: 0x004033EC File Offset: 0x004015EC
	public override bool cu(cnm A_0)
	{
		return base.cu(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() != btz.g;
	}

	// Token: 0x0600B1E9 RID: 45545 RVA: 0x00403468 File Offset: 0x00401668
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0 != null && A_0.b8() != null)
		{
			io service = bpo.GetService<io>();
			if (service != null && service.ahg())
			{
				return service.ahv(A_0.b8()) >= A_0.b8().Offense.av();
			}
		}
		return true;
	}

	// Token: 0x0600B1EA RID: 45546 RVA: 0x004034D0 File Offset: 0x004016D0
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B1EB RID: 45547 RVA: 0x004034D4 File Offset: 0x004016D4
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAttacks/AutoAttack");
	}

	// Token: 0x0600B1EC RID: 45548 RVA: 0x004034E0 File Offset: 0x004016E0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600B1ED RID: 45549 RVA: 0x004034E8 File Offset: 0x004016E8
	public override IList<string> bi()
	{
		return new List<string>();
	}

	// Token: 0x0600B1EE RID: 45550 RVA: 0x004034F0 File Offset: 0x004016F0
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B1EF RID: 45551 RVA: 0x004034F4 File Offset: 0x004016F4
	protected override int hi(cnm A_0)
	{
		return 0;
	}
}
