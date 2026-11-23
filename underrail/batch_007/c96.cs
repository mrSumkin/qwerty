using System;

// Token: 0x0200034B RID: 843
public abstract class c96
{
	// Token: 0x1700010D RID: 269
	// (get) Token: 0x060017D4 RID: 6100 RVA: 0x00079100 File Offset: 0x00077300
	public string Name
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x060017D5 RID: 6101 RVA: 0x00079108 File Offset: 0x00077308
	public c96 Parent
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x060017D6 RID: 6102 RVA: 0x00079110 File Offset: 0x00077310
	public virtual bm6 Subject
	{
		get
		{
			if (this.Parent != null)
			{
				return this.Parent.Subject;
			}
			return null;
		}
	}

	// Token: 0x060017D7 RID: 6103 RVA: 0x0007912C File Offset: 0x0007732C
	protected c96(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060017D8 RID: 6104
	public abstract ej1 aci(TimeSpan A_0, double A_1);

	// Token: 0x060017D9 RID: 6105
	public abstract bool acj(TimeSpan A_0, double A_1);

	// Token: 0x060017DA RID: 6106 RVA: 0x00079148 File Offset: 0x00077348
	public virtual void mc(TimeSpan A_0, double A_1)
	{
	}

	// Token: 0x060017DB RID: 6107 RVA: 0x0007914C File Offset: 0x0007734C
	public virtual void ack()
	{
	}

	// Token: 0x060017DC RID: 6108 RVA: 0x00079150 File Offset: 0x00077350
	public virtual float km(bool A_0)
	{
		return this.c;
	}

	// Token: 0x060017DD RID: 6109 RVA: 0x00079158 File Offset: 0x00077358
	protected amc h()
	{
		if (this.Subject != null)
		{
			return this.Subject.a8().h.b;
		}
		return null;
	}

	// Token: 0x060017DE RID: 6110 RVA: 0x0007917C File Offset: 0x0007737C
	internal void b(c96 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x04000E17 RID: 3607
	private string a;

	// Token: 0x04000E18 RID: 3608
	private c96 b;

	// Token: 0x04000E19 RID: 3609
	public float c = 1f;
}
