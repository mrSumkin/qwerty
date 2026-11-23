using System;

// Token: 0x02001893 RID: 6291
public sealed class aj5 : btm
{
	// Token: 0x0600857A RID: 34170 RVA: 0x003766C8 File Offset: 0x003748C8
	public aj5(int A_0) : base(null)
	{
		this.b = A_0;
	}

	// Token: 0x0600857B RID: 34171 RVA: 0x003766D8 File Offset: 0x003748D8
	protected override bool b4(e6d A_0)
	{
		if (this.b > 0)
		{
			this.a = DateTime.Now + TimeSpan.FromMilliseconds((double)this.b);
			return false;
		}
		return true;
	}

	// Token: 0x0600857C RID: 34172 RVA: 0x00376708 File Offset: 0x00374908
	protected override bool aen(e6d A_0)
	{
		return DateTime.Now >= this.a;
	}

	// Token: 0x04003321 RID: 13089
	private DateTime a;

	// Token: 0x04003322 RID: 13090
	private int b;
}
