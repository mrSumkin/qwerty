using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using Ouroboros.Playfield.Space;

// Token: 0x02001464 RID: 5220
[eiz("TMRV")]
[Serializable]
public sealed class dc9 : evd, ISerializable
{
	// Token: 0x060075AD RID: 30125 RVA: 0x0031D254 File Offset: 0x0031B454
	private dc9(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (bool?)A_0.GetValue("TMRV:V", typeof(bool?));
		di7.ReadEvent<EventArgs>("TMRV:V1", ref this.d, A_0);
		di7.ReadList<HorizontalDirection>("TMRV:AD", ref this.b, A_0);
		if (ell.a() >= 518)
		{
			this.c = A_0.GetInt32("TMRV:R");
		}
	}

	// Token: 0x060075AE RID: 30126 RVA: 0x0031D2CC File Offset: 0x0031B4CC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("TMRV:V", this.a);
		di7.WriteEvent<EventArgs>("TMRV:V1", this.d, info);
		di7.WriteList<HorizontalDirection>("TMRV:AD", this.b, info);
		info.AddValue("TMRV:R", this.c);
	}

	// Token: 0x060075AF RID: 30127 RVA: 0x0031D324 File Offset: 0x0031B524
	public bool? gl()
	{
		return this.a;
	}

	// Token: 0x060075B0 RID: 30128 RVA: 0x0031D32C File Offset: 0x0031B52C
	public List<HorizontalDirection> a()
	{
		return this.b;
	}

	// Token: 0x060075B1 RID: 30129 RVA: 0x0031D334 File Offset: 0x0031B534
	public void a(List<HorizontalDirection> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060075B2 RID: 30130 RVA: 0x0031D340 File Offset: 0x0031B540
	[CompilerGenerated]
	public void gm(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.d;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060075B3 RID: 30131 RVA: 0x0031D378 File Offset: 0x0031B578
	[CompilerGenerated]
	public void gn(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.d;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060075B4 RID: 30132 RVA: 0x0031D3B0 File Offset: 0x0031B5B0
	public dc9(List<HorizontalDirection> A_0 = null, int A_1 = 0)
	{
		this.b = A_0;
		this.c = A_1;
	}

	// Token: 0x060075B5 RID: 30133 RVA: 0x0031D3C8 File Offset: 0x0031B5C8
	public void go(ad5 A_0)
	{
		czh.a(A_0, "spellInvocation");
		b0b b0b = A_0.h() as b0b;
		if (b0b != null && b0b.j != cgy.b)
		{
			this.a = new bool?(false);
			if (this.d != null)
			{
				this.d(this, new EventArgs());
			}
			return;
		}
		this.a = new bool?(cun.a(A_0.q(), A_0.h(), null, this.c));
		if (this.d != null)
		{
			this.d(this, new EventArgs());
		}
	}

	// Token: 0x04003024 RID: 12324
	private bool? a;

	// Token: 0x04003025 RID: 12325
	private List<HorizontalDirection> b;

	// Token: 0x04003026 RID: 12326
	private int c;

	// Token: 0x04003027 RID: 12327
	[CompilerGenerated]
	private EventHandler<EventArgs> d;
}
