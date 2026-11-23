using System;
using System.Collections.Generic;

// Token: 0x02001CDF RID: 7391
[d29("GunnersHigh", "Gunner's High")]
public sealed class baj : ai8
{
	// Token: 0x0600A248 RID: 41544 RVA: 0x003E8E3C File Offset: 0x003E703C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A249 RID: 41545 RVA: 0x003E8E40 File Offset: 0x003E7040
	public override string au()
	{
		return "xphw";
	}

	// Token: 0x0600A24A RID: 41546 RVA: 0x003E8E48 File Offset: 0x003E7048
	public baj() : base("胩Тяжёлая стрельба")
	{
	}

	// Token: 0x0600A24B RID: 41547 RVA: 0x003E8E58 File Offset: 0x003E7058
	public override object[] at()
	{
		return new object[]
		{
			baj.b,
			Convert.ToInt32(baj.a * 100f),
			baj.c
		};
	}

	// Token: 0x0600A24C RID: 41548 RVA: 0x003E8E98 File Offset: 0x003E7098
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(70, new Type[]
			{
				typeof(e8k)
			}),
			new b4k(new Type[]
			{
				typeof(b8s)
			})
		};
	}

	// Token: 0x0600A24D RID: 41549 RVA: 0x003E8EEC File Offset: 0x003E70EC
	public static float c(efk A_0)
	{
		float num = baj.a;
		if (A_0 != null)
		{
			num += (float)A_0.GetSpecializationValue<d0y>(true) * d0y.a;
		}
		return num;
	}

	// Token: 0x0600A24E RID: 41550 RVA: 0x003E8F18 File Offset: 0x003E7118
	public static int b(efk A_0)
	{
		int num = baj.b;
		if (A_0 != null)
		{
			num += A_0.GetSpecializationValue<bzj>(true);
		}
		return num * d0u.b;
	}

	// Token: 0x0600A24F RID: 41551 RVA: 0x003E8F44 File Offset: 0x003E7144
	public static int a(efk A_0)
	{
		int num = baj.c;
		if (A_0 != null)
		{
			num += A_0.GetSpecializationValue<a1x>(true);
		}
		return num;
	}

	// Token: 0x04003E31 RID: 15921
	public new static readonly float a = 0.65f;

	// Token: 0x04003E32 RID: 15922
	public new static readonly int b = 10;

	// Token: 0x04003E33 RID: 15923
	public static readonly int c = 10;
}
