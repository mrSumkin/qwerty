using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EEC RID: 7916
[ayj("Blitz")]
public sealed class cn3 : c0z
{
	// Token: 0x0600B494 RID: 46228 RVA: 0x004089F8 File Offset: 0x00406BF8
	public override string y8()
	{
		return "Блиц";
	}

	// Token: 0x0600B495 RID: 46229 RVA: 0x00408A00 File Offset: 0x00406C00
	public override string os()
	{
		return "Blitz";
	}

	// Token: 0x0600B496 RID: 46230 RVA: 0x00408A08 File Offset: 0x00406C08
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B497 RID: 46231 RVA: 0x00408A0C File Offset: 0x00406C0C
	public override int e8()
	{
		return 3;
	}

	// Token: 0x0600B498 RID: 46232 RVA: 0x00408A10 File Offset: 0x00406C10
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.j
		};
	}

	// Token: 0x0600B499 RID: 46233 RVA: 0x00408A24 File Offset: 0x00406C24
	public override bool hl()
	{
		return false;
	}

	// Token: 0x0600B49A RID: 46234 RVA: 0x00408A28 File Offset: 0x00406C28
	public cn3()
	{
		this.e = new List<string>();
		this.e.Add("SA.Blitz");
	}

	// Token: 0x0600B49B RID: 46235 RVA: 0x00408A4C File Offset: 0x00406C4C
	public override string bm(cnm A_0)
	{
		return "Blitz";
	}

	// Token: 0x0600B49C RID: 46236 RVA: 0x00408A54 File Offset: 0x00406C54
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B49D RID: 46237 RVA: 0x00408A58 File Offset: 0x00406C58
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/Blitz", new object[]
		{
			cn3.c,
			cn3.a(A_0)
		});
	}

	// Token: 0x0600B49E RID: 46238 RVA: 0x00408A88 File Offset: 0x00406C88
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.Blitz", Math.Max(1, cn3.b - ((A_0 != null && A_0.b8() != null) ? A_0.b8().GetSpecializationValue<am1>(true) : 0)) * d0u.b, false, false)
		};
	}

	// Token: 0x0600B49F RID: 46239 RVA: 0x00408AE4 File Offset: 0x00406CE4
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0 != null && A_0.b8() != null && !A_0.b8().SpecialStates.b)
		{
			io service = bpo.GetService<io>();
			if (service != null && service.ahg())
			{
				return service.ahw(A_0.b8()) >= cn3.c;
			}
		}
		return false;
	}

	// Token: 0x0600B4A0 RID: 46240 RVA: 0x00408B54 File Offset: 0x00406D54
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600B4A1 RID: 46241 RVA: 0x00408B5C File Offset: 0x00406D5C
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B4A2 RID: 46242 RVA: 0x00408B60 File Offset: 0x00406D60
	public new static int a(cnm A_0)
	{
		int num = cn3.d;
		if (A_0 != null && A_0.b8() != null)
		{
			num += A_0.b8().GetSpecializationValue<ayw>(true) * ayw.a;
		}
		return num;
	}

	// Token: 0x0600B4A3 RID: 46243 RVA: 0x00408B9C File Offset: 0x00406D9C
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x040041E5 RID: 16869
	private new const string a = "SA.Blitz";

	// Token: 0x040041E6 RID: 16870
	public static readonly int b = 10;

	// Token: 0x040041E7 RID: 16871
	public static readonly int c = 3;

	// Token: 0x040041E8 RID: 16872
	public static readonly int d = 20;

	// Token: 0x040041E9 RID: 16873
	private new List<string> e;
}
