using System;

// Token: 0x0200046C RID: 1132
public sealed class bfo : adt
{
	// Token: 0x06001D5E RID: 7518 RVA: 0x000A2C9C File Offset: 0x000A0E9C
	public bfo(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x000A2CA8 File Offset: 0x000A0EA8
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		if (this.Subject != null)
		{
			this.Subject.y6()[cy1.g] = "flee";
			this.Subject.y6()["lgSafePlaceLoc"] = null;
			this.Subject.y6()["lgBlockedSafePlaces"] = null;
		}
		return ej1.b;
	}

	// Token: 0x06001D60 RID: 7520 RVA: 0x000A2D08 File Offset: 0x000A0F08
	public override float km(bool A_0)
	{
		return 1f;
	}

	// Token: 0x06001D61 RID: 7521 RVA: 0x000A2D14 File Offset: 0x000A0F14
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return this.Subject != null && this.Subject.y6().GetClassPropertyValue<string>(cy1.g) != "flee";
	}
}
