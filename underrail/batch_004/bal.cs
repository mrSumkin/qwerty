using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

// Token: 0x02001463 RID: 5219
[eiz("IAV")]
[Serializable]
public sealed class bal : evd, ISerializable
{
	// Token: 0x060075A6 RID: 30118 RVA: 0x0031D0C0 File Offset: 0x0031B2C0
	private bal(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (bool?)A_0.GetValue("IAV:V", typeof(bool?));
		this.b = (cuj)A_0.GetValue("IAV:I", typeof(cuj));
		di7.ReadEvent<EventArgs>("IAV:V1", ref this.c, A_0);
	}

	// Token: 0x060075A7 RID: 30119 RVA: 0x0031D124 File Offset: 0x0031B324
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("IAV:V", this.a);
		info.AddValue("IAV:I", this.b);
		di7.WriteEvent<EventArgs>("IAV:V1", this.c, info);
	}

	// Token: 0x060075A8 RID: 30120 RVA: 0x0031D160 File Offset: 0x0031B360
	public bool? gl()
	{
		return this.a;
	}

	// Token: 0x060075A9 RID: 30121 RVA: 0x0031D168 File Offset: 0x0031B368
	public bal(cuj A_0)
	{
		czh.a(A_0, "itemRef");
		this.b = A_0;
	}

	// Token: 0x060075AA RID: 30122 RVA: 0x0031D184 File Offset: 0x0031B384
	[CompilerGenerated]
	public void gm(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.c;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.c, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060075AB RID: 30123 RVA: 0x0031D1BC File Offset: 0x0031B3BC
	[CompilerGenerated]
	public void gn(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.c;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.c, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060075AC RID: 30124 RVA: 0x0031D1F4 File Offset: 0x0031B3F4
	public void go(ad5 A_0)
	{
		czh.a(A_0, "spellInvocation");
		this.a = new bool?(this.b != null && this.b.ao() != null);
		if (this.c != null)
		{
			this.c(this, new EventArgs());
		}
	}

	// Token: 0x04003021 RID: 12321
	private bool? a;

	// Token: 0x04003022 RID: 12322
	private cuj b;

	// Token: 0x04003023 RID: 12323
	[CompilerGenerated]
	private EventHandler<EventArgs> c;
}
