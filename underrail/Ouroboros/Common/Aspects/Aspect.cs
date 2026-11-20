using System;
using System.Runtime.Serialization;

namespace Ouroboros.Common.Aspects
{
	// Token: 0x02000028 RID: 40
	[eiz("A1")]
	[Serializable]
	public abstract class Aspect<TContainer> : cn7, ISerializable where TContainer : class, cuw
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00004668 File Offset: 0x00002868
		public TContainer a8()
		{
			return base.Container as TContainer;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000467C File Offset: 0x0000287C
		protected Aspect(TContainer A_0) : base(A_0)
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000468C File Offset: 0x0000288C
		protected Aspect(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
		}
	}
}
