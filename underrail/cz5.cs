using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001242 RID: 4674
[eiz("SASN")]
[Serializable]
public sealed class cz5 : c3r, ISerializable
{
	// Token: 0x060064E9 RID: 25833 RVA: 0x002B2670 File Offset: 0x002B0870
	private cz5(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("SASN:T");
		this.b = A_0.GetString("SASN:I");
		this.c = (Color)A_0.GetValue("SASN:TC", typeof(Color));
		this.d = A_0.GetBoolean("SASN:ET");
	}

	// Token: 0x060064EA RID: 25834 RVA: 0x002B26D8 File Offset: 0x002B08D8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SASN:T", this.a);
		info.AddValue("SASN:I", this.b);
		info.AddValue("SASN:TC", this.c);
		info.AddValue("SASN:ET", this.d);
	}

	// Token: 0x060064EB RID: 25835 RVA: 0x002B2730 File Offset: 0x002B0930
	public string sf()
	{
		return this.b;
	}

	// Token: 0x060064EC RID: 25836 RVA: 0x002B2738 File Offset: 0x002B0938
	public string sg()
	{
		return this.a;
	}

	// Token: 0x060064ED RID: 25837 RVA: 0x002B2740 File Offset: 0x002B0940
	public Color sh()
	{
		return this.c;
	}

	// Token: 0x060064EE RID: 25838 RVA: 0x002B2748 File Offset: 0x002B0948
	public bool si()
	{
		return this.d;
	}

	// Token: 0x060064EF RID: 25839 RVA: 0x002B2750 File Offset: 0x002B0950
	public ScrollingCombatTextOptions sj()
	{
		return ScrollingCombatTextOptions.SpecialActions;
	}

	// Token: 0x060064F0 RID: 25840 RVA: 0x002B2758 File Offset: 0x002B0958
	public cz5(string A_0, Color A_1, string A_2 = null, bool A_3 = false)
	{
		this.a = A_0;
		this.c = A_1;
		this.b = A_2;
		this.d = A_3;
	}

	// Token: 0x04002A2D RID: 10797
	private string a;

	// Token: 0x04002A2E RID: 10798
	private string b;

	// Token: 0x04002A2F RID: 10799
	private Color c;

	// Token: 0x04002A30 RID: 10800
	private bool d;
}
