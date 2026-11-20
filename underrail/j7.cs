using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x020012FA RID: 4858
[eiz("AEA3")]
[Serializable]
public abstract class j7 : Aspect<c5x>, ble, ISerializable
{
	// Token: 0x06006C0A RID: 27658 RVA: 0x002D5794 File Offset: 0x002D3994
	protected j7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006C0B RID: 27659
	public abstract string e9();

	// Token: 0x06006C0C RID: 27660
	public abstract string fa();

	// Token: 0x06006C0D RID: 27661 RVA: 0x002D57A0 File Offset: 0x002D39A0
	public b0b h7()
	{
		return base.a8();
	}

	// Token: 0x06006C0E RID: 27662
	public abstract string fb();

	// Token: 0x06006C0F RID: 27663
	public abstract Color? fc();

	// Token: 0x06006C10 RID: 27664
	public abstract string fd();

	// Token: 0x06006C11 RID: 27665 RVA: 0x002D57A8 File Offset: 0x002D39A8
	protected j7(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006C12 RID: 27666 RVA: 0x002D57B4 File Offset: 0x002D39B4
	public cst a(j7 A_0, bool A_1, string A_2 = null, bool A_3 = false)
	{
		awx awx = new awx();
		if (!A_3)
		{
			if (base.a8().k.b != null)
			{
				e1i item = new e1i(base.a8().k.b, A_0.a8(), aju.q);
				awx.ad().Add(item);
			}
			else
			{
				dsr item2 = new dsr(base.a8(), A_0.a8(), aju.q);
				awx.ad().Add(item2);
			}
		}
		c9m item3 = new c9m(this, A_0, A_1, A_2, false);
		awx.ad().Add(item3);
		awx.a(m7.b);
		if (base.a8().i.b != null)
		{
			base.a8().i.b.a(awx, atp.a, true, false);
		}
		return awx;
	}
}
