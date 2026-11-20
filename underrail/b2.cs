using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001C35 RID: 7221
[d29("TattooAegisIncorporated", "Tattoo: Aegis Incorporated")]
public sealed class b2 : e33
{
	// Token: 0x06009E9B RID: 40603 RVA: 0x003E2524 File Offset: 0x003E0724
	public b2() : base("Татуировка: Эгида Инкорпорейтед")
	{
	}

	// Token: 0x06009E9C RID: 40604 RVA: 0x003E2534 File Offset: 0x003E0734
	public override List<d3e> cy(efk A_0)
	{
		List<d3e> list = new List<d3e>();
		for (int i = 0; i < 10; i++)
		{
			list.Add(new dpw(((SkillEnum)i).a(), b2.a));
		}
		return list;
	}

	// Token: 0x06009E9D RID: 40605 RVA: 0x003E2574 File Offset: 0x003E0774
	public override object[] at()
	{
		return new object[]
		{
			b2.a
		};
	}

	// Token: 0x04003D76 RID: 15734
	public new static readonly int a = 5;
}
