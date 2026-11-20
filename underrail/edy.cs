using System;

// Token: 0x02000278 RID: 632
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class edy : Attribute
{
	// Token: 0x0600127E RID: 4734 RVA: 0x0004D574 File Offset: 0x0004B774
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600127F RID: 4735 RVA: 0x0004D57C File Offset: 0x0004B77C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001280 RID: 4736 RVA: 0x0004D588 File Offset: 0x0004B788
	public edy(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04000A3E RID: 2622
	private string a;
}
