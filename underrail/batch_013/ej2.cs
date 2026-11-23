using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E79 RID: 7801
[ayj("UtilityBotMove")]
public sealed class ej2 : m0
{
	// Token: 0x0600ADF6 RID: 44534 RVA: 0x003FBB90 File Offset: 0x003F9D90
	public override string y8()
	{
		return "Служебный робот: Передвижение";
	}

	// Token: 0x0600ADF7 RID: 44535 RVA: 0x003FBB98 File Offset: 0x003F9D98
	public override string os()
	{
		return "UtilityBotMove";
	}

	// Token: 0x0600ADF8 RID: 44536 RVA: 0x003FBBA0 File Offset: 0x003F9DA0
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600ADF9 RID: 44537 RVA: 0x003FBBA4 File Offset: 0x003F9DA4
	public override string c1()
	{
		return "Включает";
	}

	// Token: 0x0600ADFA RID: 44538 RVA: 0x003FBBAC File Offset: 0x003F9DAC
	public override bool akb()
	{
		return true;
	}

	// Token: 0x0600ADFB RID: 44539 RVA: 0x003FBBB0 File Offset: 0x003F9DB0
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600ADFC RID: 44540 RVA: 0x003FBBB4 File Offset: 0x003F9DB4
	public override bool q2()
	{
		return false;
	}

	// Token: 0x0600ADFE RID: 44542 RVA: 0x003FBBC0 File Offset: 0x003F9DC0
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600ADFF RID: 44543 RVA: 0x003FBBC4 File Offset: 0x003F9DC4
	public override string bm(cnm A_0)
	{
		return "Abilities.70";
	}

	// Token: 0x0600AE00 RID: 44544 RVA: 0x003FBBCC File Offset: 0x003F9DCC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredUnoccupiedTraversableSpot;
	}

	// Token: 0x0600AE01 RID: 44545 RVA: 0x003FBBD0 File Offset: 0x003F9DD0
	public override string bo(cnm A_0)
	{
		return "Приказывает служебному роботу переместиться в указанную точку.";
	}

	// Token: 0x0600AE02 RID: 44546 RVA: 0x003FBBD8 File Offset: 0x003F9DD8
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600AE03 RID: 44547 RVA: 0x003FBBE4 File Offset: 0x003F9DE4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return d7f.o;
	}

	// Token: 0x0600AE04 RID: 44548 RVA: 0x003FBBEC File Offset: 0x003F9DEC
	public override IList<string> bi()
	{
		return d7f.p;
	}

	// Token: 0x0600AE05 RID: 44549 RVA: 0x003FBBF4 File Offset: 0x003F9DF4
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}
}
