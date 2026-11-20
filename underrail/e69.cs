using System;
using System.Collections.Generic;

// Token: 0x02001C8B RID: 7307
[d29("Juggernaut", "Juggernaut")]
public sealed class e69 : ai8
{
	// Token: 0x0600A01A RID: 40986 RVA: 0x003E4E40 File Offset: 0x003E3040
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A01B RID: 40987 RVA: 0x003E4E44 File Offset: 0x003E3044
	public e69() : base("肢Неумолимая сила")
	{
	}

	// Token: 0x0600A01C RID: 40988 RVA: 0x003E4E54 File Offset: 0x003E3054
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A01D RID: 40989 RVA: 0x003E4E58 File Offset: 0x003E3058
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A01E RID: 40990 RVA: 0x003E4E5C File Offset: 0x003E305C
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(e69.a * 100.0),
			Convert.ToInt32(e69.b * 100.0)
		};
	}

	// Token: 0x0600A01F RID: 40991 RVA: 0x003E4EA0 File Offset: 0x003E30A0
	public override List<d3e> cy(efk A_0)
	{
		if (A_0 != null && A_0.Gear.l().Item != null && A_0.Gear.l().Item.fu().h() >= e69.b)
		{
			return new List<d3e>
			{
				new bh1(e69.a + (double)A_0.GetSpecializationValue<djh>(true) * djh.a)
				{
					Priority = int.MaxValue
				}
			};
		}
		return null;
	}

	// Token: 0x0600A020 RID: 40992 RVA: 0x003E4F20 File Offset: 0x003E3120
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axa), 7),
			new awr(typeof(d3m), 7)
		};
	}

	// Token: 0x04003DBE RID: 15806
	public new static readonly double a = 0.25;

	// Token: 0x04003DBF RID: 15807
	public new static readonly double b = 0.5;
}
