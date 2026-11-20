using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001120 RID: 4384
[eiz("SSEAFY")]
[Serializable]
public sealed class cm5 : cze, ISerializable
{
	// Token: 0x06005D98 RID: 23960 RVA: 0x0027BF78 File Offset: 0x0027A178
	private cm5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetInt32("SSEAFY:V");
			return;
		}
		if (base.GetType() == typeof(cm5))
		{
			this.a = A_0.GetInt32("_Value");
			return;
		}
		this.a = A_0.GetInt32("SetSimpleEntityAspectFrameY+_Value");
	}

	// Token: 0x06005D99 RID: 23961 RVA: 0x0027BFE8 File Offset: 0x0027A1E8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSEAFY:V", this.a);
	}

	// Token: 0x06005D9A RID: 23962 RVA: 0x0027C004 File Offset: 0x0027A204
	public int a()
	{
		return this.a;
	}

	// Token: 0x06005D9B RID: 23963 RVA: 0x0027C00C File Offset: 0x0027A20C
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005D9C RID: 23964 RVA: 0x0027C018 File Offset: 0x0027A218
	public cm5()
	{
	}

	// Token: 0x06005D9D RID: 23965 RVA: 0x0027C020 File Offset: 0x0027A220
	public cm5(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005D9E RID: 23966 RVA: 0x0027C034 File Offset: 0x0027A234
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			cd0 aspect = A_1.GetAspect<cd0>();
			if (aspect != null)
			{
				aspect.b = new Point(aspect.b.X, this.a);
			}
		}
	}

	// Token: 0x04002546 RID: 9542
	private new int a;
}
