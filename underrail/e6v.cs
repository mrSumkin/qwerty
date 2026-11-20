using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02001837 RID: 6199
[ayj("IndustrialExoskeletonAura")]
public sealed class e6v : cx6
{
	// Token: 0x0600842A RID: 33834 RVA: 0x0037117C File Offset: 0x0036F37C
	public override string y8()
	{
		return "Мощность экзоскелета";
	}

	// Token: 0x0600842B RID: 33835 RVA: 0x00371184 File Offset: 0x0036F384
	public override string os()
	{
		return "IndustrialExoskeletonAura";
	}

	// Token: 0x0600842C RID: 33836 RVA: 0x0037118C File Offset: 0x0036F38C
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600842D RID: 33837 RVA: 0x00371190 File Offset: 0x0036F390
	public override IList<string> bi()
	{
		return new List<string>
		{
			e6v.d
		};
	}

	// Token: 0x0600842E RID: 33838 RVA: 0x003711A4 File Offset: 0x0036F3A4
	public override int bh()
	{
		return 3391;
	}

	// Token: 0x0600842F RID: 33839 RVA: 0x003711AC File Offset: 0x0036F3AC
	public override v5 c2()
	{
		return v5.a;
	}

	// Token: 0x06008430 RID: 33840 RVA: 0x003711B0 File Offset: 0x0036F3B0
	public override bool hl()
	{
		return true;
	}

	// Token: 0x06008431 RID: 33841 RVA: 0x003711B4 File Offset: 0x0036F3B4
	public override string bm(cnm A_0)
	{
		return "Abilities.77";
	}

	// Token: 0x06008432 RID: 33842 RVA: 0x003711BC File Offset: 0x0036F3BC
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/IndustrialExoskeletonAura", new object[]
		{
			e6v.h,
			e6v.j,
			e6v.e,
			e6v.f,
			e6v.g
		});
	}

	// Token: 0x06008433 RID: 33843 RVA: 0x0037121C File Offset: 0x0036F41C
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x06008434 RID: 33844 RVA: 0x00371228 File Offset: 0x0036F428
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(e6v.d, 10000, false, false)
		};
	}

	// Token: 0x06008435 RID: 33845 RVA: 0x00371248 File Offset: 0x0036F448
	public override List<els> j8(cnm A_0)
	{
		return new List<els>
		{
			new jg()
		};
	}

	// Token: 0x06008436 RID: 33846 RVA: 0x0037125C File Offset: 0x0036F45C
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null && Enumerable.Any<aia>(A_0.b8().Gear.l().Item.fu().@as(), new Func<aia, bool>(this.b))) && A_0.b8().Gear.l().Item.Battery >= (double)e6v.e;
	}

	// Token: 0x06008437 RID: 33847 RVA: 0x00371300 File Offset: 0x0036F500
	public override bool cu(cnm A_0)
	{
		return base.cu(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null && Enumerable.Any<aia>(A_0.b8().Gear.l().Item.fu().@as(), new Func<aia, bool>(this.a))) && A_0.b8().Gear.l().Item.Battery > 0.0;
	}

	// Token: 0x06008438 RID: 33848 RVA: 0x003713A4 File Offset: 0x0036F5A4
	protected override int hi(cnm A_0)
	{
		return 5;
	}

	// Token: 0x0600843B RID: 33851 RVA: 0x003713EC File Offset: 0x0036F5EC
	[CompilerGenerated]
	private bool b(aia A_0)
	{
		return A_0.Value == this;
	}

	// Token: 0x0600843C RID: 33852 RVA: 0x003713F8 File Offset: 0x0036F5F8
	[CompilerGenerated]
	private bool a(aia A_0)
	{
		return A_0.Value == this;
	}

	// Token: 0x040032AA RID: 12970
	private new const string a = "Exoskeleton Power";

	// Token: 0x040032AB RID: 12971
	private const string b = "IndustrialExoskeletonAura";

	// Token: 0x040032AC RID: 12972
	private const int c = 10000;

	// Token: 0x040032AD RID: 12973
	public static readonly string d = "SA.IndustrialExoskeletonAura";

	// Token: 0x040032AE RID: 12974
	public new static readonly int e = 10;

	// Token: 0x040032AF RID: 12975
	public new static readonly int f = 5;

	// Token: 0x040032B0 RID: 12976
	public static readonly int g = 1;

	// Token: 0x040032B1 RID: 12977
	public static readonly int h = 4;

	// Token: 0x040032B2 RID: 12978
	public static readonly int i = 4;

	// Token: 0x040032B3 RID: 12979
	public static readonly int j = 40;

	// Token: 0x040032B4 RID: 12980
	public static readonly float k = 0.3f;
}
