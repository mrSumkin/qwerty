using System;
using TimelapseVertigo.Common;

// Token: 0x02002006 RID: 8198
public sealed class dlb : eb1
{
	// Token: 0x0600C186 RID: 49542 RVA: 0x00431180 File Offset: 0x0042F380
	public override av zc()
	{
		return this.a;
	}

	// Token: 0x0600C187 RID: 49543 RVA: 0x00431188 File Offset: 0x0042F388
	public override bool aj9()
	{
		return true;
	}

	// Token: 0x0600C188 RID: 49544 RVA: 0x0043118C File Offset: 0x0042F38C
	public dlb()
	{
		base.c(true);
	}

	// Token: 0x0600C189 RID: 49545 RVA: 0x0043119C File Offset: 0x0042F39C
	public dlb(esj A_0, esj A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600C18A RID: 49546 RVA: 0x004311A8 File Offset: 0x0042F3A8
	public override bool iq(e08 A_0)
	{
		return false;
	}

	// Token: 0x0600C18B RID: 49547 RVA: 0x004311AC File Offset: 0x0042F3AC
	protected override void ans()
	{
		e4z.a(this);
	}

	// Token: 0x0600C18C RID: 49548 RVA: 0x004311B8 File Offset: 0x0042F3B8
	protected override void ns(object A_0, b25 A_1)
	{
		base.ns(A_0, A_1);
		if (base.Pressed && this.zc() != null && base.PressedDuration >= wj.c)
		{
			chr service = bpo.GetService<chr>();
			if (service != null && service.ax() == null)
			{
				e08 a_ = new e08(null, this.zc().xh(), TimelapseCursor.ItemDrag.ToString());
				service.az(a_);
				base.Pressed = false;
				e4z.d();
			}
		}
	}

	// Token: 0x0600C18D RID: 49549 RVA: 0x00431240 File Offset: 0x0042F440
	protected override void zh(av A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04004608 RID: 17928
	private new av a;
}
