using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000F6C RID: 3948
[a(typeof(epo))]
[eiz("CCPEA")]
[Serializable]
public sealed class qh : epo
{
	// Token: 0x06005018 RID: 20504 RVA: 0x0023EB84 File Offset: 0x0023CD84
	private qh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("CCPEA:T", typeof(List<string>)) as List<string>);
	}

	// Token: 0x06005019 RID: 20505 RVA: 0x0023EBB0 File Offset: 0x0023CDB0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCPEA:T", this.b);
	}

	// Token: 0x0600501A RID: 20506 RVA: 0x0023EBCC File Offset: 0x0023CDCC
	public qh(c5x A_0) : base(A_0)
	{
		this.b = new List<string>
		{
			"caveCrevice"
		};
	}

	// Token: 0x0600501B RID: 20507 RVA: 0x0023EBEC File Offset: 0x0023CDEC
	public List<string> a()
	{
		return this.b;
	}

	// Token: 0x0600501C RID: 20508 RVA: 0x0023EBF4 File Offset: 0x0023CDF4
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600501D RID: 20509 RVA: 0x0023EC00 File Offset: 0x0023CE00
	public override bool kc(c5x A_0, abo A_1)
	{
		aw1.b(A_0, base.a8(), false);
		return true;
	}

	// Token: 0x0600501E RID: 20510 RVA: 0x0023EC14 File Offset: 0x0023CE14
	protected override List<d0z> kd()
	{
		if (this.a == null)
		{
			List<object> a_ = new List<object>(this.b);
			HorizontalDirection horizontalDirection = base.a8().VisualDirection;
			this.a = new List<d0z>();
			if (horizontalDirection == HorizontalDirection.North || horizontalDirection == HorizontalDirection.South)
			{
				this.a.Add(new d0z(base.a8().qe().ToString(), this.a(0, -1), this.a(0, 1), a_));
			}
			else
			{
				this.a.Add(new d0z(base.a8().qe().ToString(), this.a(-1, 0), this.a(1, 0), a_));
			}
		}
		return this.a;
	}

	// Token: 0x0600501F RID: 20511 RVA: 0x0023ECDC File Offset: 0x0023CEDC
	private abo a(int A_0, int A_1)
	{
		int a_ = base.a8().Area.c();
		return new abo(new ee4(a_, new Point(((int)base.a8().Location.X + A_0) * 4, ((int)base.a8().Location.Y + A_1) * 4)), chj.a, aj.a, 0, null);
	}

	// Token: 0x040020AA RID: 8362
	[NonSerialized]
	private List<d0z> a;

	// Token: 0x040020AB RID: 8363
	private new List<string> b;
}
