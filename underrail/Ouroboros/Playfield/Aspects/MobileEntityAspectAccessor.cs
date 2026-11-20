using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

namespace Ouroboros.Playfield.Aspects
{
	// Token: 0x02000059 RID: 89
	[eiz("MEAA")]
	[Serializable]
	public sealed class MobileEntityAspectAccessor<T> : QuickAspectAccessor<T>, c02 where T : cn7, c02
	{
		// Token: 0x06000171 RID: 369 RVA: 0x00008234 File Offset: 0x00006434
		public MobileEntityAspectAccessor(cuw A_0) : base(A_0)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00008240 File Offset: 0x00006440
		private MobileEntityAspectAccessor(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000824C File Offset: 0x0000644C
		public float h9()
		{
			this.a();
			return this.b.h9();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00008264 File Offset: 0x00006464
		public float ia()
		{
			this.a();
			return this.b.ia();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000827C File Offset: 0x0000647C
		private void a()
		{
			if (this.b == null)
			{
				base.b();
				if (this.b == null)
				{
					throw new InvalidOperationException("Unable to retrieve value.");
				}
			}
		}
	}
}
