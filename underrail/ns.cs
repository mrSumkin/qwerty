using System;
using System.Collections.Generic;

// Token: 0x02001C62 RID: 7266
[d29("TelekineticUndulation", "Telekinetic Undulation")]
public sealed class ns : ai8
{
	// Token: 0x06009F4F RID: 40783 RVA: 0x003E37E8 File Offset: 0x003E19E8
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009F50 RID: 40784 RVA: 0x003E37EC File Offset: 0x003E19EC
	public ns() : base("臦Телекинетическое возмущение")
	{
	}

	// Token: 0x06009F51 RID: 40785 RVA: 0x003E37FC File Offset: 0x003E19FC
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009F52 RID: 40786 RVA: 0x003E3800 File Offset: 0x003E1A00
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009F53 RID: 40787 RVA: 0x003E3804 File Offset: 0x003E1A04
	public override object[] at()
	{
		return new object[]
		{
			(int)(ns.a * 100.0),
			l4.a(ns.b, false)
		};
	}

	// Token: 0x06009F54 RID: 40788 RVA: 0x003E3838 File Offset: 0x003E1A38
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axr), 5),
			new b6h(new Type[]
			{
				typeof(ci5)
			})
		};
	}

	// Token: 0x04003D99 RID: 15769
	public new static readonly double a = 0.5;

	// Token: 0x04003D9A RID: 15770
	public new static readonly int b = 1;
}
