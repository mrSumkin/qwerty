using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001C3F RID: 7231
[d29("TattooPirate", "Tattoo: The Pirate")]
public sealed class aml : e33
{
	// Token: 0x06009EBF RID: 40639 RVA: 0x003E2968 File Offset: 0x003E0B68
	public aml() : base("Татуировка: Пират")
	{
	}

	// Token: 0x06009EC0 RID: 40640 RVA: 0x003E2978 File Offset: 0x003E0B78
	public override List<d3e> cy(efk A_0)
	{
		List<d3e> list = new List<d3e>();
		if (A_0.Vehicle != null && (A_0.Vehicle.y() == bws.b || A_0.Vehicle.y() == bws.a))
		{
			for (int i = 0; i < 20; i++)
			{
				List<d3e> list2 = list;
				bxb bxb = new bxb(((SkillEnum)i).a(), aml.a);
				bxb.a(true);
				bxb.Priority = 2147483646;
				list2.Add(bxb);
			}
		}
		return list;
	}

	// Token: 0x06009EC1 RID: 40641 RVA: 0x003E29F8 File Offset: 0x003E0BF8
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(aml.a * 100f)
		};
	}

	// Token: 0x04003D81 RID: 15745
	public new static readonly float a = 0.1f;
}
