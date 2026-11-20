using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020019C0 RID: 6592
[eiz("PSIE")]
[Serializable]
public abstract class bs1 : dbj
{
	// Token: 0x06008D20 RID: 36128 RVA: 0x003929B8 File Offset: 0x00390BB8
	protected bs1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008D21 RID: 36129 RVA: 0x003929C4 File Offset: 0x00390BC4
	public override string qj()
	{
		return "poison";
	}

	// Token: 0x06008D22 RID: 36130
	protected abstract string gb();

	// Token: 0x06008D23 RID: 36131 RVA: 0x003929CC File Offset: 0x00390BCC
	public override SpellTargetType qk()
	{
		return SpellTargetType.PoisonableWeapon;
	}

	// Token: 0x06008D24 RID: 36132 RVA: 0x003929D4 File Offset: 0x00390BD4
	public override string ql()
	{
		return "Status.Poison";
	}

	// Token: 0x06008D25 RID: 36133 RVA: 0x003929DC File Offset: 0x00390BDC
	public override aa6 abd()
	{
		return aa6.c;
	}

	// Token: 0x06008D26 RID: 36134 RVA: 0x003929E0 File Offset: 0x00390BE0
	public bs1()
	{
		base.RemainingTicks = 10;
	}

	// Token: 0x06008D27 RID: 36135 RVA: 0x003929F0 File Offset: 0x00390BF0
	public override bool qm(bool A_0)
	{
		return A_0;
	}

	// Token: 0x06008D28 RID: 36136 RVA: 0x003929F4 File Offset: 0x00390BF4
	public override string qn(coh A_0)
	{
		return "ApplyPoisonToBlade";
	}

	// Token: 0x06008D29 RID: 36137 RVA: 0x003929FC File Offset: 0x00390BFC
	public override List<edm> qo(cd1 A_0, bool A_1)
	{
		if (A_1)
		{
			return new List<edm>
			{
				new edm(this.gb(), 1.0, 1, true)
			};
		}
		return null;
	}

	// Token: 0x06008D2A RID: 36138 RVA: 0x00392A34 File Offset: 0x00390C34
	protected string a()
	{
		if (base.RemainingTicks == 1)
		{
			return "разовую дозу";
		}
		return base.RemainingTicks.ToString() + " несколько доз";
	}

	// Token: 0x06008D2B RID: 36139 RVA: 0x00392A6C File Offset: 0x00390C6C
	public override int abe(coh A_0)
	{
		if (A_0 != null)
		{
			bke bke = A_0.Definition as bke;
			if (bke != null && bke.n().Count > 0)
			{
				cxu cxu = Enumerable.FirstOrDefault<cxu>(Enumerable.OfType<cxu>(bke.n()));
				if (cxu != null)
				{
					return Math.Max(1, cxu.MaxPoisonApplications);
				}
			}
		}
		return 1;
	}
}
