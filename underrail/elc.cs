using System;

// Token: 0x02001884 RID: 6276
public sealed class elc : btm
{
	// Token: 0x0600854D RID: 34125 RVA: 0x00375F80 File Offset: 0x00374180
	public elc(b4r A_0) : base(null)
	{
		this.a = A_0;
	}

	// Token: 0x0600854E RID: 34126 RVA: 0x00375F94 File Offset: 0x00374194
	protected override bool aen(e6d A_0)
	{
		if (this.a != null && this.a.a != null)
		{
			bcm serviceOrThrow = bpo.GetServiceOrThrow<bcm>();
			if (serviceOrThrow.aau() != null)
			{
				serviceOrThrow.aau().g(this.a.a);
			}
		}
		return true;
	}

	// Token: 0x0400330A RID: 13066
	private b4r a;
}
