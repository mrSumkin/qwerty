using System;
using System.Collections.Generic;

// Token: 0x02001C9E RID: 7326
[d29("TasteForBlood", "Taste for Blood")]
public sealed class aq0 : ai8
{
	// Token: 0x0600A095 RID: 41109 RVA: 0x003E5CB4 File Offset: 0x003E3EB4
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A096 RID: 41110 RVA: 0x003E5CB8 File Offset: 0x003E3EB8
	public aq0() : base("膹Вкус крови")
	{
	}

	// Token: 0x0600A097 RID: 41111 RVA: 0x003E5CC8 File Offset: 0x003E3EC8
	public override object[] at()
	{
		return new object[]
		{
			(int)(aq0.a * 100.0),
			aq0.b,
			l4.a((double)aq0.c, false)
		};
	}

	// Token: 0x0600A098 RID: 41112 RVA: 0x003E5D08 File Offset: 0x003E3F08
	public static double a(efk A_0)
	{
		double num = aq0.a;
		if (A_0 != null)
		{
			num += (double)A_0.GetSpecializationValue<edr>(true) * edr.a;
		}
		return num;
	}

	// Token: 0x0600A099 RID: 41113 RVA: 0x003E5D34 File Offset: 0x003E3F34
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(50, new Type[]
			{
				typeof(jk)
			})
		};
	}

	// Token: 0x04003DD6 RID: 15830
	public new static readonly double a = 0.05;

	// Token: 0x04003DD7 RID: 15831
	public new static readonly int b = 10;

	// Token: 0x04003DD8 RID: 15832
	public static readonly int c = 2;
}
