using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001C47 RID: 7239
[d29("TattooJKK", "Tattoo: JKK")]
public sealed class btg : e33
{
	// Token: 0x06009EDE RID: 40670 RVA: 0x003E2CC8 File Offset: 0x003E0EC8
	public btg() : base("Татуировка: КБР")
	{
	}

	// Token: 0x06009EDF RID: 40671 RVA: 0x003E2CD8 File Offset: 0x003E0ED8
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new dpw(SkillEnum.Persuasion.ToString(), btg.a)
		};
	}

	// Token: 0x06009EE0 RID: 40672 RVA: 0x003E2D0C File Offset: 0x003E0F0C
	public override object[] at()
	{
		return new object[]
		{
			btg.a
		};
	}

	// Token: 0x04003D89 RID: 15753
	public new static readonly int a = 15;
}
