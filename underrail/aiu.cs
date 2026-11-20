using System;

// Token: 0x0200016D RID: 365
public abstract class aiu : z6
{
	// Token: 0x0600093C RID: 2364 RVA: 0x00026600 File Offset: 0x00024800
	public object a()
	{
		return this.a;
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x00026608 File Offset: 0x00024808
	public void a(object A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x00026614 File Offset: 0x00024814
	public virtual Guid qe()
	{
		return Guid.Empty;
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x0002661C File Offset: 0x0002481C
	public virtual string y8()
	{
		return this.b;
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x00026624 File Offset: 0x00024824
	protected aiu(string A_0)
	{
		czh.a(A_0, "name");
		this.b = A_0;
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x00026640 File Offset: 0x00024840
	public virtual void d1(e6d A_0)
	{
	}

	// Token: 0x06000942 RID: 2370
	public abstract void ob(e6d A_0, cp9 A_1, bool A_2);

	// Token: 0x040005EF RID: 1519
	private object a;

	// Token: 0x040005F0 RID: 1520
	private string b;
}
