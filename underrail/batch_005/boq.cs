using System;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200200E RID: 8206
public sealed class boq : eb1, ta
{
	// Token: 0x0600C1DE RID: 49630 RVA: 0x00432F54 File Offset: 0x00431154
	public override av zc()
	{
		return this.a;
	}

	// Token: 0x0600C1DF RID: 49631 RVA: 0x00432F5C File Offset: 0x0043115C
	public override bool zd()
	{
		return this.d.ph() || this.d.pp() != null;
	}

	// Token: 0x0600C1E0 RID: 49632 RVA: 0x00432F80 File Offset: 0x00431180
	public override void ze(bool A_0)
	{
	}

	// Token: 0x0600C1E1 RID: 49633 RVA: 0x00432F84 File Offset: 0x00431184
	public coh x6()
	{
		if (this.d != null)
		{
			return this.d.pp();
		}
		return null;
	}

	// Token: 0x0600C1E2 RID: 49634 RVA: 0x00432FA0 File Offset: 0x004311A0
	public bool zf()
	{
		return true;
	}

	// Token: 0x0600C1E3 RID: 49635 RVA: 0x00432FA4 File Offset: 0x004311A4
	public override bool zg()
	{
		return true;
	}

	// Token: 0x0600C1E4 RID: 49636 RVA: 0x00432FA8 File Offset: 0x004311A8
	public boq(efk A_0, int A_1, esj A_2, esj A_3) : base(A_2, A_3)
	{
		czh.a(A_0, "character");
		this.b = A_0;
		this.c = A_1;
		this.b();
	}

	// Token: 0x0600C1E5 RID: 49637 RVA: 0x00432FD4 File Offset: 0x004311D4
	public boq(efk A_0, int A_1)
	{
		czh.a(A_0, "character");
		this.b = A_0;
		this.c = A_1;
		this.b();
	}

	// Token: 0x0600C1E6 RID: 49638 RVA: 0x00432FFC File Offset: 0x004311FC
	private new void b()
	{
		this.d = this.b.Gear.d()[this.c];
		this.a();
	}

	// Token: 0x0600C1E7 RID: 49639 RVA: 0x00433028 File Offset: 0x00431228
	private new void a()
	{
		if (this.d.pp() == null || this.d.pp().Definition.a2().Count == 0)
		{
			this.a = null;
			return;
		}
		this.a = ecf.a(this.d.pp().Definition.a2()[0].Value, new dsx(), this.d.pp());
	}

	// Token: 0x0600C1E8 RID: 49640 RVA: 0x004330A8 File Offset: 0x004312A8
	private new void a(object A_0, c1 A_1)
	{
		this.a();
	}

	// Token: 0x0600C1E9 RID: 49641 RVA: 0x004330B0 File Offset: 0x004312B0
	protected override void zh(av A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600C1EA RID: 49642 RVA: 0x004330BC File Offset: 0x004312BC
	protected override void i0()
	{
		base.i0();
		this.a();
		this.d.pm(new EventHandler<c1>(this.a));
	}

	// Token: 0x0600C1EB RID: 49643 RVA: 0x004330E4 File Offset: 0x004312E4
	protected override void i1()
	{
		base.i1();
		this.d.pn(new EventHandler<c1>(this.a));
	}

	// Token: 0x0600C1EC RID: 49644 RVA: 0x00433104 File Offset: 0x00431304
	protected override string zi()
	{
		if (this.x6() != null)
		{
			return this.x6().Definition.a3();
		}
		return null;
	}

	// Token: 0x04004633 RID: 17971
	private new av a;

	// Token: 0x04004634 RID: 17972
	private new efk b;

	// Token: 0x04004635 RID: 17973
	private new int c;

	// Token: 0x04004636 RID: 17974
	private new IItemSlot<coh> d;
}
