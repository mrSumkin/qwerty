using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012A3 RID: 4771
[eiz("HSFEA")]
[Serializable]
public sealed class cx : Aspect<c5x>, ISerializable, bp1
{
	// Token: 0x0600685A RID: 26714 RVA: 0x002C2030 File Offset: 0x002C0230
	private cx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600685B RID: 26715 RVA: 0x002C203C File Offset: 0x002C023C
	public cx(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x0600685C RID: 26716 RVA: 0x002C2048 File Offset: 0x002C0248
	public void mx()
	{
		if (bpo.GetService<cnk>() == null)
		{
			return;
		}
		if (base.a8() != null)
		{
			foreach (ak1 ak in base.a8().l)
			{
				foreach (b0b b0b in ak.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (!c5x.IsFloor)
					{
						break;
					}
					if (c5x.Layer == 0)
					{
						c5x.ae = new float?(0f);
					}
				}
			}
		}
	}

	// Token: 0x0600685D RID: 26717 RVA: 0x002C211C File Offset: 0x002C031C
	public void my()
	{
	}
}
