using System;
using System.Collections.Generic;

// Token: 0x02001CB7 RID: 7351
[d29("SixthShell", "Sixth Shell")]
public sealed class eb9 : ai8
{
	// Token: 0x0600A123 RID: 41251 RVA: 0x003E7040 File Offset: 0x003E5240
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A124 RID: 41252 RVA: 0x003E7048 File Offset: 0x003E5248
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A125 RID: 41253 RVA: 0x003E704C File Offset: 0x003E524C
	public eb9() : base("膐Шесть дробин")
	{
	}

	// Token: 0x0600A126 RID: 41254 RVA: 0x003E705C File Offset: 0x003E525C
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A127 RID: 41255 RVA: 0x003E7060 File Offset: 0x003E5260
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A128 RID: 41256 RVA: 0x003E7064 File Offset: 0x003E5264
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(eb9.a * 100.0),
			Convert.ToInt32(eb9.b * 100.0)
		};
	}

	// Token: 0x0600A129 RID: 41257 RVA: 0x003E70A8 File Offset: 0x003E52A8
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(20, new Type[]
			{
				typeof(ct7)
			})
		};
	}

	// Token: 0x0600A12A RID: 41258 RVA: 0x003E70DC File Offset: 0x003E52DC
	public static double a(efk A_0, int A_1)
	{
		double num;
		if (A_1 >= 5)
		{
			num = eb9.b;
			if (A_0 != null)
			{
				num += (double)A_0.GetSpecializationValue<czb>(true) * czb.b;
			}
		}
		else
		{
			num = eb9.a * (double)A_1;
			if (A_0 != null)
			{
				num += (double)A_0.GetSpecializationValue<czb>(true) * czb.a * (double)A_1;
			}
		}
		return num;
	}

	// Token: 0x04003DFF RID: 15871
	public new static readonly double a = 0.1;

	// Token: 0x04003E00 RID: 15872
	public new static readonly double b = 1.0;
}
