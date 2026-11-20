using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02000691 RID: 1681
[eiz("AP1")]
[Serializable]
public sealed class bl6 : av, ISerializable
{
	// Token: 0x06002BAC RID: 11180 RVA: 0x000FC860 File Offset: 0x000FAA60
	private bl6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002BAD RID: 11181 RVA: 0x000FC86C File Offset: 0x000FAA6C
	public List<Type> a()
	{
		return (base.p() as a8s).f(this);
	}

	// Token: 0x06002BAE RID: 11182 RVA: 0x000FC880 File Offset: 0x000FAA80
	public override bool yw()
	{
		return base.q() || base.yw();
	}

	// Token: 0x06002BAF RID: 11183 RVA: 0x000FC898 File Offset: 0x000FAA98
	internal bl6(TypedObjectReference<efk> A_0, a8s A_1, object A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06002BB0 RID: 11184 RVA: 0x000FC8A8 File Offset: 0x000FAAA8
	public override av xh()
	{
		return new bl6(base.s(), base.p() as a8s, base.b9());
	}
}
