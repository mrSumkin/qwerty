using System;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001E2D RID: 7725
public sealed class awr : ValueBasedRequirement<int>
{
	// Token: 0x0600AB2D RID: 43821 RVA: 0x003F5DA4 File Offset: 0x003F3FA4
	public Type b()
	{
		return this.a;
	}

	// Token: 0x0600AB2E RID: 43822 RVA: 0x003F5DAC File Offset: 0x003F3FAC
	public bool a()
	{
		return this.b;
	}

	// Token: 0x0600AB2F RID: 43823 RVA: 0x003F5DB4 File Offset: 0x003F3FB4
	public override int og()
	{
		return Math.Max(1, (base.c() - aiy.x) * aiy.u);
	}

	// Token: 0x0600AB30 RID: 43824 RVA: 0x003F5DD0 File Offset: 0x003F3FD0
	public awr(Type A_0, int A_1) : this(A_0, A_1, false)
	{
	}

	// Token: 0x0600AB31 RID: 43825 RVA: 0x003F5DDC File Offset: 0x003F3FDC
	public awr(Type A_0, int A_1, bool A_2) : base(A_1)
	{
		czh.a(A_0, "baseAbilityType");
		this.a = A_0;
		this.b = A_2;
	}

	// Token: 0x0600AB32 RID: 43826 RVA: 0x003F5E00 File Offset: 0x003F4000
	public override bool oh(efk A_0)
	{
		czh.a(A_0, "character");
		if (A_0.BaseAbilities == null)
		{
			return false;
		}
		to to = A_0.BaseAbilities.a(this.a);
		if (to == null)
		{
			return false;
		}
		if (this.b)
		{
			return to.g() >= base.c();
		}
		return to.f() >= base.c();
	}

	// Token: 0x0600AB33 RID: 43827 RVA: 0x003F5E70 File Offset: 0x003F4070
	public override string ToString()
	{
		return to.a(this.a) + " " + base.c().ToString();
	}

	// Token: 0x04003FEA RID: 16362
	private Type a;

	// Token: 0x04003FEB RID: 16363
	private bool b;
}
