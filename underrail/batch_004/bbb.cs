using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001C38 RID: 7224
[d29("TattooBlackCrawler", "Tattoo: Black Crawler")]
public sealed class bbb : e33
{
	// Token: 0x06009EA5 RID: 40613 RVA: 0x003E2630 File Offset: 0x003E0830
	public bbb() : base("Татуировка: Чёрный краулер")
	{
	}

	// Token: 0x06009EA6 RID: 40614 RVA: 0x003E2640 File Offset: 0x003E0840
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(bbb.a * 100f)
		};
	}

	// Token: 0x06009EA7 RID: 40615 RVA: 0x003E2660 File Offset: 0x003E0860
	public override List<d3e> cy(efk A_0)
	{
		List<d3e> list = new List<d3e>();
		bxb bxb = new bxb(SkillEnum.Stealth.ToString(), bbb.a);
		bxb.a(false);
		list.Add(bxb);
		return list;
	}

	// Token: 0x04003D79 RID: 15737
	public new static readonly float a = 0.15f;
}
