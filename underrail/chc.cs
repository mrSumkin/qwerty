using System;
using System.Collections.Generic;

// Token: 0x02001CE1 RID: 7393
[d29("TrickyTrajectory", "Tricky Trajectory")]
public sealed class chc : ai8
{
	// Token: 0x0600A25A RID: 41562 RVA: 0x003E90D4 File Offset: 0x003E72D4
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A25B RID: 41563 RVA: 0x003E90D8 File Offset: 0x003E72D8
	public override string au()
	{
		return "xphw";
	}

	// Token: 0x0600A25C RID: 41564 RVA: 0x003E90E0 File Offset: 0x003E72E0
	public chc() : base("胯Замысловатая траектория")
	{
	}

	// Token: 0x0600A25D RID: 41565 RVA: 0x003E90F0 File Offset: 0x003E72F0
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(chc.a * 100.0),
			Convert.ToInt32(chc.b * 100.0)
		};
	}

	// Token: 0x0600A25E RID: 41566 RVA: 0x003E9130 File Offset: 0x003E7330
	protected override string nq()
	{
		if (dk2.f())
		{
			return "XPBL";
		}
		return null;
	}

	// Token: 0x0600A25F RID: 41567 RVA: 0x003E9144 File Offset: 0x003E7344
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(eav), 8),
			new bap(90, new Type[]
			{
				typeof(ct7),
				typeof(e8k)
			})
		};
	}

	// Token: 0x0600A260 RID: 41568 RVA: 0x003E919C File Offset: 0x003E739C
	public static double b(efk A_0)
	{
		double num = chc.a;
		if (A_0 != null)
		{
			num += (double)A_0.GetSpecializationValue<aon>(true) * aon.a;
		}
		return num;
	}

	// Token: 0x0600A261 RID: 41569 RVA: 0x003E91C8 File Offset: 0x003E73C8
	public static double a(efk A_0)
	{
		double num = chc.b;
		if (A_0 != null)
		{
			num += (double)A_0.GetSpecializationValue<rk>(true) * rk.a;
		}
		return num;
	}

	// Token: 0x0600A262 RID: 41570 RVA: 0x003E91F4 File Offset: 0x003E73F4
	public static bool a(cd1 A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		A_0.TypedDefinition.ae();
		return A_0.TypedDefinition.e() == btz.h || A_0.TypedDefinition.e() == btz.l || A_0.TypedDefinition.e() == btz.i;
	}

	// Token: 0x04003E37 RID: 15927
	public new static readonly double a = 0.1;

	// Token: 0x04003E38 RID: 15928
	public new static readonly double b = 0.3;
}
