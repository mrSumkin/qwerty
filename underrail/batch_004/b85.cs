using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02001286 RID: 4742
[eiz("EOSAEA")]
[Serializable]
public class b85 : etz, bp1, ISerializable, avp
{
	// Token: 0x0600670D RID: 26381 RVA: 0x002BC0C8 File Offset: 0x002BA2C8
	protected b85(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600670E RID: 26382 RVA: 0x002BC0D4 File Offset: 0x002BA2D4
	public b85(c5x A_0) : base(A_0)
	{
		this.o5();
	}

	// Token: 0x0600670F RID: 26383 RVA: 0x002BC0E4 File Offset: 0x002BA2E4
	public void mx()
	{
		base.a8().a(new EventHandler<c1>(this.a));
		this.o5();
	}

	// Token: 0x06006710 RID: 26384 RVA: 0x002BC104 File Offset: 0x002BA304
	public void my()
	{
		base.a8().b(new EventHandler<c1>(this.a));
	}

	// Token: 0x06006711 RID: 26385 RVA: 0x002BC120 File Offset: 0x002BA320
	public void o5()
	{
		int y = (int)((base.a8().VisualDirection + 1) % (HorizontalDirection)8);
		this.b = new Point(this.b.X, y);
	}

	// Token: 0x06006712 RID: 26386 RVA: 0x002BC154 File Offset: 0x002BA354
	[dcc("EOSAEA:mAVDC")]
	private new void a(object A_0, c1 A_1)
	{
		this.o5();
	}
}
