using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001ED7 RID: 7895
[ayj("Hypnotize")]
public sealed class aoa : c0z, bix
{
	// Token: 0x0600B321 RID: 45857 RVA: 0x00406274 File Offset: 0x00404474
	public override string y8()
	{
		return "Гипноз";
	}

	// Token: 0x0600B322 RID: 45858 RVA: 0x0040627C File Offset: 0x0040447C
	public override string os()
	{
		return "Hypnotize";
	}

	// Token: 0x0600B323 RID: 45859 RVA: 0x00406284 File Offset: 0x00404484
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B324 RID: 45860 RVA: 0x00406288 File Offset: 0x00404488
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B325 RID: 45861 RVA: 0x0040628C File Offset: 0x0040448C
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.f,
			b = new int?(100)
		};
	}

	// Token: 0x0600B326 RID: 45862 RVA: 0x004062AC File Offset: 0x004044AC
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600B327 RID: 45863 RVA: 0x004062B8 File Offset: 0x004044B8
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600B328 RID: 45864 RVA: 0x004062BC File Offset: 0x004044BC
	public aoa()
	{
		this.g = new List<string>();
		this.g.Add("SA.Hypnotize");
	}

	// Token: 0x0600B329 RID: 45865 RVA: 0x004062E0 File Offset: 0x004044E0
	public override string bm(cnm A_0)
	{
		return "Abilities.29";
	}

	// Token: 0x0600B32A RID: 45866 RVA: 0x004062E8 File Offset: 0x004044E8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.HumanoidNotSelf;
	}

	// Token: 0x0600B32B RID: 45867 RVA: 0x004062EC File Offset: 0x004044EC
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/Hypnotize", new object[]
		{
			l4.a(aoa.b, false),
			aoa.f
		});
	}

	// Token: 0x0600B32C RID: 45868 RVA: 0x0040631C File Offset: 0x0040451C
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B32D RID: 45869 RVA: 0x00406328 File Offset: 0x00404528
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.Hypnotize", aoa.c * d0u.b, false, false)
		};
	}

	// Token: 0x0600B32E RID: 45870 RVA: 0x0040634C File Offset: 0x0040454C
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B32F RID: 45871 RVA: 0x00406358 File Offset: 0x00404558
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Gear.g().Item != null) && A_0.b8().Gear.g().Item.Battery >= (double)aoa.f;
	}

	// Token: 0x0600B330 RID: 45872 RVA: 0x004063C8 File Offset: 0x004045C8
	public bg3 bs(cnm A_0, efk A_1, double A_2, double A_3, bool A_4, bool A_5, c3u A_6)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			double num = aoa.a(A_0.b8(), A_1);
			return new bg3
			{
				a = num
			};
		}
		return null;
	}

	// Token: 0x0600B331 RID: 45873 RVA: 0x00406404 File Offset: 0x00404604
	public static double a(efk A_0, efk A_1)
	{
		double result = 0.25;
		if (A_0 != null && A_1 != null)
		{
			double num = qw.a((double)A_0.Skills.Get<bhn>().g() * 1.2, (double)A_1.Defense.ae());
			result = d05.b(0.25, 1.0 - num, 0.95);
		}
		return result;
	}

	// Token: 0x0600B332 RID: 45874 RVA: 0x00406478 File Offset: 0x00404678
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B333 RID: 45875 RVA: 0x00406480 File Offset: 0x00404680
	protected override float f0(cnm A_0)
	{
		return (float)aoa.d;
	}

	// Token: 0x0600B334 RID: 45876 RVA: 0x00406488 File Offset: 0x00404688
	protected override int hi(cnm A_0)
	{
		return aoa.e;
	}

	// Token: 0x04004189 RID: 16777
	private new const string a = "SA.Hypnotize";

	// Token: 0x0400418A RID: 16778
	public static readonly int b = 2;

	// Token: 0x0400418B RID: 16779
	public static readonly int c = 5;

	// Token: 0x0400418C RID: 16780
	public static readonly int d = 5;

	// Token: 0x0400418D RID: 16781
	public new static readonly int e = 20;

	// Token: 0x0400418E RID: 16782
	public static readonly int f = 20;

	// Token: 0x0400418F RID: 16783
	private new List<string> g;
}
