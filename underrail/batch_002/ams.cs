using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C40 RID: 7232
[d29("TattooJetEater", "Tattoo: Jet Eater")]
public sealed class ams : e33
{
	// Token: 0x06009EC3 RID: 40643 RVA: 0x003E2A24 File Offset: 0x003E0C24
	public ams() : base("Татуировка: Пожиратель гидроциклов")
	{
	}

	// Token: 0x06009EC4 RID: 40644 RVA: 0x003E2A34 File Offset: 0x003E0C34
	public override object[] at()
	{
		return new object[]
		{
			ams.a
		};
	}

	// Token: 0x06009EC5 RID: 40645 RVA: 0x003E2A4C File Offset: 0x003E0C4C
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new d2r(DamageType.Acid, ams.a)
			{
				Priority = int.MaxValue
			}
		};
	}

	// Token: 0x04003D82 RID: 15746
	public new static readonly int a = 5;
}
