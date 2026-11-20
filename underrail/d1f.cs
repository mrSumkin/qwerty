using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Ouroboros.Common.RayTracing;

// Token: 0x020000F6 RID: 246
public abstract class d1f : diy
{
	// Token: 0x0600059E RID: 1438 RVA: 0x000182DC File Offset: 0x000164DC
	public Guid qe()
	{
		return this.d;
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x000182E4 File Offset: 0x000164E4
	public bbg ag()
	{
		return this.a;
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x000182EC File Offset: 0x000164EC
	public void a(bbg A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x000182F8 File Offset: 0x000164F8
	public FieldOfVisionState ah()
	{
		return this.b;
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x00018300 File Offset: 0x00016500
	protected void a(FieldOfVisionState A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x0001830C File Offset: 0x0001650C
	public Point ai()
	{
		return this.c;
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00018314 File Offset: 0x00016514
	public void aj(Point A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060005A5 RID: 1445
	public abstract bool ac8();

	// Token: 0x060005A6 RID: 1446 RVA: 0x00018320 File Offset: 0x00016520
	[CompilerGenerated]
	public void b(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.e;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x00018358 File Offset: 0x00016558
	[CompilerGenerated]
	public void a(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.e;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x00018390 File Offset: 0x00016590
	public d1f()
	{
		this.d = Guid.NewGuid();
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x000183BC File Offset: 0x000165BC
	public void ak()
	{
		if (this.ah() != FieldOfVisionState.Created && this.ah() != FieldOfVisionState.Updated)
		{
			throw new InvalidOperationException(string.Format("The field's current state ({0}) does not support the update operation.", this.ah().ToString()));
		}
		this.a(FieldOfVisionState.Updating);
		this.ada();
		this.adb();
		this.ac9();
		this.g();
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x00018424 File Offset: 0x00016624
	public void al()
	{
		if (this.ac8())
		{
			this.adc();
			return;
		}
		this.ak();
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x00018444 File Offset: 0x00016644
	public void am()
	{
		if (this.ah() == FieldOfVisionState.Updating)
		{
			this.add();
		}
		this.a(FieldOfVisionState.Destroying);
		this.ada();
		this.a(FieldOfVisionState.Destroyed);
	}

	// Token: 0x060005AC RID: 1452
	protected abstract void ada();

	// Token: 0x060005AD RID: 1453
	protected abstract void adb();

	// Token: 0x060005AE RID: 1454
	protected abstract void ac9();

	// Token: 0x060005AF RID: 1455
	protected abstract void adc();

	// Token: 0x060005B0 RID: 1456
	protected abstract void add();

	// Token: 0x060005B1 RID: 1457 RVA: 0x00018478 File Offset: 0x00016678
	protected Rectangle h()
	{
		Vector2 vector = new Vector2((float)this.ai().X + 0.5f, (float)this.ai().Y + 0.5f);
		int num = (int)(vector.X - this.ag().b());
		int num2 = (int)(vector.Y - this.ag().b());
		int num3 = d05.a(vector.X + this.ag().b());
		int num4 = d05.a(vector.Y + this.ag().b());
		return new Rectangle(num, num2, num3 - num, num4 - num2);
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x00018514 File Offset: 0x00016714
	protected void g()
	{
		this.a(FieldOfVisionState.Updated);
		if (this.e != null)
		{
			this.e(this, new EventArgs());
		}
	}

	// Token: 0x0400049C RID: 1180
	private bbg a = new bbg();

	// Token: 0x0400049D RID: 1181
	private FieldOfVisionState b;

	// Token: 0x0400049E RID: 1182
	private Point c = Point.Zero;

	// Token: 0x0400049F RID: 1183
	private Guid d;

	// Token: 0x040004A0 RID: 1184
	[CompilerGenerated]
	private EventHandler<EventArgs> e;
}
