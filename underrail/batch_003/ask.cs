using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x0200130C RID: 4876
[eiz("TOSEA")]
[Serializable]
public class ask : cd0, bp1, ISerializable, avp
{
	// Token: 0x06006D3F RID: 27967 RVA: 0x002DAA04 File Offset: 0x002D8C04
	protected ask(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006D40 RID: 27968 RVA: 0x002DAA10 File Offset: 0x002D8C10
	public ask(c5x A_0) : base(A_0)
	{
		this.o5();
	}

	// Token: 0x06006D41 RID: 27969 RVA: 0x002DAA20 File Offset: 0x002D8C20
	public void mx()
	{
		base.a8().a(new EventHandler<c1>(this.a));
	}

	// Token: 0x06006D42 RID: 27970 RVA: 0x002DAA3C File Offset: 0x002D8C3C
	public void my()
	{
		base.a8().b(new EventHandler<c1>(this.a));
	}

	// Token: 0x06006D43 RID: 27971 RVA: 0x002DAA58 File Offset: 0x002D8C58
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

	// Token: 0x06006D44 RID: 27972 RVA: 0x002DAAA8 File Offset: 0x002D8CA8
	[dcc("TOSEA:mAVDC")]
	private new void a(object A_0, c1 A_1)
	{
		this.o5();
	}
}
