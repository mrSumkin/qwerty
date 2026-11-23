using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02001313 RID: 4883
[eiz("FOSEA")]
[Serializable]
public class e4x : cd0, bp1, ISerializable, avp
{
	// Token: 0x06006D7C RID: 28028 RVA: 0x002DC170 File Offset: 0x002DA370
	protected e4x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006D7D RID: 28029 RVA: 0x002DC17C File Offset: 0x002DA37C
	public e4x(c5x A_0) : base(A_0)
	{
		this.o5();
	}

	// Token: 0x06006D7E RID: 28030 RVA: 0x002DC18C File Offset: 0x002DA38C
	public void mx()
	{
		base.a8().a(new EventHandler<c1>(this.a));
	}

	// Token: 0x06006D7F RID: 28031 RVA: 0x002DC1A8 File Offset: 0x002DA3A8
	public void my()
	{
		base.a8().b(new EventHandler<c1>(this.a));
	}

	// Token: 0x06006D80 RID: 28032 RVA: 0x002DC1C4 File Offset: 0x002DA3C4
	public void o5()
	{
		int y = (int)(base.a8().VisualDirection / HorizontalDirection.East);
		this.b = new Point(this.b.X, y);
	}

	// Token: 0x06006D81 RID: 28033 RVA: 0x002DC1F8 File Offset: 0x002DA3F8
	[dcc("FOSEA:mAVDC")]
	private new void a(object A_0, c1 A_1)
	{
		this.o5();
	}
}
