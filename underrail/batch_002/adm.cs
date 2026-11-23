using System;
using TimelapseVertigo.UI;

// Token: 0x0200208D RID: 8333
public sealed class adm : daj, el2
{
	// Token: 0x0600C732 RID: 50994 RVA: 0x00461014 File Offset: 0x0045F214
	public adm(SavedGameManipulationMode A_0, abx A_1)
	{
		this.a(A_0, A_1);
	}

	// Token: 0x0600C733 RID: 50995 RVA: 0x00461028 File Offset: 0x0045F228
	private void a(SavedGameManipulationMode A_0, abx A_1)
	{
		esj a_ = bpo.GetServiceOrThrow<bef>().k0();
		base.Size = a_;
		this.a = czo.a(a_);
		this.aox(this.a);
		this.b = new arv(A_0, A_1);
		this.b.b();
		this.aox(this.b);
	}

	// Token: 0x0600C734 RID: 50996 RVA: 0x00461088 File Offset: 0x0045F288
	protected override void i0()
	{
		base.i0();
		this.b.a9();
	}

	// Token: 0x040049BF RID: 18879
	private new bg1 a;

	// Token: 0x040049C0 RID: 18880
	private new arv b;
}
