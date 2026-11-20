using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001233 RID: 4659
[eiz("P9R")]
[Serializable]
public sealed class dru : c3r, ISerializable
{
	// Token: 0x0600646E RID: 25710 RVA: 0x002B1BD0 File Offset: 0x002AFDD0
	private dru(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("P9R:A");
	}

	// Token: 0x0600646F RID: 25711 RVA: 0x002B1BEC File Offset: 0x002AFDEC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("P9R:A", this.a);
	}

	// Token: 0x06006470 RID: 25712 RVA: 0x002B1C00 File Offset: 0x002AFE00
	public string sf()
	{
		return "PsiReserves";
	}

	// Token: 0x06006471 RID: 25713 RVA: 0x002B1C08 File Offset: 0x002AFE08
	public string sg()
	{
		return "-" + this.a.ToString();
	}

	// Token: 0x06006472 RID: 25714 RVA: 0x002B1C20 File Offset: 0x002AFE20
	public Color sh()
	{
		return adi.ac;
	}

	// Token: 0x06006473 RID: 25715 RVA: 0x002B1C28 File Offset: 0x002AFE28
	public bool si()
	{
		return false;
	}

	// Token: 0x06006474 RID: 25716 RVA: 0x002B1C2C File Offset: 0x002AFE2C
	public ScrollingCombatTextOptions sj()
	{
		return ScrollingCombatTextOptions.PsiLoss;
	}

	// Token: 0x06006475 RID: 25717 RVA: 0x002B1C30 File Offset: 0x002AFE30
	public dru(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04002A12 RID: 10770
	private int a;
}
