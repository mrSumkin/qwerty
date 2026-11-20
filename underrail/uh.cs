using System;
using System.Collections.Generic;

// Token: 0x02001C81 RID: 7297
[d29("Skinner", "Skinner")]
public sealed class uh : ai8
{
	// Token: 0x06009FE2 RID: 40930 RVA: 0x003E4838 File Offset: 0x003E2A38
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009FE3 RID: 40931 RVA: 0x003E483C File Offset: 0x003E2A3C
	public uh() : base("胄Кожевенник")
	{
	}

	// Token: 0x06009FE4 RID: 40932 RVA: 0x003E484C File Offset: 0x003E2A4C
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009FE5 RID: 40933 RVA: 0x003E4850 File Offset: 0x003E2A50
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009FE6 RID: 40934 RVA: 0x003E4854 File Offset: 0x003E2A54
	public override object[] at()
	{
		return new object[]
		{
			(int)(uh.a * 100.0)
		};
	}

	// Token: 0x06009FE7 RID: 40935 RVA: 0x003E4878 File Offset: 0x003E2A78
	public static double a(efk A_0)
	{
		double num = uh.a;
		if (A_0 != null)
		{
			num += (double)A_0.GetSpecializationValue<b7d>(true) * b7d.a;
		}
		return num;
	}

	// Token: 0x06009FE8 RID: 40936 RVA: 0x003E48A4 File Offset: 0x003E2AA4
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 7),
			new bap(15, new Type[]
			{
				typeof(qr)
			})
		};
	}

	// Token: 0x04003DB9 RID: 15801
	public new static readonly double a = 0.2;
}
