using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001C45 RID: 7237
[d29("TattooCoretech", "Tattoo: Coretech")]
public sealed class beq : e33
{
	// Token: 0x06009ED6 RID: 40662 RVA: 0x003E2BE8 File Offset: 0x003E0DE8
	public beq() : base("Татуировка: КорТех")
	{
	}

	// Token: 0x06009ED7 RID: 40663 RVA: 0x003E2BF8 File Offset: 0x003E0DF8
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new dpw(SkillEnum.Mechanics.ToString(), beq.a),
			new dpw(SkillEnum.Electronics.ToString(), beq.a)
		};
	}

	// Token: 0x06009ED8 RID: 40664 RVA: 0x003E2C4C File Offset: 0x003E0E4C
	public override object[] at()
	{
		return new object[]
		{
			beq.a
		};
	}

	// Token: 0x04003D87 RID: 15751
	public new static readonly int a = 7;
}
