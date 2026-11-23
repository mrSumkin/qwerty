using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EE8 RID: 7912
[ayj("ThrowSpear")]
public sealed class xd : c0z, bix
{
	// Token: 0x0600B447 RID: 46151 RVA: 0x0040805C File Offset: 0x0040625C
	public override string y8()
	{
		return "Бросок копья";
	}

	// Token: 0x0600B448 RID: 46152 RVA: 0x00408064 File Offset: 0x00406264
	public override string os()
	{
		return "ThrowSpear";
	}

	// Token: 0x0600B449 RID: 46153 RVA: 0x0040806C File Offset: 0x0040626C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B44A RID: 46154 RVA: 0x00408070 File Offset: 0x00406270
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B44B RID: 46155 RVA: 0x00408074 File Offset: 0x00406274
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.c,
			b = new int?(int.MaxValue),
			c = c0e.i
		};
	}

	// Token: 0x0600B44C RID: 46156 RVA: 0x004080A4 File Offset: 0x004062A4
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600B44D RID: 46157 RVA: 0x004080B0 File Offset: 0x004062B0
	public xd()
	{
		this.g = new List<string>();
		this.g.Add("SA.ThrowSpear");
	}

	// Token: 0x0600B44E RID: 46158 RVA: 0x004080D4 File Offset: 0x004062D4
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.13";
	}

	// Token: 0x0600B44F RID: 46159 RVA: 0x004080DC File Offset: 0x004062DC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B450 RID: 46160 RVA: 0x004080E4 File Offset: 0x004062E4
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/ThrowSpear", new object[]
		{
			Convert.ToInt32(xd.b(A_0) * 100.0),
			Convert.ToInt32(xd.a(A_0) * 100.0)
		});
	}

	// Token: 0x0600B451 RID: 46161 RVA: 0x0040813C File Offset: 0x0040633C
	public static double b(cnm A_0)
	{
		double num = xd.b;
		if (A_0 != null && A_0.b8() != null)
		{
			ee5 microfeat = A_0.b8().GetMicrofeat<ee5>();
			if (microfeat != null)
			{
				num += microfeat.c();
			}
		}
		return num;
	}

	// Token: 0x0600B452 RID: 46162 RVA: 0x0040817C File Offset: 0x0040637C
	public new static double a(cnm A_0)
	{
		double num = xd.c;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (double)A_0.b8().GetSpecializationValue<du5>(true) * du5.a;
			ee5 microfeat = A_0.b8().GetMicrofeat<ee5>();
			if (microfeat != null)
			{
				num += microfeat.a();
			}
		}
		return num;
	}

	// Token: 0x0600B453 RID: 46163 RVA: 0x004081D4 File Offset: 0x004063D4
	public static double a(cnm A_0, double A_1)
	{
		double num = xd.b(A_0);
		double num2 = xd.a(A_0);
		return num + num2 * A_1;
	}

	// Token: 0x0600B454 RID: 46164 RVA: 0x004081F4 File Offset: 0x004063F4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.ThrowSpear", xd.f * d0u.b, false, false)
		};
	}

	// Token: 0x0600B455 RID: 46165 RVA: 0x00408218 File Offset: 0x00406418
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B456 RID: 46166 RVA: 0x00408224 File Offset: 0x00406424
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null) && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() == WeaponSubtype.Spear;
	}

	// Token: 0x0600B457 RID: 46167 RVA: 0x0040827C File Offset: 0x0040647C
	public bg3 bs(cnm A_0, efk A_1, double A_2, double A_3, bool A_4, bool A_5, c3u A_6)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return euf.a(A_0.b8(), A_1, A_2, A_3, A_4, A_5, 1.0, c3u.a, 0.0);
		}
		return null;
	}

	// Token: 0x0600B458 RID: 46168 RVA: 0x004082C4 File Offset: 0x004064C4
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600B459 RID: 46169 RVA: 0x004082C8 File Offset: 0x004064C8
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B45A RID: 46170 RVA: 0x004082D0 File Offset: 0x004064D0
	protected override float f0(cnm A_0)
	{
		float num = (float)xd.e;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (float)(A_0.b8().GetSpecializationValue<c8i>(true) * c8i.a);
			ee5 microfeat = A_0.b8().GetMicrofeat<ee5>();
			if (microfeat != null)
			{
				num += (float)microfeat.b();
			}
		}
		return num;
	}

	// Token: 0x0600B45B RID: 46171 RVA: 0x00408328 File Offset: 0x00406528
	protected override int hi(cnm A_0)
	{
		int num = xd.d;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= A_0.b8().GetSpecializationValue<dgb>(true) * dgb.a;
			ebc microfeat = A_0.b8().GetMicrofeat<ebc>();
			if (microfeat != null)
			{
				num += microfeat.a();
			}
		}
		if (num < 0)
		{
			num = 0;
		}
		return num;
	}

	// Token: 0x040041C9 RID: 16841
	private new const string a = "SA.ThrowSpear";

	// Token: 0x040041CA RID: 16842
	public static readonly double b = 1.25;

	// Token: 0x040041CB RID: 16843
	public static readonly double c = 0.2;

	// Token: 0x040041CC RID: 16844
	public static readonly int d = 25;

	// Token: 0x040041CD RID: 16845
	public new static readonly int e = 8;

	// Token: 0x040041CE RID: 16846
	public static readonly int f = 1;

	// Token: 0x040041CF RID: 16847
	private new List<string> g;
}
