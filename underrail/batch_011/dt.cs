using System;
using System.Collections.Generic;

// Token: 0x02001C9C RID: 7324
[d29("Hypertoxicity", "Hypertoxicity")]
public sealed class dt : ai8
{
	// Token: 0x0600A086 RID: 41094 RVA: 0x003E5B30 File Offset: 0x003E3D30
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A087 RID: 41095 RVA: 0x003E5B34 File Offset: 0x003E3D34
	public dt() : base("胸Гипертоксичность")
	{
	}

	// Token: 0x0600A088 RID: 41096 RVA: 0x003E5B44 File Offset: 0x003E3D44
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A089 RID: 41097 RVA: 0x003E5B48 File Offset: 0x003E3D48
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A08A RID: 41098 RVA: 0x003E5B4C File Offset: 0x003E3D4C
	public override object[] at()
	{
		return new object[]
		{
			(int)(dt.a * 100.0)
		};
	}

	// Token: 0x0600A08B RID: 41099 RVA: 0x003E5B70 File Offset: 0x003E3D70
	public static double a(efk A_0)
	{
		double num = dt.a;
		if (A_0 != null)
		{
			num += (double)A_0.GetSpecializationValue<n6>(true) * n6.a;
		}
		return num;
	}

	// Token: 0x0600A08C RID: 41100 RVA: 0x003E5B9C File Offset: 0x003E3D9C
	public static double a(cnm A_0)
	{
		return dt.a((A_0 != null) ? A_0.b8() : null);
	}

	// Token: 0x0600A08D RID: 41101 RVA: 0x003E5BB8 File Offset: 0x003E3DB8
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(35, new Type[]
			{
				typeof(b6s)
			})
		};
	}

	// Token: 0x04003DD5 RID: 15829
	public new static readonly double a = 1.0;
}
