using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001240 RID: 4672
[eiz("ETSN")]
[Serializable]
public sealed class efj : c3r, ISerializable
{
	// Token: 0x060064D9 RID: 25817 RVA: 0x002B254C File Offset: 0x002B074C
	private efj(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("ETSN:T");
	}

	// Token: 0x060064DA RID: 25818 RVA: 0x002B2568 File Offset: 0x002B0768
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("ETSN:T", this.a);
	}

	// Token: 0x060064DB RID: 25819 RVA: 0x002B257C File Offset: 0x002B077C
	public string sf()
	{
		return null;
	}

	// Token: 0x060064DC RID: 25820 RVA: 0x002B2580 File Offset: 0x002B0780
	public string sg()
	{
		return this.a.ToString();
	}

	// Token: 0x060064DD RID: 25821 RVA: 0x002B2590 File Offset: 0x002B0790
	public Color sh()
	{
		if (this.a > 3)
		{
			return Color.Orange;
		}
		return Color.Red;
	}

	// Token: 0x060064DE RID: 25822 RVA: 0x002B25AC File Offset: 0x002B07AC
	public bool si()
	{
		return this.a <= 3;
	}

	// Token: 0x060064DF RID: 25823 RVA: 0x002B25BC File Offset: 0x002B07BC
	public ScrollingCombatTextOptions sj()
	{
		return ScrollingCombatTextOptions.Mandatory;
	}

	// Token: 0x060064E0 RID: 25824 RVA: 0x002B25C0 File Offset: 0x002B07C0
	public efj(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04002A2A RID: 10794
	private int a;
}
