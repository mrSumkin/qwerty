using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001241 RID: 4673
[eiz("SLSN")]
[Serializable]
public sealed class bi2 : c3r, ISerializable
{
	// Token: 0x060064E1 RID: 25825 RVA: 0x002B25D0 File Offset: 0x002B07D0
	private bi2(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("SLSN:A");
		this.b = A_0.GetBoolean("SLSN:CH");
	}

	// Token: 0x060064E2 RID: 25826 RVA: 0x002B25FC File Offset: 0x002B07FC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SLSN:A", this.a);
		info.AddValue("SLSN:CH", this.b);
	}

	// Token: 0x060064E3 RID: 25827 RVA: 0x002B2620 File Offset: 0x002B0820
	public string sf()
	{
		return "Overview.Shield";
	}

	// Token: 0x060064E4 RID: 25828 RVA: 0x002B2628 File Offset: 0x002B0828
	public string sg()
	{
		return "-" + this.a.ToString();
	}

	// Token: 0x060064E5 RID: 25829 RVA: 0x002B2640 File Offset: 0x002B0840
	public Color sh()
	{
		return adi.y;
	}

	// Token: 0x060064E6 RID: 25830 RVA: 0x002B2648 File Offset: 0x002B0848
	public bool si()
	{
		return this.b;
	}

	// Token: 0x060064E7 RID: 25831 RVA: 0x002B2650 File Offset: 0x002B0850
	public ScrollingCombatTextOptions sj()
	{
		return ScrollingCombatTextOptions.ShieldLoss;
	}

	// Token: 0x060064E8 RID: 25832 RVA: 0x002B2654 File Offset: 0x002B0854
	public bi2(int A_0, bool A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x04002A2B RID: 10795
	private int a;

	// Token: 0x04002A2C RID: 10796
	private bool b;
}
