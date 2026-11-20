using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02001309 RID: 4873
[eiz("EOSEA")]
[Serializable]
public class a2o : cd0, bp1, ISerializable, avp
{
	// Token: 0x06006D19 RID: 27929 RVA: 0x002D9DE8 File Offset: 0x002D7FE8
	protected a2o(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006D1A RID: 27930 RVA: 0x002D9DF4 File Offset: 0x002D7FF4
	public a2o(c5x A_0) : base(A_0)
	{
		this.o5();
	}

	// Token: 0x06006D1B RID: 27931 RVA: 0x002D9E04 File Offset: 0x002D8004
	public void mx()
	{
		base.a8().a(new EventHandler<c1>(this.a));
		this.o5();
	}

	// Token: 0x06006D1C RID: 27932 RVA: 0x002D9E24 File Offset: 0x002D8024
	public void my()
	{
		base.a8().b(new EventHandler<c1>(this.a));
	}

	// Token: 0x06006D1D RID: 27933 RVA: 0x002D9E40 File Offset: 0x002D8040
	public void o5()
	{
		int y = (int)((base.a8().VisualDirection + 1) % (HorizontalDirection)8);
		this.b = new Point(this.b.X, y);
	}

	// Token: 0x06006D1E RID: 27934 RVA: 0x002D9E74 File Offset: 0x002D8074
	[dcc("EOSEA:mAVDC")]
	private new void a(object A_0, c1 A_1)
	{
		this.o5();
	}
}
