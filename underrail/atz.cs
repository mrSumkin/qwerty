using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Space;

// Token: 0x02001285 RID: 4741
[eiz("RFSEA")]
[Serializable]
public class atz : Aspect<c5x>, bp1, ISerializable
{
	// Token: 0x06006707 RID: 26375 RVA: 0x002BBF3C File Offset: 0x002BA13C
	protected atz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006708 RID: 26376 RVA: 0x002BBF48 File Offset: 0x002BA148
	public atz(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006709 RID: 26377 RVA: 0x002BBF54 File Offset: 0x002BA154
	public void mx()
	{
		base.a8().g(new EventHandler<c1>(this.a));
	}

	// Token: 0x0600670A RID: 26378 RVA: 0x002BBF70 File Offset: 0x002BA170
	public void my()
	{
		base.a8().h(new EventHandler<c1>(this.a));
	}

	// Token: 0x0600670B RID: 26379 RVA: 0x002BBF8C File Offset: 0x002BA18C
	private Axis a(HorizontalDirection A_0)
	{
		if (A_0 == HorizontalDirection.East || A_0 == HorizontalDirection.West || A_0 == HorizontalDirection.Northwest || A_0 == HorizontalDirection.Southeast)
		{
			return Axis.Y;
		}
		return Axis.X;
	}

	// Token: 0x0600670C RID: 26380 RVA: 0x002BBFB0 File Offset: 0x002BA1B0
	[dcc("RFSEA:mAVDC")]
	private void a(object A_0, c1 A_1)
	{
		if (base.a8() != null && Enum.IsDefined(typeof(HorizontalDirection), A_1.b()) && Enum.IsDefined(typeof(HorizontalDirection), A_1.a()))
		{
			HorizontalDirection a_ = (HorizontalDirection)A_1.b();
			HorizontalDirection a_2 = (HorizontalDirection)A_1.a();
			Axis axis = this.a(a_);
			Axis axis2 = this.a(a_2);
			if (axis != axis2)
			{
				if (base.a8().z != null)
				{
					base.a8().z = new Vector2?(new Vector2(base.a8().z.Value.Y, base.a8().z.Value.X));
				}
				base.a8().Size = new Vector3(base.a8().Size.Y, base.a8().Size.X, base.a8().Size.Z);
				base.a8().ah();
			}
		}
	}
}
