using System;

// Token: 0x020005F6 RID: 1526
public abstract class em8 : bad, eal
{
	// Token: 0x06002808 RID: 10248 RVA: 0x000E76DC File Offset: 0x000E58DC
	public av ati()
	{
		return this.a;
	}

	// Token: 0x06002809 RID: 10249 RVA: 0x000E76E4 File Offset: 0x000E58E4
	public override bool io()
	{
		return base.io() && this.a.yw();
	}

	// Token: 0x0600280A RID: 10250 RVA: 0x000E7700 File Offset: 0x000E5900
	protected em8(av A_0)
	{
		czh.a(A_0, "proxy");
		this.a = A_0;
	}

	// Token: 0x0600280B RID: 10251 RVA: 0x000E7720 File Offset: 0x000E5920
	public override void f1(c1a A_0)
	{
		if (!this.a.yw() || this.a.p() == null)
		{
			return;
		}
		c5x c5x = bpo.GetServiceOrThrow<cnk>().aqu().v().b() as c5x;
		if (!this.a.p().hm(new eoj(this.a.b8(), this.a.b9(), base.a())))
		{
			return;
		}
		c5x.h.b.a(this.ati(), base.a());
	}

	// Token: 0x0400164E RID: 5710
	private new av a;
}
