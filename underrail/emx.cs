using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200123C RID: 4668
[eiz("P9")]
[Serializable]
public sealed class emx : c3r, ISerializable
{
	// Token: 0x060064B9 RID: 25785 RVA: 0x002B2328 File Offset: 0x002B0528
	private emx(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("P9:A");
	}

	// Token: 0x060064BA RID: 25786 RVA: 0x002B2344 File Offset: 0x002B0544
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("P9:A", this.a);
	}

	// Token: 0x060064BB RID: 25787 RVA: 0x002B2358 File Offset: 0x002B0558
	public string sf()
	{
		return "Psi";
	}

	// Token: 0x060064BC RID: 25788 RVA: 0x002B2360 File Offset: 0x002B0560
	public string sg()
	{
		return "-" + this.a.ToString();
	}

	// Token: 0x060064BD RID: 25789 RVA: 0x002B2378 File Offset: 0x002B0578
	public Color sh()
	{
		return adi.aa;
	}

	// Token: 0x060064BE RID: 25790 RVA: 0x002B2380 File Offset: 0x002B0580
	public bool si()
	{
		return false;
	}

	// Token: 0x060064BF RID: 25791 RVA: 0x002B2384 File Offset: 0x002B0584
	public ScrollingCombatTextOptions sj()
	{
		return ScrollingCombatTextOptions.PsiLoss;
	}

	// Token: 0x060064C0 RID: 25792 RVA: 0x002B2388 File Offset: 0x002B0588
	public emx(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04002A24 RID: 10788
	private int a;
}
