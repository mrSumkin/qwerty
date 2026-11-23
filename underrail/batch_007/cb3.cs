using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020019C8 RID: 6600
[eiz("TOCASHIE")]
[Serializable]
public sealed class cb3 : dbj
{
	// Token: 0x06008D5D RID: 36189 RVA: 0x003932AC File Offset: 0x003914AC
	private cb3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008D5E RID: 36190 RVA: 0x003932B8 File Offset: 0x003914B8
	public override string f9()
	{
		return "sheeted";
	}

	// Token: 0x06008D5F RID: 36191 RVA: 0x003932C0 File Offset: 0x003914C0
	public override string ga()
	{
		return "Контактно-активный энерголист";
	}

	// Token: 0x06008D60 RID: 36192 RVA: 0x003932C8 File Offset: 0x003914C8
	public override string qj()
	{
		return "Sheeted";
	}

	// Token: 0x06008D61 RID: 36193 RVA: 0x003932D0 File Offset: 0x003914D0
	public override SpellTargetType qk()
	{
		return SpellTargetType.CapacitativeSheetCompatibleWeapon;
	}

	// Token: 0x06008D62 RID: 36194 RVA: 0x003932D4 File Offset: 0x003914D4
	public override string ql()
	{
		return "ContactActiveCapacitativeSheet";
	}

	// Token: 0x06008D63 RID: 36195 RVA: 0x003932DC File Offset: 0x003914DC
	public cb3()
	{
	}

	// Token: 0x06008D64 RID: 36196 RVA: 0x003932E4 File Offset: 0x003914E4
	public override bool qm(bool A_0)
	{
		return A_0;
	}

	// Token: 0x06008D65 RID: 36197 RVA: 0x003932E8 File Offset: 0x003914E8
	public override string qn(coh A_0)
	{
		return "TearPoster";
	}

	// Token: 0x06008D66 RID: 36198 RVA: 0x003932F4 File Offset: 0x003914F4
	public override string gc(efk A_0)
	{
		return string.Format("Применяется на дробящем оружии ближнего боя и наносит от {1} до {2} урона в зависимости от веса оружия. Эти повреждения наносятся дважды при каждом ударе, имеет запас на {0} ударов.", base.RemainingTicks, ly.a(20).a(true), ly.a(72).a(true));
	}

	// Token: 0x06008D67 RID: 36199 RVA: 0x00393338 File Offset: 0x00391538
	public override string ae7(efk A_0, coh A_1)
	{
		edm a_ = Enumerable.FirstOrDefault<edm>(this.qo(A_1 as cd1, true));
		return string.Format("Ваши атаки наносят дополнительно {0} урона дважды.", ly.a(a_));
	}

	// Token: 0x06008D68 RID: 36200 RVA: 0x00393370 File Offset: 0x00391570
	public override List<edm> qo(cd1 A_0, bool A_1)
	{
		if (A_1)
		{
			double num = 0.0;
			if (A_0 != null)
			{
				bke bke = A_0.TypedDefinition;
				if (bke != null)
				{
					if (bke.a4() > 40.0)
					{
						num = 6.0;
					}
					if (bke.a4() > 30.0)
					{
						num = 4.0;
					}
					else if (bke.a4() > 20.0)
					{
						num = 3.0;
					}
					else if (bke.a4() > 10.0)
					{
						num = 2.0;
					}
					else if (bke.a4() > 4.0)
					{
						num = 1.5;
					}
					else if (bke.a4() > 3.0)
					{
						num = 1.0;
					}
					else if (bke.a4() > 2.0)
					{
						num = 0.5;
					}
				}
			}
			return new List<edm>
			{
				new edm("energyHit", 1.0, Convert.ToInt32(20.0 + 12.0 * num), true),
				new edm("energyHit", 1.0, Convert.ToInt32(20.0 + 12.0 * num), true)
			};
		}
		return null;
	}
}
