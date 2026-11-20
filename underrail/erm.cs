using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001C86 RID: 7302
[d29("SureStep", "Sure Step")]
public sealed class erm : ai8
{
	// Token: 0x06009FFE RID: 40958 RVA: 0x003E4B60 File Offset: 0x003E2D60
	public erm() : base("背Уверенный шаг")
	{
	}

	// Token: 0x06009FFF RID: 40959 RVA: 0x003E4B70 File Offset: 0x003E2D70
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A000 RID: 40960 RVA: 0x003E4B74 File Offset: 0x003E2D74
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A001 RID: 40961 RVA: 0x003E4B78 File Offset: 0x003E2D78
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new awe(CharacterImmunities.Caltrops),
			new awe(CharacterImmunities.AcidPuddles)
		};
	}

	// Token: 0x0600A002 RID: 40962 RVA: 0x003E4BA4 File Offset: 0x003E2DA4
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(dqg), 5)
		};
	}
}
