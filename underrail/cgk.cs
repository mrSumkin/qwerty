using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200193B RID: 6459
[eiz("AII")]
[Serializable]
public abstract class cgk : a06, IItemInstance<eya>, ISerializable
{
	// Token: 0x0600890B RID: 35083 RVA: 0x00388F30 File Offset: 0x00387130
	protected cgk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600890C RID: 35084 RVA: 0x00388F3C File Offset: 0x0038713C
	public new eya fu()
	{
		return base.Definition as eya;
	}

	// Token: 0x0600890D RID: 35085 RVA: 0x00388F4C File Offset: 0x0038714C
	protected cgk(bit A_0) : base(A_0)
	{
	}
}
