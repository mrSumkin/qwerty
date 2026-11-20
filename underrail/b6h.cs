using System;

// Token: 0x02001E0B RID: 7691
public sealed class b6h : eie
{
	// Token: 0x0600AA4F RID: 43599 RVA: 0x003F3A84 File Offset: 0x003F1C84
	public override string aee()
	{
		return dh9.c("PsiAbility");
	}

	// Token: 0x0600AA50 RID: 43600 RVA: 0x003F3A90 File Offset: 0x003F1C90
	public override int og()
	{
		return 1;
	}

	// Token: 0x0600AA51 RID: 43601 RVA: 0x003F3A94 File Offset: 0x003F1C94
	public b6h(params Type[] A_0) : base(A_0)
	{
	}

	// Token: 0x0600AA52 RID: 43602 RVA: 0x003F3AA0 File Offset: 0x003F1CA0
	protected override bool aef(efk A_0, Type A_1)
	{
		return A_0.PsiAbilities.a(A_1);
	}
}
