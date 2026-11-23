using System;
using System.Collections.Generic;

// Token: 0x02001C96 RID: 7318
[d29("Disassemble", "Disassemble")]
public sealed class e88 : ai8
{
	// Token: 0x0600A064 RID: 41060 RVA: 0x003E577C File Offset: 0x003E397C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A065 RID: 41061 RVA: 0x003E5780 File Offset: 0x003E3980
	public e88() : base("肋Демонтаж")
	{
	}

	// Token: 0x0600A066 RID: 41062 RVA: 0x003E5790 File Offset: 0x003E3990
	public override void ar(efk A_0)
	{
		e3q e3q = A_0 as e3q;
		if (e3q != null)
		{
			e3q.b(typeof(gt));
		}
	}

	// Token: 0x0600A067 RID: 41063 RVA: 0x003E57BC File Offset: 0x003E39BC
	public override void @as(efk A_0)
	{
		e3q e3q = A_0 as e3q;
		if (e3q != null)
		{
			e3q.a(typeof(gt));
		}
	}

	// Token: 0x0600A068 RID: 41064 RVA: 0x003E57E8 File Offset: 0x003E39E8
	public override object[] at()
	{
		return new object[]
		{
			(int)(e88.a * 100.0)
		};
	}

	// Token: 0x0600A069 RID: 41065 RVA: 0x003E580C File Offset: 0x003E3A0C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 7),
			new bap(20, new Type[]
			{
				typeof(ij),
				typeof(eq1)
			})
		};
	}

	// Token: 0x04003DD0 RID: 15824
	public new static double a = 1.0;
}
