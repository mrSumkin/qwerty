using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EAB RID: 7851
[ayj("shotgunBurst")]
public sealed class bom : bon
{
	// Token: 0x0600B08A RID: 45194 RVA: 0x004000FC File Offset: 0x003FE2FC
	public override string y8()
	{
		return "Очередь из дробовика";
	}

	// Token: 0x0600B08B RID: 45195 RVA: 0x00400104 File Offset: 0x003FE304
	public override string os()
	{
		return "shotgunBurst";
	}

	// Token: 0x0600B08C RID: 45196 RVA: 0x0040010C File Offset: 0x003FE30C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B08D RID: 45197 RVA: 0x00400110 File Offset: 0x003FE310
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600B08E RID: 45198 RVA: 0x00400114 File Offset: 0x003FE314
	public override int ct()
	{
		return 2;
	}

	// Token: 0x0600B08F RID: 45199 RVA: 0x00400118 File Offset: 0x003FE318
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600B090 RID: 45200 RVA: 0x00400120 File Offset: 0x003FE320
	public override bool j7()
	{
		return false;
	}

	// Token: 0x0600B091 RID: 45201 RVA: 0x00400124 File Offset: 0x003FE324
	public override bool l8()
	{
		return false;
	}

	// Token: 0x0600B092 RID: 45202 RVA: 0x00400128 File Offset: 0x003FE328
	public override bool i2()
	{
		return true;
	}

	// Token: 0x0600B093 RID: 45203 RVA: 0x0040012C File Offset: 0x003FE32C
	public bom()
	{
		this.a = new List<string>();
		this.a.Add(d7f.a);
	}

	// Token: 0x0600B094 RID: 45204 RVA: 0x00400150 File Offset: 0x003FE350
	public override string bm(cnm A_0)
	{
		return "ShotgunBurst";
	}

	// Token: 0x0600B095 RID: 45205 RVA: 0x0040015C File Offset: 0x003FE35C
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.e && (eub.b(A_0.b8(), A_0.b8().Offense.u()) || A_0.b8().Offense.u().TypedDefinition.g());
	}

	// Token: 0x0600B096 RID: 45206 RVA: 0x00400214 File Offset: 0x003FE414
	public override bool cu(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.e;
	}

	// Token: 0x0600B097 RID: 45207 RVA: 0x00400280 File Offset: 0x003FE480
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B098 RID: 45208 RVA: 0x00400284 File Offset: 0x003FE484
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/ShotgunBurst", new object[]
		{
			bom.a(A_0)
		});
	}

	// Token: 0x0600B099 RID: 45209 RVA: 0x004002A4 File Offset: 0x003FE4A4
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B09A RID: 45210 RVA: 0x004002B0 File Offset: 0x003FE4B0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B09B RID: 45211 RVA: 0x004002E4 File Offset: 0x003FE4E4
	public override double l9(cnm A_0, double A_1)
	{
		double num = 0.75;
		if (A_0 != null && A_0.b8() != null)
		{
			num = d05.b(0.05, num + A_0.b8().Offense.u().TypedDefinition.s(), 1.0);
		}
		return num;
	}

	// Token: 0x0600B09C RID: 45212 RVA: 0x00400344 File Offset: 0x003FE544
	public new static int a(cnm A_0)
	{
		int num = 3;
		if (A_0 != null && A_0.b8() != null)
		{
			cd1 cd = A_0.b9() as cd1;
			if (cd == null)
			{
				cd = A_0.b8().Offense.u();
			}
			if (A_0.b8().Feats.Contains<crq>())
			{
				num++;
			}
			if (cd.TypedDefinition.d() > 0)
			{
				num += cd.TypedDefinition.d();
			}
		}
		return num;
	}

	// Token: 0x0600B09D RID: 45213 RVA: 0x004003C0 File Offset: 0x003FE5C0
	protected override int hi(cnm A_0)
	{
		double bp = as3.bp;
		return (int)Math.Min((double)base.hi(A_0) * bp, 50.0);
	}

	// Token: 0x0600B09E RID: 45214 RVA: 0x004003EC File Offset: 0x003FE5EC
	protected override int ma(cnm A_0)
	{
		return bom.a(A_0) * this.mb(A_0);
	}

	// Token: 0x0600B09F RID: 45215 RVA: 0x004003FC File Offset: 0x003FE5FC
	protected override int mb(cnm A_0)
	{
		return 200;
	}

	// Token: 0x040040E3 RID: 16611
	private new List<string> a;
}
