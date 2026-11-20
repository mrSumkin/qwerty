using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001C3B RID: 7227
[d29("TattooSGS", "Tattoo: South Gate Station")]
public sealed class brw : e33
{
	// Token: 0x06009EAF RID: 40623 RVA: 0x003E2720 File Offset: 0x003E0920
	public brw() : base("Татуировка: Станция Саут-Гейт")
	{
	}

	// Token: 0x06009EB0 RID: 40624 RVA: 0x003E2730 File Offset: 0x003E0930
	public override List<d3e> cy(efk A_0)
	{
		List<d3e> list = new List<d3e>();
		foreach (object obj in Enum.GetValues(typeof(SkillEnum)))
		{
			SkillEnum skillEnum = (SkillEnum)obj;
			list.Add(new dpw(skillEnum.a(), brw.a));
		}
		return list;
	}

	// Token: 0x06009EB1 RID: 40625 RVA: 0x003E27B8 File Offset: 0x003E09B8
	public override object[] at()
	{
		return new object[]
		{
			brw.a
		};
	}

	// Token: 0x04003D7C RID: 15740
	public new static readonly int a = 2;
}
