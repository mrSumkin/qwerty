using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F88 RID: 8072
[ayj("CoagulationShotConsumation")]
public sealed class cyy : awn
{
	// Token: 0x0600BD62 RID: 48482 RVA: 0x00417988 File Offset: 0x00415B88
	public override string y8()
	{
		return "Коагуляционный инъектор";
	}

	// Token: 0x0600BD63 RID: 48483 RVA: 0x00417990 File Offset: 0x00415B90
	public override string os()
	{
		return "CoagulationShotConsumation";
	}

	// Token: 0x0600BD64 RID: 48484 RVA: 0x00417998 File Offset: 0x00415B98
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BD65 RID: 48485 RVA: 0x0041799C File Offset: 0x00415B9C
	public cyy()
	{
		this.d = new List<string>();
		this.d.Add(cyy.c);
	}

	// Token: 0x0600BD66 RID: 48486 RVA: 0x004179C0 File Offset: 0x00415BC0
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600BD67 RID: 48487 RVA: 0x004179C8 File Offset: 0x00415BC8
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BD68 RID: 48488 RVA: 0x004179CC File Offset: 0x00415BCC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BD69 RID: 48489 RVA: 0x004179D0 File Offset: 0x00415BD0
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/CoagulationShot", new object[]
		{
			cyy.a
		});
	}

	// Token: 0x0600BD6A RID: 48490 RVA: 0x004179F0 File Offset: 0x00415BF0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(cyy.c, cyy.b * d0u.b, false, false)
		};
	}

	// Token: 0x04004421 RID: 17441
	public new static readonly int a = 3;

	// Token: 0x04004422 RID: 17442
	public static readonly int b = 2;

	// Token: 0x04004423 RID: 17443
	public static readonly string c = "CoagulationShot";

	// Token: 0x04004424 RID: 17444
	private List<string> d;
}
