using System;
using System.Collections.Generic;

// Token: 0x02001CA8 RID: 7336
[d29("Grenadier", "Grenadier")]
public sealed class ev : ai8
{
	// Token: 0x0600A0C9 RID: 41161 RVA: 0x003E6574 File Offset: 0x003E4774
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A0CA RID: 41162 RVA: 0x003E6578 File Offset: 0x003E4778
	public ev() : base("膌Гренадёр")
	{
	}

	// Token: 0x0600A0CB RID: 41163 RVA: 0x003E6588 File Offset: 0x003E4788
	public override object[] at()
	{
		return new object[]
		{
			l4.a(ev.a, false),
			l4.a(ev.b, false)
		};
	}

	// Token: 0x0600A0CC RID: 41164 RVA: 0x003E65AC File Offset: 0x003E47AC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 6),
			new bap(30, new Type[]
			{
				typeof(dei)
			})
		};
	}

	// Token: 0x04003DED RID: 15853
	public new static readonly int a = 2;

	// Token: 0x04003DEE RID: 15854
	public new static readonly int b = 3;
}
