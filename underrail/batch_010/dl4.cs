using System;
using System.Collections.Generic;

// Token: 0x02001CD6 RID: 7382
[d29("TriggerHappy", "Trigger Happy")]
public sealed class dl4 : ai8
{
	// Token: 0x0600A205 RID: 41477 RVA: 0x003E86B0 File Offset: 0x003E68B0
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A206 RID: 41478 RVA: 0x003E86B8 File Offset: 0x003E68B8
	public dl4() : base("肌Счастливый боёк")
	{
	}

	// Token: 0x0600A207 RID: 41479 RVA: 0x003E86C8 File Offset: 0x003E68C8
	public override object[] at()
	{
		return new object[]
		{
			dl4.a
		};
	}

	// Token: 0x0600A208 RID: 41480 RVA: 0x003E86E0 File Offset: 0x003E68E0
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new b5x(dl4.a + A_0.GetSpecializationValue<b9m>(true) * b9m.a)
		};
	}

	// Token: 0x0600A209 RID: 41481 RVA: 0x003E8708 File Offset: 0x003E6908
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 6)
		};
	}

	// Token: 0x04003E21 RID: 15905
	public new static readonly int a = 7;
}
