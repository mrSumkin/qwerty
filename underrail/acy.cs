using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001C21 RID: 7201
[d29("Motioner", "Motioner")]
public sealed class acy : ai8
{
	// Token: 0x06009E23 RID: 40483 RVA: 0x003E17D4 File Offset: 0x003DF9D4
	public override bool aq()
	{
		return false;
	}

	// Token: 0x06009E24 RID: 40484 RVA: 0x003E17D8 File Offset: 0x003DF9D8
	public override bool ap()
	{
		return true;
	}

	// Token: 0x06009E25 RID: 40485 RVA: 0x003E17DC File Offset: 0x003DF9DC
	public acy() : base("Motioner")
	{
	}

	// Token: 0x06009E26 RID: 40486 RVA: 0x003E17EC File Offset: 0x003DF9EC
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>(1)
		{
			new ax6(BaseAbilityEnum.Intelligence.ToString(), -acy.a)
		};
	}

	// Token: 0x06009E27 RID: 40487 RVA: 0x003E1820 File Offset: 0x003DFA20
	public override object[] at()
	{
		return new object[]
		{
			acy.a
		};
	}

	// Token: 0x04003D5A RID: 15706
	private new static readonly int a = 1;
}
