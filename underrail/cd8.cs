using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EEA RID: 7914
[ayj("VehicleTurbo")]
public sealed class cd8 : elr
{
	// Token: 0x0600B46D RID: 46189 RVA: 0x004085B4 File Offset: 0x004067B4
	public override string y8()
	{
		return "Турбо";
	}

	// Token: 0x0600B46E RID: 46190 RVA: 0x004085BC File Offset: 0x004067BC
	public override string os()
	{
		return "VehicleTurbo";
	}

	// Token: 0x0600B46F RID: 46191 RVA: 0x004085C4 File Offset: 0x004067C4
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B470 RID: 46192 RVA: 0x004085C8 File Offset: 0x004067C8
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B471 RID: 46193 RVA: 0x004085CC File Offset: 0x004067CC
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.a,
			c = c0e.s
		};
	}

	// Token: 0x0600B472 RID: 46194 RVA: 0x004085EC File Offset: 0x004067EC
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600B473 RID: 46195 RVA: 0x004085F0 File Offset: 0x004067F0
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B474 RID: 46196 RVA: 0x004085F8 File Offset: 0x004067F8
	public cd8()
	{
		this.g = new List<string>();
		this.g.Add("SA.JetskiTurbo");
	}

	// Token: 0x0600B475 RID: 46197 RVA: 0x0040861C File Offset: 0x0040681C
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.3";
	}

	// Token: 0x0600B476 RID: 46198 RVA: 0x00408624 File Offset: 0x00406824
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B477 RID: 46199 RVA: 0x00408628 File Offset: 0x00406828
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/VehicleTurbo", new object[]
		{
			cd8.e,
			Convert.ToInt32(cd8.c * 100.0),
			Convert.ToInt32(cd8.f * 100.0),
			l4.a(cd8.d, false)
		});
	}

	// Token: 0x0600B478 RID: 46200 RVA: 0x00408698 File Offset: 0x00406898
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.JetskiTurbo", cd8.b, false, false)
		};
	}

	// Token: 0x0600B479 RID: 46201 RVA: 0x004086B8 File Offset: 0x004068B8
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Vehicle != null && A_0.b8().Vehicle.g() >= (double)cd8.e) && A_0.b8().Vehicle.aj();
	}

	// Token: 0x0600B47A RID: 46202 RVA: 0x00408724 File Offset: 0x00406924
	protected override int br(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B47B RID: 46203 RVA: 0x00408728 File Offset: 0x00406928
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x040041D5 RID: 16853
	private new const string a = "SA.JetskiTurbo";

	// Token: 0x040041D6 RID: 16854
	private static readonly int b = d0u.b * 7;

	// Token: 0x040041D7 RID: 16855
	public static readonly double c = 0.2;

	// Token: 0x040041D8 RID: 16856
	public static readonly int d = 3;

	// Token: 0x040041D9 RID: 16857
	public new static readonly int e = 50;

	// Token: 0x040041DA RID: 16858
	public static readonly double f = 1.0;

	// Token: 0x040041DB RID: 16859
	private new List<string> g;
}
