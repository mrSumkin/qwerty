using System;
using System.Collections.Generic;

// Token: 0x02001E02 RID: 7682
[d29("SS", "Sharpshooter")]
public sealed class b03 : ai8
{
	// Token: 0x0600AA15 RID: 43541 RVA: 0x003F31E8 File Offset: 0x003F13E8
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600AA16 RID: 43542 RVA: 0x003F31EC File Offset: 0x003F13EC
	public b03() : base("膂Снайпер")
	{
	}

	// Token: 0x0600AA17 RID: 43543 RVA: 0x003F31FC File Offset: 0x003F13FC
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600AA18 RID: 43544 RVA: 0x003F3200 File Offset: 0x003F1400
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600AA19 RID: 43545 RVA: 0x003F3204 File Offset: 0x003F1404
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(eav), 10),
			new bap(60, new Type[]
			{
				typeof(ct7),
				typeof(e5n)
			}),
			new b4k(new Type[]
			{
				typeof(avk)
			})
		};
	}

	// Token: 0x0600AA1A RID: 43546 RVA: 0x003F327C File Offset: 0x003F147C
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(b03.a * 100f)
		};
	}

	// Token: 0x0600AA1B RID: 43547 RVA: 0x003F32A0 File Offset: 0x003F14A0
	public override List<d3e> cy(efk A_0)
	{
		List<d3e> list = new List<d3e>();
		bool flag = A_0.Offense.af();
		if (A_0.Offense.u() != null && A_0.Offense.u().TypedDefinition != null)
		{
			bke bke = A_0.Offense.u().TypedDefinition;
			bool flag2 = false;
			btz btz = A_0.Offense.u().TypedDefinition.e();
			if (btz != btz.a)
			{
				if (btz == btz.d || btz == btz.f)
				{
					flag2 = flag;
				}
			}
			else
			{
				flag2 = (flag || (bke.ae() != null && euf.g(bke.ae().Value)));
			}
			if (flag2)
			{
				float a_ = Convert.ToSingle((double)b03.a + (double)A_0.GetSpecializationValue<cvn>(true) * cvn.a);
				list.Add(new cex(a_));
			}
		}
		return list;
	}

	// Token: 0x04003FB2 RID: 16306
	public new static readonly float a = 0.3f;
}
