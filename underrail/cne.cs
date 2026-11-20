using System;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000115 RID: 277
public interface cne
{
	// Token: 0x060006AF RID: 1711
	T GetResource<T>(string assetName, double? idleLimit = null) where T : class;

	// Token: 0x060006B0 RID: 1712
	Texture2D us(string A_0, double? A_1 = null);

	// Token: 0x060006B1 RID: 1713
	ecg u0(Texture2D A_0);

	// Token: 0x060006B2 RID: 1714
	void u1();

	// Token: 0x060006B3 RID: 1715
	void u2();

	// Token: 0x060006B4 RID: 1716
	bool ut(string A_0);

	// Token: 0x060006B5 RID: 1717
	void uz(bool A_0 = false);

	// Token: 0x060006B6 RID: 1718
	void uy();

	// Token: 0x060006B7 RID: 1719
	double uu();

	// Token: 0x060006B8 RID: 1720
	void uv(double A_0);

	// Token: 0x060006B9 RID: 1721
	bool uw();

	// Token: 0x060006BA RID: 1722
	void ux(bool A_0);
}
