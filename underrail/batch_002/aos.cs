using System;

// Token: 0x0200211D RID: 8477
[dp2("1.1.2.5_OldIbPhotoIconFix", "1.1.2.5")]
public sealed class aos : dnv
{
	// Token: 0x0600C888 RID: 51336 RVA: 0x0046B3FC File Offset: 0x004695FC
	public bool eq(bk3 A_0)
	{
		return true;
	}

	// Token: 0x0600C889 RID: 51337 RVA: 0x0046B400 File Offset: 0x00469600
	public bool er(coh A_0)
	{
		dj3 dj = A_0.Definition as dj3;
		if (dj != null)
		{
			d48 d = A_0 as d48;
			if (d != null && dj.az() == "Семейная фотография старого Иба (Усадьба старого Иба)")
			{
				d.Definition.f("Plot.69");
			}
		}
		return true;
	}
}
