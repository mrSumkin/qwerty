using System;
using System.Collections.Generic;

// Token: 0x02001CA5 RID: 7333
[d29("VileWeaponry", "Vile Weaponry")]
public sealed class c6t : ai8
{
	// Token: 0x0600A0BA RID: 41146 RVA: 0x003E62E0 File Offset: 0x003E44E0
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A0BB RID: 41147 RVA: 0x003E62E4 File Offset: 0x003E44E4
	public c6t() : base("膩Запрещённое оружие")
	{
	}

	// Token: 0x0600A0BC RID: 41148 RVA: 0x003E62F4 File Offset: 0x003E44F4
	public override object[] at()
	{
		return new object[]
		{
			(int)(c6t.a * 100.0),
			(int)(c6t.b * 100.0),
			c6t.c
		};
	}

	// Token: 0x0600A0BD RID: 41149 RVA: 0x003E6344 File Offset: 0x003E4544
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(10, new Type[]
			{
				typeof(b6s)
			}),
			new bap(25, new Type[]
			{
				typeof(e5n),
				typeof(jk),
				typeof(c0b)
			})
		};
	}

	// Token: 0x04003DE5 RID: 15845
	public new static readonly double a = 0.1;

	// Token: 0x04003DE6 RID: 15846
	public new static readonly double b = 0.25;

	// Token: 0x04003DE7 RID: 15847
	public static readonly int c = 3;
}
