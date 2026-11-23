using System;

// Token: 0x020001B8 RID: 440
public abstract class bu7
{
	// Token: 0x06000CB0 RID: 3248 RVA: 0x0003430C File Offset: 0x0003250C
	protected cne b()
	{
		if (this.a == null)
		{
			this.a = bpo.GetServiceOrThrow<cne>();
		}
		return this.a;
	}

	// Token: 0x06000CB1 RID: 3249
	public abstract bym aiy(b0b A_0, dnn A_1, e6d A_2, a44 A_3);

	// Token: 0x04000779 RID: 1913
	private cne a;
}
