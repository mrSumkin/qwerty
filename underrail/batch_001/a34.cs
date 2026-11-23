using System;
using System.Runtime.Serialization;

// Token: 0x02001284 RID: 4740
[eiz("LGEA6")]
[Serializable]
public sealed class a34 : cry, ISerializable, chb, c98
{
	// Token: 0x06006700 RID: 26368 RVA: 0x002BBEE8 File Offset: 0x002BA0E8
	private a34(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006701 RID: 26369 RVA: 0x002BBEF4 File Offset: 0x002BA0F4
	public override string gv()
	{
		return "leperGas";
	}

	// Token: 0x06006702 RID: 26370 RVA: 0x002BBEFC File Offset: 0x002BA0FC
	public override bool gw()
	{
		return false;
	}

	// Token: 0x06006703 RID: 26371 RVA: 0x002BBF00 File Offset: 0x002BA100
	protected override bool ur()
	{
		return true;
	}

	// Token: 0x06006704 RID: 26372 RVA: 0x002BBF04 File Offset: 0x002BA104
	public a34(c5x A_0, string A_1, Guid? A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06006705 RID: 26373 RVA: 0x002BBF10 File Offset: 0x002BA110
	public override void gx(c5x A_0)
	{
	}

	// Token: 0x06006706 RID: 26374 RVA: 0x002BBF14 File Offset: 0x002BA114
	protected override void gy(c5x A_0)
	{
		d8r aspect = A_0.GetAspect<d8r>();
		if (aspect != null)
		{
			aspect.tt(base.f(), false);
		}
	}
}
