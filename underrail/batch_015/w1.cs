using System;
using System.Runtime.Serialization;

// Token: 0x02001256 RID: 4694
[eiz("NPCTC")]
[Serializable]
public sealed class w1 : dth, ISerializable
{
	// Token: 0x0600657A RID: 25978 RVA: 0x002B376C File Offset: 0x002B196C
	private w1(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600657B RID: 25979 RVA: 0x002B3774 File Offset: 0x002B1974
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600657C RID: 25980 RVA: 0x002B3778 File Offset: 0x002B1978
	public w1()
	{
	}

	// Token: 0x0600657D RID: 25981 RVA: 0x002B3780 File Offset: 0x002B1980
	public bool jh(object A_0)
	{
		return false;
	}

	// Token: 0x0600657E RID: 25982 RVA: 0x002B3784 File Offset: 0x002B1984
	public string ji()
	{
		return "Only NPCs can travel through this transition";
	}
}
