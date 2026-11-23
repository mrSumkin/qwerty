using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02001ED2 RID: 7890
[ayj("WirelessChargingAura")]
public sealed class agj : cx6
{
	// Token: 0x0600B2CF RID: 45775 RVA: 0x004059C4 File Offset: 0x00403BC4
	public override string y8()
	{
		return "Аура беспроводной зарядки";
	}

	// Token: 0x0600B2D0 RID: 45776 RVA: 0x004059CC File Offset: 0x00403BCC
	public override string os()
	{
		return "WirelessChargingAura";
	}

	// Token: 0x0600B2D1 RID: 45777 RVA: 0x004059D4 File Offset: 0x00403BD4
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B2D2 RID: 45778 RVA: 0x004059D8 File Offset: 0x00403BD8
	public override IList<string> bi()
	{
		return new List<string>
		{
			agj.d
		};
	}

	// Token: 0x0600B2D3 RID: 45779 RVA: 0x004059EC File Offset: 0x00403BEC
	public override int bh()
	{
		return int.MinValue;
	}

	// Token: 0x0600B2D4 RID: 45780 RVA: 0x004059F4 File Offset: 0x00403BF4
	public override v5 c2()
	{
		return v5.a;
	}

	// Token: 0x0600B2D5 RID: 45781 RVA: 0x004059F8 File Offset: 0x00403BF8
	public override bool hl()
	{
		return false;
	}

	// Token: 0x0600B2D6 RID: 45782 RVA: 0x004059FC File Offset: 0x00403BFC
	public override string bm(cnm A_0)
	{
		return "Abilities.76";
	}

	// Token: 0x0600B2D7 RID: 45783 RVA: 0x00405A04 File Offset: 0x00403C04
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/WirelessChargingAura", new object[]
		{
			agj.e,
			Convert.ToInt32(agj.f * 100.0)
		});
	}

	// Token: 0x0600B2D8 RID: 45784 RVA: 0x00405A40 File Offset: 0x00403C40
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B2D9 RID: 45785 RVA: 0x00405A4C File Offset: 0x00403C4C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(agj.d, 10000, false, false)
		};
	}

	// Token: 0x0600B2DA RID: 45786 RVA: 0x00405A6C File Offset: 0x00403C6C
	public override List<els> j8(cnm A_0)
	{
		return new List<els>
		{
			new aee()
		};
	}

	// Token: 0x0600B2DB RID: 45787 RVA: 0x00405A84 File Offset: 0x00403C84
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Vehicle == null && A_0.b8().Gear.l().Item != null && Enumerable.Any<aia>(A_0.b8().Gear.l().Item.fu().@as(), new Func<aia, bool>(this.b))) && (int)A_0.b8().Gear.l().Item.Battery > 0;
	}

	// Token: 0x0600B2DC RID: 45788 RVA: 0x00405B30 File Offset: 0x00403D30
	public override bool cu(cnm A_0)
	{
		return base.cu(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Vehicle == null && A_0.b8().Gear.l().Item != null && Enumerable.Any<aia>(A_0.b8().Gear.l().Item.fu().@as(), new Func<aia, bool>(this.a))) && (int)A_0.b8().Gear.l().Item.Battery > 0;
	}

	// Token: 0x0600B2DD RID: 45789 RVA: 0x00405BDC File Offset: 0x00403DDC
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x0600B2E0 RID: 45792 RVA: 0x00405C10 File Offset: 0x00403E10
	[CompilerGenerated]
	private bool b(aia A_0)
	{
		return A_0.Value == this;
	}

	// Token: 0x0600B2E1 RID: 45793 RVA: 0x00405C1C File Offset: 0x00403E1C
	[CompilerGenerated]
	private bool a(aia A_0)
	{
		return A_0.Value == this;
	}

	// Token: 0x0400416E RID: 16750
	private new const string a = "Wireless Charging Aura";

	// Token: 0x0400416F RID: 16751
	private const string b = "WirelessChargingAura";

	// Token: 0x04004170 RID: 16752
	private const int c = 10000;

	// Token: 0x04004171 RID: 16753
	public static readonly string d = "SA.WirelessChargingAura";

	// Token: 0x04004172 RID: 16754
	public new static readonly double e = 10.0;

	// Token: 0x04004173 RID: 16755
	public new static readonly double f = 0.8;
}
