using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001243 RID: 4675
[eiz("GMSN")]
[Serializable]
public sealed class d53 : c3r, ISerializable
{
	// Token: 0x060064F1 RID: 25841 RVA: 0x002B2780 File Offset: 0x002B0980
	private d53(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("GMSN:T");
			this.b = A_0.GetString("GMSN:I");
			this.c = (Color)A_0.GetValue("GMSN:TC", typeof(Color));
			this.d = A_0.GetBoolean("GMSN:ET");
			return;
		}
		if (base.GetType() == typeof(d53))
		{
			this.a = A_0.GetString("_Text");
			this.b = A_0.GetString("_Icon");
			this.c = (Color)A_0.GetValue("_TextColor", typeof(Color));
			this.d = A_0.GetBoolean("_EnlargedText");
			return;
		}
		this.a = A_0.GetString("GenericMandatoryScrollingNotification+_Text");
		this.b = A_0.GetString("GenericMandatoryScrollingNotification+_Icon");
		this.c = (Color)A_0.GetValue("GenericMandatoryScrollingNotification+_TextColor", typeof(Color));
		this.d = A_0.GetBoolean("GenericMandatoryScrollingNotification+_EnlargedText");
	}

	// Token: 0x060064F2 RID: 25842 RVA: 0x002B28B4 File Offset: 0x002B0AB4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("GMSN:T", this.a);
		info.AddValue("GMSN:I", this.b);
		info.AddValue("GMSN:TC", this.c);
		info.AddValue("GMSN:ET", this.d);
	}

	// Token: 0x060064F3 RID: 25843 RVA: 0x002B290C File Offset: 0x002B0B0C
	public string sf()
	{
		return this.b;
	}

	// Token: 0x060064F4 RID: 25844 RVA: 0x002B2914 File Offset: 0x002B0B14
	public string sg()
	{
		return this.a;
	}

	// Token: 0x060064F5 RID: 25845 RVA: 0x002B291C File Offset: 0x002B0B1C
	public Color sh()
	{
		return this.c;
	}

	// Token: 0x060064F6 RID: 25846 RVA: 0x002B2924 File Offset: 0x002B0B24
	public bool si()
	{
		return this.d;
	}

	// Token: 0x060064F7 RID: 25847 RVA: 0x002B292C File Offset: 0x002B0B2C
	public ScrollingCombatTextOptions sj()
	{
		return ScrollingCombatTextOptions.Mandatory;
	}

	// Token: 0x060064F8 RID: 25848 RVA: 0x002B2930 File Offset: 0x002B0B30
	public d53(string A_0, Color A_1, string A_2 = null, bool A_3 = false)
	{
		this.a = A_0;
		this.c = A_1;
		this.b = A_2;
		this.d = A_3;
	}

	// Token: 0x04002A31 RID: 10801
	private string a;

	// Token: 0x04002A32 RID: 10802
	private string b;

	// Token: 0x04002A33 RID: 10803
	private Color c;

	// Token: 0x04002A34 RID: 10804
	private bool d;
}
