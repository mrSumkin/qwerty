using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200123E RID: 4670
[eiz("SASN2")]
[Serializable]
public sealed class e5x : c3r, ISerializable
{
	// Token: 0x060064C9 RID: 25801 RVA: 0x002B2408 File Offset: 0x002B0608
	private e5x(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("SASN2:T");
		this.b = A_0.GetString("SASN2:I");
		this.c = (Color)A_0.GetValue("SASN2:TC", typeof(Color));
		this.d = A_0.GetBoolean("SASN2:ET");
	}

	// Token: 0x060064CA RID: 25802 RVA: 0x002B2470 File Offset: 0x002B0670
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SASN2:T", this.a);
		info.AddValue("SASN2:I", this.b);
		info.AddValue("SASN2:TC", this.c);
		info.AddValue("SASN2:ET", this.d);
	}

	// Token: 0x060064CB RID: 25803 RVA: 0x002B24C8 File Offset: 0x002B06C8
	public string sf()
	{
		return this.b;
	}

	// Token: 0x060064CC RID: 25804 RVA: 0x002B24D0 File Offset: 0x002B06D0
	public string sg()
	{
		return this.a;
	}

	// Token: 0x060064CD RID: 25805 RVA: 0x002B24D8 File Offset: 0x002B06D8
	public Color sh()
	{
		return this.c;
	}

	// Token: 0x060064CE RID: 25806 RVA: 0x002B24E0 File Offset: 0x002B06E0
	public bool si()
	{
		return this.d;
	}

	// Token: 0x060064CF RID: 25807 RVA: 0x002B24E8 File Offset: 0x002B06E8
	public ScrollingCombatTextOptions sj()
	{
		return ScrollingCombatTextOptions.SpecialActions;
	}

	// Token: 0x060064D0 RID: 25808 RVA: 0x002B24F0 File Offset: 0x002B06F0
	public e5x(string A_0, Color A_1, string A_2 = null, bool A_3 = false)
	{
		this.a = A_0;
		this.c = A_1;
		this.b = A_2;
		this.d = A_3;
	}

	// Token: 0x04002A26 RID: 10790
	private string a;

	// Token: 0x04002A27 RID: 10791
	private string b;

	// Token: 0x04002A28 RID: 10792
	private Color c;

	// Token: 0x04002A29 RID: 10793
	private bool d;
}
