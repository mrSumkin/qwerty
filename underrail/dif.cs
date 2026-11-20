using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02001289 RID: 4745
[eiz("FOSAEA")]
[Serializable]
public class dif : etz, bp1, ISerializable, avp
{
	// Token: 0x0600672E RID: 26414 RVA: 0x002BC678 File Offset: 0x002BA878
	protected dif(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600672F RID: 26415 RVA: 0x002BC684 File Offset: 0x002BA884
	public dif(c5x A_0) : base(A_0)
	{
		this.o5();
	}

	// Token: 0x06006730 RID: 26416 RVA: 0x002BC694 File Offset: 0x002BA894
	public void mx()
	{
		base.a8().a(new EventHandler<c1>(this.a));
	}

	// Token: 0x06006731 RID: 26417 RVA: 0x002BC6B0 File Offset: 0x002BA8B0
	public void my()
	{
		base.a8().b(new EventHandler<c1>(this.a));
	}

	// Token: 0x06006732 RID: 26418 RVA: 0x002BC6CC File Offset: 0x002BA8CC
	public void o5()
	{
		int y = (int)(base.a8().VisualDirection / HorizontalDirection.East);
		this.b = new Point(this.b.X, y);
	}

	// Token: 0x06006733 RID: 26419 RVA: 0x002BC700 File Offset: 0x002BA900
	[dcc("FOSAEA:mAVDC")]
	private new void a(object A_0, c1 A_1)
	{
		this.o5();
	}
}
