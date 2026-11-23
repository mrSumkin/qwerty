using System;
using System.Collections.Generic;

// Token: 0x02001C7B RID: 7291
[d29("AdvancedPsiEmpathy", "Advanced Psi Empathy")]
public sealed class eh3 : aw2
{
	// Token: 0x06009FC5 RID: 40901 RVA: 0x003E452C File Offset: 0x003E272C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009FC6 RID: 40902 RVA: 0x003E4530 File Offset: 0x003E2730
	public eh3() : base("臜Улучшенная пси-эмпатия")
	{
	}

	// Token: 0x06009FC7 RID: 40903 RVA: 0x003E4540 File Offset: 0x003E2740
	public override object[] at()
	{
		return new object[]
		{
			(int)(eh3.a * 100.0),
			(int)(eh3.b * 100.0)
		};
	}

	// Token: 0x06009FC8 RID: 40904 RVA: 0x003E4578 File Offset: 0x003E2778
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new db7(100));
		list.Add(new b4k(new Type[]
		{
			typeof(c3v)
		}));
		return list;
	}

	// Token: 0x04003DB3 RID: 15795
	public new static readonly double a = 0.15;

	// Token: 0x04003DB4 RID: 15796
	public new static readonly double b = 0.2;
}
