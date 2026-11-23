using System;
using TimelapseVertigo.Common.Data;
using TimelapseVertigo.Common.Settings;

// Token: 0x02002012 RID: 8210
public sealed class ex4 : pm
{
	// Token: 0x0600C20A RID: 49674 RVA: 0x00433700 File Offset: 0x00431900
	public sealed override float wf()
	{
		return 0f;
	}

	// Token: 0x0600C20B RID: 49675 RVA: 0x00433708 File Offset: 0x00431908
	public sealed override void wg(float A_0)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600C20C RID: 49676 RVA: 0x00433710 File Offset: 0x00431910
	public sealed override float wh()
	{
		if (this.a == null)
		{
			return 0f;
		}
		return this.a.zm();
	}

	// Token: 0x0600C20D RID: 49677 RVA: 0x00433730 File Offset: 0x00431930
	public sealed override void wi(float A_0)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600C20E RID: 49678 RVA: 0x00433738 File Offset: 0x00431938
	public sealed override float wj()
	{
		if (this.a == null)
		{
			return 0f;
		}
		return this.a().zo();
	}

	// Token: 0x0600C20F RID: 49679 RVA: 0x00433758 File Offset: 0x00431958
	public sealed override void wk(float A_0)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600C210 RID: 49680 RVA: 0x00433760 File Offset: 0x00431960
	public IBoundVariable<float> a()
	{
		return this.a;
	}

	// Token: 0x0600C211 RID: 49681 RVA: 0x00433768 File Offset: 0x00431968
	public void a(IBoundVariable<float> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600C212 RID: 49682 RVA: 0x00433774 File Offset: 0x00431974
	public ex4()
	{
		wj wj = global::wj.a();
		if (wj.d != UiSize.Classic)
		{
			base.a(wj.f);
			this.e = wj.bs;
			this.f = new esj?(wj.bt);
			this.b = wj.br;
		}
	}

	// Token: 0x0600C213 RID: 49683 RVA: 0x004337D0 File Offset: 0x004319D0
	public ex4(IBoundVariable<float> A_0) : this()
	{
		this.a = A_0;
	}

	// Token: 0x0400463A RID: 17978
	private new IBoundVariable<float> a;

	// Token: 0x0400463B RID: 17979
	public new int b;
}
