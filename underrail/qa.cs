using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02001ED1 RID: 7889
[ayj("HelmetLanternAura")]
public sealed class qa : cx6
{
	// Token: 0x0600B2B7 RID: 45751 RVA: 0x00405644 File Offset: 0x00403844
	public override string y8()
	{
		return "Свет налобного фонаря";
	}

	// Token: 0x0600B2B8 RID: 45752 RVA: 0x0040564C File Offset: 0x0040384C
	public override string os()
	{
		return "HelmetLanternAura";
	}

	// Token: 0x0600B2B9 RID: 45753 RVA: 0x00405654 File Offset: 0x00403854
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B2BA RID: 45754 RVA: 0x00405658 File Offset: 0x00403858
	public override IList<string> bi()
	{
		return new List<string>
		{
			qa.d
		};
	}

	// Token: 0x0600B2BB RID: 45755 RVA: 0x0040566C File Offset: 0x0040386C
	public override int bh()
	{
		return int.MinValue;
	}

	// Token: 0x0600B2BC RID: 45756 RVA: 0x00405674 File Offset: 0x00403874
	public override v5 c2()
	{
		return v5.a;
	}

	// Token: 0x0600B2BD RID: 45757 RVA: 0x00405678 File Offset: 0x00403878
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600B2BE RID: 45758 RVA: 0x0040567C File Offset: 0x0040387C
	public override string bm(cnm A_0)
	{
		return "Status.87";
	}

	// Token: 0x0600B2BF RID: 45759 RVA: 0x00405684 File Offset: 0x00403884
	public override string bo(cnm A_0)
	{
		double num = Math.Round((double)qa.a(A_0), 1);
		double num2 = Math.Round(qa.d(A_0), 1);
		double num3 = Math.Round(qa.e(A_0), 1);
		return qv.a("SpecialAbilities/HelmetLanternAura", new object[]
		{
			num2,
			num3,
			num
		});
	}

	// Token: 0x0600B2C0 RID: 45760 RVA: 0x004056E4 File Offset: 0x004038E4
	public static double e(cnm A_0)
	{
		int num = qa.c(A_0);
		return Math.Round(2.5 - Math.Min(1.5, (double)num * 0.01), 1);
	}

	// Token: 0x0600B2C1 RID: 45761 RVA: 0x00405724 File Offset: 0x00403924
	public static double d(cnm A_0)
	{
		return qa.e(A_0) * 3.0;
	}

	// Token: 0x0600B2C2 RID: 45762 RVA: 0x00405738 File Offset: 0x00403938
	private static int c(cnm A_0)
	{
		if (A_0 != null)
		{
			coh coh = null;
			coh coh2 = A_0.b9() as coh;
			if (coh2 != null)
			{
				coh = coh2;
			}
			else if (A_0.b8() != null)
			{
				coh = A_0.b8().Gear.g().Item;
			}
			if (coh != null && coh.Definition != null)
			{
				return coh.Definition.a7().GetPrimitivePropertyValue<int>("helmetLanternQuality", new int?(0)).Value;
			}
		}
		return 0;
	}

	// Token: 0x0600B2C3 RID: 45763 RVA: 0x004057C0 File Offset: 0x004039C0
	public static float b(cnm A_0)
	{
		return 0.5f;
	}

	// Token: 0x0600B2C4 RID: 45764 RVA: 0x004057C8 File Offset: 0x004039C8
	public static float a(cnm A_0)
	{
		int num = qa.c(A_0);
		return Convert.ToSingle(Math.Round((double)Math.Min(10f, 1.5f + (float)num * 0.07f), 1));
	}

	// Token: 0x0600B2C5 RID: 45765 RVA: 0x00405800 File Offset: 0x00403A00
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B2C6 RID: 45766 RVA: 0x0040580C File Offset: 0x00403A0C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(qa.d, 10000, false, false)
		};
	}

	// Token: 0x0600B2C7 RID: 45767 RVA: 0x0040582C File Offset: 0x00403A2C
	public override List<els> j8(cnm A_0)
	{
		return new List<els>
		{
			new ep4()
		};
	}

	// Token: 0x0600B2C8 RID: 45768 RVA: 0x00405844 File Offset: 0x00403A44
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		double num = qa.d(A_0);
		return A_0 != null && A_0.b8() != null && A_0.b8().Gear.g().Item != null && Enumerable.Any<aia>(A_0.b8().Gear.g().Item.fu().@as(), new Func<aia, bool>(this.b)) && A_0.b8().Gear.g().Item.Battery >= num;
	}

	// Token: 0x0600B2C9 RID: 45769 RVA: 0x004058E8 File Offset: 0x00403AE8
	public override bool cu(cnm A_0)
	{
		if (!base.cu(A_0))
		{
			return false;
		}
		qa.e(A_0);
		return A_0 != null && A_0.b8() != null && A_0.b8().Gear.g().Item != null && Enumerable.Any<aia>(A_0.b8().Gear.g().Item.fu().@as(), new Func<aia, bool>(this.a)) && A_0.b8().Gear.g().Item.Battery > 0.0;
	}

	// Token: 0x0600B2CA RID: 45770 RVA: 0x00405994 File Offset: 0x00403B94
	protected override int hi(cnm A_0)
	{
		return 5;
	}

	// Token: 0x0600B2CD RID: 45773 RVA: 0x004059AC File Offset: 0x00403BAC
	[CompilerGenerated]
	private bool b(aia A_0)
	{
		return A_0.Value == this;
	}

	// Token: 0x0600B2CE RID: 45774 RVA: 0x004059B8 File Offset: 0x00403BB8
	[CompilerGenerated]
	private bool a(aia A_0)
	{
		return A_0.Value == this;
	}

	// Token: 0x0400416A RID: 16746
	private new const string a = "Headlamp Light";

	// Token: 0x0400416B RID: 16747
	private const string b = "HelmetLanternAura";

	// Token: 0x0400416C RID: 16748
	private const int c = 10000;

	// Token: 0x0400416D RID: 16749
	public static readonly string d = "SA.HelmetLanternAura";
}
