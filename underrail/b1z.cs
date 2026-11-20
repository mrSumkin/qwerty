using System;
using System.Runtime.Serialization;

// Token: 0x02000466 RID: 1126
[eiz("TA1")]
[Serializable]
public abstract class b1z : dvv, cst, ISerializable
{
	// Token: 0x06001D44 RID: 7492 RVA: 0x000A261C File Offset: 0x000A081C
	protected b1z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06001D45 RID: 7493 RVA: 0x000A2628 File Offset: 0x000A0828
	public virtual m7 kh()
	{
		return m7.a;
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x000A262C File Offset: 0x000A082C
	protected b1z()
	{
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x000A2634 File Offset: 0x000A0834
	protected b1z(string A_0) : base(A_0)
	{
	}
}
