using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E99 RID: 7833
public abstract class eyv : bon
{
	// Token: 0x0600AF6B RID: 44907 RVA: 0x003FDD48 File Offset: 0x003FBF48
	public override string c1()
	{
		return "Стреляет";
	}

	// Token: 0x0600AF6C RID: 44908 RVA: 0x003FDD50 File Offset: 0x003FBF50
	public override bool l8()
	{
		return false;
	}

	// Token: 0x0600AF6D RID: 44909 RVA: 0x003FDD54 File Offset: 0x003FBF54
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600AF6E RID: 44910 RVA: 0x003FDD58 File Offset: 0x003FBF58
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AF6F RID: 44911 RVA: 0x003FDD60 File Offset: 0x003FBF60
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.f;
	}

	// Token: 0x0600AF70 RID: 44912 RVA: 0x003FDDD8 File Offset: 0x003FBFD8
	public override bool cu(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.f;
	}

	// Token: 0x0600AF71 RID: 44913 RVA: 0x003FDE44 File Offset: 0x003FC044
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600AF72 RID: 44914 RVA: 0x003FDE48 File Offset: 0x003FC048
	public static int a(coh A_0)
	{
		if (A_0 != null)
		{
			return A_0.Definition.a7().GetPrimitivePropertyValue<int>("power", new int?(1)).Value;
		}
		return 1;
	}

	// Token: 0x0600AF73 RID: 44915 RVA: 0x003FDE80 File Offset: 0x003FC080
	protected override int hi(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(aw0.a))
		{
			return 0;
		}
		int num = 25;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.f)
		{
			num = base.hi(A_0);
		}
		if (A_0 == null || A_0.b8() == null || !A_0.b8().Feats.Contains<d95>())
		{
			num += 4;
		}
		return num;
	}

	// Token: 0x0600AF74 RID: 44916 RVA: 0x003FDF24 File Offset: 0x003FC124
	protected override int br(cnm A_0)
	{
		return 500;
	}
}
