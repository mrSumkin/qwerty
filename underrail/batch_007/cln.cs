using System;
using System.Collections.Generic;

// Token: 0x02001C91 RID: 7313
[d29("Ripper", "Ripper")]
public sealed class cln : ai8
{
	// Token: 0x0600A043 RID: 41027 RVA: 0x003E5428 File Offset: 0x003E3628
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A044 RID: 41028 RVA: 0x003E542C File Offset: 0x003E362C
	public cln() : base("膧Потрошитель")
	{
	}

	// Token: 0x0600A045 RID: 41029 RVA: 0x003E543C File Offset: 0x003E363C
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A046 RID: 41030 RVA: 0x003E5440 File Offset: 0x003E3640
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A047 RID: 41031 RVA: 0x003E5444 File Offset: 0x003E3644
	public override object[] at()
	{
		return new object[]
		{
			(int)(cln.a * 100.0),
			(int)(cln.b * 100.0)
		};
	}

	// Token: 0x0600A048 RID: 41032 RVA: 0x003E547C File Offset: 0x003E367C
	protected override string nq()
	{
		if (dk2.f())
		{
			return "XPBL";
		}
		return null;
	}

	// Token: 0x0600A049 RID: 41033 RVA: 0x003E5494 File Offset: 0x003E3694
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 10),
			new awr(typeof(axr), 5),
			new bap(50, new Type[]
			{
				typeof(jk),
				typeof(dei)
			})
		};
	}

	// Token: 0x0600A04A RID: 41034 RVA: 0x003E5504 File Offset: 0x003E3704
	public static double a(efk A_0)
	{
		double num = cln.a;
		if (A_0 != null)
		{
			num += (double)A_0.GetSpecializationValue<b9w>(true) * b9w.a;
		}
		return num;
	}

	// Token: 0x04003DC8 RID: 15816
	public new static readonly double a = 0.01;

	// Token: 0x04003DC9 RID: 15817
	public new static readonly double b = 0.01;
}
