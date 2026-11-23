using System;
using System.Collections.Generic;

// Token: 0x02001C49 RID: 7241
[d29("GunFu", "Gun-Fu")]
public sealed class bbt : ai8
{
	// Token: 0x06009EE6 RID: 40678 RVA: 0x003E2D98 File Offset: 0x003E0F98
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009EE7 RID: 40679 RVA: 0x003E2D9C File Offset: 0x003E0F9C
	public bbt() : base("胵Ган-Фу")
	{
	}

	// Token: 0x06009EE8 RID: 40680 RVA: 0x003E2DAC File Offset: 0x003E0FAC
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009EE9 RID: 40681 RVA: 0x003E2DB0 File Offset: 0x003E0FB0
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009EEA RID: 40682 RVA: 0x003E2DB4 File Offset: 0x003E0FB4
	public override object[] at()
	{
		return new object[]
		{
			(int)(bbt.a * 100.0)
		};
	}

	// Token: 0x06009EEB RID: 40683 RVA: 0x003E2DD8 File Offset: 0x003E0FD8
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(40, new Type[]
			{
				typeof(ct7)
			}),
			new bap(40, new Type[]
			{
				typeof(jk)
			})
		};
	}

	// Token: 0x06009EEC RID: 40684 RVA: 0x003E2E2C File Offset: 0x003E102C
	public static double a(efk A_0)
	{
		double num = bbt.a;
		if (A_0 != null)
		{
			num += (double)A_0.GetSpecializationValue<bqx>(true) * bqx.a;
		}
		return num;
	}

	// Token: 0x04003D8B RID: 15755
	public new static readonly double a = 0.4;
}
