using System;
using System.Runtime.Serialization;

// Token: 0x020007BA RID: 1978
[eiz("SGSCCA")]
[Serializable]
public sealed class bsp : esc, ISerializable
{
	// Token: 0x06003188 RID: 12680 RVA: 0x0012F80C File Offset: 0x0012DA0C
	private bsp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003189 RID: 12681 RVA: 0x0012F818 File Offset: 0x0012DA18
	public override int d5(bq8 A_0, bq8 A_1)
	{
		A_1.RemoveProperty("clueList");
		return 0;
	}

	// Token: 0x0600318A RID: 12682 RVA: 0x0012F828 File Offset: 0x0012DA28
	public bsp()
	{
	}
}
