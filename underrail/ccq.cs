using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001239 RID: 4665
[eiz("GSN")]
[Serializable]
public sealed class ccq : c3r, ISerializable
{
	// Token: 0x060064A1 RID: 25761 RVA: 0x002B2104 File Offset: 0x002B0304
	private ccq(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("GSN:T");
		this.b = A_0.GetString("GSN:I");
		this.c = (Color)A_0.GetValue("GSN:TC", typeof(Color));
		this.d = A_0.GetBoolean("GSN:ET");
		this.e = (ScrollingCombatTextOptions)A_0.GetValue("GSN:C", typeof(ScrollingCombatTextOptions));
	}

	// Token: 0x060064A2 RID: 25762 RVA: 0x002B218C File Offset: 0x002B038C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("GSN:T", this.a);
		info.AddValue("GSN:I", this.b);
		info.AddValue("GSN:TC", this.c);
		info.AddValue("GSN:ET", this.d);
		info.AddValue("GSN:C", this.e);
	}

	// Token: 0x060064A3 RID: 25763 RVA: 0x002B21F8 File Offset: 0x002B03F8
	public string sf()
	{
		return this.b;
	}

	// Token: 0x060064A4 RID: 25764 RVA: 0x002B2200 File Offset: 0x002B0400
	public string sg()
	{
		return this.a;
	}

	// Token: 0x060064A5 RID: 25765 RVA: 0x002B2208 File Offset: 0x002B0408
	public Color sh()
	{
		return this.c;
	}

	// Token: 0x060064A6 RID: 25766 RVA: 0x002B2210 File Offset: 0x002B0410
	public bool si()
	{
		return this.d;
	}

	// Token: 0x060064A7 RID: 25767 RVA: 0x002B2218 File Offset: 0x002B0418
	public ScrollingCombatTextOptions sj()
	{
		return this.e;
	}

	// Token: 0x060064A8 RID: 25768 RVA: 0x002B2220 File Offset: 0x002B0420
	public ccq(ScrollingCombatTextOptions A_0, string A_1, Color A_2, string A_3 = null, bool A_4 = false)
	{
		this.e = A_0;
		this.a = A_1;
		this.c = A_2;
		this.b = A_3;
		this.d = A_4;
	}

	// Token: 0x04002A1D RID: 10781
	private string a;

	// Token: 0x04002A1E RID: 10782
	private string b;

	// Token: 0x04002A1F RID: 10783
	private Color c;

	// Token: 0x04002A20 RID: 10784
	private bool d;

	// Token: 0x04002A21 RID: 10785
	private ScrollingCombatTextOptions e;
}
