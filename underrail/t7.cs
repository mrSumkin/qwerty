using System;

// Token: 0x02000013 RID: 19
public abstract class t7 : abg
{
	// Token: 0x0600002A RID: 42 RVA: 0x00003118 File Offset: 0x00001318
	public override void lt()
	{
		base.lt();
		this.d = false;
		this.c = null;
		this.e = false;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00003138 File Offset: 0x00001338
	public override abg f7()
	{
		if (!this.d)
		{
			this.c = this.ip();
			this.d = true;
			if (this.c != null)
			{
				return null;
			}
			return this.b;
		}
		else
		{
			if (this.c.State == dc4.c)
			{
				return this.a;
			}
			if (this.c.State == dc4.e)
			{
				return this.b;
			}
			if (this.c.State == dc4.d)
			{
				if (this.e)
				{
					return this.b;
				}
				this.e = true;
				this.c = this.ip();
				if (this.c == null)
				{
					return this.b;
				}
			}
			return null;
		}
	}

	// Token: 0x0600002C RID: 44
	protected abstract cst ip();

	// Token: 0x04000075 RID: 117
	public abg a;

	// Token: 0x04000076 RID: 118
	public abg b;

	// Token: 0x04000077 RID: 119
	private new cst c;

	// Token: 0x04000078 RID: 120
	private bool d;

	// Token: 0x04000079 RID: 121
	private bool e;
}
