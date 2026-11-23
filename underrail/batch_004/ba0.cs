using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001245 RID: 4677
[eiz("ISN")]
[Serializable]
public sealed class ba0 : c3r, ISerializable
{
	// Token: 0x06006501 RID: 25857 RVA: 0x002B29AC File Offset: 0x002B0BAC
	private ba0(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06006502 RID: 25858 RVA: 0x002B29B4 File Offset: 0x002B0BB4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06006503 RID: 25859 RVA: 0x002B29B8 File Offset: 0x002B0BB8
	public string sf()
	{
		return null;
	}

	// Token: 0x06006504 RID: 25860 RVA: 0x002B29BC File Offset: 0x002B0BBC
	public string sg()
	{
		return "Невосприимчивость";
	}

	// Token: 0x06006505 RID: 25861 RVA: 0x002B29C4 File Offset: 0x002B0BC4
	public Color sh()
	{
		return adi.n;
	}

	// Token: 0x06006506 RID: 25862 RVA: 0x002B29CC File Offset: 0x002B0BCC
	public bool si()
	{
		return false;
	}

	// Token: 0x06006507 RID: 25863 RVA: 0x002B29D0 File Offset: 0x002B0BD0
	public ScrollingCombatTextOptions sj()
	{
		return ScrollingCombatTextOptions.ResistsSImmunities;
	}

	// Token: 0x06006508 RID: 25864 RVA: 0x002B29D8 File Offset: 0x002B0BD8
	public ba0()
	{
	}
}
