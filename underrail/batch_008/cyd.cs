using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001234 RID: 4660
[eiz("P8R")]
[Serializable]
public sealed class cyd : c3r, ISerializable
{
	// Token: 0x06006476 RID: 25718 RVA: 0x002B1C40 File Offset: 0x002AFE40
	private cyd(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("P8R:A");
	}

	// Token: 0x06006477 RID: 25719 RVA: 0x002B1C5C File Offset: 0x002AFE5C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("P8R:A", this.a);
	}

	// Token: 0x06006478 RID: 25720 RVA: 0x002B1C70 File Offset: 0x002AFE70
	public string sf()
	{
		return "PsiReserves";
	}

	// Token: 0x06006479 RID: 25721 RVA: 0x002B1C78 File Offset: 0x002AFE78
	public string sg()
	{
		return "+" + this.a.ToString();
	}

	// Token: 0x0600647A RID: 25722 RVA: 0x002B1C90 File Offset: 0x002AFE90
	public Color sh()
	{
		return adi.ab;
	}

	// Token: 0x0600647B RID: 25723 RVA: 0x002B1C98 File Offset: 0x002AFE98
	public bool si()
	{
		return false;
	}

	// Token: 0x0600647C RID: 25724 RVA: 0x002B1C9C File Offset: 0x002AFE9C
	public ScrollingCombatTextOptions sj()
	{
		return ScrollingCombatTextOptions.PsiGain;
	}

	// Token: 0x0600647D RID: 25725 RVA: 0x002B1CA0 File Offset: 0x002AFEA0
	public cyd(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04002A13 RID: 10771
	private int a;
}
