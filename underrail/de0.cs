using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EEB RID: 7915
[ayj("ShootHarp1Rocket")]
public sealed class de0 : elr, a5q
{
	// Token: 0x0600B47D RID: 46205 RVA: 0x00408764 File Offset: 0x00406964
	public override string y8()
	{
		return "Запустить ракету";
	}

	// Token: 0x0600B47E RID: 46206 RVA: 0x0040876C File Offset: 0x0040696C
	public override string os()
	{
		return "ShootHarp1Rocket";
	}

	// Token: 0x0600B47F RID: 46207 RVA: 0x00408774 File Offset: 0x00406974
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B480 RID: 46208 RVA: 0x00408778 File Offset: 0x00406978
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B481 RID: 46209 RVA: 0x0040877C File Offset: 0x0040697C
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.a,
			c = c0e.s
		};
	}

	// Token: 0x0600B482 RID: 46210 RVA: 0x0040879C File Offset: 0x0040699C
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600B483 RID: 46211 RVA: 0x004087A0 File Offset: 0x004069A0
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600B484 RID: 46212 RVA: 0x004087AC File Offset: 0x004069AC
	public override IList<string> bi()
	{
		return this.i;
	}

	// Token: 0x0600B485 RID: 46213 RVA: 0x004087B4 File Offset: 0x004069B4
	public de0()
	{
		this.i = new List<string>();
		this.i.Add("SA.ShootHarp1Rocket");
	}

	// Token: 0x0600B486 RID: 46214 RVA: 0x004087D8 File Offset: 0x004069D8
	public override string bm(cnm A_0)
	{
		return "xpbl_Ammo.30";
	}

	// Token: 0x0600B487 RID: 46215 RVA: 0x004087E0 File Offset: 0x004069E0
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x0600B488 RID: 46216 RVA: 0x004087E8 File Offset: 0x004069E8
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/ShootHarp1Rocket", new object[]
		{
			de0.c(1.0).a(true),
			de0.b(1.0).a(true),
			de0.g
		});
	}

	// Token: 0x0600B489 RID: 46217 RVA: 0x00408848 File Offset: 0x00406A48
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.ShootHarp1Rocket", de0.b, false, false)
		};
	}

	// Token: 0x0600B48A RID: 46218 RVA: 0x00408868 File Offset: 0x00406A68
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0 != null && A_0.b8() != null && A_0.b8().Vehicle != null)
		{
			agt agt;
			A_0.b8().Vehicle.o().TryGetValue("rockets", out agt);
			return agt != null && agt.fu().a5() == "harp1Rocket";
		}
		return false;
	}

	// Token: 0x0600B48B RID: 46219 RVA: 0x004088E0 File Offset: 0x00406AE0
	public static a1q c(double A_0 = 1.0)
	{
		return new a1q(DamageType.Mechanical, de0.c, de0.d);
	}

	// Token: 0x0600B48C RID: 46220 RVA: 0x004088F4 File Offset: 0x00406AF4
	public static a1q b(double A_0 = 1.0)
	{
		return new a1q(DamageType.Heat, de0.e, de0.f);
	}

	// Token: 0x0600B48D RID: 46221 RVA: 0x00408908 File Offset: 0x00406B08
	public static List<csk> a(double A_0)
	{
		return new List<csk>
		{
			euf.a(de0.c(1.0), A_0),
			euf.a(de0.b(1.0), A_0)
		};
	}

	// Token: 0x0600B48E RID: 46222 RVA: 0x00408944 File Offset: 0x00406B44
	public double[] f2(cnm A_0, double A_1, bool A_2, cmn A_3)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			int a_ = euf.a(A_0.b8(), true);
			return euf.a(A_0.b8(), a_, A_1, 0.0);
		}
		return null;
	}

	// Token: 0x0600B48F RID: 46223 RVA: 0x00408988 File Offset: 0x00406B88
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B490 RID: 46224 RVA: 0x00408990 File Offset: 0x00406B90
	protected override float f0(cnm A_0)
	{
		return (float)de0.h;
	}

	// Token: 0x0600B491 RID: 46225 RVA: 0x00408998 File Offset: 0x00406B98
	protected override int hi(cnm A_0)
	{
		return 30;
	}

	// Token: 0x0600B492 RID: 46226 RVA: 0x0040899C File Offset: 0x00406B9C
	protected override int d2(cnm A_0)
	{
		return de0.g;
	}

	// Token: 0x040041DC RID: 16860
	private new const string a = "SA.ShootHarp1Rocket";

	// Token: 0x040041DD RID: 16861
	private static readonly int b = d0u.b * 2;

	// Token: 0x040041DE RID: 16862
	private static readonly int c = 150;

	// Token: 0x040041DF RID: 16863
	private static readonly int d = 225;

	// Token: 0x040041E0 RID: 16864
	private new static readonly int e = 150;

	// Token: 0x040041E1 RID: 16865
	private static readonly int f = 225;

	// Token: 0x040041E2 RID: 16866
	public new static readonly int g = 2;

	// Token: 0x040041E3 RID: 16867
	public new static readonly int h = 10;

	// Token: 0x040041E4 RID: 16868
	private new List<string> i;
}
