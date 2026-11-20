using System;
using System.Collections.Generic;

// Token: 0x02001CBE RID: 7358
[d29("ImprovedNavalCombat", "Improved Naval Combat")]
public sealed class duv : ai8
{
	// Token: 0x0600A155 RID: 41301 RVA: 0x003E751C File Offset: 0x003E571C
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A156 RID: 41302 RVA: 0x003E7524 File Offset: 0x003E5724
	public override bool aq()
	{
		return false;
	}

	// Token: 0x0600A157 RID: 41303 RVA: 0x003E7528 File Offset: 0x003E5728
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A158 RID: 41304 RVA: 0x003E752C File Offset: 0x003E572C
	public duv() : base("Улучшенный морской бой")
	{
	}

	// Token: 0x0600A159 RID: 41305 RVA: 0x003E753C File Offset: 0x003E573C
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A15A RID: 41306 RVA: 0x003E7540 File Offset: 0x003E5740
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A15B RID: 41307 RVA: 0x003E7544 File Offset: 0x003E5744
	public override object[] at()
	{
		return new object[]
		{
			(int)(duv.a * 100.0),
			(int)(duv.b * 100.0),
			duv.c
		};
	}

	// Token: 0x0600A15C RID: 41308 RVA: 0x003E7594 File Offset: 0x003E5794
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(dqg), 7),
			new b4k(new Type[]
			{
				typeof(ej3)
			})
		};
	}

	// Token: 0x04003E04 RID: 15876
	public new static readonly double a = 0.15;

	// Token: 0x04003E05 RID: 15877
	public new static readonly double b = 0.1;

	// Token: 0x04003E06 RID: 15878
	public static readonly int c = 10;

	// Token: 0x04003E07 RID: 15879
	public new static readonly int d = 50;
}
