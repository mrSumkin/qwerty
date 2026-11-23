using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x0200128B RID: 4747
[eiz("TOSAEA")]
[Serializable]
public class ah0 : etz, bp1, ISerializable, avp
{
	// Token: 0x06006747 RID: 26439 RVA: 0x002BCCA4 File Offset: 0x002BAEA4
	protected ah0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006748 RID: 26440 RVA: 0x002BCCB0 File Offset: 0x002BAEB0
	public ah0(c5x A_0) : base(A_0)
	{
		this.o5();
	}

	// Token: 0x06006749 RID: 26441 RVA: 0x002BCCC0 File Offset: 0x002BAEC0
	public void mx()
	{
		base.a8().a(new EventHandler<c1>(this.a));
	}

	// Token: 0x0600674A RID: 26442 RVA: 0x002BCCDC File Offset: 0x002BAEDC
	public void my()
	{
		base.a8().b(new EventHandler<c1>(this.a));
	}

	// Token: 0x0600674B RID: 26443 RVA: 0x002BCCF8 File Offset: 0x002BAEF8
	public void o5()
	{
		int y;
		if (base.a8().VisualDirection == HorizontalDirection.East || base.a8().VisualDirection == HorizontalDirection.West)
		{
			y = 1;
		}
		else
		{
			y = 0;
		}
		this.b = new Point(this.b.X, y);
	}

	// Token: 0x0600674C RID: 26444 RVA: 0x002BCD48 File Offset: 0x002BAF48
	[dcc("TOSAEA:mAVDC")]
	private new void a(object A_0, c1 A_1)
	{
		this.o5();
	}
}
