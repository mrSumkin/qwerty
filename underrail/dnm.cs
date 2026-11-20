using System;

// Token: 0x02000893 RID: 2195
public abstract class dnm : el4
{
	// Token: 0x0600367A RID: 13946 RVA: 0x0014B2AC File Offset: 0x001494AC
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x0600367B RID: 13947 RVA: 0x0014B2B0 File Offset: 0x001494B0
	public override bool fk()
	{
		return true;
	}

	// Token: 0x0600367C RID: 13948 RVA: 0x0014B2B4 File Offset: 0x001494B4
	public override bool fl()
	{
		return true;
	}

	// Token: 0x0600367D RID: 13949 RVA: 0x0014B2B8 File Offset: 0x001494B8
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x0600367E RID: 13950 RVA: 0x0014B2D0 File Offset: 0x001494D0
	protected dnm() : base(new string[]
	{
		ega.b,
		ega.e
	})
	{
	}
}
