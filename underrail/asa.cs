using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E75 RID: 7797
[ayj("startInterfacing")]
public sealed class asa : m0
{
	// Token: 0x0600ADB1 RID: 44465 RVA: 0x003FB7D8 File Offset: 0x003F99D8
	public override string y8()
	{
		return "StartInterfacing";
	}

	// Token: 0x0600ADB2 RID: 44466 RVA: 0x003FB7E0 File Offset: 0x003F99E0
	public override string os()
	{
		return "startInterfacing";
	}

	// Token: 0x0600ADB3 RID: 44467 RVA: 0x003FB7E8 File Offset: 0x003F99E8
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600ADB4 RID: 44468 RVA: 0x003FB7EC File Offset: 0x003F99EC
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600ADB5 RID: 44469 RVA: 0x003FB7F0 File Offset: 0x003F99F0
	public override a3b bl(cnm A_0, efk A_1)
	{
		return new a3b
		{
			c = c0e.d
		};
	}

	// Token: 0x0600ADB7 RID: 44471 RVA: 0x003FB80C File Offset: 0x003F9A0C
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600ADB8 RID: 44472 RVA: 0x003FB810 File Offset: 0x003F9A10
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600ADB9 RID: 44473 RVA: 0x003FB814 File Offset: 0x003F9A14
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600ADBA RID: 44474 RVA: 0x003FB818 File Offset: 0x003F9A18
	public override string bo(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600ADBB RID: 44475 RVA: 0x003FB820 File Offset: 0x003F9A20
	public override string bp(cnm A_0)
	{
		if (A_0 != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null && coh.Definition != null)
			{
				return coh.Definition.a7().GetClassPropertyValue<string>("InterfaceCommandText");
			}
		}
		return string.Empty;
	}

	// Token: 0x0600ADBC RID: 44476 RVA: 0x003FB86C File Offset: 0x003F9A6C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return d7f.o;
	}

	// Token: 0x0600ADBD RID: 44477 RVA: 0x003FB874 File Offset: 0x003F9A74
	public override IList<string> bi()
	{
		return d7f.p;
	}

	// Token: 0x0600ADBE RID: 44478 RVA: 0x003FB87C File Offset: 0x003F9A7C
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}
}
