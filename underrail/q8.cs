using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001C43 RID: 7235
[d29("TattooMagnarGhost", "Tattoo: Magnar's Ghost")]
public sealed class q8 : e33
{
	// Token: 0x06009ECE RID: 40654 RVA: 0x003E2B04 File Offset: 0x003E0D04
	public q8() : base("Татуировка: Призрак Магнара")
	{
	}

	// Token: 0x06009ECF RID: 40655 RVA: 0x003E2B14 File Offset: 0x003E0D14
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new dpw(SkillEnum.Dodge.ToString(), q8.a),
			new dpw(SkillEnum.Evasion.ToString(), q8.a)
		};
	}

	// Token: 0x06009ED0 RID: 40656 RVA: 0x003E2B68 File Offset: 0x003E0D68
	public override object[] at()
	{
		return new object[]
		{
			q8.a
		};
	}

	// Token: 0x04003D85 RID: 15749
	public new static readonly int a = 10;
}
