using System;
using System.Collections.Generic;

// Token: 0x02001C99 RID: 7321
[d29("Packrathound", "Pack Rathound")]
public sealed class bnj : ai8
{
	// Token: 0x0600A075 RID: 41077 RVA: 0x003E5990 File Offset: 0x003E3B90
	public bnj() : base("肄Вьючный крысоволк")
	{
	}

	// Token: 0x0600A076 RID: 41078 RVA: 0x003E59A0 File Offset: 0x003E3BA0
	public override object[] at()
	{
		return new object[]
		{
			bnj.a
		};
	}

	// Token: 0x0600A077 RID: 41079 RVA: 0x003E59B8 File Offset: 0x003E3BB8
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new bgl(bnj.a + A_0.GetSpecializationValue<dhw>(true) * dhw.a)
		};
	}

	// Token: 0x04003DD2 RID: 15826
	public new static readonly int a = 50;
}
