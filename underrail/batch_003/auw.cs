using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200123B RID: 4667
[eiz("H8")]
[Serializable]
public sealed class auw : c3r, ISerializable
{
	// Token: 0x060064B1 RID: 25777 RVA: 0x002B2280 File Offset: 0x002B0480
	private auw(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("H8:A");
		if (ell.a() >= 631)
		{
			this.b = A_0.GetBoolean("H8:C");
		}
	}

	// Token: 0x060064B2 RID: 25778 RVA: 0x002B22BC File Offset: 0x002B04BC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("H8:A", this.a);
		info.AddValue("H8:C", this.b);
	}

	// Token: 0x060064B3 RID: 25779 RVA: 0x002B22E0 File Offset: 0x002B04E0
	public string sf()
	{
		return null;
	}

	// Token: 0x060064B4 RID: 25780 RVA: 0x002B22E4 File Offset: 0x002B04E4
	public string sg()
	{
		return "+" + this.a.ToString();
	}

	// Token: 0x060064B5 RID: 25781 RVA: 0x002B22FC File Offset: 0x002B04FC
	public Color sh()
	{
		return adi.w;
	}

	// Token: 0x060064B6 RID: 25782 RVA: 0x002B2304 File Offset: 0x002B0504
	public bool si()
	{
		return this.b;
	}

	// Token: 0x060064B7 RID: 25783 RVA: 0x002B230C File Offset: 0x002B050C
	public ScrollingCombatTextOptions sj()
	{
		return ScrollingCombatTextOptions.Healing;
	}

	// Token: 0x060064B8 RID: 25784 RVA: 0x002B2310 File Offset: 0x002B0510
	public auw(int A_0, bool A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x04002A22 RID: 10786
	private int a;

	// Token: 0x04002A23 RID: 10787
	private bool b;
}
