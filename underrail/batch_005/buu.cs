using System;
using System.Runtime.Serialization;

// Token: 0x0200196D RID: 6509
[eiz("HE")]
[Serializable]
public abstract class buu : ISerializable
{
	// Token: 0x06008B58 RID: 35672 RVA: 0x0038F210 File Offset: 0x0038D410
	protected buu(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06008B59 RID: 35673 RVA: 0x0038F218 File Offset: 0x0038D418
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06008B5A RID: 35674 RVA: 0x0038F21C File Offset: 0x0038D41C
	public virtual bool yk(edm A_0)
	{
		return false;
	}

	// Token: 0x06008B5B RID: 35675
	public abstract string e1(edm A_0);

	// Token: 0x06008B5C RID: 35676 RVA: 0x0038F220 File Offset: 0x0038D420
	protected buu()
	{
	}

	// Token: 0x06008B5D RID: 35677 RVA: 0x0038F228 File Offset: 0x0038D428
	protected static int a(edm A_0)
	{
		return Convert.ToInt32(A_0.Chance * 100.0);
	}
}
