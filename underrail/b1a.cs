using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x0200119E RID: 4510
[eiz("TLE")]
[Serializable]
public sealed class b1a : k2, ISerializable
{
	// Token: 0x06006033 RID: 24627 RVA: 0x0029FAAC File Offset: 0x0029DCAC
	private b1a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(b1a);
		}
	}

	// Token: 0x06006034 RID: 24628 RVA: 0x0029FAD8 File Offset: 0x0029DCD8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06006035 RID: 24629 RVA: 0x0029FAE8 File Offset: 0x0029DCE8
	public override int ac7()
	{
		c5x c5x = base.Carrier as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			return Convert.ToInt32(c5x.h.b.aa().SightRange + (float)aju.b);
		}
		return 15;
	}

	// Token: 0x06006036 RID: 24630 RVA: 0x0029FB3C File Offset: 0x0029DD3C
	public b1a(TypedObjectReference<bag> A_0) : base(A_0)
	{
	}
}
