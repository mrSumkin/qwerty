using System;

// Token: 0x02000BCF RID: 3023
public abstract class jn : bsb
{
	// Token: 0x06004537 RID: 17719 RVA: 0x001C2514 File Offset: 0x001C0714
	public string hn()
	{
		return this.b;
	}

	// Token: 0x06004538 RID: 17720 RVA: 0x001C251C File Offset: 0x001C071C
	public virtual bool cd()
	{
		return false;
	}

	// Token: 0x06004539 RID: 17721 RVA: 0x001C2520 File Offset: 0x001C0720
	public virtual string cc()
	{
		return null;
	}

	// Token: 0x0600453A RID: 17722 RVA: 0x001C2524 File Offset: 0x001C0724
	protected jn(string A_0, string A_1)
	{
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x0600453B RID: 17723 RVA: 0x001C253C File Offset: 0x001C073C
	public b0b ho(cyt A_0)
	{
		c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a("locale\\" + this.a);
		if (c5k != null)
		{
			b0b b0b = c5k.a(null, true);
			if (b0b != null)
			{
				b0b.Layer = aju.x;
			}
			return b0b;
		}
		return null;
	}

	// Token: 0x0600453C RID: 17724 RVA: 0x001C2594 File Offset: 0x001C0794
	public virtual void cf(b0b A_0, cyt A_1, string A_2)
	{
	}

	// Token: 0x0600453D RID: 17725 RVA: 0x001C2598 File Offset: 0x001C0798
	public virtual void hp(b0b A_0, cyt A_1, string A_2)
	{
	}

	// Token: 0x0600453E RID: 17726
	public abstract string b1(cyt A_0);

	// Token: 0x0600453F RID: 17727 RVA: 0x001C259C File Offset: 0x001C079C
	public virtual string ce(cyt A_0, string A_1)
	{
		return null;
	}

	// Token: 0x06004540 RID: 17728 RVA: 0x001C25A0 File Offset: 0x001C07A0
	protected void a(b0b A_0, string A_1)
	{
		if (A_0 != null)
		{
			bm6 aspect = A_0.GetAspect<bm6>();
			if (aspect != null)
			{
				if (string.IsNullOrEmpty(A_1))
				{
					aspect.y6().RemoveProperty(ddq.ay);
					return;
				}
				aspect.y6()[ddq.ay] = new bt4(A_1);
			}
		}
	}

	// Token: 0x04001C6E RID: 7278
	private string a;

	// Token: 0x04001C6F RID: 7279
	private string b;
}
